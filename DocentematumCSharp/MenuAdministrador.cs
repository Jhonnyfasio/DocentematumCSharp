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
		int userCode, n;
		public string labelDivisionID, labelNivelType;

		public MenuAdministrator()
		{
			InitializeComponent();
		}

		public MenuAdministrator(MainForm m,Login forma1,int uCode)
		{
			InitializeComponent();
			chargeDGVCarreras();
			chargeDgvDivisiones();
			chargeDgvUsers();
			chargeComboDivision();
			chargeComboNivel();
			forma1.Hide();
			userCode = uCode;
			main = m;
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

		private void chargeComboDivision()
		{
			comboDivision.Items.Clear();
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM division;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboDivision.Items.Add(reader.GetInt32(reader.GetOrdinal("idDivision")).ToString()  
					+" - "+ reader.GetString(reader.GetOrdinal("nombre")));
			}
			connection.closeConnection();
		}

		private void chargeComboNivel()
		{
			comboNivel.Items.Clear();
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM nivel;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboNivel.Items.Add(reader.GetInt32(reader.GetOrdinal("idNivel"))
					+" - "+reader.GetString(reader.GetOrdinal("tipo")));
			}
			connection.closeConnection();
		}

		private void comboNivel_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelNivelType = comboNivel.SelectedIndex.ToString();
		}	

		private void comboDivision_SelectedIndexChanged(object sender, EventArgs e)
		{	
	
		}

		private void chargeDGVCarreras()
		{
			string strCarrera;
			dgvCarrera.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			strCarrera = "SELECT idCarrera, c.nombre AS CName, d.nombre AS DName, tipo" +
				" FROM carrera AS C LEFT JOIN division AS d ON " +
				"C.idDivision=d.idDivision LEFT JOIN nivel AS N ON C.idNivel=n.idNivel;";
			MySqlCommand command = connection.getCommand(strCarrera);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvCarrera.Rows.Add();
				dgvCarrera.Rows[row].Cells["idCarrera"].Value = reader.GetString(reader.GetOrdinal("idCarrera"));	
				dgvCarrera.Rows[row].Cells["idDivision"].Value = reader.GetString(reader.GetOrdinal("DName"));			
				dgvCarrera.Rows[row].Cells["idNivel"].Value = reader.GetString(reader.GetOrdinal("tipo"));				
				dgvCarrera.Rows[row].Cells["nombre"].Value = reader.GetString(reader.GetOrdinal("CName"));
			}
			connection.closeConnection();
		}

		private void MenuAdministrator_FormClosing(object sender, FormClosingEventArgs e)
		{
			main.endOfProgram();
		}

		private void buttonGuardarCarrera_Click(object sender, EventArgs e)
		{
			int indexNivel = comboNivel.SelectedIndex;
			int indexDivision = comboDivision.SelectedIndex;
			string str, division, nivel;
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)
				|| comboDivision.SelectedIndex == -1 || comboNivel.SelectedIndex == -1)
			{
				MessageBox.Show("No puede haber campos nulos");
				return;
			}

			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM carrera WHERE idCarrera = \"" +textBox1.Text+"\";";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				MessageBox.Show("Error, carrera: '" + textBox1.Text + "' ya previamente registrada");
			}
			else
			{
				connection.closeConnection();
				division = comboDivision.Items[indexDivision].ToString().Substring(0, 5);
				nivel = comboNivel.Items[indexNivel].ToString().Substring(0, 1);

				connection = new ConnectionSql();
				str = "INSERT INTO carrera VALUES ('" + textBox1.Text + "', '" + division +
					"', '" + nivel + "', '" + textBox2.Text + "');";

				command = connection.getCommand(str);
				command.ExecuteNonQuery();

				chargeDGVCarreras();
			}
			connection.closeConnection();
			cleanTextBoxCarrera();
		}

		private void buttonBorrarCarrera_Click(object sender, EventArgs e)
		{
			string str;
			DialogResult dialog = MessageBox.Show("Estás por eliminar un registro ¿Estás seguro de esto?","Eliminado regsitro.",MessageBoxButtons.YesNoCancel);
			if (dialog == DialogResult.Yes)
			{
				if (n != -1)
				{
					ConnectionSql connection = new ConnectionSql();
					str = "DELETE FROM carrera WHERE idCarrera = \"" + (string)dgvCarrera.Rows[n].Cells["idCarrera"].Value + "\";";
					MySqlCommand command = connection.getCommand(str);
					command.ExecuteNonQuery();
					dgvCarrera.Rows.RemoveAt(n);
					connection.closeConnection();
				}
			}

			
		}

		private void dgvCarrera_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
		}

		private void buttonLimpiarCarrera_Click(object sender, EventArgs e)
		{
			cleanTextBoxCarrera();
		}

		private void cleanTextBoxCarrera()
		{
			textBox1.Clear();
			textBox2.Clear();
			comboNivel.SelectedItem = -1;
			comboDivision.SelectedItem = -1;
		}

		// ///////////////////////////////////////// DIVISIONES ////////////////////////////////////////////

		private void buttonBuscarDivision_Click(object sender, EventArgs e)
		{
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM division WHERE idDivision = '" + textBoxFindDiv.Text + "';";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				dgvDivisiones.Rows.Clear();
				int row = dgvDivisiones.Rows.Add();
				dgvDivisiones.Rows[row].Cells["ClaveDivision"].Value = reader.GetString(reader.GetOrdinal("idDivision"));
				dgvDivisiones.Rows[row].Cells["NombreDivision"].Value = reader.GetString(reader.GetOrdinal("nombre"));
			}
			else
			{
				MessageBox.Show("Error, la división no pudo ser encontrada");
			}
			textBoxFindDiv.Clear();
			connection.closeConnection();
		}

		private void buttonAgregarDivision_Click(object sender, EventArgs e)
		{
			string str;
			if (string.IsNullOrWhiteSpace(textBoxClaveDiv.Text) || string.IsNullOrWhiteSpace(textBoxNomDiv.Text))
			{
				MessageBox.Show("No puede haber campos nulos");
				return;
			}

			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM division WHERE idDivision = " + textBoxClaveDiv.Text + ";";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				MessageBox.Show("Error, carrera: '" + textBox1.Text + "' ya previamente registrada");
			}
			else
			{
				connection.closeConnection();

				connection = new ConnectionSql();
				str = "INSERT INTO division VALUES ('" + textBoxClaveDiv.Text + "', '" + textBoxNomDiv.Text + "');";

				command = connection.getCommand(str);
				command.ExecuteNonQuery();

				chargeDgvDivisiones();
				chargeComboDivision();
			}
			connection.closeConnection();
			cleanTextBoxDivision();
		}

		public void chargeDgvDivisiones()
		{
			string strCarrera;
			dgvDivisiones.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			strCarrera = "SELECT * FROM division";
			MySqlCommand command = connection.getCommand(strCarrera);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvDivisiones.Rows.Add();
				dgvDivisiones.Rows[row].Cells["ClaveDivision"].Value = reader.GetString(reader.GetOrdinal("idDivision"));
				dgvDivisiones.Rows[row].Cells["NombreDivision"].Value = reader.GetString(reader.GetOrdinal("nombre"));
			}
			connection.closeConnection();
		}

		private void buttonEliminarDivision_Click(object sender, EventArgs e)
		{
			string str;
			DialogResult dialog = MessageBox.Show("Estás por eliminar un registro ¿Estás seguro de esto?", "Eliminado regsitro.", MessageBoxButtons.YesNoCancel);
			if (dialog == DialogResult.Yes)
			{
				if (n != -1)
				{
					ConnectionSql connection = new ConnectionSql();
					str = "DELETE FROM division WHERE idDivision = " + (string)dgvDivisiones.Rows[n].Cells["ClaveDivision"].Value + ";";
					MySqlCommand command = connection.getCommand(str);
					command.ExecuteNonQuery();
					dgvDivisiones.Rows.RemoveAt(n);
					chargeDGVCarreras();

					connection.closeConnection();
				}
			}
		}

		private void dgvDivisiones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
		}

		private void buttonListarTodo_Click(object sender, EventArgs e)
		{
			chargeDgvDivisiones();
		}

		public void cleanTextBoxDivision()
		{
			textBoxClaveDiv.Clear();
			textBoxNomDiv.Clear();
		}

		
		//////////////////////////////////////////// USUARIO ///////////////////////////////////////////////

		private void buttonAgregarUsuario_Click(object sender, EventArgs e)
		{
			RegistroUsuario user = new RegistroUsuario();
			user.Show();
			chargeDgvUsers();
		}

		public void chargeUsers()
		{
			chargeDgvUsers();
		}

		private void buttonEliminarUsuario_Click(object sender, EventArgs e)
		{
			string str;
			DialogResult dialog = MessageBox.Show("Estás por eliminar un registro ¿Estás seguro de esto?", "Eliminado regsitro.", MessageBoxButtons.YesNoCancel);
			if (dialog == DialogResult.Yes)
			{
				if (n != -1)
				{
					ConnectionSql connection = new ConnectionSql();
					str = "DELETE FROM profesor WHERE codigoTrabajador = " + (string)dgvDivisiones.Rows[n].Cells["ClaveDivision"].Value + ";";
					MySqlCommand command = connection.getCommand(str);
					command.ExecuteNonQuery();
					dgvUsuarios.Rows.RemoveAt(n);
					chargeDgvUsers();

					connection.closeConnection();
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			chargeDgvUsers();
		}

		private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
		}

		public void chargeDgvUsers()
		{
			string str;
			dgvUsuarios.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			str= "SELECT * FROM profesor AS p LEFT JOIN tipo_usuario AS t ON p.idTipoUsuario = t.idTipoUsuario;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvUsuarios.Rows.Add();
				dgvUsuarios.Rows[row].Cells["CodigoProfesor"].Value = reader.GetInt32(reader.GetOrdinal("codigoTrabajador")).ToString();
				dgvUsuarios.Rows[row].Cells["nombreProfesor"].Value = reader.GetString(reader.GetOrdinal("nombre"));
				dgvUsuarios.Rows[row].Cells["apellidoPProfesor"].Value = reader.GetString(reader.GetOrdinal("apellidoPaterno"));
				dgvUsuarios.Rows[row].Cells["apellidoMProfesor"].Value = reader.GetString(reader.GetOrdinal("apellidoMaterno"));
				dgvUsuarios.Rows[row].Cells["usuarioProfesor"].Value = reader.GetString(reader.GetOrdinal("usuario"));
				if (reader["correo"] != DBNull.Value)
				{
					dgvUsuarios.Rows[row].Cells["correoProfesor"].Value = reader.GetString(reader.GetOrdinal("correo"));
				}
				
				dgvUsuarios.Rows[row].Cells["tipoUsuarioProfesor"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvUsuarios.Rows[row].Cells["estadoProfesor"].Value = reader.GetString(reader.GetOrdinal("estado"));
			}
			connection.closeConnection();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string str;
			ConnectionSql connection = new ConnectionSql(); str = "SELECT * FROM profesor AS p LEFT JOIN tipo_usuario AS t ON p.idTipoUsuario = t.idTipoUsuario;";
			//str = "SELECT * FROM profesor WHERE codigoTrabajador = '" + textBoxFindUser.Text + "';";
			str = "SELECT * FROM profesor AS p LEFT JOIN tipo_usuario AS t ON p.idTipoUsuario = t.idTipoUsuario WHERE codigoTrabajador = '"+
				textBoxFindUser.Text+"';";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				dgvUsuarios.Rows.Clear();
				int row = dgvUsuarios.Rows.Add();
				dgvUsuarios.Rows[row].Cells["codigoProfesor"].Value = reader.GetInt32(reader.GetOrdinal("codigoTrabajador")).ToString();
				dgvUsuarios.Rows[row].Cells["nombreProfesor"].Value = reader.GetString(reader.GetOrdinal("nombre"));
				dgvUsuarios.Rows[row].Cells["apellidoPProfesor"].Value = reader.GetString(reader.GetOrdinal("apellidoPaterno"));
				dgvUsuarios.Rows[row].Cells["apellidoMProfesor"].Value = reader.GetString(reader.GetOrdinal("apellidoMaterno"));
				dgvUsuarios.Rows[row].Cells["usuarioProfesor"].Value = reader.GetString(reader.GetOrdinal("usuario"));
				if (reader["correo"] != DBNull.Value)
				{
					dgvUsuarios.Rows[row].Cells["correoProfesor"].Value = reader.GetString(reader.GetOrdinal("correo"));
				}
				dgvUsuarios.Rows[row].Cells["tipoUsuarioProfesor"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvUsuarios.Rows[row].Cells["estadoProfesor"].Value = reader.GetString(reader.GetOrdinal("estado"));
			}
			else
			{
				MessageBox.Show("Error, el usuario no pudo ser encontrado");
			}
			textBoxFindUser.Clear();
			connection.closeConnection();
		}

	}
}
