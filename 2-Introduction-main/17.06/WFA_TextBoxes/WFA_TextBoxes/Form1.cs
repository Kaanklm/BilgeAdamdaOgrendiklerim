using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
       * 1-txtAd'ın içerisine girilen değer btnKayit tıklandığında lblAd'ın içerisine gönderilecek.
       * 2-txtSoyad'ın içerisine girilen değer btn kayıt tıklandığında lblSoyad'ın içerisine gönderilecek.
       * 3-txtEmail'ın içerisine girilen değer btn kayıt tıklandığında lblemail'ın içerisine gönderilecek.
       * 4-txtAdress'ın içerisine girilen değer btn kayıt tıklandığında lblAdres'ın içerisine gönderilecek.
       * 
       */
        private void btnKayit_Click(object sender, EventArgs e)
        {
            lblAd.Text = txtAd.Text;
            lblSoyad.Text = txtSoyad.Text;
            lblEmail.Text = txtEmail.Text;
            lblAdres.Text = txtAdres.Text;

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";

            txtAd.Focus();
        }

      
    }
}
