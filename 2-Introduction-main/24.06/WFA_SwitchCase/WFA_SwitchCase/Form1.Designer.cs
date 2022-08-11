
namespace WFA_SwitchCase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnRol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.txtGirisYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevsim:";
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(180, 32);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(134, 20);
            this.txtDeger.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(180, 59);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(134, 29);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Aylar";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(503, 32);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(134, 20);
            this.txtRol.TabIndex = 1;
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(503, 59);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(134, 29);
            this.btnRol.TabIndex = 2;
            this.btnRol.Text = "Rol Getir";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(255, 241);
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(134, 20);
            this.txtKullanıcıAdi.TabIndex = 1;
            // 
            // txtGirisYap
            // 
            this.txtGirisYap.Location = new System.Drawing.Point(255, 293);
            this.txtGirisYap.Name = "txtGirisYap";
            this.txtGirisYap.Size = new System.Drawing.Size(134, 29);
            this.txtGirisYap.TabIndex = 2;
            this.txtGirisYap.Text = "Giriş Yap";
            this.txtGirisYap.UseVisualStyleBackColor = true;
            this.txtGirisYap.Click += new System.EventHandler(this.txtGirisYap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(255, 267);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(134, 20);
            this.txtSifre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.txtGirisYap);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdi);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
        private System.Windows.Forms.Button txtGirisYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

