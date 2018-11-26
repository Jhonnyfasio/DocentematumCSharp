using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocentematumCSharp
{
	public partial class Form1 : Form
	{
		MainForm main;
		public Form1()
		{
			InitializeComponent();
			this.CenterToScreen();
		}
		public Form1(MainForm m)
		{
			InitializeComponent();
			main = m;
			//main.Close();
			this.CenterToScreen();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void labelNuevo_Click(object sender, EventArgs e)
		{
			MenuAdministrator formaUsuarioEstandar = new MenuAdministrator();
			formaUsuarioEstandar.Show();
			this.Hide();
		}
	}
}
