namespace Ej23Guia_Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEuroOut = new System.Windows.Forms.Label();
            this.lblDolarOut = new System.Windows.Forms.Label();
            this.lblPesoOut = new System.Windows.Forms.Label();
            this.lblCoti = new System.Windows.Forms.Label();
            this.txtEuroIn = new System.Windows.Forms.TextBox();
            this.txtDolarIn = new System.Windows.Forms.TextBox();
            this.txtPesoIn = new System.Windows.Forms.TextBox();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.txtCotiEuro = new System.Windows.Forms.TextBox();
            this.txtCotiDolar = new System.Windows.Forms.TextBox();
            this.txtCotiPeso = new System.Windows.Forms.TextBox();
            this.btnLockCoti = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(12, 95);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 127);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 164);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // lblEuroOut
            // 
            this.lblEuroOut.AutoSize = true;
            this.lblEuroOut.Location = new System.Drawing.Point(232, 71);
            this.lblEuroOut.Name = "lblEuroOut";
            this.lblEuroOut.Size = new System.Drawing.Size(29, 13);
            this.lblEuroOut.TabIndex = 3;
            this.lblEuroOut.Text = "Euro";
            // 
            // lblDolarOut
            // 
            this.lblDolarOut.AutoSize = true;
            this.lblDolarOut.Location = new System.Drawing.Point(329, 71);
            this.lblDolarOut.Name = "lblDolarOut";
            this.lblDolarOut.Size = new System.Drawing.Size(32, 13);
            this.lblDolarOut.TabIndex = 4;
            this.lblDolarOut.Text = "Dolar";
            // 
            // lblPesoOut
            // 
            this.lblPesoOut.AutoSize = true;
            this.lblPesoOut.Location = new System.Drawing.Point(421, 71);
            this.lblPesoOut.Name = "lblPesoOut";
            this.lblPesoOut.Size = new System.Drawing.Size(31, 13);
            this.lblPesoOut.TabIndex = 5;
            this.lblPesoOut.Text = "Peso";
            // 
            // lblCoti
            // 
            this.lblCoti.AutoSize = true;
            this.lblCoti.Location = new System.Drawing.Point(60, 35);
            this.lblCoti.Name = "lblCoti";
            this.lblCoti.Size = new System.Drawing.Size(56, 13);
            this.lblCoti.TabIndex = 6;
            this.lblCoti.Text = "Cotizacion";
            // 
            // txtEuroIn
            // 
            this.txtEuroIn.Location = new System.Drawing.Point(53, 92);
            this.txtEuroIn.Name = "txtEuroIn";
            this.txtEuroIn.Size = new System.Drawing.Size(75, 20);
            this.txtEuroIn.TabIndex = 7;
            // 
            // txtDolarIn
            // 
            this.txtDolarIn.Location = new System.Drawing.Point(53, 124);
            this.txtDolarIn.Name = "txtDolarIn";
            this.txtDolarIn.Size = new System.Drawing.Size(75, 20);
            this.txtDolarIn.TabIndex = 8;
            // 
            // txtPesoIn
            // 
            this.txtPesoIn.Location = new System.Drawing.Point(53, 161);
            this.txtPesoIn.Name = "txtPesoIn";
            this.txtPesoIn.Size = new System.Drawing.Size(75, 20);
            this.txtPesoIn.TabIndex = 9;
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Location = new System.Drawing.Point(134, 93);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 10;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.BtnConvertEuro_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Location = new System.Drawing.Point(134, 124);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 11;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.BtnConvertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(134, 159);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 12;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.BtnConvertPeso_Click);
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.Enabled = false;
            this.txtEuroEuro.Location = new System.Drawing.Point(215, 96);
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(89, 20);
            this.txtEuroEuro.TabIndex = 13;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.Enabled = false;
            this.txtDolarEuro.Location = new System.Drawing.Point(215, 124);
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(89, 20);
            this.txtDolarEuro.TabIndex = 14;
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.Enabled = false;
            this.txtPesoEuro.Location = new System.Drawing.Point(215, 164);
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(89, 20);
            this.txtPesoEuro.TabIndex = 15;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.Enabled = false;
            this.txtEuroDolar.Location = new System.Drawing.Point(310, 96);
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(80, 20);
            this.txtEuroDolar.TabIndex = 16;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.Enabled = false;
            this.txtDolarDolar.Location = new System.Drawing.Point(310, 126);
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(80, 20);
            this.txtDolarDolar.TabIndex = 17;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.Enabled = false;
            this.txtPesoDolar.Location = new System.Drawing.Point(310, 164);
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(80, 20);
            this.txtPesoDolar.TabIndex = 18;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.Enabled = false;
            this.txtEuroPeso.Location = new System.Drawing.Point(398, 95);
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(80, 20);
            this.txtEuroPeso.TabIndex = 19;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.Enabled = false;
            this.txtDolarPeso.Location = new System.Drawing.Point(398, 124);
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(80, 20);
            this.txtDolarPeso.TabIndex = 20;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.Enabled = false;
            this.txtPesoPeso.Location = new System.Drawing.Point(398, 164);
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(80, 20);
            this.txtPesoPeso.TabIndex = 21;
            // 
            // txtCotiEuro
            // 
            this.txtCotiEuro.Enabled = false;
            this.txtCotiEuro.Location = new System.Drawing.Point(215, 30);
            this.txtCotiEuro.Name = "txtCotiEuro";
            this.txtCotiEuro.Size = new System.Drawing.Size(80, 20);
            this.txtCotiEuro.TabIndex = 22;
            this.txtCotiEuro.Leave += new System.EventHandler(this.TxtCotiEuro_Leave);
            // 
            // txtCotiDolar
            // 
            this.txtCotiDolar.Enabled = false;
            this.txtCotiDolar.Location = new System.Drawing.Point(310, 30);
            this.txtCotiDolar.Name = "txtCotiDolar";
            this.txtCotiDolar.Size = new System.Drawing.Size(80, 20);
            this.txtCotiDolar.TabIndex = 23;
            this.txtCotiDolar.Leave += new System.EventHandler(this.TxtCotiDolar_Leave);
            // 
            // txtCotiPeso
            // 
            this.txtCotiPeso.Enabled = false;
            this.txtCotiPeso.Location = new System.Drawing.Point(398, 30);
            this.txtCotiPeso.Name = "txtCotiPeso";
            this.txtCotiPeso.Size = new System.Drawing.Size(80, 20);
            this.txtCotiPeso.TabIndex = 24;
            this.txtCotiPeso.Leave += new System.EventHandler(this.TxtCotiPeso_Leave);
            // 
            // btnLockCoti
            // 
            this.btnLockCoti.ImageIndex = 1;
            this.btnLockCoti.ImageList = this.imageList1;
            this.btnLockCoti.Location = new System.Drawing.Point(134, 30);
            this.btnLockCoti.Name = "btnLockCoti";
            this.btnLockCoti.Size = new System.Drawing.Size(75, 23);
            this.btnLockCoti.TabIndex = 25;
            this.btnLockCoti.UseVisualStyleBackColor = true;
            this.btnLockCoti.Click += new System.EventHandler(this.BtnLockCoti_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock-open-solid.png");
            this.imageList1.Images.SetKeyName(1, "lock-solid.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 226);
            this.Controls.Add(this.btnLockCoti);
            this.Controls.Add(this.txtCotiPeso);
            this.Controls.Add(this.txtCotiDolar);
            this.Controls.Add(this.txtCotiEuro);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.txtPesoIn);
            this.Controls.Add(this.txtDolarIn);
            this.Controls.Add(this.txtEuroIn);
            this.Controls.Add(this.lblCoti);
            this.Controls.Add(this.lblPesoOut);
            this.Controls.Add(this.lblDolarOut);
            this.Controls.Add(this.lblEuroOut);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblEuroOut;
        private System.Windows.Forms.Label lblDolarOut;
        private System.Windows.Forms.Label lblPesoOut;
        private System.Windows.Forms.Label lblCoti;
        private System.Windows.Forms.TextBox txtEuroIn;
        private System.Windows.Forms.TextBox txtDolarIn;
        private System.Windows.Forms.TextBox txtPesoIn;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtPesoPeso;
        private System.Windows.Forms.TextBox txtCotiEuro;
        private System.Windows.Forms.TextBox txtCotiDolar;
        private System.Windows.Forms.TextBox txtCotiPeso;
        private System.Windows.Forms.Button btnLockCoti;
        private System.Windows.Forms.ImageList imageList1;
    }
}

