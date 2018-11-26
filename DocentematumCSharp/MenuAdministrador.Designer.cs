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
			this.tabGrado = new System.Windows.Forms.TabPage();
			this.tabProduccion = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Usuario = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.dgvCarrera = new System.Windows.Forms.DataGridView();
			this.tabPrincipal.SuspendLayout();
			this.tabCarrera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPrincipal
			// 
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
			this.tabCarrera.Location = new System.Drawing.Point(4, 22);
			this.tabCarrera.Name = "tabCarrera";
			this.tabCarrera.Padding = new System.Windows.Forms.Padding(3);
			this.tabCarrera.Size = new System.Drawing.Size(577, 406);
			this.tabCarrera.TabIndex = 0;
			this.tabCarrera.Text = "Carrera";
			this.tabCarrera.UseVisualStyleBackColor = true;
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
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
			this.pictureBox1.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.pictureBox1.Location = new System.Drawing.Point(200, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(649, 37);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(199, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 38);
			this.button1.TabIndex = 2;
			this.button1.Text = "Carreras";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(332, 10);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 38);
			this.button2.TabIndex = 3;
			this.button2.Text = "Grados";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(465, 10);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 38);
			this.button3.TabIndex = 4;
			this.button3.Text = "Producciones";
			this.button3.UseVisualStyleBackColor = true;
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
			// dgvCarrera
			// 
			this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrera.Location = new System.Drawing.Point(42, 235);
			this.dgvCarrera.Name = "dgvCarrera";
			this.dgvCarrera.Size = new System.Drawing.Size(489, 150);
			this.dgvCarrera.TabIndex = 43;
			// 
			// MenuAdministrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Brown;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(789, 460);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tabPrincipal);
			this.Name = "MenuAdministrator";
			this.Text = "Registro de Usuarios";
			this.tabPrincipal.ResumeLayout(false);
			this.tabCarrera.ResumeLayout(false);
			this.tabCarrera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabCarrera;
		private System.Windows.Forms.TabPage tabGrado;
		private System.Windows.Forms.TabPage tabProduccion;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dgvCarrera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Usuario;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}