using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Metot3 : Form
    {
        public Metot3()
        {
            InitializeComponent();
        }

        int Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }

        string PersonelBilgisi()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string adres = txtAdres.Text;
            string tckn = txtTckn.Text;

            string bilgi = ad + " " + soyad + " " + tckn + " " + adres;
            return bilgi;
        }


        string MailGonder(string mailAdresi)
        {

            return mailAdresi+" mail gönderildi!";
        }


        private void Metot3_Load(object sender, EventArgs e)
        {
            //Geriye değer döndüren metot

           int donenDeger= Topla(10, 20);
            MessageBox.Show(donenDeger.ToString());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(PersonelBilgisi());
            MessageBox.Show(MailGonder("fatih.gunalp@bilgeadam.com"));
        }
    }
}
