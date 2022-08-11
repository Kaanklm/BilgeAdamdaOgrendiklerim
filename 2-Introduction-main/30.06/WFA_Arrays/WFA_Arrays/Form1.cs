using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Array (Dizi)

            /*
                aynı tip (string, int, byte, char, bool) verileri tek bir yapı altında tutmamızı sağlayan yapılardır.
             */

            //I. YOL
            int[] sayilar = new int[3];
            sayilar[0] = 5;
            sayilar[1] = 10;
            sayilar[2] = 15;
            //sayilar[3] = 20;//out of range exception

            //II. YOL

            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };
            //MessageBox.Show(sehirler[1]);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //btnEkle tıklandığında listbox'ın içerisine sınıfın listesini ekleyin.
            string[] sinifListesi = { "ABDULKADİR GÜL", "AHMET ALİBEŞE", "Ahmet Çavuş", "ALİ FIRAT KARDAŞ", "ALPER SARMAN", "BERKAY SARMAN", "BURCU ÖZCAN", "GÖKÇEN AKÇA", "GÖKHAN ERYALÇIN", "İBRAHİM BERKAY KAÇAR", "İREM BUSE PINAR", "KAAN KİLİM", "KADİR KENAN", "SALİM FARUK POLAT", "YASİN SAF" };
            

            //listBox1.Items.Add(sinifListesi[0]);
            //listBox1.Items.Add(sinifListesi[1]);
            //listBox1.Items.Add(sinifListesi[2]);
            //listBox1.Items.Add(sinifListesi[3]);
            //listBox1.Items.Add(sinifListesi[4]);
            //listBox1.Items.Add(sinifListesi[5]);

            for(int i=0; i<sinifListesi.Length; i++)
            {
                listBox1.Items.Add(sinifListesi[i]);
            }

        

        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {

            //ÖDEV:
                /*
                 aşağıdaki işlemde rastgele bir seçim yapıldıktan sonra seçim yapılan öğrenci listbox içerisinden kaldırılıyor. Ancak seçim yapılan öğrenci listbox'da kalsın ama tekrar seçilemesin.
                 */

            //rastgele butonuna tıklandığında listbox içerisinde rastgele bir öğrenciyi mesaj kutusunda gösterin.

            if (listBox1.Items.Count > 0)//ilk olarak listbox içerisinde herhangi bir değer var mı kontrol ediyoruz.
            {
                Random rnd = new Random();//instance
                int rastgele = rnd.Next(0, listBox1.Items.Count);
                string rastgeleOgrenci = listBox1.Items[rastgele].ToString();
                MessageBox.Show(rastgeleOgrenci);
                listBox1.Items.Remove(rastgeleOgrenci);
            }
            else
            {
                MessageBox.Show("sen önce git listbox'ı doldur!");
            }
        }

        private void btnEnKucukSayi_Click(object sender, EventArgs e)
        {
            // -34, -5, -768, -467, -657, -457, -999, -324

            //yukarıdaki sayıları bir dizi içerisinde tanımlayın. Ardından dizideki en küçük sayıyı mesaj kutusunda gösterin.

            int[] sayilar = { -34, -5, -768, -467, -657, -457, -999, -324 };

            int enKucukSayi = sayilar[0];
            for(int i=0; i<sayilar.Length; i++)
            {
                if (enKucukSayi > sayilar[i])
                {
                    enKucukSayi = sayilar[i];
                }
            }
            MessageBox.Show("En küçük sayı: " + enKucukSayi);
        }
    }
}
