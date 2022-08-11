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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global
        decimal sayiBir=0;
        decimal sayiIki=0;
        decimal sonuc = 0;

        private void btnTopla_Click(object sender, EventArgs e)
        {
            #region Eski
            //?
            //decimal sayiBir = nudToplamSayiBir.Value;
            //decimal sayiIki = nudToplamSayiIki.Value;

            //decimal sonuc = sayiBir + sayiIki;
            //lblToplam.Text = sonuc.ToString(); 
            #endregion
            //local
            sayiBir = nudToplamSayiBir.Value;
            sayiIki = nudToplamSayiIki.Value;
            sonuc = sayiBir + sayiIki;
            lblToplam.Text = sonuc.ToString();
        }

        private void btnFark_Click(object sender, EventArgs e)
        {
            #region Eski
            //decimal sayiBir = nudFarkSayiBir.Value;
            //decimal sayiIki = nudFarkSayiIki.Value;

            //decimal sonuc = sayiBir - sayiIki;

            //lblFark.Text = sonuc.ToString(); 
            #endregion
            sayiBir = nudFarkSayiBir.Value;
            sayiIki = nudFarkSayiIki.Value;
            sonuc = sayiBir - sayiIki;
            lblFark.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayiBir = nudCarpimSayiBir.Value;
            sayiIki = nudCarpimSayiIki.Value;
            sonuc = sayiBir * sayiIki;
            lblCarpim.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            sayiBir = nudBolumSayiBir.Value;
            sayiIki = nudBolumSayiIki.Value;
            sonuc = sayiBir / sayiIki;
            lblBolum.Text = sonuc.ToString();
        }
    }
}
