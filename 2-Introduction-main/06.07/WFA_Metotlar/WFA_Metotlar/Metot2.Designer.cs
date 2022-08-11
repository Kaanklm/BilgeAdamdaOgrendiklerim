
namespace WFA_Metotlar
{
    partial class Metot2
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
            this.btnTopla2 = new System.Windows.Forms.Button();
            this.txtSayiIki = new System.Windows.Forms.TextBox();
            this.txtSayiBir = new System.Windows.Forms.TextBox();
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla2
            // 
            this.btnTopla2.Location = new System.Drawing.Point(12, 65);
            this.btnTopla2.Name = "btnTopla2";
            this.btnTopla2.Size = new System.Drawing.Size(100, 23);
            this.btnTopla2.TabIndex = 6;
            this.btnTopla2.Text = "Topla";
            this.btnTopla2.UseVisualStyleBackColor = true;
            this.btnTopla2.Click += new System.EventHandler(this.btnTopla2_Click);
            // 
            // txtSayiIki
            // 
            this.txtSayiIki.Location = new System.Drawing.Point(12, 38);
            this.txtSayiIki.Name = "txtSayiIki";
            this.txtSayiIki.Size = new System.Drawing.Size(100, 20);
            this.txtSayiIki.TabIndex = 4;
            // 
            // txtSayiBir
            // 
            this.txtSayiBir.Location = new System.Drawing.Point(12, 12);
            this.txtSayiBir.Name = "txtSayiBir";
            this.txtSayiBir.Size = new System.Drawing.Size(100, 20);
            this.txtSayiBir.TabIndex = 5;
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Location = new System.Drawing.Point(282, 25);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(75, 23);
            this.btnMesajVer.TabIndex = 7;
            this.btnMesajVer.Text = "Mesaj Ver";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // Metot2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.btnTopla2);
            this.Controls.Add(this.txtSayiIki);
            this.Controls.Add(this.txtSayiBir);
            this.Name = "Metot2";
            this.Text = "Metot2";
            this.Load += new System.EventHandler(this.Metot2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla2;
        private System.Windows.Forms.TextBox txtSayiIki;
        private System.Windows.Forms.TextBox txtSayiBir;
        private System.Windows.Forms.Button btnMesajVer;
    }
}