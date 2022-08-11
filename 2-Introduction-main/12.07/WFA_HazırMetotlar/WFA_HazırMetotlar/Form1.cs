using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HazırMetotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        string ornekMetin = "";
        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Compare To=> Metodu kullanuldığında string değer ile metoda verdiğimiz parametredeki string değeri sözlük mantığıyla karşılaştırır. Eğer sözlük ile lokasyondaysa 0, parametredeki değer sözlükten önceyse -1, sonraysa 1 değerini döndürür.
            ornekMetin = txtOrnek.Text;
           int sonuc= ornekMetin.CompareTo("bilgeadam");

            switch (sonuc)
            {
                case 0:
                    MessageBox.Show("Kelime diğer kelime ile eşleşiyor!");
                    break;
                case -1:
                    MessageBox.Show("Kelime diğer kelime ile eşleşmiyor! Eksik karakter var.");
                    break;
                case 1:
                    MessageBox.Show("Kelime diğer kelime ile eşleşmiyor! Fazla karakter var.");
                    break;

            }

        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            ornekMetin = txtOrnek.Text;

           bool varMi= ornekMetin.Contains("adam");

            //Ternary If
            string sonuc = varMi ? "bulunmaktadır" : "bulunmamaktadır!";

            MessageBox.Show(sonuc);
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            ornekMetin = txtOrnek.Text;

           bool sonuc= ornekMetin.StartsWith("bil");
            string mesaj = sonuc ? "Kelime \"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır.";

            MessageBox.Show(mesaj);

        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            ornekMetin = txtOrnek.Text;

            bool sonuc = ornekMetin.EndsWith("dam");

            string mesaj = sonuc ? "Kellime \"dam\" ile bitmektedir." : "Kellime \"dam\" ile bitmemektedir.";
            MessageBox.Show(mesaj);
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //Remove=> verdiğiniz index numarası dahil o indexteki ve sonraki tüm karakterleri kaldırır.

            //Not: bir string üzerinde yaptığınız değişiklikler o string'i değiştirmez. Size yeni bir kopyasını teslim eder.

            ornekMetin = txtOrnek.Text;
            //ornekMetin = ornekMetin.Remove(5);
            ornekMetin = ornekMetin.Remove(6, 3);
            MessageBox.Show(ornekMetin);
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            //Replace=> metniniz içerisindeki bir karakteri ya da bir bölümü yeni bir karakter/bolum ile değiştirilmesine olanak sağlar.

            ornekMetin = txtOrnek.Text;
            ornekMetin = ornekMetin.Replace("adam", "kadın");
            MessageBox.Show(ornekMetin);
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //Split=> metninizi özel bir karakter ile birden fazla parçaya ayırmanızı sağlayan metottur.
            ornekMetin = txtOrnek.Text;
           string[] adresler= ornekMetin.Split(';',':');
            foreach (string adres in adresler)
            {
                MessageBox.Show(adres + " " + "mail gönderildi!");
            }
        }
    }
}
