
namespace WFA_Arrays
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.btnEnKucukSayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(238, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 264);
            this.listBox1.TabIndex = 1;
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(37, 283);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(195, 36);
            this.btnRastgele.TabIndex = 2;
            this.btnRastgele.Text = "Rastgele";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // btnEnKucukSayi
            // 
            this.btnEnKucukSayi.Location = new System.Drawing.Point(239, 42);
            this.btnEnKucukSayi.Name = "btnEnKucukSayi";
            this.btnEnKucukSayi.Size = new System.Drawing.Size(117, 23);
            this.btnEnKucukSayi.TabIndex = 3;
            this.btnEnKucukSayi.Text = "En Küçük Sayı";
            this.btnEnKucukSayi.UseVisualStyleBackColor = true;
            this.btnEnKucukSayi.Click += new System.EventHandler(this.btnEnKucukSayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnKucukSayi);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Button btnEnKucukSayi;
    }
}

