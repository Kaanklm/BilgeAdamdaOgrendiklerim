using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        /*
            
         */

        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();//Instance (Ornek alma) => bir nesnenin örneğini ram üzerine çıkarma.
        int oyuncuZar1;
        int oyuncuZar2;
        private void btnOyuncu1ZarAt_Click(object sender, EventArgs e)
        {
            
            //globalde tanımlanan oyuncuZar1'in içerisine rastgele bir sayı gönderiyoruz.
            oyuncuZar1 = rnd.Next(1, 7);
            lblOyuncuZar1.Text = oyuncuZar1.ToString();
            btnOyuncu1ZarAt.Enabled = false;
            btnOyuncu2ZarAt.Enabled = true;
        }

        private void btnOyuncu2ZarAt_Click(object sender, EventArgs e)
        {
            //globalde tanımlanan oyuncuZar2'in içerisine rastgele bir sayı gönderiyoruz.
            oyuncuZar2 = rnd.Next(1, 7);
            lblOyuncuZar2.Text = oyuncuZar2.ToString();
            btnOyuncu2ZarAt.Enabled = false;

            //Kazanma durumu

            if (oyuncuZar1 == oyuncuZar2)
            {
                lblSonuc.Text = "Oyun berabere!";
            }
            else if (oyuncuZar1 > oyuncuZar2)
            {
                lblSonuc.Text = "1. oyuncu kazandı!";
            }
            else
            {
                lblSonuc.Text = "2. oyuncu kazandı!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOyuncu2ZarAt.Enabled = false;
        }
    }
}
