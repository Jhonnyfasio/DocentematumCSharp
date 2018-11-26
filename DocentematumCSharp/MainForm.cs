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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.CenterToScreen();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 forma1 = new Form1(this);
			this.Hide();
			forma1.Show();
			
		}
	}
}
