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
            ConnectionSql connection;

            if (string.IsNullOrWhiteSpace(textCodigo.Text) || string.IsNullOrWhiteSpace(textUsuario.Text) ||
				string.IsNullOrWhiteSpace(textContrasena.Text) || string.IsNullOrWhiteSpace(textName.Text) ||
				string.IsNullOrWhiteSpace(comboTipoUsuario.Text) || string.IsNullOrWhiteSpace(textPaterno.Text)||
                string.IsNullOrWhiteSpace(textMaterno.Text) || textCodigo.Text == "")
			{
				MessageBox.Show("Rellene los campos marcados con un recuadro rojo");
				return;	
			}
            if (System.Text.RegularExpressions.Regex.IsMatch(textCodigo.Text, "[^0-9]"))
            {
                MessageBox.Show("Sólo se permiten números en el campo de código");
                textCodigo.Focus();
                return;
            }
			string str, date1, date2, date3;
			int indexDivision = comboTipoUsuario.SelectedIndex;
            
			date1 = dateFechaNacimiento.Value.Year.ToString() + "-" + dateFechaNacimiento.Value.Month.ToString() +
				"-" + dateFechaNacimiento.Value.Day.ToString();
			date2 = dateAdmision.Value.Year.ToString() + "-" + dateAdmision.Value.Month.ToString() +
				"-" + dateAdmision.Value.Day.ToString();
			date3 = dateUltimoCiclo.Value.Year.ToString() +
				"-" + dateUltimoCiclo.Value.Month.ToString() + "-" + dateUltimoCiclo.Value.Day.ToString();
            if(dateUltimoCiclo.Value.Date < dateAdmision.Value.Date)
            {
                MessageBox.Show("Error, la fecha del último ciclo no puede ser menor a la de admisión");
                dateAdmision.Focus();
                return;
            }

            connection = new ConnectionSql();
            str = "SELECT * FROM profesor WHERE codigoTrabajador = " + textCodigo.Text + ";";
            MySqlCommand command = connection.getCommand(str);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Error, este código de trabajador ya está registrado");
                connection.closeConnection();
                textCodigo.Focus();
                return;
            }
            else
            {
                connection.closeConnection();
            }


            str = $"INSERT INTO profesor VALUES(\"{textCodigo.Text}\",\"{comboTipoUsuario.Items[indexDivision].ToString().Substring(0, 1)}\"" +
				$",\"{textName.Text}\",\"{textPaterno.Text}\",\"{textMaterno.Text}\",\"{ textUsuario.Text}\"" +
				$",\"{textContrasena.Text}\",\"{date1} \",";
			
			str+=$"\"{textCorreo.Text}\",\"{textTelefono.Text}\",";
			/*if (string.IsNullOrWhiteSpace(textCorreo.Text))
			{
				str += $"\"{textCorreo.Text}\",";
			}
			else
			{
				str += "\"NULL\", ";
			}
			if (string.IsNullOrWhiteSpace(textTelefono.Text))
				{
				str += $"\"{textTelefono.Text}\",";
			}
			else
			{
				str += "\"NULL\",";
			}*/
			str += $"\"{date2}\",\"{date3}\",\"ACTIVO\");";
            //MessageBox.Show(str);
            connection = new ConnectionSql();
			command = connection.getCommand(str);
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
