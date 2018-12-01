using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DocentematumCSharp
{
	public partial class VistaProduccion : Form
	{
		int prodCode;
		public VistaProduccion()
		{
			InitializeComponent();
		}
		public VistaProduccion(int u_code)
		{
			InitializeComponent();

			prodCode = u_code;

			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM produccion WHERE idProduccion = '"+prodCode+"';";
			MySqlCommand command = connection.getCommand(str);
			command.ExecuteNonQuery();
			MySqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int row = dgvProduccion.Rows.Add();
				dgvProduccion.Rows[row].Cells["IDProduccion"].Value = reader.GetInt32(reader.GetOrdinal("idProduccion")).ToString();
				dgvProduccion.Rows[row].Cells["tipoProduccion"].Value = reader.GetString(reader.GetOrdinal("tipo"));		
				dgvProduccion.Rows[row].Cells["fechaProduccion"].Value = reader.GetString(reader.GetOrdinal("fechaInicio"));
				dgvProduccion.Rows[row].Cells["statusProduccion"].Value = reader.GetString(reader.GetOrdinal("status"));
				dgvProduccion.Rows[row].Cells["propositoProduccion"].Value = reader.GetString(reader.GetOrdinal("proposito"));
				dgvProduccion.Rows[row].Cells["numeroRegistro"].Value = reader.GetInt32(reader.GetOrdinal("numeroInstitucion")).ToString();
			}
			labelProduccion.Text = reader.GetString(reader.GetOrdinal("titulo"));
			connection.closeConnection();
		}
	}
}
