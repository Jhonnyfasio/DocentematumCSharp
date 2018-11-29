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
			if (string.IsNullOrWhiteSpace(textCodigo.Text) || string.IsNullOrWhiteSpace(textUsuario.Text) ||
				string.IsNullOrWhiteSpace(textContrasena.Text) || string.IsNullOrWhiteSpace(textName.Text) ||
				string.IsNullOrWhiteSpace(comboTipoUsuario.Text))
			{
				MessageBox.Show("Rellene los campos marcados con un recuadro rojo");
				return;	
			}

			string str, date1, date2, date3;
			int indexDivision = comboTipoUsuario.SelectedIndex;
			ConnectionSql connection = new ConnectionSql();
			date1 = dateFechaNacimiento.Value.Year.ToString() + "-" + dateFechaNacimiento.Value.Month.ToString() +
				"-" + dateFechaNacimiento.Value.Day.ToString();
			date2 = dateAdmision.Value.Year.ToString() + "-" + dateAdmision.Value.Month.ToString() +
				"-" + dateAdmision.Value.Day.ToString();
			date3 = dateUltimoCiclo.Value.Year.ToString() +
				"-" + dateUltimoCiclo.Value.Month.ToString() + "-" + dateUltimoCiclo.Value.Day.ToString();

			str = "INSERT INTO profesor VALUES('" + textCodigo.Text + "','" +
				comboTipoUsuario.Items[indexDivision].ToString().Substring(0, 1) + "','0','" + textName.Text
				+ "','" + textPaterno.Text + "','" + textMaterno.Text + "','" + textUsuario.Text + "','" +
				textContrasena.Text + "','" + date1 + "','";
			MessageBox.Show(str);
			if (string.IsNullOrWhiteSpace(textCorreo.Text))
			{
				str += textCorreo.Text + "','";
			}
			else
			{
				str += "NULL"+"','";
			}
			if (string.IsNullOrWhiteSpace(textCorreo.Text))
				{
				str += textTelefono.Text+"','";
			}
			else
			{
				str += "NULL" + "','";
			}
			str +=date2 + "','" + date3 + "', 'ACTIVO');";
			MySqlCommand command = connection.getCommand(str);
			command.ExecuteNonQuery();
			connection.closeConnection();

			MessageBox.Show("Usuario Registrado");

			this.Close();
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
				comboTipoUsuario.Items.Add(reader.GetInt32(reader.GetOrdinal("idTipoUsuario"))
					+ " - " + reader.GetString(reader.GetOrdinal("tipo")));
			}
			connection.closeConnection();
		}
	}
}
