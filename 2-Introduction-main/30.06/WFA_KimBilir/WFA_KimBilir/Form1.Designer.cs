
namespace WFA_KimBilir
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
            this.components = new System.ComponentModel.Container();
            this.lblSayac = new System.Windows.Forms.Label();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstBilenler = new System.Windows.Forms.ListBox();
            this.lstBilemeyenler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(433, 48);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(150, 150);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "30";
            this.lblSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.Location = new System.Drawing.Point(13, 13);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(372, 563);
            this.lstOgrenciler.TabIndex = 1;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(433, 202);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(150, 39);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstBilenler
            // 
            this.lstBilenler.FormattingEnabled = true;
            this.lstBilenler.Location = new System.Drawing.Point(611, 34);
            this.lstBilenler.Name = "lstBilenler";
            this.lstBilenler.Size = new System.Drawing.Size(237, 407);
            this.lstBilenler.TabIndex = 3;
            // 
            // lstBilemeyenler
            // 
            this.lstBilemeyenler.FormattingEnabled = true;
            this.lstBilemeyenler.Location = new System.Drawing.Point(868, 34);
            this.lstBilemeyenler.Name = "lstBilemeyenler";
            this.lstBilemeyenler.Size = new System.Drawing.Size(237, 407);
            this.lstBilemeyenler.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Her bir soru 5 puan değerindedir!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOgrenci.Location = new System.Drawing.Point(402, 270);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(203, 34);
            this.lblOgrenci.TabIndex = 5;
            this.lblOgrenci.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 603);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBilemeyenler);
            this.Controls.Add(this.lstBilenler);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstBilenler;
        private System.Windows.Forms.ListBox lstBilemeyenler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOgrenci;
    }
}

