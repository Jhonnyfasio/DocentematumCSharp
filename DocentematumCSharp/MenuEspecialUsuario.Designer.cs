namespace DocentematumCSharp
{
	partial class MenuEspecialUsuario
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
			this.buttonCrearProfesor = new System.Windows.Forms.Button();
			this.tabPageProduccionesUsuarioEspecial = new System.Windows.Forms.TabPage();
			this.dgvProduccion = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxFindProd = new System.Windows.Forms.TextBox();
			this.buttonVerProduccion = new System.Windows.Forms.Button();
			this.buttonRechazar = new System.Windows.Forms.Button();
			this.buttonAprobar = new System.Windows.Forms.Button();
			this.labelNombre = new System.Windows.Forms.Label();
			this.buttonEditarPerfil = new System.Windows.Forms.Button();
			this.labelCodigo = new System.Windows.Forms.Label();
			this.tabControlUsuarioEspecial = new System.Windows.Forms.TabControl();
			this.IDProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tituloProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonBuscarProduccion = new System.Windows.Forms.Button();
			this.tabPageProduccionesUsuarioEspecial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
			this.tabControlUsuarioEspecial.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCrearProfesor
			// 
			this.buttonCrearProfesor.BackColor = System.Drawing.Color.DarkSlateGray;
			this.buttonCrearProfesor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonCrearProfesor.Location = new System.Drawing.Point(19, 322);
			this.buttonCrearProfesor.Name = "buttonCrearProfesor";
			this.buttonCrearProfesor.Size = new System.Drawing.Size(99, 23);
			this.buttonCrearProfesor.TabIndex = 63;
			this.buttonCrearProfesor.Text = "Crear Profesor";
			this.buttonCrearProfesor.UseVisualStyleBackColor = false;
			this.buttonCrearProfesor.Click += new System.EventHandler(this.buttonCrearProfesor_Click);
			// 
			// tabPageProduccionesUsuarioEspecial
			// 
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.buttonBuscarProduccion);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.dgvProduccion);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.label4);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.textBoxFindProd);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.buttonVerProduccion);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.buttonRechazar);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.buttonAprobar);
			this.tabPageProduccionesUsuarioEspecial.Location = new System.Drawing.Point(4, 22);
			this.tabPageProduccionesUsuarioEspecial.Name = "tabPageProduccionesUsuarioEspecial";
			this.tabPageProduccionesUsuarioEspecial.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProduccionesUsuarioEspecial.Size = new System.Drawing.Size(591, 343);
			this.tabPageProduccionesUsuarioEspecial.TabIndex = 2;
			this.tabPageProduccionesUsuarioEspecial.Text = "Administracion de Producciones";
			this.tabPageProduccionesUsuarioEspecial.UseVisualStyleBackColor = true;
			// 
			// dgvProduccion
			// 
			this.dgvProduccion.AllowUserToAddRows = false;
			this.dgvProduccion.AllowUserToOrderColumns = true;
			this.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduccion,
            this.tipoProduccion,
            this.tituloProduccion,
            this.fechaProduccion,
            this.statusProduccion});
			this.dgvProduccion.Location = new System.Drawing.Point(9, 74);
			this.dgvProduccion.Name = "dgvProduccion";
			this.dgvProduccion.ReadOnly = true;
			this.dgvProduccion.Size = new System.Drawing.Size(543, 169);
			this.dgvProduccion.TabIndex = 20;
			this.dgvProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduccion_CellClick);
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
			// textBoxFindProd
			// 
			this.textBoxFindProd.Location = new System.Drawing.Point(69, 23);
			this.textBoxFindProd.Name = "textBoxFindProd";
			this.textBoxFindProd.Size = new System.Drawing.Size(255, 20);
			this.textBoxFindProd.TabIndex = 17;
			// 
			// buttonVerProduccion
			// 
			this.buttonVerProduccion.BackColor = System.Drawing.Color.Olive;
			this.buttonVerProduccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonVerProduccion.Location = new System.Drawing.Point(411, 277);
			this.buttonVerProduccion.Name = "buttonVerProduccion";
			this.buttonVerProduccion.Size = new System.Drawing.Size(93, 23);
			this.buttonVerProduccion.TabIndex = 15;
			this.buttonVerProduccion.Text = "Ver Produccion";
			this.buttonVerProduccion.UseVisualStyleBackColor = false;
			this.buttonVerProduccion.Click += new System.EventHandler(this.buttonVerProduccion_Click);
			// 
			// buttonRechazar
			// 
			this.buttonRechazar.BackColor = System.Drawing.Color.DarkRed;
			this.buttonRechazar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonRechazar.Location = new System.Drawing.Point(510, 277);
			this.buttonRechazar.Name = "buttonRechazar";
			this.buttonRechazar.Size = new System.Drawing.Size(75, 23);
			this.buttonRechazar.TabIndex = 14;
			this.buttonRechazar.Text = "Rechazar";
			this.buttonRechazar.UseVisualStyleBackColor = false;
			// 
			// buttonAprobar
			// 
			this.buttonAprobar.BackColor = System.Drawing.Color.DarkGreen;
			this.buttonAprobar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonAprobar.Location = new System.Drawing.Point(330, 277);
			this.buttonAprobar.Name = "buttonAprobar";
			this.buttonAprobar.Size = new System.Drawing.Size(75, 23);
			this.buttonAprobar.TabIndex = 13;
			this.buttonAprobar.Text = "Aprobar";
			this.buttonAprobar.UseVisualStyleBackColor = false;
			this.buttonAprobar.Click += new System.EventHandler(this.buttonAprobar_Click);
			// 
			// labelNombre
			// 
			this.labelNombre.AutoSize = true;
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.Color.White;
			this.labelNombre.Location = new System.Drawing.Point(16, 100);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(62, 18);
			this.labelNombre.TabIndex = 59;
			this.labelNombre.Text = "Nombre";
			// 
			// buttonEditarPerfil
			// 
			this.buttonEditarPerfil.BackColor = System.Drawing.Color.Peru;
			this.buttonEditarPerfil.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonEditarPerfil.Location = new System.Drawing.Point(19, 383);
			this.buttonEditarPerfil.Name = "buttonEditarPerfil";
			this.buttonEditarPerfil.Size = new System.Drawing.Size(99, 23);
			this.buttonEditarPerfil.TabIndex = 62;
			this.buttonEditarPerfil.Text = "Editar Perfil";
			this.buttonEditarPerfil.UseVisualStyleBackColor = false;
			// 
			// labelCodigo
			// 
			this.labelCodigo.AutoSize = true;
			this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
			this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCodigo.ForeColor = System.Drawing.Color.White;
			this.labelCodigo.Location = new System.Drawing.Point(16, 41);
			this.labelCodigo.Name = "labelCodigo";
			this.labelCodigo.Size = new System.Drawing.Size(56, 18);
			this.labelCodigo.TabIndex = 60;
			this.labelCodigo.Text = "Código";
			// 
			// tabControlUsuarioEspecial
			// 
			this.tabControlUsuarioEspecial.Controls.Add(this.tabPageProduccionesUsuarioEspecial);
			this.tabControlUsuarioEspecial.Location = new System.Drawing.Point(185, 41);
			this.tabControlUsuarioEspecial.Name = "tabControlUsuarioEspecial";
			this.tabControlUsuarioEspecial.SelectedIndex = 0;
			this.tabControlUsuarioEspecial.Size = new System.Drawing.Size(599, 369);
			this.tabControlUsuarioEspecial.TabIndex = 61;
			// 
			// IDProduccion
			// 
			this.IDProduccion.HeaderText = "ID";
			this.IDProduccion.Name = "IDProduccion";
			// 
			// tipoProduccion
			// 
			this.tipoProduccion.HeaderText = "Tipo";
			this.tipoProduccion.Name = "tipoProduccion";
			// 
			// tituloProduccion
			// 
			this.tituloProduccion.HeaderText = "Titulo";
			this.tituloProduccion.Name = "tituloProduccion";
			// 
			// fechaProduccion
			// 
			this.fechaProduccion.HeaderText = "Fecha Inicio";
			this.fechaProduccion.Name = "fechaProduccion";
			// 
			// statusProduccion
			// 
			this.statusProduccion.HeaderText = "Status";
			this.statusProduccion.Name = "statusProduccion";
			// 
			// buttonBuscarProduccion
			// 
			this.buttonBuscarProduccion.BackColor = System.Drawing.Color.MediumBlue;
			this.buttonBuscarProduccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonBuscarProduccion.Location = new System.Drawing.Point(371, 21);
			this.buttonBuscarProduccion.Name = "buttonBuscarProduccion";
			this.buttonBuscarProduccion.Size = new System.Drawing.Size(75, 23);
			this.buttonBuscarProduccion.TabIndex = 21;
			this.buttonBuscarProduccion.Text = "Buscar ID";
			this.buttonBuscarProduccion.UseVisualStyleBackColor = false;
			this.buttonBuscarProduccion.Click += new System.EventHandler(this.buttonBuscarProduccion_Click);
			// 
			// MenuEspecialUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCrearProfesor);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.buttonEditarPerfil);
			this.Controls.Add(this.labelCodigo);
			this.Controls.Add(this.tabControlUsuarioEspecial);
			this.Name = "MenuEspecialUsuario";
			this.Text = "MenuEspecialUsuario";
			this.tabPageProduccionesUsuarioEspecial.ResumeLayout(false);
			this.tabPageProduccionesUsuarioEspecial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
			this.tabControlUsuarioEspecial.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCrearProfesor;
		private System.Windows.Forms.TabPage tabPageProduccionesUsuarioEspecial;
		private System.Windows.Forms.DataGridView dgvProduccion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxFindProd;
		private System.Windows.Forms.Button buttonVerProduccion;
		private System.Windows.Forms.Button buttonRechazar;
		private System.Windows.Forms.Button buttonAprobar;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Button buttonEditarPerfil;
		private System.Windows.Forms.Label labelCodigo;
		private System.Windows.Forms.TabControl tabControlUsuarioEspecial;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn tituloProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusProduccion;
		private System.Windows.Forms.Button buttonBuscarProduccion;
	}
}