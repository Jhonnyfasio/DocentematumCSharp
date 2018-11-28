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
	public partial class MenuAdministrator : Form
	{
		MainForm main;
		int userCode;
		public MenuAdministrator()
		{
			InitializeComponent();
		}

		public MenuAdministrator(MainForm m,Login forma1,int uCode)
		{
			InitializeComponent();
			chargeDGVCarreras();
			forma1.Hide();
			userCode = uCode;
			main = m;
			ConnectionSql connection = new ConnectionSql();
			string sentence = "SELECT * FROM profesor WHERE codigoTrabajador = '" + userCode.ToString() + "';";
			MySqlCommand command = connection.getCommand(sentence);
			MySqlDataReader myReader = command.ExecuteReader();
			myReader.Read();
			labelCodigo.Text = userCode.ToString();;
			labelNombre.Text = myReader.GetString(myReader.GetOrdinal("nombre"));
			connection.closeConnection();

		}

		private void chargeDGVCarreras()
		{
			string strCarrera, strDivision, strNivel, str;
			dgvCarrera.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			ConnectionSql connectionDivision = new ConnectionSql();
			ConnectionSql connectionNivel = new ConnectionSql();
			strCarrera = "SELECT * FROM carrera;";
			MySqlCommand command = connection.getCommand(strCarrera);
			MySqlDataReader reader, readerDivision, readerNivel;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				MessageBox.Show("");
				int row = dgvCarrera.Rows.Add();
				dgvCarrera.Rows[row].Cells["idCarrera"].Value = reader.GetInt32(reader.GetOrdinal("idCarrera")).ToString();
				
				str = reader.GetInt32(reader.GetOrdinal("idDivision")).ToString();
				//connection.closeConnection();
				readerDivision = connectionDivision.getCommand("SELECT * FROM division WHERE idDivision = '"+str+"';").ExecuteReader();
				readerDivision.Read();
				dgvCarrera.Rows[row].Cells["idDivision"].Value = readerDivision.GetString(readerDivision.GetOrdinal("nombre"));

				str = reader.GetInt32(reader.GetOrdinal("idNivel")).ToString();
				readerNivel = connectionNivel.getCommand("SELECT * FROM nivel WHERE idNivel = '" + str + "';").ExecuteReader();
				readerNivel.Read();
				dgvCarrera.Rows[row].Cells["idNivel"].Value = readerNivel.GetString(readerNivel.GetOrdinal("tipo"));

				//connection.openConnection();
				dgvCarrera.Rows[row].Cells["nombre"].Value = reader.GetString(reader.GetOrdinal("nombre"));
				MessageBox.Show("");
			}
			connectionDivision.closeConnection();
			connectionNivel.closeConnection();
			connection.closeConnection();
		}

		private void MenuAdministrator_FormClosing(object sender, FormClosingEventArgs e)
		{
			main.endOfProgram();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			tabPrincipal.SelectedIndex = 1;
		}

		private void buttonGrado_Click(object sender, EventArgs e)
		{
			tabPrincipal.SelectedIndex = 2;
		}

		private void buttonInicio_Click(object sender, EventArgs e)
		{
			tabPrincipal.SelectedIndex = 0;
		}

		private void buttonProduccion_Click(object sender, EventArgs e)
		{
			tabPrincipal.SelectedIndex = 3;
		}
	}
}
