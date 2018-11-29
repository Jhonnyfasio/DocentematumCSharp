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
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageProduccionesUsuarioEspecial = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.buttonVerProduccion = new System.Windows.Forms.Button();
			this.buttonRechazar = new System.Windows.Forms.Button();
			this.buttonAprobar = new System.Windows.Forms.Button();
			this.labelNombreUsuarioEspecial = new System.Windows.Forms.Label();
			this.buttonEditarPerfil = new System.Windows.Forms.Button();
			this.labelCodigoUsuarioEspecial = new System.Windows.Forms.Label();
			this.tabControlUsuarioEspecial = new System.Windows.Forms.TabControl();
			this.tabPageProduccionesUsuarioEspecial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabControlUsuarioEspecial.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCrearProfesor
			// 
			this.buttonCrearProfesor.BackColor = System.Drawing.Color.DarkSlateGray;
			this.buttonCrearProfesor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonCrearProfesor.Location = new System.Drawing.Point(19, 340);
			this.buttonCrearProfesor.Name = "buttonCrearProfesor";
			this.buttonCrearProfesor.Size = new System.Drawing.Size(99, 23);
			this.buttonCrearProfesor.TabIndex = 63;
			this.buttonCrearProfesor.Text = "Crear Profesor";
			this.buttonCrearProfesor.UseVisualStyleBackColor = false;
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
			// tabPageProduccionesUsuarioEspecial
			// 
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.dataGridView3);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.label4);
			this.tabPageProduccionesUsuarioEspecial.Controls.Add(this.textBox7);
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
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduccion,
            this.Tipo,
            this.Titulo,
            this.FechaInicio,
            this.Status});
			this.dataGridView3.Location = new System.Drawing.Point(9, 74);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(543, 169);
			this.dataGridView3.TabIndex = 20;
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
			// 
			// labelNombreUsuarioEspecial
			// 
			this.labelNombreUsuarioEspecial.AutoSize = true;
			this.labelNombreUsuarioEspecial.BackColor = System.Drawing.Color.Transparent;
			this.labelNombreUsuarioEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreUsuarioEspecial.ForeColor = System.Drawing.Color.White;
			this.labelNombreUsuarioEspecial.Location = new System.Drawing.Point(16, 100);
			this.labelNombreUsuarioEspecial.Name = "labelNombreUsuarioEspecial";
			this.labelNombreUsuarioEspecial.Size = new System.Drawing.Size(62, 18);
			this.labelNombreUsuarioEspecial.TabIndex = 59;
			this.labelNombreUsuarioEspecial.Text = "Nombre";
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
			// labelCodigoUsuarioEspecial
			// 
			this.labelCodigoUsuarioEspecial.AutoSize = true;
			this.labelCodigoUsuarioEspecial.BackColor = System.Drawing.Color.Transparent;
			this.labelCodigoUsuarioEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCodigoUsuarioEspecial.ForeColor = System.Drawing.Color.White;
			this.labelCodigoUsuarioEspecial.Location = new System.Drawing.Point(16, 41);
			this.labelCodigoUsuarioEspecial.Name = "labelCodigoUsuarioEspecial";
			this.labelCodigoUsuarioEspecial.Size = new System.Drawing.Size(56, 18);
			this.labelCodigoUsuarioEspecial.TabIndex = 60;
			this.labelCodigoUsuarioEspecial.Text = "Código";
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
			// MenuEspecialUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCrearProfesor);
			this.Controls.Add(this.labelNombreUsuarioEspecial);
			this.Controls.Add(this.buttonEditarPerfil);
			this.Controls.Add(this.labelCodigoUsuarioEspecial);
			this.Controls.Add(this.tabControlUsuarioEspecial);
			this.Name = "MenuEspecialUsuario";
			this.Text = "MenuEspecialUsuario";
			this.tabPageProduccionesUsuarioEspecial.ResumeLayout(false);
			this.tabPageProduccionesUsuarioEspecial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabControlUsuarioEspecial.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCrearProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDProduccion;
		private System.Windows.Forms.TabPage tabPageProduccionesUsuarioEspecial;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button buttonVerProduccion;
		private System.Windows.Forms.Button buttonRechazar;
		private System.Windows.Forms.Button buttonAprobar;
		private System.Windows.Forms.Label labelNombreUsuarioEspecial;
		private System.Windows.Forms.Button buttonEditarPerfil;
		private System.Windows.Forms.Label labelCodigoUsuarioEspecial;
		private System.Windows.Forms.TabControl tabControlUsuarioEspecial;
	}
}