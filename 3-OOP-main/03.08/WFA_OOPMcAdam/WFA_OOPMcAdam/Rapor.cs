using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPMcAdam
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraGelir = 0;
            int satisAdet = 0;
            int siparisSayisi = 0;

            foreach (Siparis siparis in Form1.siparisListesi)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra ekstra in siparis.Ekstralar)
                {
                    ekstraGelir += ekstra.Fiyat;
                }
                satisAdet += siparis.Adet;
            }
            siparisSayisi = Form1.siparisListesi.Count;

            lblCiro.Text = ciro.ToString();
            lblEkstraGelir.Text = ekstraGelir.ToString();
            lblSiparisSayisi.Text = siparisSayisi.ToString();
            lblUrunAdet.Text = satisAdet.ToString();
        }
    }
}
