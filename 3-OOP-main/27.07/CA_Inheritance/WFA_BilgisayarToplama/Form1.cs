using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BilgisayarToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunListesi = new List<Urun>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Klavye
            Klavye klavye = new Klavye();
            klavye.Marka = "Logitech";
            klavye.Model = "G5";
            klavye.Tip = "Q";
            klavye.Fiyat = 750;

            Klavye klavye2 = new Klavye();
            klavye2.Marka = "Logitech";
            klavye2.Model = "G5";
            klavye2.Tip = "F";
            klavye2.Fiyat = 750;

            //Monitor
            Monitor monitor = new Monitor();
            monitor.Marka = "Samsung";
            monitor.Model = "Kafa1500";
            monitor.TepkimeSuresi = 1f;
            monitor.Fiyat = 2000;


            //Anakart
            Anakart anakart = new Anakart();
            anakart.Marka = "Msi";
            anakart.Model = "Yzl";
            anakart.SlotSayisi = 4;
            anakart.Fiyat = 500;

            //Islemci
            Islemci islemci = new Islemci();
            islemci.Marka = "Intel";
            islemci.Model = "I7";
            islemci.Fiyat = 2750;

            //Ekran Kartı
            EkranKarti ekranKarti = new EkranKarti();
            ekranKarti.Marka = "Nvidia";
            ekranKarti.Model = "Geforce ";
            ekranKarti.Fiyat = 3000;
            ekranKarti.Bellek = 16;

            //Guc Kaynağı
            GucKaynagi gucKaynagi = new GucKaynagi();
            gucKaynagi.Marka = "Armut";
            gucKaynagi.Marka = "asd";
            gucKaynagi.Guc = 1000;

            urunListesi.Add(klavye);
            urunListesi.Add(klavye2);
            urunListesi.Add(monitor);
            urunListesi.Add(anakart);
            urunListesi.Add(islemci);
            urunListesi.Add(ekranKarti);
            urunListesi.Add(gucKaynagi);

            foreach (Urun urun in urunListesi)
            {
                string format = string.Format("{0} {1}-{2}", urun.Marka, urun.Model, urun.Fiyat);
                if(urun is Klavye)
                {
                    lstKlavye.Items.Add(format);
                }
                else if(urun is Monitor)
                {
                    lstMonitor.Items.Add(format);
                }
                else if(urun is Anakart)
                {
                    lstAnaKart.Items.Add(format);
                    lstAnaKart.Tag = urun;
                }
                else if(urun is EkranKarti)
                {
                    lstEkranKart.Items.Add(format);
                }
                else if (urun is Islemci)
                {
                    lstIslemci.Items.Add(format);
                }
                else if (urun is GucKaynagi)
                {
                    lstGucKaynagi.Items.Add(format);
                }
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if (lstAnaKart.SelectedItems.Count > 0)
            {
                //string seciliAnakart=(string)lstAnaKart.SelectedItems[0];
                //string[] formatArray= seciliAnakart.Split('-');
                //MessageBox.Show(formatArray[1]);

                Urun anakart = (Urun)lstAnaKart.Tag;
                MessageBox.Show(anakart.Fiyat.ToString());

            }
        }
    }
}
