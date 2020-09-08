using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace DocentematumCSharp
{
	public partial class MenuEstandarUsuario : Form
	{
		MainForm main;
		Login formaLogin;
		int userCode, n = -1, n2 = -1, newCode;
        string imageRoute = "C:\\Users\\Juan Balderrama\\source\\repos\\Jhonnyfasio\\DocentematumCSharp\\DocentematumCSharp\\bin\\Debug\\Images\\NotFound.jpg";
		public MenuEstandarUsuario()
		{
			InitializeComponent();
            
		}

		public MenuEstandarUsuario(MainForm m, Login forma1, int uCode)
		{
            
			string str;
			InitializeComponent();
			userCode = uCode;
			newCode = uCode;
            str = "C:\\Users\\Juan Balderrama\\source\\repos\\Jhonnyfasio\\DocentematumCSharp\\DocentematumCSharp\\bin\\Debug\\Images\\" + userCode.ToString() + ".jpg";
            if (File.Exists(str))
            {
                pictureProfile.Image = System.Drawing.Image.FromFile(str);
                imageRoute = str;
            }
            else
            {
                pictureProfile.Image = System.Drawing.Image.FromFile("Images\\NotFound.jpg");
            }

			ConnectionSql connection = new ConnectionSql();
			str = "SELECT nombre, codigoTrabajador FROM profesor WHERE codigoTrabajador = '" + userCode + "';";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				labelCodigo.Text = reader.GetInt32(reader.GetOrdinal("codigoTrabajador")).ToString();
				labelNombre.Text = reader.GetString(reader.GetOrdinal("nombre"));
			}

			chargeComboBoxGrado();
			chargeDvgAgregadas();
			chargeDgvCarrera();
			chargeDgvGrado();
			chargeDgvProduccion();

			main = m;
			formaLogin = forma1;
			forma1.Hide();
			this.CenterToScreen();

			

		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			ConnectionSql connection = new ConnectionSql();
			MySqlCommand command;

			string str;
			//dgvAgregadas.Rows.Clear();
			//dgvCarrera.Rows.Clear();
			if (n == -1)
			{
				MessageBox.Show("Seleccione una carrera primero");
				return;
			}

			str = "SELECT * FROM carrera_profesor WHERE idProfesor = '" + userCode + "' " +
				"AND idCarrera = \"" + (string)dgvCarrera.Rows[n].Cells["IdCarrera"].Value + "\";";
			command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				MessageBox.Show("Esta carrera ya ha sido agregada");
				n = -1;
				return;
			}
			connection.closeConnection();

			connection = new ConnectionSql();
			//str = (string)dgvCarrera.Rows[n].Cells["IdCarrera"].Value;
			str = "INSERT INTO carrera_profesor values (\"" + (string)dgvCarrera.Rows[n].Cells["IdCarrera"].Value + "\",'" +
				userCode + "');";

			command = connection.getCommand(str);
			command.ExecuteNonQuery();
			connection.closeConnection();

			string strCarrera;
			connection = new ConnectionSql();
			strCarrera = "SELECT * FROM carrera_profesor AS cp LEFT JOIN carrera AS c ON cp.idCarrera = c.idCarrera " +
				"WHERE cp.idProfesor = '" + userCode + "';";
			command = connection.getCommand(strCarrera);

			dgvAgregadas.Rows.Clear();
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvAgregadas.Rows.Add();
				dgvAgregadas.Rows[row].Cells["idAgregada"].Value = reader.GetString(reader.GetOrdinal("idCarrera")); ;
				dgvAgregadas.Rows[row].Cells["nombreAgregada"].Value = reader.GetString(reader.GetOrdinal("nombre"));
			}
			connection.closeConnection();
			n = -1;
		}

		private void dgvCarrera_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
			//MessageBox.Show(n.ToString());
		}

		private void dgvAgregadas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n2 = e.RowIndex;
		}

		private void buttonEliminar_Click(object sender, EventArgs e)
		{
			string str;

			if (n2 != -1)
			{
				ConnectionSql connection = new ConnectionSql();
				str = "DELETE FROM carrera_profesor WHERE idProfesor = '" + userCode + "' AND idCarrera = \"" + (string)dgvAgregadas.Rows[n2].Cells["idAgregada"].Value + "\";";
				MySqlCommand command = connection.getCommand(str);
				command.ExecuteNonQuery();
				dgvAgregadas.Rows.RemoveAt(n2);
				connection.closeConnection();
			}
			n2 = -1;
		}

		private void MenuEstandarUsuario_FormClosing(object sender, FormClosingEventArgs e)
		{
			formaLogin.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			chargeDgvCarrera();
		}

		private void buttonBuscarCarrera_Click(object sender, EventArgs e)
		{
			string str;

			ConnectionSql connection = new ConnectionSql();
			str = "SELECT idCarrera, c.nombre AS CName, d.nombre AS DName, tipo" +
				" FROM carrera AS C LEFT JOIN division AS d ON " +
				"C.idDivision=d.idDivision LEFT JOIN nivel AS N ON C.idNivel=n.idNivel WHERE idCarrera = +" +
			"\"" + textBoxBusquedaCarrera.Text + "\";";
			//str = "SELECT * FROM carrera WHERE idCarrera = \"" + textBoxBusquedaCarrera.Text +"\";";

			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			if (reader.Read())
			{
				dgvCarrera.Rows.Clear();
				int row = dgvCarrera.Rows.Add();
				dgvCarrera.Rows[row].Cells["idCarrera"].Value = reader.GetString(reader.GetOrdinal("idCarrera"));
				dgvCarrera.Rows[row].Cells["divisionCarrera"].Value = reader.GetString(reader.GetOrdinal("DName"));
				dgvCarrera.Rows[row].Cells["nivelCarrera"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvCarrera.Rows[row].Cells["nombreCarrera"].Value = reader.GetString(reader.GetOrdinal("CName"));
			}
			else
			{
				MessageBox.Show("No se ha encontrado alguna carrera con esa clave");
			}
		}

		public void chargeDgvCarrera()
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
				dgvCarrera.Rows[row].Cells["divisionCarrera"].Value = reader.GetString(reader.GetOrdinal("DName"));
				dgvCarrera.Rows[row].Cells["nivelCarrera"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvCarrera.Rows[row].Cells["nombreCarrera"].Value = reader.GetString(reader.GetOrdinal("CName"));
			}
			connection.closeConnection();
		}

		public void chargeDvgAgregadas()
		{
			string strCarrera;
			dgvAgregadas.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			strCarrera = "SELECT * FROM carrera_profesor AS cp LEFT JOIN carrera AS c ON cp.idCarrera = c.idCarrera WHERE idProfesor = '" + userCode.ToString() + "';";

			MySqlCommand command = connection.getCommand(strCarrera);
			MySqlDataReader reader;
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				int row = dgvAgregadas.Rows.Add();
				dgvAgregadas.Rows[row].Cells["idAgregada"].Value = reader.GetString(reader.GetOrdinal("idCarrera"));
				dgvAgregadas.Rows[row].Cells["nombreAgregada"].Value = reader.GetString(reader.GetOrdinal("nombre"));
			}
			connection.closeConnection();
		}

		///////////////////////////////////////// GRADOS ///////////////////////////////////////////////

		int nGrado = -1;

		private void chargeComboBoxGrado()
		{
			comboBoxTipo.Items.Clear();
			string str;
			ConnectionSql connection = new ConnectionSql();
			str = "SELECT * FROM grado_tipo;";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboBoxTipo.Items.Add(reader.GetInt32(reader.GetOrdinal("idGradoTipo"))
					+ " - " + reader.GetString(reader.GetOrdinal("tipo")));
			}
			connection.closeConnection();
		}

		private void DgvGrado_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nGrado = e.RowIndex;
		}

		private void buttonAgregarGrado_Click(object sender, EventArgs e)
		{
			try
			{
				string str;
				ConnectionSql connection = new ConnectionSql(), connectionAux;
				MySqlCommand command;
				MySqlDataReader reader;
				str = $"SELECT * FROM grado WHERE idTipo = \"{comboBoxTipo.Text.Substring(0, 1)}\" AND nombre = " +
					$"\"{textBoxNombreGrado.Text}\";";
				//MessageBox.Show(str);
				command = connection.getCommand(str);
				reader = command.ExecuteReader();
				if (reader.Read())
				{
					connectionAux = new ConnectionSql();
					str = $"INSERT INTO grado_profesor VALUES (\"{ reader.GetInt32(reader.GetOrdinal("idGrado")).ToString()}\"," +
						$"\"{labelCodigo.Text}\");";
					//MessageBox.Show(str);
					command = connectionAux.getCommand(str);
					command.ExecuteNonQuery();
					connectionAux.closeConnection();
				}
				else
				{
					connection.closeConnection();
					connection = new ConnectionSql();
					str = $"INSERT INTO grado VALUES (NULL, \"{comboBoxTipo.Text.Substring(0, 1)}\",\"{textBoxNombreGrado.Text}\");";
					//MessageBox.Show(str);
					command = connection.getCommand(str);
					command.ExecuteNonQuery();
					connection.closeConnection();

					connection = new ConnectionSql();
					str = $"SELECT * FROM grado WHERE idTipo = \"{ comboBoxTipo.Text.Substring(0, 1)}\"" +
						$" AND nombre = \"{ textBoxNombreGrado.Text}\";";
					//MessageBox.Show(str);
					command = connection.getCommand(str);
					reader = command.ExecuteReader();

					if (reader.Read())
					{
						connectionAux = new ConnectionSql();
						str = $"INSERT INTO grado_profesor VALUES (\"{ reader.GetInt32(reader.GetOrdinal("idGrado")).ToString()}\"" +
							$",\"{labelCodigo.Text}\");";
						//MessageBox.Show(str);
						command = connectionAux.getCommand(str);
						command.ExecuteNonQuery();
						connectionAux.closeConnection();
					}
				}
				connection.closeConnection();
				chargeDgvGrado();

			} catch (MySqlException i)
			{
				MessageBox.Show(i.Message+" - "+i.ToString());
			}
		}

		private void buttonEliminarGrado_Click(object sender, EventArgs e)
		{
			string str;
			DialogResult dialog = MessageBox.Show("Estás por eliminar un registro ¿Estás seguro de esto?", "Eliminado registro.", MessageBoxButtons.YesNoCancel);
			if (dialog == DialogResult.Yes)
			{
				if (nGrado != -1)
				{
					ConnectionSql connection = new ConnectionSql(), connectionAux;
					MySqlCommand command;
					MySqlDataReader reader;
					str = $"SELECT grado.idGrado, grado.nombre, grado_profesor.idProfesor FROM grado_profesor " +
						$"LEFT JOIN grado ON grado.idGrado = grado_profesor.idGrado " +
						$"WHERE grado_profesor.idProfesor = {labelCodigo.Text} AND grado.nombre = \"{(string)DgvGrado.Rows[nGrado].Cells["NombreGrado"].Value}\";";
					//MessageBox.Show(str);
					command = connection.getCommand(str);
					reader = command.ExecuteReader();
					if (reader.Read())
					{
						connectionAux = new ConnectionSql();
						str = $"DELETE FROM grado_profesor WHERE idProfesor = \"{labelCodigo.Text}\" AND  idGrado = \"{reader.GetInt32(reader.GetOrdinal("idGrado"))}\";";
						//MessageBox.Show(str);
						command = connectionAux.getCommand(str);
						command.ExecuteNonQuery();
						DgvGrado.Rows.RemoveAt(nGrado);
						connectionAux.closeConnection();
					}
					nGrado = -1;
					connection.closeConnection();


				}
			}
			//chargeDgvGrado();
		}

		private void chargeDgvGrado()
		{
			int row;
			DgvGrado.Rows.Clear();
			ConnectionSql connection = new ConnectionSql();
			string str = "SELECT g.nombre AS gNombre, gt.tipo AS gtTipo FROM grado_profesor AS gp LEFT JOIN grado AS g " +
				"ON gp.idGrado = g.idGrado LEFT JOIN grado_tipo AS gt ON g.idTipo = gt.idGradoTipo " +
				$"WHERE gp.idProfesor = {labelCodigo.Text};";
			MySqlCommand command = connection.getCommand(str);
			MySqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				row = DgvGrado.Rows.Add();
				DgvGrado.Rows[row].Cells["TipoGrado"].Value = reader.GetString(reader.GetOrdinal("gtTipo"));
				DgvGrado.Rows[row].Cells["NombreGrado"].Value = reader.GetString(reader.GetOrdinal("gNombre"));
			}

			connection.closeConnection();
		}

		// ///////////////////////////////////// Produccion //////////////////////////////////////////////

		int nProd = -1;

		private void buttonAgregarProduccion_Click(object sender, EventArgs e)
		{
			Produccion production = new Produccion(Convert.ToInt32(labelCodigo.Text),this);
			production.Show();
			

		}

		private void buttonModificarProduccion_Click(object sender, EventArgs e)
		{
			if (nProd != -1)
			{
				Produccion production = new Produccion((string)dgvProduccion.Rows[nProd].Cells["IDProduccion"].Value, this);
				production.Show();
			}
			else
			{
				MessageBox.Show("Error, seleccione primero una producción");
			}

		}

		private void buttonDetallarProduccion_Click(object sender, EventArgs e)
		{
			if (nProd != -1)
			{
				//MessageBox.Show((int)dgvProduccion.Rows[nProd].Cells["IDProduccion"].Value);
				VistaProduccion production = new VistaProduccion(Convert.ToInt32(dgvProduccion.Rows[nProd].Cells["IDProduccion"].Value.ToString()));
				production.Show();
			}
			else
			{
				MessageBox.Show("Error, seleccione primero una producción");
			}
			
		}

		private void buttonBuscarProduccion_Click(object sender, EventArgs e)
		{
			ConnectionSql connection = new ConnectionSql();
			MySqlCommand command;
			MySqlDataReader reader;
			string str = $"SELECT * FROM produccion WHERE idProduccion = \"{textBuscarProduccion.Text}\";";
			command = connection.getCommand(str);
			reader = command.ExecuteReader();
			dgvProduccion.Rows.Clear();
			if (reader.Read())
			{
				int row = dgvProduccion.Rows.Add();
				dgvProduccion.Rows[row].Cells["IDProduccion"].Value = reader.GetInt32(reader.GetOrdinal("idProduccion")).ToString();
				dgvProduccion.Rows[row].Cells["Titulo"].Value = reader.GetString(reader.GetOrdinal("titulo"));
				dgvProduccion.Rows[row].Cells["Tipo"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvProduccion.Rows[row].Cells["FechaInicio"].Value = reader.GetString(reader.GetOrdinal("fechaInicio"));
				dgvProduccion.Rows[row].Cells["Status"].Value = reader.GetString(reader.GetOrdinal("status"));
			}
			else
			{
				MessageBox.Show("Error, no hay un registro con este ID");
			}
			connection.closeConnection();
		}

		private void buttonListarProduccion_Click(object sender, EventArgs e)
		{
			chargeDgvProduccion();
		}

		private void buttonExportarCurriculum_Click(object sender, EventArgs e)
		{
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageRoute);
			Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.InitialDirectory = @"C:";
			dialog.Title = "Guardar Curriculum";
			dialog.DefaultExt = "pdf";
			dialog.Filter = "pdf files (*.pdf)|*-pdf| ALL files (*.*)|*.*";
			dialog.FilterIndex = 2;
			dialog.RestoreDirectory = true;
            image.ScaleToFit(80f, 80f);
            image.SpacingBefore = 10f;
            image.SpacingAfter = 10f;
            image.BorderColor = iTextSharp.text.BaseColor.BLUE;
            image.SetAbsolutePosition(doc.PageSize.Width - 150f, doc.PageSize.Height - 140);
            //image.IndentationRight = 20f;
            //image.Alignment = Element.ALIGN_LEFT + 20;
            //image.Alignment = Element.
            
			string filename = "";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				filename = dialog.FileName;
			}
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if(filename == "")
            {
                return;
            }
            FileStream file = new FileStream(filename, FileMode.Create);
            PdfWriter.GetInstance(doc, file);
            doc.Open();
			
			Paragraph p = new Paragraph();
			string str;
			str = "";
            
            doc.Add(new Paragraph("\n\n"));
            doc.Add(image);
            doc.Add(new Paragraph($"               Código:  {labelCodigo.Text}"));

			ConnectionSql connection = new ConnectionSql();
			MySqlCommand command;
			MySqlDataReader reader;
			str = $"SELECT * FROM profesor WHERE codigoTrabajador = \"{labelCodigo.Text}\";";
			command = connection.getCommand(str);
			reader = command.ExecuteReader();
			if (reader.Read())
			{
				doc.Add(new Paragraph($"               Nombre: { reader.GetString(reader.GetOrdinal("nombre")) } { reader.GetString(reader.GetOrdinal("apellidoPaterno"))} { reader.GetString(reader.GetOrdinal("apellidoMaterno"))} \n"));
				doc.Add(new Paragraph($"               Fecha Nacimiento: {reader.GetString(reader.GetOrdinal("fechaNacimiento"))} \n"));
				doc.Add(new Paragraph($"               Correo: {reader.GetString(reader.GetOrdinal("Correo"))} \n\n"));
			}

			BaseFont baseColumn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252,
				BaseFont.NOT_EMBEDDED);
			iTextSharp.text.Font font = new iTextSharp.text.Font(baseColumn, 10, 1, BaseColor.WHITE);

            ////////////////////// Grados ////////////////////////
			doc.Add(new Paragraph("               Grados obtenidos: \n\n"));
			PdfPTable tableGrado = new PdfPTable(DgvGrado.Columns.Count);
			//Table Header
			for (int i = 0; i < DgvGrado.Columns.Count; i++)
			{
				PdfPCell cell = new PdfPCell();
				cell.BackgroundColor = BaseColor.GRAY;
				cell.AddElement(new Chunk(DgvGrado.Columns[i].HeaderText.ToUpper(), font));
				tableGrado.AddCell(cell);
			}

			//Table Data
			for (int i = 0; i < DgvGrado.Rows.Count; i++)
			{
				for (int j = 0; j < DgvGrado.Columns.Count; j++)
					tableGrado.AddCell((string)DgvGrado.Rows[i].Cells[j].Value);
				;
			}
			doc.Add(tableGrado);
			doc.Add(new Paragraph("\n\n"));

            ////////////////////// Carreras ////////////////////////
            doc.Add(new Paragraph("               Carreras impartidas: \n\n"));
			PdfPTable tableCarrera = new PdfPTable(dgvAgregadas.Columns.Count);

			//Table Header
			for (int i = 0; i < dgvAgregadas.Columns.Count; i++)
			{
				PdfPCell cell = new PdfPCell();
				cell.BackgroundColor = BaseColor.GRAY;
				cell.AddElement(new Chunk(dgvAgregadas.Columns[i].HeaderText.ToUpper(), font));
				tableCarrera.AddCell(cell);
			}

			//Table Data
			for (int i = 0; i < dgvAgregadas.Rows.Count; i++)
			{
				for (int j = 0; j < dgvAgregadas.Columns.Count; j++)
					tableCarrera.AddCell((string)dgvAgregadas.Rows[i].Cells[j].Value);
				;
			}
			doc.Add(tableCarrera);
			doc.Add(new Paragraph("\n\n"));

            ////////////////////// Producciones ////////////////////////
            doc.Add(new Paragraph("               Producciones Aprobadas y Pendientes: \n\n"));
			PdfPTable tableProduccion = new PdfPTable(dgvProduccion.Columns.Count);
            float[] widths = new float[] { 20f, 20f, 20f, 20f, 20f };
            tableProduccion.SetWidths(widths);
			//Table Header
			for (int i = 0; i < dgvProduccion.Columns.Count; i++)
			{
				PdfPCell cell = new PdfPCell();
                if(i == 0)
                {
                    //cell.fix
                }
				cell.BackgroundColor = BaseColor.GRAY;
				cell.AddElement(new Chunk(dgvProduccion.Columns[i].HeaderText.ToUpper(), font));
				tableProduccion.AddCell(cell);
			}

			//Table Data
			for (int i = 0; i < dgvProduccion.Rows.Count; i++)
			{

                //MessageBox.Show((string)dgvProduccion.Rows[i].Cells["Status"].Value);
				if ((string)dgvProduccion.Rows[i].Cells["Status"].Value == "APROBADA")
				{
					for (int j = 0; j < dgvProduccion.Columns.Count; j++)
						tableProduccion.AddCell((string)dgvProduccion.Rows[i].Cells[j].Value);
				}
				
				
			}
			doc.Add(tableProduccion);
			doc.Add(new Paragraph("\n"));

			doc.Close();
			
		}

		private void buttonEliminarProduccion_Click(object sender, EventArgs e)
		{
			string str;
			
			if (nProd != -1)
			{
				DialogResult dialog = MessageBox.Show("Estás por eliminar un registro ¿Estás seguro de esto?", "Eliminado registro.", MessageBoxButtons.YesNoCancel);
				if (dialog == DialogResult.Yes)
				{
					try
					{
						ConnectionSql connection = new ConnectionSql();
						MySqlCommand command;
						str = $"DELETE FROM produccion WHERE idProduccion = \"{(string)dgvProduccion.Rows[nProd].Cells["IDProduccion"].Value}\";";
						//MessageBox.Show(str);
						command = connection.getCommand(str);
						command.ExecuteNonQuery();

						nProd = -1;
						connection.closeConnection();
						chargeDgvProduccion();
					}
					catch (MySqlException i)
					{
						MessageBox.Show(i.Message + "-" + i.ToString());
					}
				}
			}
			else
			{
				MessageBox.Show("Error, seleccione primero una producción");
			}
			
		}

		private void dgvProduccion_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nProd = e.RowIndex;
		}

		public void chargeDgvProduccion()
		{
			ConnectionSql connection = new ConnectionSql();
			MySqlCommand command;
			MySqlDataReader reader;
			string str = $"SELECT * FROM produccion WHERE idProfesor = \"{labelCodigo.Text}\";";
			command = connection.getCommand(str);
			reader = command.ExecuteReader();
			dgvProduccion.Rows.Clear();
			while (reader.Read())
			{
				int row = dgvProduccion.Rows.Add();
				dgvProduccion.Rows[row].Cells["IDProduccion"].Value = reader.GetInt32(reader.GetOrdinal("idProduccion")).ToString();
				dgvProduccion.Rows[row].Cells["Titulo"].Value = reader.GetString(reader.GetOrdinal("titulo"));
				dgvProduccion.Rows[row].Cells["Tipo"].Value = reader.GetString(reader.GetOrdinal("tipo"));
				dgvProduccion.Rows[row].Cells["FechaInicio"].Value = reader.GetString(reader.GetOrdinal("fechaInicio"));
				dgvProduccion.Rows[row].Cells["Status"].Value = reader.GetString(reader.GetOrdinal("status"));
			}
			connection.closeConnection();
		}
	}
}
