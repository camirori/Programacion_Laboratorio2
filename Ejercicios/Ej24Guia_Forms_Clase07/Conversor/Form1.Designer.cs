namespace Conversor
{
    partial class Conversor
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
            this.lblFahrenheitIn = new System.Windows.Forms.Label();
            this.lblCelsiusIn = new System.Windows.Forms.Label();
            this.lblKelvinIn = new System.Windows.Forms.Label();
            this.lblFahrenheitOut = new System.Windows.Forms.Label();
            this.lblCelsiusOut = new System.Windows.Forms.Label();
            this.lblKelvinOut = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.txtFIn = new System.Windows.Forms.TextBox();
            this.txtKK = new System.Windows.Forms.TextBox();
            this.txtKC = new System.Windows.Forms.TextBox();
            this.txtKF = new System.Windows.Forms.TextBox();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.txtFF = new System.Windows.Forms.TextBox();
            this.txtKIn = new System.Windows.Forms.TextBox();
            this.txtCIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFahrenheitIn
            // 
            this.lblFahrenheitIn.AutoSize = true;
            this.lblFahrenheitIn.Location = new System.Drawing.Point(12, 81);
            this.lblFahrenheitIn.Name = "lblFahrenheitIn";
            this.lblFahrenheitIn.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheitIn.TabIndex = 0;
            this.lblFahrenheitIn.Text = "Fahrenheit";
            // 
            // lblCelsiusIn
            // 
            this.lblCelsiusIn.AutoSize = true;
            this.lblCelsiusIn.Location = new System.Drawing.Point(12, 111);
            this.lblCelsiusIn.Name = "lblCelsiusIn";
            this.lblCelsiusIn.Size = new System.Drawing.Size(40, 13);
            this.lblCelsiusIn.TabIndex = 1;
            this.lblCelsiusIn.Text = "Celsius";
            // 
            // lblKelvinIn
            // 
            this.lblKelvinIn.AutoSize = true;
            this.lblKelvinIn.Location = new System.Drawing.Point(16, 137);
            this.lblKelvinIn.Name = "lblKelvinIn";
            this.lblKelvinIn.Size = new System.Drawing.Size(36, 13);
            this.lblKelvinIn.TabIndex = 2;
            this.lblKelvinIn.Text = "Kelvin";
            // 
            // lblFahrenheitOut
            // 
            this.lblFahrenheitOut.AutoSize = true;
            this.lblFahrenheitOut.Location = new System.Drawing.Point(234, 58);
            this.lblFahrenheitOut.Name = "lblFahrenheitOut";
            this.lblFahrenheitOut.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheitOut.TabIndex = 3;
            this.lblFahrenheitOut.Text = "Fahrenheit";
            // 
            // lblCelsiusOut
            // 
            this.lblCelsiusOut.AutoSize = true;
            this.lblCelsiusOut.Location = new System.Drawing.Point(307, 58);
            this.lblCelsiusOut.Name = "lblCelsiusOut";
            this.lblCelsiusOut.Size = new System.Drawing.Size(40, 13);
            this.lblCelsiusOut.TabIndex = 4;
            this.lblCelsiusOut.Text = "Celsius";
            // 
            // lblKelvinOut
            // 
            this.lblKelvinOut.AutoSize = true;
            this.lblKelvinOut.Location = new System.Drawing.Point(373, 58);
            this.lblKelvinOut.Name = "lblKelvinOut";
            this.lblKelvinOut.Size = new System.Drawing.Size(36, 13);
            this.lblKelvinOut.TabIndex = 5;
            this.lblKelvinOut.Text = "Kelvin";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(142, 78);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 6;
            this.btnF.Text = "->";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(142, 108);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "->";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(142, 135);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 23);
            this.btnK.TabIndex = 8;
            this.btnK.Text = "->";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // txtFIn
            // 
            this.txtFIn.Location = new System.Drawing.Point(76, 81);
            this.txtFIn.Name = "txtFIn";
            this.txtFIn.Size = new System.Drawing.Size(60, 20);
            this.txtFIn.TabIndex = 9;
            this.txtFIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKK
            // 
            this.txtKK.Enabled = false;
            this.txtKK.Location = new System.Drawing.Point(364, 130);
            this.txtKK.Name = "txtKK";
            this.txtKK.Size = new System.Drawing.Size(60, 20);
            this.txtKK.TabIndex = 10;
            this.txtKK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKC
            // 
            this.txtKC.Enabled = false;
            this.txtKC.Location = new System.Drawing.Point(297, 130);
            this.txtKC.Name = "txtKC";
            this.txtKC.Size = new System.Drawing.Size(60, 20);
            this.txtKC.TabIndex = 11;
            this.txtKC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKF
            // 
            this.txtKF.Enabled = false;
            this.txtKF.Location = new System.Drawing.Point(231, 130);
            this.txtKF.Name = "txtKF";
            this.txtKF.Size = new System.Drawing.Size(60, 20);
            this.txtKF.TabIndex = 12;
            this.txtKF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCF
            // 
            this.txtCF.Enabled = false;
            this.txtCF.Location = new System.Drawing.Point(231, 104);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(60, 20);
            this.txtCF.TabIndex = 13;
            this.txtCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCC
            // 
            this.txtCC.Enabled = false;
            this.txtCC.Location = new System.Drawing.Point(297, 104);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(60, 20);
            this.txtCC.TabIndex = 14;
            this.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCK
            // 
            this.txtCK.Enabled = false;
            this.txtCK.Location = new System.Drawing.Point(364, 104);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(60, 20);
            this.txtCK.TabIndex = 15;
            this.txtCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFK
            // 
            this.txtFK.Enabled = false;
            this.txtFK.Location = new System.Drawing.Point(363, 78);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(60, 20);
            this.txtFK.TabIndex = 16;
            this.txtFK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFC
            // 
            this.txtFC.Enabled = false;
            this.txtFC.Location = new System.Drawing.Point(297, 78);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(60, 20);
            this.txtFC.TabIndex = 17;
            this.txtFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFF
            // 
            this.txtFF.Enabled = false;
            this.txtFF.Location = new System.Drawing.Point(231, 78);
            this.txtFF.Name = "txtFF";
            this.txtFF.Size = new System.Drawing.Size(60, 20);
            this.txtFF.TabIndex = 18;
            this.txtFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKIn
            // 
            this.txtKIn.Location = new System.Drawing.Point(76, 137);
            this.txtKIn.Name = "txtKIn";
            this.txtKIn.Size = new System.Drawing.Size(60, 20);
            this.txtKIn.TabIndex = 19;
            this.txtKIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCIn
            // 
            this.txtCIn.Location = new System.Drawing.Point(76, 111);
            this.txtCIn.Name = "txtCIn";
            this.txtCIn.Size = new System.Drawing.Size(60, 20);
            this.txtCIn.TabIndex = 20;
            this.txtCIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 168);
            this.Controls.Add(this.txtCIn);
            this.Controls.Add(this.txtKIn);
            this.Controls.Add(this.txtFF);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtCK);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.txtKF);
            this.Controls.Add(this.txtKC);
            this.Controls.Add(this.txtKK);
            this.Controls.Add(this.txtFIn);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.lblKelvinOut);
            this.Controls.Add(this.lblCelsiusOut);
            this.Controls.Add(this.lblFahrenheitOut);
            this.Controls.Add(this.lblKelvinIn);
            this.Controls.Add(this.lblCelsiusIn);
            this.Controls.Add(this.lblFahrenheitIn);
            this.Name = "Conversor";
            this.Text = "Conversor Unidades de Medida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheitIn;
        private System.Windows.Forms.Label lblCelsiusIn;
        private System.Windows.Forms.Label lblKelvinIn;
        private System.Windows.Forms.Label lblFahrenheitOut;
        private System.Windows.Forms.Label lblCelsiusOut;
        private System.Windows.Forms.Label lblKelvinOut;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.TextBox txtFIn;
        private System.Windows.Forms.TextBox txtKK;
        private System.Windows.Forms.TextBox txtKC;
        private System.Windows.Forms.TextBox txtKF;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.TextBox txtFF;
        private System.Windows.Forms.TextBox txtKIn;
        private System.Windows.Forms.TextBox txtCIn;
    }
}

