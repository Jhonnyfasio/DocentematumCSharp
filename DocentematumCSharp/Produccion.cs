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
	public partial class Produccion : Form
	{
		int idProfesor;
		int idProduccion;
		MenuEstandarUsuario menuEstandarUser;

		public Produccion()
		{
			InitializeComponent();
		}
		public Produccion(int userCode, MenuEstandarUsuario menuEstandar)
		{
			InitializeComponent();
			idProfesor = userCode;
			buttonGuardarModificar.Hide();
			menuEstandarUser = menuEstandar;
		}

		public Produccion(string idProduc, MenuEstandarUsuario menuUser)
		{
			InitializeComponent();
			menuEstandarUser = menuUser;
			idProduccion = Convert.ToInt32(idProduc);

			ConnectionSql connection = new ConnectionSql();
			MySqlCommand command;
			MySqlDataReader reader;

			string str = $"SELECT * FROM produccion WHERE idProduccion = \"{idProduccion}\";";
			command = connection.getCommand(str);
			reader = command.ExecuteReader();
			if (reader.Read())
			{
				buttonGuardar.Hide();
				textTipo.Text = reader.GetString(reader.GetOrdinal("tipo"));
				textTitulo.Text = reader.GetString(reader.GetOrdinal("titulo"));
				textNumeroInstitucion.Text = reader.GetString(reader.GetOrdinal("numeroInstitucion"));
				textProposito.Text = reader.GetString(reader.GetOrdinal("proposito"));
				textNumeroRegistro.Text = reader.GetString(reader.GetOrdinal("numeroRegistro"));
				textStatus.Text = reader.GetString(reader.GetOrdinal("status"));
			}
			else
			{
				this.Close();
			}
		}

		private bool checkNullFields()
		{
			if (string.IsNullOrWhiteSpace(textTipo.Text) || string.IsNullOrWhiteSpace(textTitulo.Text) ||
				string.IsNullOrWhiteSpace(textNumeroInstitucion.Text) || string.IsNullOrWhiteSpace(textNumeroRegistro.Text))
			{
				MessageBox.Show("Error, rellene todos los campos marcados con una marca roja");
				return false;
			}
			return true;
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			if (checkNullFields())
			{
                try
                {
                    buttonGuardarModificar.Hide();
                    buttonGuardar.Show();
                    ConnectionSql connection = new ConnectionSql();
                    MySqlCommand command;
                    string date1, date2;
                    date1 = dateFechaIncio.Value.Year.ToString() + "-" + dateFechaIncio.Value.Month.ToString() + "-" + dateFechaIncio.Value.Day.ToString();
                    date2 = dateFechaFinal.Value.Year.ToString() + "-" + dateFechaFinal.Value.Month.ToString() + "-" + dateFechaFinal.Value.Day.ToString();

                    //MessageBox.Show("here1");
                    if (dateFechaFinal.Value.Date < dateFechaIncio.Value.Date)
                    {
                        MessageBox.Show("La fecha final de la producción no puede ser menor a la inicial");
                        return;
                    }

                    string str = $"INSERT INTO produccion VALUES (NULL,\"{textTipo.Text}\",\"{textTitulo.Text}\"," +
						$"\"{date1}\",\"{date2}\",\"{textNumeroInstitucion.Text}\",\"{textProposito.Text}\"," +
						$"\"{textNumeroRegistro.Text}\",'Pendiente',\"{idProfesor.ToString()}\");";
					//MessageBox.Show(str);
					command = connection.getCommand(str);
					command.ExecuteNonQuery();
					connection.closeConnection();

					this.Close();
					menuEstandarUser.chargeDgvProduccion();
				}
				catch (MySqlException i)
				{
					MessageBox.Show(i.Message + " - " + i.ToString());
				}
			}
		}

		private void label10_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonGuardarModificar_Click(object sender, EventArgs e)
		{
            if (checkNullFields())
            {
                try
                {
                    ConnectionSql connection = new ConnectionSql();
                    MySqlCommand command;
                    string date1, date2;
                    date1 = dateFechaIncio.Value.Year.ToString() + "-" + dateFechaIncio.Value.Month.ToString() + "-" + dateFechaIncio.Value.Day.ToString();
                    date2 = dateFechaFinal.Value.Year.ToString() + "-" + dateFechaFinal.Value.Month.ToString() + "-" + dateFechaFinal.Value.Day.ToString();
                    //MessageBox.Show("here");
                    if (dateFechaFinal.Value.Date < dateFechaIncio.Value.Date)
                    {
                        MessageBox.Show("La fecha final de la producción no puede ser menor a la inicial");
                        return;
                    }

                    string str = $"UPDATE produccion SET tipo=\"{textTipo.Text}\", titulo=\"{textTitulo.Text}\"," +
                        $"fechaInicio = \"{date1}\",fechaFinal = \"{date2}\", numeroInstitucion = \"{textNumeroInstitucion.Text}\", proposito=\"{textProposito.Text}\"," +
                        $"numeroRegistro = \"{textNumeroRegistro.Text}\" WHERE idProduccion = \"{idProduccion}\";";
                    //MessageBox.Show(str);
                    command = connection.getCommand(str);
                    command.ExecuteNonQuery();
                    connection.closeConnection();
                    menuEstandarUser.chargeDgvProduccion();
                    this.Close();

                }
                catch (MySqlException i)
                {
                    MessageBox.Show(i.Message + "-" + i.ToString());
                }
            }
		}
	}
}
