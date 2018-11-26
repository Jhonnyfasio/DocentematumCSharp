namespace DocentematumCSharp
{
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.usuarioTextBox = new System.Windows.Forms.TextBox();
			this.contrasenaTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Usuario = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// usuarioTextBox
			// 
			this.usuarioTextBox.Location = new System.Drawing.Point(108, 138);
			this.usuarioTextBox.Name = "usuarioTextBox";
			this.usuarioTextBox.Size = new System.Drawing.Size(154, 20);
			this.usuarioTextBox.TabIndex = 1;
			// 
			// contrasenaTextBox
			// 
			this.contrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contrasenaTextBox.Location = new System.Drawing.Point(108, 195);
			this.contrasenaTextBox.Name = "contrasenaTextBox";
			this.contrasenaTextBox.PasswordChar = '*';
			this.contrasenaTextBox.Size = new System.Drawing.Size(154, 20);
			this.contrasenaTextBox.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(118, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Iniciar Sesión";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Usuario
			// 
			this.Usuario.AutoSize = true;
			this.Usuario.BackColor = System.Drawing.Color.Transparent;
			this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Usuario.ForeColor = System.Drawing.Color.White;
			this.Usuario.Location = new System.Drawing.Point(10, 140);
			this.Usuario.Name = "Usuario";
			this.Usuario.Size = new System.Drawing.Size(60, 18);
			this.Usuario.TabIndex = 4;
			this.Usuario.Text = "Usuario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Contraseña";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::DocentematumCSharp.Properties.Resources.LoginIcon;
			this.pictureBox1.Location = new System.Drawing.Point(151, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(66, 78);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(352, 399);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Usuario);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.contrasenaTextBox);
			this.Controls.Add(this.usuarioTextBox);
			this.Name = "Login";
			this.Text = "Iniciar Sesión";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox usuarioTextBox;
		private System.Windows.Forms.TextBox contrasenaTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Usuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

