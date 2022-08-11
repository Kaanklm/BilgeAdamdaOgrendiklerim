using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sinifListesi = { "ABDULKADİR GÜL", "AHMET ALİBEŞE", "Ahmet Çavuş", "ALİ FIRAT KARDAŞ", "ALPER SARMAN", "BERKAY SARMAN", "BURCU ÖZCAN", "GÖKÇEN AKÇA", "GÖKHAN ERYALÇIN", "İBRAHİM BERKAY KAÇAR", "İREM BUSE PINAR", "KAAN KİLİM", "KADİR KENAN", "SALİM FARUK POLAT", "YASİN SAF" };
            
            foreach(string ogrenci in sinifListesi)
            {
                lstOgrenciler.Items.Add(ogrenci);
              
            }
        }
        string rastgeleOgrenci;
        int rastgele;
        private void btnGetir_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (lstOgrenciler.Items.Count > 0)
            {
                Random rnd = new Random();
                rastgele = rnd.Next(0, lstOgrenciler.Items.Count);
               rastgeleOgrenci = lstOgrenciler.Items[rastgele].ToString();
                lblOgrenci.Text = rastgeleOgrenci;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = sayac.ToString();
            if (sayac == 10)
            {
                lblSayac.BackColor = Color.Red;
            }
            else if (sayac == 0)
            {
                timer1.Stop();
               DialogResult dr = MessageBox.Show(rastgeleOgrenci, rastgeleOgrenci + " " + "Soruyu bildi mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstBilenler.Items.Add(string.Format("{0} {1}", rastgeleOgrenci, 5));
                    lstOgrenciler.Items.Remove(lstOgrenciler.Items[rastgele]);
                    
                }
                else
                {
                    lstBilemeyenler.Items.Add(string.Format("{0} {1}", rastgeleOgrenci, 0));
                    lstOgrenciler.Items.Remove(lstOgrenciler.Items[rastgele]);
                }



            }
        }
    }
}
