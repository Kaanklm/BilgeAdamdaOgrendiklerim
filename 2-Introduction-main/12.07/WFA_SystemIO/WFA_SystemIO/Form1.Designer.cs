
namespace WFA_SystemIO
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
            this.btnDirectoryExist = new System.Windows.Forms.Button();
            this.btnDirectoryDelete = new System.Windows.Forms.Button();
            this.btnDirectoryCreate = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFileCreate = new System.Windows.Forms.Button();
            this.btnFileWrite = new System.Windows.Forms.Button();
            this.btnFileRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDirectoryExist
            // 
            this.btnDirectoryExist.Location = new System.Drawing.Point(23, 30);
            this.btnDirectoryExist.Name = "btnDirectoryExist";
            this.btnDirectoryExist.Size = new System.Drawing.Size(129, 28);
            this.btnDirectoryExist.TabIndex = 0;
            this.btnDirectoryExist.Text = "Klasör Kontrol";
            this.btnDirectoryExist.UseVisualStyleBackColor = true;
            this.btnDirectoryExist.Click += new System.EventHandler(this.btnDirectoryExist_Click);
            // 
            // btnDirectoryDelete
            // 
            this.btnDirectoryDelete.Location = new System.Drawing.Point(23, 64);
            this.btnDirectoryDelete.Name = "btnDirectoryDelete";
            this.btnDirectoryDelete.Size = new System.Drawing.Size(129, 28);
            this.btnDirectoryDelete.TabIndex = 0;
            this.btnDirectoryDelete.Text = "Klasör Silme";
            this.btnDirectoryDelete.UseVisualStyleBackColor = true;
            this.btnDirectoryDelete.Click += new System.EventHandler(this.btnDirectoryDelete_Click);
            // 
            // btnDirectoryCreate
            // 
            this.btnDirectoryCreate.Location = new System.Drawing.Point(23, 98);
            this.btnDirectoryCreate.Name = "btnDirectoryCreate";
            this.btnDirectoryCreate.Size = new System.Drawing.Size(129, 28);
            this.btnDirectoryCreate.TabIndex = 0;
            this.btnDirectoryCreate.Text = "Klasör Oluşturma";
            this.btnDirectoryCreate.UseVisualStyleBackColor = true;
            this.btnDirectoryCreate.Click += new System.EventHandler(this.btnDirectoryCreate_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(240, 30);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(120, 28);
            this.btnGetFiles.TabIndex = 1;
            this.btnGetFiles.Text = "Dosyaları Oku";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(240, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 95);
            this.listBox1.TabIndex = 2;
            // 
            // btnFileCreate
            // 
            this.btnFileCreate.Location = new System.Drawing.Point(23, 132);
            this.btnFileCreate.Name = "btnFileCreate";
            this.btnFileCreate.Size = new System.Drawing.Size(129, 28);
            this.btnFileCreate.TabIndex = 1;
            this.btnFileCreate.Text = "Dosya Oluştur";
            this.btnFileCreate.UseVisualStyleBackColor = true;
            this.btnFileCreate.Click += new System.EventHandler(this.btnFileCreate_Click);
            // 
            // btnFileWrite
            // 
            this.btnFileWrite.Location = new System.Drawing.Point(23, 166);
            this.btnFileWrite.Name = "btnFileWrite";
            this.btnFileWrite.Size = new System.Drawing.Size(129, 28);
            this.btnFileWrite.TabIndex = 1;
            this.btnFileWrite.Text = "Dosya Yazdır";
            this.btnFileWrite.UseVisualStyleBackColor = true;
            this.btnFileWrite.Click += new System.EventHandler(this.btnFileWrite_Click);
            // 
            // btnFileRead
            // 
            this.btnFileRead.Location = new System.Drawing.Point(23, 200);
            this.btnFileRead.Name = "btnFileRead";
            this.btnFileRead.Size = new System.Drawing.Size(129, 28);
            this.btnFileRead.TabIndex = 1;
            this.btnFileRead.Text = "Dosya Oku";
            this.btnFileRead.UseVisualStyleBackColor = true;
            this.btnFileRead.Click += new System.EventHandler(this.btnFileRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFileRead);
            this.Controls.Add(this.btnFileWrite);
            this.Controls.Add(this.btnFileCreate);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnDirectoryCreate);
            this.Controls.Add(this.btnDirectoryDelete);
            this.Controls.Add(this.btnDirectoryExist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDirectoryExist;
        private System.Windows.Forms.Button btnDirectoryDelete;
        private System.Windows.Forms.Button btnDirectoryCreate;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFileCreate;
        private System.Windows.Forms.Button btnFileWrite;
        private System.Windows.Forms.Button btnFileRead;
    }
}

