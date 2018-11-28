﻿using System;
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
	public partial class Login : Form
	{
		MainForm main;
		public Login()
		{
			InitializeComponent();
			this.CenterToScreen();
		}
		public Login(MainForm m)
		{
			InitializeComponent();
			this.CenterToScreen();
			main = m;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				ConnectionSql connection = new ConnectionSql();
				string sentencia = "SELECT * FROM profesor WHERE usuario = '" + usuarioTextBox.Text + "' AND contrasena = '" + contrasenaTextBox.Text + "';";
				MySqlCommand comando = connection.getCommand(sentencia);
				MySqlDataReader myReader;
				myReader = comando.ExecuteReader();
				if (myReader.Read())
				{
					int codTrab;
					codTrab = myReader.GetInt32(myReader.GetOrdinal("codigoTrabajador"));
					MenuAdministrator menuAdmin = new MenuAdministrator(main,this,codTrab);
					menuAdmin.Show();
				}
				else
				{
					MessageBox.Show("Error, contraseña y/o usuario incorrectos.");
					
				}
				connection.closeConnection();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error encotrado: " + ex.ToString());
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			main.endOfProgram();
		}
	}
}