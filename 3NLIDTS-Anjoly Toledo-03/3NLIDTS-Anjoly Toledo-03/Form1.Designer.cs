namespace _3NLIDTS_Anjoly_Toledo_03
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lbCelsius = new System.Windows.Forms.Label();
			this.lbFahrenheit = new System.Windows.Forms.Label();
			this.lbKelvin = new System.Windows.Forms.Label();
			this.txtbCelsius = new System.Windows.Forms.TextBox();
			this.txtbFahrenheit = new System.Windows.Forms.TextBox();
			this.txtbKelvin = new System.Windows.Forms.TextBox();
			this.btCancelar = new System.Windows.Forms.Button();
			this.btLimpiar = new System.Windows.Forms.Button();
			this.rbnCelsius = new System.Windows.Forms.RadioButton();
			this.rbnFahrenheit = new System.Windows.Forms.RadioButton();
			this.rbnKelvin = new System.Windows.Forms.RadioButton();
			this.gBxTemperatura = new System.Windows.Forms.GroupBox();
			this.gBxTemperatura.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbCelsius
			// 
			this.lbCelsius.AutoSize = true;
			this.lbCelsius.BackColor = System.Drawing.Color.Transparent;
			this.lbCelsius.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCelsius.Location = new System.Drawing.Point(89, 66);
			this.lbCelsius.Name = "lbCelsius";
			this.lbCelsius.Size = new System.Drawing.Size(97, 26);
			this.lbCelsius.TabIndex = 0;
			this.lbCelsius.Text = "Celsius";
			// 
			// lbFahrenheit
			// 
			this.lbFahrenheit.AutoSize = true;
			this.lbFahrenheit.BackColor = System.Drawing.Color.Transparent;
			this.lbFahrenheit.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFahrenheit.Location = new System.Drawing.Point(325, 66);
			this.lbFahrenheit.Name = "lbFahrenheit";
			this.lbFahrenheit.Size = new System.Drawing.Size(152, 26);
			this.lbFahrenheit.TabIndex = 1;
			this.lbFahrenheit.Text = "Fahrenheit";
			// 
			// lbKelvin
			// 
			this.lbKelvin.AutoSize = true;
			this.lbKelvin.BackColor = System.Drawing.Color.Transparent;
			this.lbKelvin.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbKelvin.Location = new System.Drawing.Point(605, 66);
			this.lbKelvin.Name = "lbKelvin";
			this.lbKelvin.Size = new System.Drawing.Size(90, 26);
			this.lbKelvin.TabIndex = 2;
			this.lbKelvin.Text = "Kelvin";
			this.lbKelvin.Click += new System.EventHandler(this.lbKelvin_Click);
			// 
			// txtbCelsius
			// 
			this.txtbCelsius.BackColor = System.Drawing.Color.Firebrick;
			this.txtbCelsius.ForeColor = System.Drawing.Color.White;
			this.txtbCelsius.Location = new System.Drawing.Point(86, 114);
			this.txtbCelsius.Name = "txtbCelsius";
			this.txtbCelsius.Size = new System.Drawing.Size(100, 22);
			this.txtbCelsius.TabIndex = 3;
			this.txtbCelsius.TextChanged += new System.EventHandler(this.txtbCelsius_TextChanged);
			// 
			// txtbFahrenheit
			// 
			this.txtbFahrenheit.BackColor = System.Drawing.Color.Firebrick;
			this.txtbFahrenheit.ForeColor = System.Drawing.Color.White;
			this.txtbFahrenheit.Location = new System.Drawing.Point(350, 114);
			this.txtbFahrenheit.Name = "txtbFahrenheit";
			this.txtbFahrenheit.Size = new System.Drawing.Size(100, 22);
			this.txtbFahrenheit.TabIndex = 4;
			this.txtbFahrenheit.TextChanged += new System.EventHandler(this.txtbFahrenheit_TextChanged);
			// 
			// txtbKelvin
			// 
			this.txtbKelvin.BackColor = System.Drawing.Color.Firebrick;
			this.txtbKelvin.ForeColor = System.Drawing.Color.White;
			this.txtbKelvin.Location = new System.Drawing.Point(595, 114);
			this.txtbKelvin.Name = "txtbKelvin";
			this.txtbKelvin.Size = new System.Drawing.Size(100, 22);
			this.txtbKelvin.TabIndex = 5;
			// 
			// btCancelar
			// 
			this.btCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btCancelar.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCancelar.Location = new System.Drawing.Point(206, 311);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(104, 40);
			this.btCancelar.TabIndex = 6;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = false;
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// btLimpiar
			// 
			this.btLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btLimpiar.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLimpiar.Location = new System.Drawing.Point(510, 311);
			this.btLimpiar.Name = "btLimpiar";
			this.btLimpiar.Size = new System.Drawing.Size(104, 40);
			this.btLimpiar.TabIndex = 7;
			this.btLimpiar.Text = "Limpiar";
			this.btLimpiar.UseVisualStyleBackColor = false;
			// 
			// rbnCelsius
			// 
			this.rbnCelsius.AutoSize = true;
			this.rbnCelsius.BackColor = System.Drawing.Color.Firebrick;
			this.rbnCelsius.ForeColor = System.Drawing.Color.White;
			this.rbnCelsius.Location = new System.Drawing.Point(6, 32);
			this.rbnCelsius.Name = "rbnCelsius";
			this.rbnCelsius.Size = new System.Drawing.Size(106, 26);
			this.rbnCelsius.TabIndex = 8;
			this.rbnCelsius.TabStop = true;
			this.rbnCelsius.Text = "Celsius";
			this.rbnCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbnCelsius.UseVisualStyleBackColor = false;
			// 
			// rbnFahrenheit
			// 
			this.rbnFahrenheit.AutoSize = true;
			this.rbnFahrenheit.BackColor = System.Drawing.Color.Firebrick;
			this.rbnFahrenheit.ForeColor = System.Drawing.Color.White;
			this.rbnFahrenheit.Location = new System.Drawing.Point(256, 32);
			this.rbnFahrenheit.Name = "rbnFahrenheit";
			this.rbnFahrenheit.Size = new System.Drawing.Size(154, 26);
			this.rbnFahrenheit.TabIndex = 9;
			this.rbnFahrenheit.TabStop = true;
			this.rbnFahrenheit.Text = "Fahrenheit";
			this.rbnFahrenheit.UseVisualStyleBackColor = false;
			// 
			// rbnKelvin
			// 
			this.rbnKelvin.AutoSize = true;
			this.rbnKelvin.BackColor = System.Drawing.Color.Firebrick;
			this.rbnKelvin.ForeColor = System.Drawing.Color.White;
			this.rbnKelvin.Location = new System.Drawing.Point(516, 32);
			this.rbnKelvin.Name = "rbnKelvin";
			this.rbnKelvin.Size = new System.Drawing.Size(100, 26);
			this.rbnKelvin.TabIndex = 10;
			this.rbnKelvin.TabStop = true;
			this.rbnKelvin.Text = "Kelvin";
			this.rbnKelvin.UseVisualStyleBackColor = false;
			// 
			// gBxTemperatura
			// 
			this.gBxTemperatura.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gBxTemperatura.Controls.Add(this.rbnCelsius);
			this.gBxTemperatura.Controls.Add(this.rbnKelvin);
			this.gBxTemperatura.Controls.Add(this.rbnFahrenheit);
			this.gBxTemperatura.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gBxTemperatura.Location = new System.Drawing.Point(94, 206);
			this.gBxTemperatura.Name = "gBxTemperatura";
			this.gBxTemperatura.Size = new System.Drawing.Size(624, 58);
			this.gBxTemperatura.TabIndex = 11;
			this.gBxTemperatura.TabStop = false;
			this.gBxTemperatura.Text = "Temperatura";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::_3NLIDTS_Anjoly_Toledo_03.Properties.Resources._854206254368177170;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gBxTemperatura);
			this.Controls.Add(this.btLimpiar);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.txtbKelvin);
			this.Controls.Add(this.txtbFahrenheit);
			this.Controls.Add(this.txtbCelsius);
			this.Controls.Add(this.lbKelvin);
			this.Controls.Add(this.lbFahrenheit);
			this.Controls.Add(this.lbCelsius);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.gBxTemperatura.ResumeLayout(false);
			this.gBxTemperatura.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCelsius;
		private System.Windows.Forms.Label lbFahrenheit;
		private System.Windows.Forms.Label lbKelvin;
		private System.Windows.Forms.TextBox txtbCelsius;
		private System.Windows.Forms.TextBox txtbFahrenheit;
		private System.Windows.Forms.TextBox txtbKelvin;
		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Button btLimpiar;
		private System.Windows.Forms.RadioButton rbnCelsius;
		private System.Windows.Forms.RadioButton rbnFahrenheit;
		private System.Windows.Forms.RadioButton rbnKelvin;
		private System.Windows.Forms.GroupBox gBxTemperatura;
	}
}

