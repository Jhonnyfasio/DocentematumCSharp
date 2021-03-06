﻿namespace DocentematumCSharp
{
	partial class MenuAdministrator
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.CodigoProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuarioProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFindUser = new System.Windows.Forms.TextBox();
            this.tabCarrera = new System.Windows.Forms.TabPage();
            this.buttonBorrarCarrera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.comboDivision = new System.Windows.Forms.ComboBox();
            this.buttonLimpiarCarrera = new System.Windows.Forms.Button();
            this.buttonGuardarCarrera = new System.Windows.Forms.Button();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.idCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabDivision = new System.Windows.Forms.TabPage();
            this.buttonListarTodo = new System.Windows.Forms.Button();
            this.dgvDivisiones = new System.Windows.Forms.DataGridView();
            this.ClaveDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscarDivision = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNomDiv = new System.Windows.Forms.TextBox();
            this.textBoxFindDiv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxClaveDiv = new System.Windows.Forms.TextBox();
            this.buttonEliminarDivision = new System.Windows.Forms.Button();
            this.buttonAgregarDivision = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAlgo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPrincipal.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            this.tabDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivisiones)).BeginInit();
            this.tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabUsuario);
            this.tabPrincipal.Controls.Add(this.tabCarrera);
            this.tabPrincipal.Controls.Add(this.tabDivision);
            this.tabPrincipal.Controls.Add(this.tabInicio);
            this.tabPrincipal.Location = new System.Drawing.Point(188, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(598, 391);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.button2);
            this.tabUsuario.Controls.Add(this.button1);
            this.tabUsuario.Controls.Add(this.dgvUsuarios);
            this.tabUsuario.Controls.Add(this.buttonEliminarUsuario);
            this.tabUsuario.Controls.Add(this.buttonAgregarUsuario);
            this.tabUsuario.Controls.Add(this.label9);
            this.tabUsuario.Controls.Add(this.textBoxFindUser);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Size = new System.Drawing.Size(590, 365);
            this.tabUsuario.TabIndex = 5;
            this.tabUsuario.Text = "Usuarios";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(494, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Listar Todos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(266, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Buscar Código";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProfesor,
            this.nombreProfesor,
            this.apellidoPProfesor,
            this.apellidoMProfesor,
            this.usuarioProfesor,
            this.estadoProfesor,
            this.correoProfesor,
            this.tipoUsuarioProfesor});
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 80);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(544, 216);
            this.dgvUsuarios.TabIndex = 29;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // CodigoProfesor
            // 
            this.CodigoProfesor.HeaderText = "Código";
            this.CodigoProfesor.Name = "CodigoProfesor";
            this.CodigoProfesor.ReadOnly = true;
            this.CodigoProfesor.Width = 50;
            // 
            // nombreProfesor
            // 
            this.nombreProfesor.HeaderText = "Nombre";
            this.nombreProfesor.Name = "nombreProfesor";
            this.nombreProfesor.ReadOnly = true;
            // 
            // apellidoPProfesor
            // 
            this.apellidoPProfesor.HeaderText = "Apellido Paterno";
            this.apellidoPProfesor.Name = "apellidoPProfesor";
            this.apellidoPProfesor.ReadOnly = true;
            // 
            // apellidoMProfesor
            // 
            this.apellidoMProfesor.HeaderText = "Apellido Materno";
            this.apellidoMProfesor.Name = "apellidoMProfesor";
            this.apellidoMProfesor.ReadOnly = true;
            // 
            // usuarioProfesor
            // 
            this.usuarioProfesor.HeaderText = "Usuario";
            this.usuarioProfesor.Name = "usuarioProfesor";
            this.usuarioProfesor.ReadOnly = true;
            // 
            // estadoProfesor
            // 
            this.estadoProfesor.HeaderText = "Estado";
            this.estadoProfesor.Name = "estadoProfesor";
            this.estadoProfesor.ReadOnly = true;
            // 
            // correoProfesor
            // 
            this.correoProfesor.HeaderText = "Correo";
            this.correoProfesor.Name = "correoProfesor";
            this.correoProfesor.ReadOnly = true;
            // 
            // tipoUsuarioProfesor
            // 
            this.tipoUsuarioProfesor.HeaderText = "Tipo Usuario";
            this.tipoUsuarioProfesor.Name = "tipoUsuarioProfesor";
            this.tipoUsuarioProfesor.ReadOnly = true;
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(504, 315);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarUsuario.TabIndex = 28;
            this.buttonEliminarUsuario.Text = "Eliminar";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(413, 315);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarUsuario.TabIndex = 27;
            this.buttonAgregarUsuario.Text = "Agregar";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = false;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Buscar: ";
            // 
            // textBoxFindUser
            // 
            this.textBoxFindUser.Location = new System.Drawing.Point(63, 26);
            this.textBoxFindUser.Name = "textBoxFindUser";
            this.textBoxFindUser.Size = new System.Drawing.Size(184, 20);
            this.textBoxFindUser.TabIndex = 25;
            // 
            // tabCarrera
            // 
            this.tabCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabCarrera.Controls.Add(this.buttonBorrarCarrera);
            this.tabCarrera.Controls.Add(this.label4);
            this.tabCarrera.Controls.Add(this.comboNivel);
            this.tabCarrera.Controls.Add(this.comboDivision);
            this.tabCarrera.Controls.Add(this.buttonLimpiarCarrera);
            this.tabCarrera.Controls.Add(this.buttonGuardarCarrera);
            this.tabCarrera.Controls.Add(this.dgvCarrera);
            this.tabCarrera.Controls.Add(this.label3);
            this.tabCarrera.Controls.Add(this.textBox2);
            this.tabCarrera.Controls.Add(this.label2);
            this.tabCarrera.Controls.Add(this.label1);
            this.tabCarrera.Controls.Add(this.Usuario);
            this.tabCarrera.Controls.Add(this.textBox1);
            this.tabCarrera.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tabCarrera.Location = new System.Drawing.Point(4, 22);
            this.tabCarrera.Name = "tabCarrera";
            this.tabCarrera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarrera.Size = new System.Drawing.Size(590, 365);
            this.tabCarrera.TabIndex = 0;
            this.tabCarrera.Text = "Carrera";
            this.tabCarrera.UseVisualStyleBackColor = true;
            // 
            // buttonBorrarCarrera
            // 
            this.buttonBorrarCarrera.Location = new System.Drawing.Point(420, 176);
            this.buttonBorrarCarrera.Name = "buttonBorrarCarrera";
            this.buttonBorrarCarrera.Size = new System.Drawing.Size(136, 23);
            this.buttonBorrarCarrera.TabIndex = 56;
            this.buttonBorrarCarrera.Text = "Borrar Seleccionado";
            this.buttonBorrarCarrera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBorrarCarrera.UseVisualStyleBackColor = true;
            this.buttonBorrarCarrera.Click += new System.EventHandler(this.buttonBorrarCarrera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Carreras Añadidas:";
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Location = new System.Drawing.Point(187, 95);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(216, 21);
            this.comboNivel.TabIndex = 54;
            // 
            // comboDivision
            // 
            this.comboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDivision.FormattingEnabled = true;
            this.comboDivision.Location = new System.Drawing.Point(187, 122);
            this.comboDivision.Name = "comboDivision";
            this.comboDivision.Size = new System.Drawing.Size(216, 21);
            this.comboDivision.TabIndex = 53;
            this.comboDivision.SelectedIndexChanged += new System.EventHandler(this.comboDivision_SelectedIndexChanged);
            // 
            // buttonLimpiarCarrera
            // 
            this.buttonLimpiarCarrera.Location = new System.Drawing.Point(439, 77);
            this.buttonLimpiarCarrera.Name = "buttonLimpiarCarrera";
            this.buttonLimpiarCarrera.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiarCarrera.TabIndex = 45;
            this.buttonLimpiarCarrera.Text = "Limpiar";
            this.buttonLimpiarCarrera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimpiarCarrera.UseVisualStyleBackColor = true;
            this.buttonLimpiarCarrera.Click += new System.EventHandler(this.buttonLimpiarCarrera_Click);
            // 
            // buttonGuardarCarrera
            // 
            this.buttonGuardarCarrera.Location = new System.Drawing.Point(439, 41);
            this.buttonGuardarCarrera.Name = "buttonGuardarCarrera";
            this.buttonGuardarCarrera.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarCarrera.TabIndex = 44;
            this.buttonGuardarCarrera.Text = "Guardar";
            this.buttonGuardarCarrera.UseVisualStyleBackColor = true;
            this.buttonGuardarCarrera.Click += new System.EventHandler(this.buttonGuardarCarrera_Click);
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.AllowUserToAddRows = false;
            this.dgvCarrera.AllowUserToOrderColumns = true;
            this.dgvCarrera.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarrera,
            this.nombre,
            this.idDivision,
            this.idNivel});
            this.dgvCarrera.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCarrera.Location = new System.Drawing.Point(23, 205);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.ReadOnly = true;
            this.dgvCarrera.Size = new System.Drawing.Size(550, 150);
            this.dgvCarrera.TabIndex = 43;
            this.dgvCarrera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrera_CellClick);
            // 
            // idCarrera
            // 
            this.idCarrera.HeaderText = "Clave";
            this.idCarrera.Name = "idCarrera";
            this.idCarrera.ReadOnly = true;
            this.idCarrera.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MaxInputLength = 29;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 240;
            // 
            // idDivision
            // 
            this.idDivision.HeaderText = "Division";
            this.idDivision.Name = "idDivision";
            this.idDivision.ReadOnly = true;
            this.idDivision.Width = 128;
            // 
            // idNivel
            // 
            this.idNivel.HeaderText = "Nivel";
            this.idNivel.Name = "idNivel";
            this.idNivel.ReadOnly = true;
            this.idNivel.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tipo de Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "División";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(41, 40);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(45, 18);
            this.Usuario.TabIndex = 38;
            this.Usuario.Text = "Clave";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 41);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 35;
            // 
            // tabDivision
            // 
            this.tabDivision.Controls.Add(this.buttonListarTodo);
            this.tabDivision.Controls.Add(this.dgvDivisiones);
            this.tabDivision.Controls.Add(this.buttonBuscarDivision);
            this.tabDivision.Controls.Add(this.label10);
            this.tabDivision.Controls.Add(this.textBoxNomDiv);
            this.tabDivision.Controls.Add(this.textBoxFindDiv);
            this.tabDivision.Controls.Add(this.label7);
            this.tabDivision.Controls.Add(this.textBoxClaveDiv);
            this.tabDivision.Controls.Add(this.buttonEliminarDivision);
            this.tabDivision.Controls.Add(this.buttonAgregarDivision);
            this.tabDivision.Controls.Add(this.label8);
            this.tabDivision.Location = new System.Drawing.Point(4, 22);
            this.tabDivision.Name = "tabDivision";
            this.tabDivision.Padding = new System.Windows.Forms.Padding(3);
            this.tabDivision.Size = new System.Drawing.Size(590, 365);
            this.tabDivision.TabIndex = 4;
            this.tabDivision.Text = "Divisiones";
            this.tabDivision.UseVisualStyleBackColor = true;
            // 
            // buttonListarTodo
            // 
            this.buttonListarTodo.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonListarTodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonListarTodo.Location = new System.Drawing.Point(467, 67);
            this.buttonListarTodo.Name = "buttonListarTodo";
            this.buttonListarTodo.Size = new System.Drawing.Size(75, 23);
            this.buttonListarTodo.TabIndex = 31;
            this.buttonListarTodo.Text = "Listar Todo";
            this.buttonListarTodo.UseVisualStyleBackColor = false;
            this.buttonListarTodo.Click += new System.EventHandler(this.buttonListarTodo_Click);
            // 
            // dgvDivisiones
            // 
            this.dgvDivisiones.AllowUserToAddRows = false;
            this.dgvDivisiones.AllowUserToOrderColumns = true;
            this.dgvDivisiones.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dgvDivisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveDivision,
            this.NombreDivision});
            this.dgvDivisiones.Location = new System.Drawing.Point(46, 96);
            this.dgvDivisiones.Name = "dgvDivisiones";
            this.dgvDivisiones.ReadOnly = true;
            this.dgvDivisiones.Size = new System.Drawing.Size(496, 150);
            this.dgvDivisiones.TabIndex = 30;
            this.dgvDivisiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDivisiones_CellClick);
            // 
            // ClaveDivision
            // 
            this.ClaveDivision.FillWeight = 50F;
            this.ClaveDivision.HeaderText = "Clave";
            this.ClaveDivision.Name = "ClaveDivision";
            this.ClaveDivision.ReadOnly = true;
            this.ClaveDivision.Width = 50;
            // 
            // NombreDivision
            // 
            this.NombreDivision.FillWeight = 50F;
            this.NombreDivision.HeaderText = "Nombre";
            this.NombreDivision.Name = "NombreDivision";
            this.NombreDivision.ReadOnly = true;
            this.NombreDivision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NombreDivision.Width = 150;
            // 
            // buttonBuscarDivision
            // 
            this.buttonBuscarDivision.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonBuscarDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscarDivision.Location = new System.Drawing.Point(467, 35);
            this.buttonBuscarDivision.Name = "buttonBuscarDivision";
            this.buttonBuscarDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarDivision.TabIndex = 29;
            this.buttonBuscarDivision.Text = "Buscar";
            this.buttonBuscarDivision.UseVisualStyleBackColor = false;
            this.buttonBuscarDivision.Click += new System.EventHandler(this.buttonBuscarDivision_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Nombre";
            // 
            // textBoxNomDiv
            // 
            this.textBoxNomDiv.Location = new System.Drawing.Point(368, 290);
            this.textBoxNomDiv.Name = "textBoxNomDiv";
            this.textBoxNomDiv.Size = new System.Drawing.Size(174, 20);
            this.textBoxNomDiv.TabIndex = 27;
            // 
            // textBoxFindDiv
            // 
            this.textBoxFindDiv.Location = new System.Drawing.Point(102, 40);
            this.textBoxFindDiv.Name = "textBoxFindDiv";
            this.textBoxFindDiv.Size = new System.Drawing.Size(281, 20);
            this.textBoxFindDiv.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Buscar: ";
            // 
            // textBoxClaveDiv
            // 
            this.textBoxClaveDiv.Location = new System.Drawing.Point(80, 290);
            this.textBoxClaveDiv.MaxLength = 5;
            this.textBoxClaveDiv.Name = "textBoxClaveDiv";
            this.textBoxClaveDiv.Size = new System.Drawing.Size(174, 20);
            this.textBoxClaveDiv.TabIndex = 24;
            // 
            // buttonEliminarDivision
            // 
            this.buttonEliminarDivision.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEliminarDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarDivision.Location = new System.Drawing.Point(439, 328);
            this.buttonEliminarDivision.Name = "buttonEliminarDivision";
            this.buttonEliminarDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarDivision.TabIndex = 22;
            this.buttonEliminarDivision.Text = "Eliminar";
            this.buttonEliminarDivision.UseVisualStyleBackColor = false;
            this.buttonEliminarDivision.Click += new System.EventHandler(this.buttonEliminarDivision_Click);
            // 
            // buttonAgregarDivision
            // 
            this.buttonAgregarDivision.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonAgregarDivision.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregarDivision.Location = new System.Drawing.Point(346, 328);
            this.buttonAgregarDivision.Name = "buttonAgregarDivision";
            this.buttonAgregarDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarDivision.TabIndex = 21;
            this.buttonAgregarDivision.Text = "Agregar";
            this.buttonAgregarDivision.UseVisualStyleBackColor = false;
            this.buttonAgregarDivision.Click += new System.EventHandler(this.buttonAgregarDivision_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Clave";
            // 
            // tabInicio
            // 
            this.tabInicio.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
            this.tabInicio.Controls.Add(this.label6);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(590, 365);
            this.tabInicio.TabIndex = 3;
            this.tabInicio.Text = "Ayuda";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(33, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Consulta el manual técnico del programa";
            // 
            // labelAlgo
            // 
            this.labelAlgo.AutoSize = true;
            this.labelAlgo.BackColor = System.Drawing.Color.Transparent;
            this.labelAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgo.ForeColor = System.Drawing.Color.White;
            this.labelAlgo.Location = new System.Drawing.Point(25, 212);
            this.labelAlgo.Name = "labelAlgo";
            this.labelAlgo.Size = new System.Drawing.Size(66, 18);
            this.labelAlgo.TabIndex = 44;
            this.labelAlgo.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Código: ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNombre.Location = new System.Drawing.Point(25, 235);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(45, 18);
            this.labelNombre.TabIndex = 46;
            this.labelNombre.Text = "Algo2";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelCodigo.Location = new System.Drawing.Point(25, 178);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(37, 18);
            this.labelCodigo.TabIndex = 47;
            this.labelCodigo.Text = "Algo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DocentematumCSharp.Properties.Resources.administrator;
            this.pictureBox2.Location = new System.Drawing.Point(35, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // MenuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
            this.ClientSize = new System.Drawing.Size(796, 421);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAlgo);
            this.Name = "MenuAdministrator";
            this.Text = "Menú Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuAdministrator_FormClosing);
            this.tabPrincipal.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabCarrera.ResumeLayout(false);
            this.tabCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            this.tabDivision.ResumeLayout(false);
            this.tabDivision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivisiones)).EndInit();
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabCarrera;
		private System.Windows.Forms.DataGridView dgvCarrera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Usuario;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelAlgo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelCodigo;
		private System.Windows.Forms.TabPage tabInicio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonLimpiarCarrera;
		private System.Windows.Forms.Button buttonGuardarCarrera;
		private System.Windows.Forms.ComboBox comboDivision;
		private System.Windows.Forms.ComboBox comboNivel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonBorrarCarrera;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCarrera;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDivision;
		private System.Windows.Forms.DataGridViewTextBoxColumn idNivel;
		private System.Windows.Forms.TabPage tabDivision;
		private System.Windows.Forms.TextBox textBoxFindDiv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxClaveDiv;
		private System.Windows.Forms.Button buttonEliminarDivision;
		private System.Windows.Forms.Button buttonAgregarDivision;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabUsuario;
		private System.Windows.Forms.Button buttonEliminarUsuario;
		private System.Windows.Forms.Button buttonAgregarUsuario;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxFindUser;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxNomDiv;
		private System.Windows.Forms.Button buttonBuscarDivision;
		private System.Windows.Forms.DataGridView dgvDivisiones;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDivision;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreDivision;
		private System.Windows.Forms.Button buttonListarTodo;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuarioProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn estadoProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn correoProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioProfesor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}