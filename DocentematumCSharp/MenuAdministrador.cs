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
		public MenuAdministrator()
		{
			InitializeComponent();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void labelRegresar_Click(object sender, EventArgs e)
		{
			Form1 forma1 = new Form1();
			this.Close();
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
	}
}
