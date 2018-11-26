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

		private void button1_Click(object sender, EventArgs e)
		{
			tabPrincipal.SelectTab(1);
		}

		private void chargeDGVCarreras()
		{
			string str;
			dgvCarrera.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM nivel";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvCarrera.Rows.Add();
				dgvCarrera.Rows[row].Cells["Nombre"].Value = reader.GetInt32(reader.GetOrdinal("idNivel")).ToString();
			}
			
		}

		private void MenuAdministrator_FormClosing(object sender, FormClosingEventArgs e)
		{
			main.endOfProgram();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			tabPrincipal.SelectedIndex = 1;
		}
	}
}
