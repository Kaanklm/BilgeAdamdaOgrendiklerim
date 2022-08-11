using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //C# Windows Form Apllication Event Drivin (Olay güdümlü) bir dildir.

        private void btnInstall_Click(object sender, EventArgs e)
        {
            //Ne yapacağım?
                //ekranda mesaj kutusu göstereceğim.
            //Ne zaman yapacağım?
                //install isimli butona tıklandığında.

            MessageBox.Show("Kurulum başlatıldı!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem iptal edildi");
        }

        private void lblTitle_MouseHover(object sender, EventArgs e)
        {
            //Ne yapacağım?
            //lblContent'ı görünür yapacağım.
            //Ne zaman yapacağım?
            //lblTitle'ın üzerine gelindiğinde.
            lblContent.Visible = true;
        }

        private void pbLogo_MouseHover(object sender, EventArgs e)
        {
            //Ne yapacağım?
            //btnInstall'ın arkaplan rengini yeşil yapacağım.
            //Ne zaman yapacağım?
            //pbLogo'nun üzerine mouse ile gelindiğinde.
            btnInstall.BackColor = Color.Green;
        }
    }
}
