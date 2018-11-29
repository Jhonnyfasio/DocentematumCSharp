namespace DocentematumCSharp
{
	partial class VistaProduccion
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
			this.dgvProduccion = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.labelProduccion = new System.Windows.Forms.Label();
			this.IDProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colaboradorProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.propositoProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProduccion
			// 
			this.dgvProduccion.AllowUserToAddRows = false;
			this.dgvProduccion.AllowUserToOrderColumns = true;
			this.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduccion,
            this.numeroRegistro,
            this.colaboradorProduccion,
            this.propositoProduccion,
            this.tipoProduccion,
            this.fechaProduccion,
            this.statusProduccion});
			this.dgvProduccion.Location = new System.Drawing.Point(12, 72);
			this.dgvProduccion.Name = "dgvProduccion";
			this.dgvProduccion.ReadOnly = true;
			this.dgvProduccion.Size = new System.Drawing.Size(776, 317);
			this.dgvProduccion.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 26);
			this.label1.TabIndex = 22;
			this.label1.Text = "Producción :";
			// 
			// labelProduccion
			// 
			this.labelProduccion.AutoSize = true;
			this.labelProduccion.BackColor = System.Drawing.Color.Transparent;
			this.labelProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProduccion.ForeColor = System.Drawing.Color.White;
			this.labelProduccion.Location = new System.Drawing.Point(165, 26);
			this.labelProduccion.Name = "labelProduccion";
			this.labelProduccion.Size = new System.Drawing.Size(84, 18);
			this.labelProduccion.TabIndex = 61;
			this.labelProduccion.Text = "Producción";
			// 
			// IDProduccion
			// 
			this.IDProduccion.HeaderText = "ID";
			this.IDProduccion.Name = "IDProduccion";
			this.IDProduccion.ReadOnly = true;
			this.IDProduccion.Width = 50;
			// 
			// numeroRegistro
			// 
			this.numeroRegistro.HeaderText = "Registro #";
			this.numeroRegistro.Name = "numeroRegistro";
			this.numeroRegistro.ReadOnly = true;
			this.numeroRegistro.Width = 70;
			// 
			// colaboradorProduccion
			// 
			this.colaboradorProduccion.HeaderText = "Colaboradores";
			this.colaboradorProduccion.Name = "colaboradorProduccion";
			this.colaboradorProduccion.ReadOnly = true;
			this.colaboradorProduccion.Width = 150;
			// 
			// propositoProduccion
			// 
			this.propositoProduccion.HeaderText = "Propósito";
			this.propositoProduccion.Name = "propositoProduccion";
			this.propositoProduccion.ReadOnly = true;
			// 
			// tipoProduccion
			// 
			this.tipoProduccion.HeaderText = "Tipo";
			this.tipoProduccion.Name = "tipoProduccion";
			this.tipoProduccion.ReadOnly = true;
			// 
			// fechaProduccion
			// 
			this.fechaProduccion.HeaderText = "Fecha Inicio";
			this.fechaProduccion.Name = "fechaProduccion";
			this.fechaProduccion.ReadOnly = true;
			this.fechaProduccion.Width = 90;
			// 
			// statusProduccion
			// 
			this.statusProduccion.HeaderText = "Status";
			this.statusProduccion.Name = "statusProduccion";
			this.statusProduccion.ReadOnly = true;
			// 
			// VistaProduccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::DocentematumCSharp.Properties.Resources.BackGround_Blue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelProduccion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProduccion);
			this.Name = "VistaProduccion";
			this.Text = "VistaProduccion";
			((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduccion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroRegistro;
		private System.Windows.Forms.DataGridViewTextBoxColumn colaboradorProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn propositoProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaProduccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusProduccion;
	}
}