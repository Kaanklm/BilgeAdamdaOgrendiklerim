
namespace WFA_BakiyeIsmleri
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParaYatir = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParaCek = new System.Windows.Forms.TextBox();
            this.btnParaCEk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.lblHesapAdi = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(146, 58);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(462, 39);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "500";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParaYatir);
            this.groupBox2.Controls.Add(this.btnParaYatir);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(373, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Yatır";
            // 
            // txtParaYatir
            // 
            this.txtParaYatir.Location = new System.Drawing.Point(86, 55);
            this.txtParaYatir.Name = "txtParaYatir";
            this.txtParaYatir.Size = new System.Drawing.Size(119, 20);
            this.txtParaYatir.TabIndex = 3;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(86, 82);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(120, 33);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParaCek);
            this.groupBox1.Controls.Add(this.btnParaCEk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Çek";
            // 
            // txtParaCek
            // 
            this.txtParaCek.Location = new System.Drawing.Point(87, 56);
            this.txtParaCek.Name = "txtParaCek";
            this.txtParaCek.Size = new System.Drawing.Size(119, 20);
            this.txtParaCek.TabIndex = 3;
            // 
            // btnParaCEk
            // 
            this.btnParaCEk.Location = new System.Drawing.Point(86, 82);
            this.btnParaCEk.Name = "btnParaCEk";
            this.btnParaCEk.Size = new System.Drawing.Size(120, 33);
            this.btnParaCEk.TabIndex = 2;
            this.btnParaCEk.Text = "Para Çek";
            this.btnParaCEk.UseVisualStyleBackColor = true;
            this.btnParaCEk.Click += new System.EventHandler(this.btnParaCEk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miktar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İşlem Dökümü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hesap Adı:";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(208, 10);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(367, 20);
            this.txtHesapAdi.TabIndex = 8;
            // 
            // lblHesapAdi
            // 
            this.lblHesapAdi.AutoSize = true;
            this.lblHesapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapAdi.Location = new System.Drawing.Point(327, 30);
            this.lblHesapAdi.Name = "lblHesapAdi";
            this.lblHesapAdi.Size = new System.Drawing.Size(98, 24);
            this.lblHesapAdi.TabIndex = 9;
            this.lblHesapAdi.Text = "Hesap Adı";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(581, 8);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 10;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 436);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.lblHesapAdi);
            this.Controls.Add(this.txtHesapAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParaCEk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.Label lblHesapAdi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtParaYatir;
        private System.Windows.Forms.TextBox txtParaCek;
    }
}

