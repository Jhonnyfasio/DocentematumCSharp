namespace DocentematumCSharp
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
			this.tabCarrera = new System.Windows.Forms.TabPage();
			this.dgvCarrera = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Usuario = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabGrado = new System.Windows.Forms.TabPage();
			this.tabProduccion = new System.Windows.Forms.TabPage();
			this.labelAlgo = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelCodigo = new System.Windows.Forms.Label();
			this.tabInicio = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonCarrera = new System.Windows.Forms.Button();
			this.buttonGrado = new System.Windows.Forms.Button();
			this.buttonProduccion = new System.Windows.Forms.Button();
			this.buttonInicio = new System.Windows.Forms.Button();
			this.idCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPrincipal.SuspendLayout();
			this.tabCarrera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPrincipal
			// 
			this.tabPrincipal.Controls.Add(this.tabInicio);
			this.tabPrincipal.Controls.Add(this.tabCarrera);
			this.tabPrincipal.Controls.Add(this.tabGrado);
			this.tabPrincipal.Controls.Add(this.tabProduccion);
			this.tabPrincipal.Location = new System.Drawing.Point(201, 26);
			this.tabPrincipal.Name = "tabPrincipal";
			this.tabPrincipal.SelectedIndex = 0;
			this.tabPrincipal.Size = new System.Drawing.Size(585, 432);
			this.tabPrincipal.TabIndex = 0;
			// 
			// tabCarrera
			// 
			this.tabCarrera.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.tabCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabCarrera.Controls.Add(this.dgvCarrera);
			this.tabCarrera.Controls.Add(this.label3);
			this.tabCarrera.Controls.Add(this.textBox4);
			this.tabCarrera.Controls.Add(this.label2);
			this.tabCarrera.Controls.Add(this.label1);
			this.tabCarrera.Controls.Add(this.Usuario);
			this.tabCarrera.Controls.Add(this.textBox3);
			this.tabCarrera.Controls.Add(this.textBox2);
			this.tabCarrera.Controls.Add(this.textBox1);
			this.tabCarrera.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tabCarrera.Location = new System.Drawing.Point(4, 22);
			this.tabCarrera.Name = "tabCarrera";
			this.tabCarrera.Padding = new System.Windows.Forms.Padding(3);
			this.tabCarrera.Size = new System.Drawing.Size(577, 406);
			this.tabCarrera.TabIndex = 0;
			this.tabCarrera.Text = "Carrera";
			this.tabCarrera.UseVisualStyleBackColor = true;
			// 
			// dgvCarrera
			// 
			this.dgvCarrera.AllowUserToAddRows = false;
			this.dgvCarrera.AllowUserToDeleteRows = false;
			this.dgvCarrera.AllowUserToOrderColumns = true;
			this.dgvCarrera.BackgroundColor = System.Drawing.SystemColors.WindowText;
			this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarrera,
            this.nombre,
            this.idDivision,
            this.idNivel});
			this.dgvCarrera.GridColor = System.Drawing.SystemColors.ButtonShadow;
			this.dgvCarrera.Location = new System.Drawing.Point(21, 235);
			this.dgvCarrera.Name = "dgvCarrera";
			this.dgvCarrera.ReadOnly = true;
			this.dgvCarrera.Size = new System.Drawing.Size(535, 150);
			this.dgvCarrera.TabIndex = 43;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(39, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 42;
			this.label3.Text = "Nombre";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(187, 181);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(216, 20);
			this.textBox4.TabIndex = 41;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(39, 136);
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
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(39, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 18);
			this.label1.TabIndex = 39;
			this.label1.Text = "ID División";
			// 
			// Usuario
			// 
			this.Usuario.AutoSize = true;
			this.Usuario.BackColor = System.Drawing.Color.Transparent;
			this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Usuario.ForeColor = System.Drawing.Color.White;
			this.Usuario.Location = new System.Drawing.Point(39, 50);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(76, 18);
			this.Usuario.TabIndex = 38;
			this.Usuario.Text = "ID Carrera";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(187, 137);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(216, 20);
			this.textBox3.TabIndex = 37;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(187, 95);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 20);
			this.textBox2.TabIndex = 36;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(187, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 20);
			this.textBox1.TabIndex = 35;
			// 
			// tabGrado
			// 
			this.tabGrado.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.tabGrado.Location = new System.Drawing.Point(4, 22);
			this.tabGrado.Name = "tabGrado";
			this.tabGrado.Padding = new System.Windows.Forms.Padding(3);
			this.tabGrado.Size = new System.Drawing.Size(577, 406);
			this.tabGrado.TabIndex = 1;
			this.tabGrado.Text = "Grado";
			this.tabGrado.UseVisualStyleBackColor = true;
			// 
			// tabProduccion
			// 
			this.tabProduccion.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.tabProduccion.Location = new System.Drawing.Point(4, 22);
			this.tabProduccion.Name = "tabProduccion";
			this.tabProduccion.Size = new System.Drawing.Size(577, 406);
			this.tabProduccion.TabIndex = 2;
			this.tabProduccion.Text = "Producción";
			this.tabProduccion.UseVisualStyleBackColor = true;
			// 
			// labelAlgo
			// 
			this.labelAlgo.AutoSize = true;
			this.labelAlgo.BackColor = System.Drawing.Color.Transparent;
			this.labelAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAlgo.ForeColor = System.Drawing.Color.White;
			this.labelAlgo.Location = new System.Drawing.Point(6, 128);
			this.labelAlgo.Name = "labelAlgo";
			this.labelAlgo.Size = new System.Drawing.Size(190, 18);
			this.labelAlgo.TabIndex = 44;
			this.labelAlgo.Text = "Nombre: _______________";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(6, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 18);
			this.label5.TabIndex = 45;
			this.label5.Text = "Código: ________________";
			// 
			// labelNombre
			// 
			this.labelNombre.AutoSize = true;
			this.labelNombre.BackColor = System.Drawing.Color.Transparent;
			this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.ForeColor = System.Drawing.SystemColors.Window;
			this.labelNombre.Location = new System.Drawing.Point(70, 125);
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
			this.labelCodigo.Location = new System.Drawing.Point(71, 159);
			this.labelCodigo.Name = "labelCodigo";
			this.labelCodigo.Size = new System.Drawing.Size(37, 18);
			this.labelCodigo.TabIndex = 47;
			this.labelCodigo.Text = "Algo";
			// 
			// tabInicio
			// 
			this.tabInicio.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.tabInicio.Location = new System.Drawing.Point(4, 22);
			this.tabInicio.Name = "tabInicio";
			this.tabInicio.Size = new System.Drawing.Size(577, 406);
			this.tabInicio.TabIndex = 3;
			this.tabInicio.Text = "tabInicio";
			this.tabInicio.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
			this.pictureBox1.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.pictureBox1.Location = new System.Drawing.Point(200, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(649, 37);
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			// 
			// buttonCarrera
			// 
			this.buttonCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCarrera.Location = new System.Drawing.Point(333, 8);
			this.buttonCarrera.Name = "buttonCarrera";
			this.buttonCarrera.Size = new System.Drawing.Size(133, 38);
			this.buttonCarrera.TabIndex = 49;
			this.buttonCarrera.Text = "Carreras";
			this.buttonCarrera.UseVisualStyleBackColor = true;
			this.buttonCarrera.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// buttonGrado
			// 
			this.buttonGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGrado.Location = new System.Drawing.Point(466, 8);
			this.buttonGrado.Name = "buttonGrado";
			this.buttonGrado.Size = new System.Drawing.Size(133, 38);
			this.buttonGrado.TabIndex = 50;
			this.buttonGrado.Text = "Grados";
			this.buttonGrado.UseVisualStyleBackColor = true;
			this.buttonGrado.Click += new System.EventHandler(this.buttonGrado_Click);
			// 
			// buttonProduccion
			// 
			this.buttonProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProduccion.Location = new System.Drawing.Point(599, 8);
			this.buttonProduccion.Name = "buttonProduccion";
			this.buttonProduccion.Size = new System.Drawing.Size(134, 38);
			this.buttonProduccion.TabIndex = 51;
			this.buttonProduccion.Text = "Producciones";
			this.buttonProduccion.UseVisualStyleBackColor = true;
			this.buttonProduccion.Click += new System.EventHandler(this.buttonProduccion_Click);
			// 
			// buttonInicio
			// 
			this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInicio.Location = new System.Drawing.Point(200, 8);
			this.buttonInicio.Name = "buttonInicio";
			this.buttonInicio.Size = new System.Drawing.Size(133, 38);
			this.buttonInicio.TabIndex = 52;
			this.buttonInicio.Text = "Inicio";
			this.buttonInicio.UseVisualStyleBackColor = true;
			this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
			// 
			// idCarrera
			// 
			this.idCarrera.HeaderText = "ID";
			this.idCarrera.Name = "idCarrera";
			this.idCarrera.ReadOnly = true;
			this.idCarrera.Width = 50;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			this.nombre.Width = 240;
			// 
			// idDivision
			// 
			this.idDivision.HeaderText = "Division";
			this.idDivision.Name = "idDivision";
			this.idDivision.ReadOnly = true;
			this.idDivision.Width = 50;
			// 
			// idNivel
			// 
			this.idNivel.HeaderText = "Nivel";
			this.idNivel.Name = "idNivel";
			this.idNivel.ReadOnly = true;
			this.idNivel.Width = 150;
			// 
			// MenuAdministrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Brown;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(789, 460);
			this.Controls.Add(this.labelCodigo);
			this.Controls.Add(this.labelNombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelAlgo);
			this.Controls.Add(this.tabPrincipal);
			this.Controls.Add(this.buttonProduccion);
			this.Controls.Add(this.buttonGrado);
			this.Controls.Add(this.buttonCarrera);
			this.Controls.Add(this.buttonInicio);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MenuAdministrator";
			this.Text = "Registro de Usuarios";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuAdministrator_FormClosing);
			this.tabPrincipal.ResumeLayout(false);
			this.tabCarrera.ResumeLayout(false);
			this.tabCarrera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabCarrera;
		private System.Windows.Forms.TabPage tabGrado;
		private System.Windows.Forms.TabPage tabProduccion;
		private System.Windows.Forms.DataGridView dgvCarrera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Usuario;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label labelAlgo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelCodigo;
		private System.Windows.Forms.TabPage tabInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonCarrera;
		private System.Windows.Forms.Button buttonGrado;
		private System.Windows.Forms.Button buttonProduccion;
		private System.Windows.Forms.Button buttonInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCarrera;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDivision;
		private System.Windows.Forms.DataGridViewTextBoxColumn idNivel;
	}
}