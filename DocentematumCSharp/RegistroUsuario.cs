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
	public partial class RegistroUsuario : Form
	{
		public RegistroUsuario()
		{
			InitializeComponent();
			chargeComboBoxUsuario();
		}

		private void label10_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int indexDivision = comboTipoUsuario.SelectedIndex;
			ConnectionSql connection = new ConnectionSql();
			comboDivision.Items[indexDivision].ToString().Substring(0, 5);
			str = "INSERT INTO profesor VALUES('" + textCodigo.Text + "','" + 
				comboTipoUsuario.Items[indexDivision].ToString().Substring(0,1)+"','0','"+ +";";
			MySqlCommand command = connection.getCommand(str);
			command.ExecuteNonQuery();
			dgvDivisiones.Rows.RemoveAt(n);
			chargeDGVCarreras();
		}

		private void chargeComboBoxUsuario()
		{
			comboTipoUsuario.Items.Clear();
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM tipo_usuario;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboNivel.Items.Add(reader.GetInt32(reader.GetOrdinal("idTipoUsuario"))
					+ " - " + reader.GetString(reader.GetOrdinal("tipo")));
			}
			connection.closeConnection();
		}
	}
}
