using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        decimal sayiBir = 0;
        decimal sayiIki = 0;
        decimal sonuc = 0;

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sayiBir = nudSayiBir.Value;
            sayiIki = nudSayiIki.Value;
            sonuc = sayiBir + sayiIki;
            lblSonuc.Text = sonuc.ToString();
            btnTopla.Enabled = false;
            listBox1.Items.Add("Toplam Sonuç: " + sonuc);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            sayiBir = nudSayiBir.Value;
            sayiIki = nudSayiIki.Value;
            sonuc = sayiBir - sayiIki;
            lblSonuc.Text = sonuc.ToString();
            btnCikar.Enabled = false;
            listBox1.Items.Add("Fark Sonuç: " + sonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayiBir = nudSayiBir.Value;
            sayiIki = nudSayiIki.Value;
            sonuc = sayiBir * sayiIki;
            lblSonuc.Text = sonuc.ToString();
            btnCarp.Enabled = false;
            listBox1.Items.Add("Çarpım Sonuç: " + sonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            sayiBir = nudSayiBir.Value;
            sayiIki = nudSayiIki.Value;
            sonuc = sayiBir / sayiIki;
            lblSonuc.Text = sonuc.ToString();
            btnBol.Enabled = false;
            listBox1.Items.Add("Bölüm Sonuç: " + sonuc);
        }
    }
}
