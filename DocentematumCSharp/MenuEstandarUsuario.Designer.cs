namespace DocentematumCSharp
{
	partial class MenuEstandarUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonExportarCurriculum = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.tabPageProduccionesProfesor = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.TipoGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.IDGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelTipoGrado = new System.Windows.Forms.Label();
			this.labelCodigoAdministrador = new System.Windows.Forms.Label();
			this.labelNombreAdministrador = new System.Windows.Forms.Label();
			this.tabPageCarrerasProfesor = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelBusqueda = new System.Windows.Forms.Label();
			this.textBoxBusqueda = new System.Windows.Forms.TextBox();
			this.buttonEliminar = new System.Windows.Forms.Button();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.comboBoxTipo = new System.Windows.Forms.ComboBox();
			this.textBoxNombreGrado = new System.Windows.Forms.TextBox();
			this.labelNombreGrado = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.buttonEditarPerfil = new System.Windows.Forms.Button();
			this.tabControlProfesor = new System.Windows.Forms.TabControl();
			this.tabPageGradosProfesor = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPageProduccionesProfesor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPageCarrerasProfesor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControlProfesor.SuspendLayout();
			this.tabPageGradosProfesor.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonExportarCurriculum
			// 
			this.buttonExportarCurriculum.BackColor = System.Drawing.Color.Indigo;
			this.buttonExportarCurriculum.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonExportarCurriculum.Location = new System.Drawing.Point(666, 393);
			this.buttonExportarCurriculum.Name = "buttonExportarCurriculum";
			this.buttonExportarCurriculum.Size = new System.Drawing.Size(114, 23);
			this.buttonExportarCurriculum.TabIndex = 59;
			this.buttonExportarCurriculum.Text = "Exportar Curriculum";
			this.buttonExportarCurriculum.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Buscar: ";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(69, 23);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(516, 20);
			this.textBox7.TabIndex = 17;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Olive;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.Location = new System.Drawing.Point(396, 277);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "Modificar";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DarkRed;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Location = new System.Drawing.Point(477, 277);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 14;
			this.button5.Text = "Eliminar";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			// 
			// FechaInicio
			// 
			this.FechaInicio.HeaderText = "Fecha Inicio";
			this.FechaInicio.Name = "FechaInicio";
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Titulo";
			this.Titulo.Name = "Titulo";
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			// 
			// IDProduccion
			// 
			this.IDProduccion.HeaderText = "ID";
			this.IDProduccion.Name = "IDProduccion";
			// 
			// dataGridView3
			// 
			this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduccion,
            this.Tipo,
            this.Titulo,
            this.FechaInicio,
            this.Status});
			this.dataGridView3.Location = new System.Drawing.Point(9, 75);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(543, 169);
			this.dataGridView3.TabIndex = 19;
			// 
			// tabPageProduccionesProfesor
			// 
			this.tabPageProduccionesProfesor.Controls.Add(this.dataGridView3);
			this.tabPageProduccionesProfesor.Controls.Add(this.label4);
			this.tabPageProduccionesProfesor.Controls.Add(this.textBox7);
			this.tabPageProduccionesProfesor.Controls.Add(this.button4);
			this.tabPageProduccionesProfesor.Controls.Add(this.button5);
			this.tabPageProduccionesProfesor.Controls.Add(this.button6);
			this.tabPageProduccionesProfesor.Location = new System.Drawing.Point(4, 22);
			this.tabPageProduccionesProfesor.Name = "tabPageProduccionesProfesor";
			this.tabPageProduccionesProfesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProduccionesProfesor.Size = new System.Drawing.Size(591, 311);
			this.tabPageProduccionesProfesor.TabIndex = 2;
			this.tabPageProduccionesProfesor.Text = "Tus Producciones";
			this.tabPageProduccionesProfesor.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DarkGreen;
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.Location = new System.Drawing.Point(300, 277);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 13;
			this.button6.Text = "Agregar";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// TipoGrado
			// 
			this.TipoGrado.HeaderText = "Tipo";
			this.TipoGrado.Name = "TipoGrado";
			// 
			// NombreGrado
			// 
			this.NombreGrado.HeaderText = "Nombre";
			this.NombreGrado.Name = "NombreGrado";
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGrado,
            this.NombreGrado,
            this.TipoGrado});
			this.dataGridView2.Location = new System.Drawing.Point(58, 48);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(346, 148);
			this.dataGridView2.TabIndex = 29;
			// 
			// IDGrado
			// 
			this.IDGrado.HeaderText = "ID";
			this.IDGrado.Name = "IDGrado";
			// 
			// labelTipoGrado
			// 
			this.labelTipoGrado.AutoSize = true;
			this.labelTipoGrado.Location = new System.Drawing.Point(10, 261);
			this.labelTipoGrado.Name = "labelTipoGrado";
			this.labelTipoGrado.Size = new System.Drawing.Size(28, 13);
			this.labelTipoGrado.TabIndex = 28;
			this.labelTipoGrado.Text = "Tipo";
			// 
			// labelCodigoAdministrador
			// 
			this.labelCodigoAdministrador.AutoSize = true;
			this.labelCodigoAdministrador.BackColor = System.Drawing.Color.Transparent;
			this.labelCodigoAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCodigoAdministrador.ForeColor = System.Drawing.Color.White;
			this.labelCodigoAdministrador.Location = new System.Drawing.Point(16, 34);
			this.labelCodigoAdministrador.Name = "labelCodigoAdministrador";
			this.labelCodigoAdministrador.Size = new System.Drawing.Size(56, 18);
			this.labelCodigoAdministrador.TabIndex = 56;
			this.labelCodigoAdministrador.Text = "Código";
			// 
			// labelNombreAdministrador
			// 
			this.labelNombreAdministrador.AutoSize = true;
			this.labelNombreAdministrador.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreAdministrador.ForeColor = System.Drawing.Color.White;
			this.labelNombreAdministrador.Location = new System.Drawing.Point(16, 93);
			this.labelNombreAdministrador.Name = "labelNombreAdministrador";
			this.labelNombreAdministrador.Size = new System.Drawing.Size(62, 18);
			this.labelNombreAdministrador.TabIndex = 55;
			this.labelNombreAdministrador.Text = "Nombre";
			// 
			// tabPageCarrerasProfesor
			// 
			this.tabPageCarrerasProfesor.Controls.Add(this.dataGridView1);
			this.tabPageCarrerasProfesor.Controls.Add(this.labelBusqueda);
			this.tabPageCarrerasProfesor.Controls.Add(this.textBoxBusqueda);
			this.tabPageCarrerasProfesor.Controls.Add(this.buttonEliminar);
			this.tabPageCarrerasProfesor.Controls.Add(this.buttonAgregar);
			this.tabPageCarrerasProfesor.Location = new System.Drawing.Point(4, 22);
			this.tabPageCarrerasProfesor.Name = "tabPageCarrerasProfesor";
			this.tabPageCarrerasProfesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCarrerasProfesor.Size = new System.Drawing.Size(591, 311);
			this.tabPageCarrerasProfesor.TabIndex = 0;
			this.tabPageCarrerasProfesor.Text = "Tus Carreras";
			this.tabPageCarrerasProfesor.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Division,
            this.Nivel});
			this.dataGridView1.Location = new System.Drawing.Point(69, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(438, 150);
			this.dataGridView1.TabIndex = 12;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Division
			// 
			this.Division.HeaderText = "Division";
			this.Division.Name = "Division";
			// 
			// Nivel
			// 
			this.Nivel.HeaderText = "Nivel";
			this.Nivel.Name = "Nivel";
			// 
			// labelBusqueda
			// 
			this.labelBusqueda.AutoSize = true;
			this.labelBusqueda.Location = new System.Drawing.Point(6, 25);
			this.labelBusqueda.Name = "labelBusqueda";
			this.labelBusqueda.Size = new System.Drawing.Size(46, 13);
			this.labelBusqueda.TabIndex = 11;
			this.labelBusqueda.Text = "Buscar: ";
			// 
			// textBoxBusqueda
			// 
			this.textBoxBusqueda.Location = new System.Drawing.Point(69, 22);
			this.textBoxBusqueda.Name = "textBoxBusqueda";
			this.textBoxBusqueda.Size = new System.Drawing.Size(506, 20);
			this.textBoxBusqueda.TabIndex = 10;
			// 
			// buttonEliminar
			// 
			this.buttonEliminar.BackColor = System.Drawing.Color.DarkRed;
			this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonEliminar.Location = new System.Drawing.Point(500, 285);
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
			this.buttonEliminar.TabIndex = 4;
			this.buttonEliminar.Text = "Eliminar";
			this.buttonEliminar.UseVisualStyleBackColor = false;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.BackColor = System.Drawing.Color.DarkGreen;
			this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonAgregar.Location = new System.Drawing.Point(400, 285);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
			this.buttonAgregar.TabIndex = 3;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = false;
			// 
			// comboBoxTipo
			// 
			this.comboBoxTipo.FormattingEnabled = true;
			this.comboBoxTipo.Items.AddRange(new object[] {
            "LIC",
            "MTR",
            "MTRO",
            "PHD",
            "PPHD"});
			this.comboBoxTipo.Location = new System.Drawing.Point(74, 258);
			this.comboBoxTipo.Name = "comboBoxTipo";
			this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTipo.TabIndex = 27;
			// 
			// textBoxNombreGrado
			// 
			this.textBoxNombreGrado.Location = new System.Drawing.Point(74, 219);
			this.textBoxNombreGrado.Name = "textBoxNombreGrado";
			this.textBoxNombreGrado.Size = new System.Drawing.Size(174, 20);
			this.textBoxNombreGrado.TabIndex = 26;
			// 
			// labelNombreGrado
			// 
			this.labelNombreGrado.AutoSize = true;
			this.labelNombreGrado.Location = new System.Drawing.Point(10, 222);
			this.labelNombreGrado.Name = "labelNombreGrado";
			this.labelNombreGrado.Size = new System.Drawing.Size(44, 13);
			this.labelNombreGrado.TabIndex = 24;
			this.labelNombreGrado.Text = "Nombre";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkRed;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(477, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 23;
			this.button2.Text = "Eliminar";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkGreen;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Location = new System.Drawing.Point(379, 235);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 22;
			this.button3.Text = "Agregar";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Buscar: ";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(58, 10);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(516, 20);
			this.textBox8.TabIndex = 20;
			// 
			// buttonEditarPerfil
			// 
			this.buttonEditarPerfil.BackColor = System.Drawing.Color.Peru;
			this.buttonEditarPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonEditarPerfil.Location = new System.Drawing.Point(19, 393);
			this.buttonEditarPerfil.Name = "buttonEditarPerfil";
			this.buttonEditarPerfil.Size = new System.Drawing.Size(75, 23);
			this.buttonEditarPerfil.TabIndex = 58;
			this.buttonEditarPerfil.Text = "Editar Perfil";
			this.buttonEditarPerfil.UseVisualStyleBackColor = false;
			// 
			// tabControlProfesor
			// 
			this.tabControlProfesor.Controls.Add(this.tabPageCarrerasProfesor);
			this.tabControlProfesor.Controls.Add(this.tabPageGradosProfesor);
			this.tabControlProfesor.Controls.Add(this.tabPageProduccionesProfesor);
			this.tabControlProfesor.Location = new System.Drawing.Point(185, 34);
			this.tabControlProfesor.Name = "tabControlProfesor";
			this.tabControlProfesor.SelectedIndex = 0;
			this.tabControlProfesor.Size = new System.Drawing.Size(599, 337);
			this.tabControlProfesor.TabIndex = 57;
			// 
			// tabPageGradosProfesor
			// 
			this.tabPageGradosProfesor.Controls.Add(this.dataGridView2);
			this.tabPageGradosProfesor.Controls.Add(this.labelTipoGrado);
			this.tabPageGradosProfesor.Controls.Add(this.comboBoxTipo);
			this.tabPageGradosProfesor.Controls.Add(this.textBoxNombreGrado);
			this.tabPageGradosProfesor.Controls.Add(this.labelNombreGrado);
			this.tabPageGradosProfesor.Controls.Add(this.button2);
			this.tabPageGradosProfesor.Controls.Add(this.button3);
			this.tabPageGradosProfesor.Controls.Add(this.label5);
			this.tabPageGradosProfesor.Controls.Add(this.textBox8);
			this.tabPageGradosProfesor.Location = new System.Drawing.Point(4, 22);
			this.tabPageGradosProfesor.Name = "tabPageGradosProfesor";
			this.tabPageGradosProfesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGradosProfesor.Size = new System.Drawing.Size(591, 311);
			this.tabPageGradosProfesor.TabIndex = 1;
			this.tabPageGradosProfesor.Text = "Tus Grados";
			this.tabPageGradosProfesor.UseVisualStyleBackColor = true;
			// 
			// MenuEstandarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonExportarCurriculum);
			this.Controls.Add(this.labelCodigoAdministrador);
			this.Controls.Add(this.labelNombreAdministrador);
			this.Controls.Add(this.buttonEditarPerfil);
			this.Controls.Add(this.tabControlProfesor);
			this.Name = "MenuEstandarUsuario";
			this.Text = "MenuEstandarUsuario";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPageProduccionesProfesor.ResumeLayout(false);
			this.tabPageProduccionesProfesor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPageCarrerasProfesor.ResumeLayout(false);
			this.tabPageCarrerasProfesor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControlProfesor.ResumeLayout(false);
			this.tabPageGradosProfesor.ResumeLayout(false);
			this.tabPageGradosProfesor.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExportarCurriculum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDProduccion;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.TabPage tabPageProduccionesProfesor;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoGrado;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreGrado;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDGrado;
		private System.Windows.Forms.Label labelTipoGrado;
		private System.Windows.Forms.Label labelCodigoAdministrador;
		private System.Windows.Forms.Label labelNombreAdministrador;
		private System.Windows.Forms.TabPage tabPageCarrerasProfesor;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Division;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
		private System.Windows.Forms.Label labelBusqueda;
		private System.Windows.Forms.TextBox textBoxBusqueda;
		private System.Windows.Forms.Button buttonEliminar;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.ComboBox comboBoxTipo;
		private System.Windows.Forms.TextBox textBoxNombreGrado;
		private System.Windows.Forms.Label labelNombreGrado;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button buttonEditarPerfil;
		private System.Windows.Forms.TabControl tabControlProfesor;
		private System.Windows.Forms.TabPage tabPageGradosProfesor;
	}
}