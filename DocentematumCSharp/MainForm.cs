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
		MainForm forma;
		public MainForm()
		{
			InitializeComponent();
			this.CenterToScreen();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login forma1 = new Login(this);
			this.Hide();
			forma1.Show();
			
		}

		public void endOfProgram()
		{
			this.Close();
		}

		public void setMainForm(MainForm formaMainForm)
		{
			
			forma = formaMainForm;
		}

		public MainForm getMainForm()
		{
			return forma;
		}
	}
}
