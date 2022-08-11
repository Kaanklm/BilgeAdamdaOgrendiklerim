
namespace WFA_Metotlar
{
    partial class Metot1
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSayiBir = new System.Windows.Forms.TextBox();
            this.txtSayiIki = new System.Windows.Forms.TextBox();
            this.btnTopla2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(13, 23);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSayiBir
            // 
            this.txtSayiBir.Location = new System.Drawing.Point(479, 13);
            this.txtSayiBir.Name = "txtSayiBir";
            this.txtSayiBir.Size = new System.Drawing.Size(100, 20);
            this.txtSayiBir.TabIndex = 2;
            // 
            // txtSayiIki
            // 
            this.txtSayiIki.Location = new System.Drawing.Point(479, 39);
            this.txtSayiIki.Name = "txtSayiIki";
            this.txtSayiIki.Size = new System.Drawing.Size(100, 20);
            this.txtSayiIki.TabIndex = 2;
            // 
            // btnTopla2
            // 
            this.btnTopla2.Location = new System.Drawing.Point(479, 66);
            this.btnTopla2.Name = "btnTopla2";
            this.btnTopla2.Size = new System.Drawing.Size(100, 23);
            this.btnTopla2.TabIndex = 3;
            this.btnTopla2.Text = "Topla";
            this.btnTopla2.UseVisualStyleBackColor = true;
            this.btnTopla2.Click += new System.EventHandler(this.btnTopla2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopla2);
            this.Controls.Add(this.txtSayiIki);
            this.Controls.Add(this.txtSayiBir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSayiBir;
        private System.Windows.Forms.TextBox txtSayiIki;
        private System.Windows.Forms.Button btnTopla2;
    }
}

