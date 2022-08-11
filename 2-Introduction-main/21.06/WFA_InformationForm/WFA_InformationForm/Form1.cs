using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_InformationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add("form yüklendi!");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //?
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEmail.Text;
            string adres = txtAdres.Text;

            string sonuc = ad + " " + soyad + " " + " " + email + " " + adres;

            listBox1.Items.Add(sonuc);

            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtAdres.Clear();

            //işlem sonlandı.
        }
    }
}
