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
    public partial class Metot2 : Form
    {

        public Metot2()
        {
            InitializeComponent();
        }

        void Topla(int sayi1)
        {
            int topla = 10 + sayi1;
            MessageBox.Show(topla.ToString());
        }

        //Overload
        void Topla(int sayi1,int sayi2)
        {
            int topla = sayi1 + sayi2;
            MessageBox.Show(topla.ToString());
        }

        void MesajVer(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        void ToplamaIslemi (int s1, int s2, string islem)
        {
            int toplam = s1 + s2;
            MessageBox.Show(islem + " " + toplam);
        }

        private void Metot2_Load(object sender, EventArgs e)
        {
            //Geriye değer döndürmeyen parametre alan metotlar

            //Topla(10);
            //Topla(10, 5);

            ToplamaIslemi(5, 3, "Toplama İşlemi");


        }

        private void btnTopla2_Click(object sender, EventArgs e)
        {
            int sayiBir = Convert.ToInt32(txtSayiBir.Text);
            int sayiIki = Convert.ToInt32(txtSayiIki.Text);

            Topla(sayiBir, sayiIki);
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            MesajVer("Hello World");
        }
    }
}
