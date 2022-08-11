
namespace WFA_HazırMetotlar
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
            this.txtOrnek = new System.Windows.Forms.TextBox();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.btnOrnek5 = new System.Windows.Forms.Button();
            this.btnOrnek6 = new System.Windows.Forms.Button();
            this.btnOrnek7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOrnek
            // 
            this.txtOrnek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrnek.Location = new System.Drawing.Point(13, 13);
            this.txtOrnek.Name = "txtOrnek";
            this.txtOrnek.Size = new System.Drawing.Size(243, 26);
            this.txtOrnek.TabIndex = 0;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(13, 46);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek1.TabIndex = 1;
            this.btnOrnek1.Text = "Compare To";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(13, 90);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "Contains";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(13, 134);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek3.TabIndex = 1;
            this.btnOrnek3.Text = "StartsWith";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Location = new System.Drawing.Point(13, 178);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek4.TabIndex = 1;
            this.btnOrnek4.Text = "EndsWith";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // btnOrnek5
            // 
            this.btnOrnek5.Location = new System.Drawing.Point(13, 222);
            this.btnOrnek5.Name = "btnOrnek5";
            this.btnOrnek5.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek5.TabIndex = 1;
            this.btnOrnek5.Text = "Remove";
            this.btnOrnek5.UseVisualStyleBackColor = true;
            this.btnOrnek5.Click += new System.EventHandler(this.btnOrnek5_Click);
            // 
            // btnOrnek6
            // 
            this.btnOrnek6.Location = new System.Drawing.Point(12, 266);
            this.btnOrnek6.Name = "btnOrnek6";
            this.btnOrnek6.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek6.TabIndex = 1;
            this.btnOrnek6.Text = "Replace";
            this.btnOrnek6.UseVisualStyleBackColor = true;
            this.btnOrnek6.Click += new System.EventHandler(this.btnOrnek6_Click);
            // 
            // btnOrnek7
            // 
            this.btnOrnek7.Location = new System.Drawing.Point(12, 310);
            this.btnOrnek7.Name = "btnOrnek7";
            this.btnOrnek7.Size = new System.Drawing.Size(243, 38);
            this.btnOrnek7.TabIndex = 1;
            this.btnOrnek7.Text = "Split";
            this.btnOrnek7.UseVisualStyleBackColor = true;
            this.btnOrnek7.Click += new System.EventHandler(this.btnOrnek7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 365);
            this.Controls.Add(this.btnOrnek7);
            this.Controls.Add(this.btnOrnek6);
            this.Controls.Add(this.btnOrnek5);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtOrnek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrnek;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.Button btnOrnek5;
        private System.Windows.Forms.Button btnOrnek6;
        private System.Windows.Forms.Button btnOrnek7;
    }
}

