namespace Desafio5_Ejercicio3
{
	partial class Form1
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
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicacion = new System.Windows.Forms.Button();
			this.btnDivision = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblPrimerNumero = new System.Windows.Forms.Label();
			this.lblSegundoNumero = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.outputResultado = new System.Windows.Forms.TextBox();
			this.inputPrimerNumero = new System.Windows.Forms.NumericUpDown();
			this.inputSegundoNumero = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.inputPrimerNumero)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inputSegundoNumero)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSuma
			// 
			this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.Location = new System.Drawing.Point(347, 198);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 37);
			this.btnSuma.TabIndex = 0;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
			// 
			// btnResta
			// 
			this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.Location = new System.Drawing.Point(428, 198);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 39);
			this.btnResta.TabIndex = 1;
			this.btnResta.Text = "-";
			this.btnResta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
			// 
			// btnMultiplicacion
			// 
			this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicacion.Location = new System.Drawing.Point(428, 241);
			this.btnMultiplicacion.Name = "btnMultiplicacion";
			this.btnMultiplicacion.Size = new System.Drawing.Size(75, 37);
			this.btnMultiplicacion.TabIndex = 2;
			this.btnMultiplicacion.Text = "*";
			this.btnMultiplicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMultiplicacion.UseVisualStyleBackColor = true;
			this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
			// 
			// btnDivision
			// 
			this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivision.Location = new System.Drawing.Point(347, 241);
			this.btnDivision.Name = "btnDivision";
			this.btnDivision.Size = new System.Drawing.Size(75, 37);
			this.btnDivision.TabIndex = 3;
			this.btnDivision.Text = "/";
			this.btnDivision.UseVisualStyleBackColor = true;
			this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Red;
			this.lblTitulo.Location = new System.Drawing.Point(310, 25);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(239, 25);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "Calculadora Andreani";
			// 
			// lblPrimerNumero
			// 
			this.lblPrimerNumero.AutoSize = true;
			this.lblPrimerNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrimerNumero.Location = new System.Drawing.Point(365, 76);
			this.lblPrimerNumero.Name = "lblPrimerNumero";
			this.lblPrimerNumero.Size = new System.Drawing.Size(107, 18);
			this.lblPrimerNumero.TabIndex = 5;
			this.lblPrimerNumero.Text = "Primer número";
			// 
			// lblSegundoNumero
			// 
			this.lblSegundoNumero.AutoSize = true;
			this.lblSegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSegundoNumero.Location = new System.Drawing.Point(365, 136);
			this.lblSegundoNumero.Name = "lblSegundoNumero";
			this.lblSegundoNumero.Size = new System.Drawing.Size(122, 18);
			this.lblSegundoNumero.TabIndex = 6;
			this.lblSegundoNumero.Text = "Segundo número";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.Location = new System.Drawing.Point(378, 290);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(94, 24);
			this.lblResultado.TabIndex = 7;
			this.lblResultado.Text = "Resultado";
			// 
			// outputResultado
			// 
			this.outputResultado.BackColor = System.Drawing.Color.White;
			this.outputResultado.Enabled = false;
			this.outputResultado.Location = new System.Drawing.Point(347, 317);
			this.outputResultado.Name = "outputResultado";
			this.outputResultado.Size = new System.Drawing.Size(156, 20);
			this.outputResultado.TabIndex = 10;
			// 
			// inputPrimerNumero
			// 
			this.inputPrimerNumero.Location = new System.Drawing.Point(352, 97);
			this.inputPrimerNumero.Name = "inputPrimerNumero";
			this.inputPrimerNumero.Size = new System.Drawing.Size(151, 20);
			this.inputPrimerNumero.TabIndex = 11;
			this.inputPrimerNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// inputSegundoNumero
			// 
			this.inputSegundoNumero.Location = new System.Drawing.Point(352, 157);
			this.inputSegundoNumero.Name = "inputSegundoNumero";
			this.inputSegundoNumero.Size = new System.Drawing.Size(151, 20);
			this.inputSegundoNumero.TabIndex = 12;
			this.inputSegundoNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inputSegundoNumero);
			this.Controls.Add(this.inputPrimerNumero);
			this.Controls.Add(this.outputResultado);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblSegundoNumero);
			this.Controls.Add(this.lblPrimerNumero);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnDivision);
			this.Controls.Add(this.btnMultiplicacion);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.inputPrimerNumero)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inputSegundoNumero)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnMultiplicacion;
		private System.Windows.Forms.Button btnDivision;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblPrimerNumero;
		private System.Windows.Forms.Label lblSegundoNumero;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox outputResultado;
		private System.Windows.Forms.NumericUpDown inputPrimerNumero;
		private System.Windows.Forms.NumericUpDown inputSegundoNumero;
	}
}

