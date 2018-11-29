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
			str = "SELECT * FROM profesor AS p LEFT JOIN profesor_produccion AS pp ON p.codigoTrabajador = " +
				"pp.codigoTrabajador LEFT JOIN produccion pro ON p.codigoTrabajador = pro.codigoTrabajador;";
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
				dgvProduccion.Rows[row].Cells["propositoProduccion"].Value = reader.GetSByte(reader.GetOrdinal("proposito"));
				dgvProduccion.Rows[row].Cells["numeroRegistro"].Value = reader.GetSByte(reader.GetOrdinal("numeroInstituto"));
				dgvProduccion.Rows[row].Cells["colaboradorProduccion"].Value = reader.GetSByte(reader.GetOrdinal("nombre"));
			}
			labelProduccion.Text = reader.GetString(reader.GetOrdinal("titulo"));
			connection.closeConnection();
		}
	}
}
