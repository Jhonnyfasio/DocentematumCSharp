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
	public partial class MenuEspecialUsuario : Form
	{
		MainForm main;
		Login formaLogin;
		int userCode, n;

		public MenuEspecialUsuario()
		{
			InitializeComponent();
		}

		public MenuEspecialUsuario(MainForm m, Login forma1, int uCode)
		{
			InitializeComponent();
			chargeDgvProduccion();
			forma1.Hide();
			userCode = uCode;
			main = m;
			formaLogin = forma1;
			ConnectionSql connection = new ConnectionSql();
			string sentence = "SELECT * FROM profesor WHERE codigoTrabajador = '" + userCode.ToString() + "';";
			MySqlCommand command = connection.getCommand(sentence);
			MySqlDataReader myReader = command.ExecuteReader();
			myReader.Read();
			labelCodigo.Text = userCode.ToString();
			labelNombre.Text = myReader.GetString(myReader.GetOrdinal("nombre"));
			connection.closeConnection();
			this.CenterToScreen();
		}

		private void buttonCrearProfesor_Click(object sender, EventArgs e)
		{
			RegistroUsuario user = new RegistroUsuario();
			user.Show();
		}

		private void buttonBuscarProduccion_Click(object sender, EventArgs e)
		{
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM produccion WHERE idProduccion = '" + textBoxFindProd.Text + "';";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				dgvProduccion.Rows.Clear();
				int row = dgvProduccion.Rows.Add();
				dgvProduccion.Rows[row].Cells["IDProduccion"].Value = reader.GetInt32(reader.GetOrdinal("idProduccion")).ToString();
				dgvProduccion.Rows[row].Cells["tipoProduccion"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvProduccion.Rows[row].Cells["tituloProduccion"].Value = reader.GetString(reader.GetOrdinal("titulo"));
				dgvProduccion.Rows[row].Cells["fechaProduccion"].Value = reader.GetString(reader.GetOrdinal("fechaInicio"));
				dgvProduccion.Rows[row].Cells["statusProduccion"].Value = reader.GetString(reader.GetOrdinal("status"));
			}
			else
			{
				MessageBox.Show("Error, la produccion no pudo ser encontrada");
			}
			textBoxFindProd.Clear();
			connection.closeConnection();
		}

		private void buttonAprobar_Click(object sender, EventArgs e)
		{
			if (n == -1)
			{
				MessageBox.Show("Error, debe seleccionar una producción primero");
				return;
			}
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "UPDATE produccion set status = 'APROBADA' WHERE idProduccion = '" + (string)dgvProduccion.Rows[n].Cells["idProduccion"].Value + "';";
			MySqlCommand command = connection.getCommand(str);
			command.ExecuteNonQuery();

			connection.closeConnection();
			chargeDgvProduccion();
		}

		private void dgvProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
		}

		private void buttonVerProduccion_Click(object sender, EventArgs e)
		{
		string str;
			if (n != -1)
			{
				ConnectionSql connection = new ConnectionSql();
				str = "SELECT * FROM produccion WHERE idProduccion = '" + (string)dgvProduccion.Rows[n].Cells["idProduccion"].Value + "';";
				MySqlCommand command = connection.getCommand(str);
				command.ExecuteNonQuery();
				MySqlDataReader reader = command.ExecuteReader();
				reader.Read();

				VistaProduccion vista = new VistaProduccion(reader.GetInt32(reader.GetOrdinal("idProduccion")));
				connection.closeConnection();
				vista.Show();

				
			}

		}

		private void buttonRechazar_Click(object sender, EventArgs e)
		{
			if (n == -1)
			{
				MessageBox.Show("Error, debe seleccionar una producción primero");
				return;
			}
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "UPDATE produccion set status = 'RECHAZADA' WHERE idProduccion = '" + (string)dgvProduccion.Rows[n].Cells["idProduccion"].Value + "';";
			MySqlCommand command = connection.getCommand(str);
			command.ExecuteNonQuery();

			connection.closeConnection();
			chargeDgvProduccion();
		}

		private void MenuEspecialUsuario_FormClosing(object sender, FormClosingEventArgs e)
		{
			formaLogin.Show();
		}

		private void chargeDgvProduccion()
		{
			string str;
			dgvProduccion.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM produccion;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvProduccion.Rows.Add();
				dgvProduccion.Rows[row].Cells["IDProduccion"].Value = reader.GetInt32(reader.GetOrdinal("idProduccion")).ToString();
				dgvProduccion.Rows[row].Cells["tipoProduccion"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvProduccion.Rows[row].Cells["tituloProduccion"].Value = reader.GetString(reader.GetOrdinal("titulo"));
				dgvProduccion.Rows[row].Cells["fechaProduccion"].Value = reader.GetString(reader.GetOrdinal("fechaInicio"));
				dgvProduccion.Rows[row].Cells["statusProduccion"].Value = reader.GetString(reader.GetOrdinal("status"));
			}
			connection.closeConnection();
		}
	}
}
