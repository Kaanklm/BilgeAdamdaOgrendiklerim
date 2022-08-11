using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_OOPMcAdam.Tools;

namespace WFA_OOPMcAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hamburger Listesi
        public static List<HamburgerMenu> menuListesi = new List<HamburgerMenu>()
        {
            new HamburgerMenu{MenuAd="McAlaturca",Fiyat=25},
            new HamburgerMenu{MenuAd="McChicken",Fiyat=28},
            new HamburgerMenu{MenuAd="BigMc",Fiyat=30}
        };

        //Ekstra Listesi
        List<Ekstra> ekstraListesi = new List<Ekstra>()
        {
            new Ekstra{EkstraAd="Mayonez",Fiyat=2},
             new Ekstra{EkstraAd="Barbeku",Fiyat=2},
              new Ekstra{EkstraAd="Hardal",Fiyat=2},
               new Ekstra{EkstraAd="Buffalo",Fiyat=2.5m}
        };

        //Sipariş Listesi
        public static List<Siparis> siparisListesi = new List<Siparis>();


        private void Form1_Load(object sender, EventArgs e)
        {
            #region Uzun Yol
            //HamburgerMenu menu1 = new HamburgerMenu();
            //menu1.MenuAd = "McChicken";
            //menu1.Fiyat = 28;

            //HamburgerMenu menu2 = new HamburgerMenu();
            //menu2.MenuAd = "McAlaturca";
            //menu2.Fiyat = 25;

            //HamburgerMenu menu3 = new HamburgerMenu();
            //menu3.MenuAd = "BigMc";
            //menu3.Fiyat = 30; 

            //menuListesi.Add(menu1);
            //menuListesi.Add(menu2);
            //menuListesi.Add(menu3);
            #endregion

            //Hamburgerleri ComboBox'a ekleme
            foreach (HamburgerMenu menu in menuListesi)
            {
                cmbMenu.Items.Add(menu);
            }

            //Ekstraları flowlayoutpanel'e ekleme
            foreach (Ekstra ekstra in ekstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.EkstraAd;
                chk.Tag = ekstra;

                flowLayoutPanel1.Controls.Add(chk);
            }
            rbKucuk.Checked = true;
        }
        Siparis siparis = new Siparis();
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            //Combobox içerisine daha önce HambergerMenu tipini gönderdiğimiz için aşağıdaki işlemde seçili olan item'ı sipariş içerisinde bulunan SeciliMenu'ye aktarıyoruz. Ancak aktarma işlemini yaparken unboxing (cast) işlemini kullanıyoruz. Çünkü SelectedItem bize object tipini teslim etmekte.
            siparis.SeciliMenu = (HamburgerMenu)cmbMenu.SelectedItem;
            //
            if (rbKucuk.Checked)
            {
                siparis.Ebat = Ebat.Küçük;
            }
            else if (rbOrta.Checked)
            {
                siparis.Ebat = Ebat.Orta;
            }
            else
            {
                siparis.Ebat = Ebat.Büyük;
            }
            //aşğıda instance(örnek) almamızın sebebi ise Siparis isimli class içerisinde "List<Ekstra> Ekstralar" property olarak tanımlandığı için. Bu yüzden her siparişe ait ayrı bir Ekstra listesi oluşturmamız gerekmektedir.
            siparis.Ekstralar = new List<Ekstra>();
            //
            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    Ekstra seciliEkstra = (Ekstra)chk.Tag;
                    siparis.Ekstralar.Add(seciliEkstra);
                }
            }

            if (nudAdet.Value > 0)
            {
                siparis.Adet = Convert.ToInt32(nudAdet.Value);
            }
            else
            {
                MessageBox.Show("Adet 0 olamaz!");
            }

            siparis.TutarHesapla();
            siparisListesi.Add(siparis);
            listBox1.Items.Add(siparis);
            siparis = new Siparis();
            lblTutar.Text = Hesapla().ToString();
            Function.Temizle(this.Controls);
        }

        public decimal Hesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < siparisListesi.Count; i++)
            {
                Siparis gelenSiparis = siparisListesi[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }

            return toplamTutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Ücreti: {Hesapla()} siparişi tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                //siparisListesi.Clear();
                listBox1.Items.Clear();
                lblTutar.Text = "0 TL";
            }

            
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            MenuEkle menuEkle = new MenuEkle();
            menuEkle.Show();
        }
    }
}
