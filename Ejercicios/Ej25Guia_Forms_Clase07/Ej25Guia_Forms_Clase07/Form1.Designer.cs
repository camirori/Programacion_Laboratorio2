namespace Ej25Guia_Forms_Clase07
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
            this.lblBinDec = new System.Windows.Forms.Label();
            this.lblDecBin = new System.Windows.Forms.Label();
            this.txtBinIn = new System.Windows.Forms.TextBox();
            this.txtDecIn = new System.Windows.Forms.TextBox();
            this.txtDecOut = new System.Windows.Forms.TextBox();
            this.txtBinOut = new System.Windows.Forms.TextBox();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinDec
            // 
            this.lblBinDec.AutoSize = true;
            this.lblBinDec.Location = new System.Drawing.Point(13, 27);
            this.lblBinDec.Name = "lblBinDec";
            this.lblBinDec.Size = new System.Drawing.Size(89, 13);
            this.lblBinDec.TabIndex = 0;
            this.lblBinDec.Text = "Binario a Decimal";
            // 
            // lblDecBin
            // 
            this.lblDecBin.AutoSize = true;
            this.lblDecBin.Location = new System.Drawing.Point(14, 53);
            this.lblDecBin.Name = "lblDecBin";
            this.lblDecBin.Size = new System.Drawing.Size(89, 13);
            this.lblDecBin.TabIndex = 1;
            this.lblDecBin.Text = "Decimal a Binario";
            // 
            // txtBinIn
            // 
            this.txtBinIn.Location = new System.Drawing.Point(109, 19);
            this.txtBinIn.Name = "txtBinIn";
            this.txtBinIn.Size = new System.Drawing.Size(65, 20);
            this.txtBinIn.TabIndex = 2;
            this.txtBinIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBinIn.Click += new System.EventHandler(this.txtBinIn_Click);
            this.txtBinIn.Leave += new System.EventHandler(this.txtBinIn_Leave);
            // 
            // txtDecIn
            // 
            this.txtDecIn.Location = new System.Drawing.Point(109, 49);
            this.txtDecIn.Name = "txtDecIn";
            this.txtDecIn.Size = new System.Drawing.Size(65, 20);
            this.txtDecIn.TabIndex = 3;
            this.txtDecIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDecIn.Leave += new System.EventHandler(this.txtDecIn_Leave);
            // 
            // txtDecOut
            // 
            this.txtDecOut.Enabled = false;
            this.txtDecOut.Location = new System.Drawing.Point(249, 19);
            this.txtDecOut.Name = "txtDecOut";
            this.txtDecOut.Size = new System.Drawing.Size(65, 20);
            this.txtDecOut.TabIndex = 4;
            this.txtDecOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBinOut
            // 
            this.txtBinOut.Enabled = false;
            this.txtBinOut.Location = new System.Drawing.Point(249, 50);
            this.txtBinOut.Name = "txtBinOut";
            this.txtBinOut.Size = new System.Drawing.Size(65, 20);
            this.txtBinOut.TabIndex = 5;
            this.txtBinOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(181, 19);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(62, 23);
            this.btnBD.TabIndex = 6;
            this.btnBD.Text = "->";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(180, 48);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(62, 23);
            this.btnDB.TabIndex = 7;
            this.btnDB.Text = "->";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 93);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.txtBinOut);
            this.Controls.Add(this.txtDecOut);
            this.Controls.Add(this.txtDecIn);
            this.Controls.Add(this.txtBinIn);
            this.Controls.Add(this.lblDecBin);
            this.Controls.Add(this.lblBinDec);
            this.Name = "Form1";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinDec;
        private System.Windows.Forms.Label lblDecBin;
        private System.Windows.Forms.TextBox txtBinIn;
        private System.Windows.Forms.TextBox txtDecIn;
        private System.Windows.Forms.TextBox txtDecOut;
        private System.Windows.Forms.TextBox txtBinOut;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnDB;
    }
}

