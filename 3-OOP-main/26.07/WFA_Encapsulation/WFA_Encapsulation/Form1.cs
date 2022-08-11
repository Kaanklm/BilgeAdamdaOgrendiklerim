using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] turler = { "spor", "klasik", "terlik" };
            foreach (string tur in turler)
            {
                cmbTur.Items.Add(tur);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.marka = txtMarka.Text;
            
            ayakkabi.Fiyat = nudFiyat.Value;
            ayakkabi.Numara = Convert.ToByte(nudNumara.Value);
            ayakkabi.Tur = cmbTur.Text;

            listBox1.Items.Add(string.Format("{0} {1} {2} {3}", ayakkabi.marka, ayakkabi.Tur, ayakkabi.Numara, ayakkabi.KdvDahilFiyat,ayakkabi.Renk));

        }
    }
}
