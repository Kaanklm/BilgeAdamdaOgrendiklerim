using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listbox'ın içerisine 1'den 10'a kadar rakamları ekleyin.
            //listBox1.Items.Add("1");
            //listBox1.Items.Add(2);
            //listBox1.Items.Add(3);
            //listBox1.Items.Add(4);
            //listBox1.Items.Add(5);
            //listBox1.Items.Add(6);
            //listBox1.Items.Add(7);
            //listBox1.Items.Add(8);
            //listBox1.Items.Add(9);
            //listBox1.Items.Add(10);


            //Loop (Döngü)

            /*
                Hazırlamış olduğumuz programlarda bir işi birden fazla kez yapılası gereken durumlarda döngüler kullanılır.
                    C# içerisinde bize sunulan toplamda 4 adet döngü bulunmaktadır.

                1-While
                2-Do While
                3-For
                4-ForEach


             */

            //While döngüsünü kullanarak listbox1'in içerisine 1'den 1000'e kadar rakamları listeleyin.

            int count = 1;


            while(count<=1000)//true
            {

                listBox1.Items.Add(count);
                count++; //iterasyon

            }
           


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int gelenSayi = Convert.ToInt32(txtAdet.Text);//kullanıcıdan alınan sayı
            listBox1.Items.Clear();//listbox'ın temizlenmesi.

            int count = 1; //sayacın tanımlanması


            while (count <= gelenSayi)//döngü için koşulun kontrolü (koşulun sonucu true olduğu takdirde döngü içerisine yönlendirilecek.)
            {

                listBox1.Items.Add(count);//sayacın listbox'a eklenmesi
                count++; //iterasyon artışı

            }

        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            //1-100 arasındaki tek sayıların toplamını txtTekToplam'a cift sayıların toplamını txtCiftToplam'a yazdırın.
            int sayac = 1;
            int tekToplam = 0;
            int ciftToplam = 0;


            while (sayac <= 100)
            {
                if (sayac % 2 == 0)
                {
                    //çift
                    ciftToplam += sayac;
                }
                else
                {
                    //tek
                    tekToplam += sayac;
                }
                sayac++;
            }

            txtTekToplam.Text = tekToplam.ToString();
            txtCiftToplam.Text = ciftToplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnFaktoriyel tıklandığında 5'in faktöriyelini mesaj kutusunda gösterin.

            //1*2*3*4*5=120



            int deger = Convert.ToInt32(txtFaktoriyel.Text);
            int sonuc = 1;
            while (deger > 1)
            {
                sonuc *= deger;
                deger--;
            }

            MessageBox.Show(sonuc.ToString());

        }
    }
}
