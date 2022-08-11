using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_VizeFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vize;
        double final;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //vizenin %30'u
            //finalin %70'i

            //alınan not ortalaması,
            /*
                0   -   30 => FF
                31  -   50 => DD
                51  -   70 => CC
                71  -   85 => BB
                86  -   100=> AA

             */

            //harf notunu kullanıcıya mesaj kutusunda gösterin.
            #region Ahmet
            //try
            //{
            //    int vizeYuzde = 3 * Convert.ToInt32(txtVize.Text) / 10;
            //    int finalYuzde = 7 * Convert.ToInt32(txtFinal.Text) / 10;
            //    int ort = vizeYuzde + finalYuzde;
            //    txtVize.Clear();
            //    txtFinal.Clear();
            //    if (0 < ort && ort <= 30)
            //    {
            //        lblSonuc.Text = "FF";
            //    }
            //    else if (30 < ort && ort <= 50)
            //    {
            //        lblSonuc.Text = "DD";
            //    }
            //    else if (50 < ort && ort <= 70)
            //    {
            //        lblSonuc.Text = "CC";
            //    }
            //    else if (70 < ort && ort <= 85)
            //    {
            //        lblSonuc.Text = "BB";
            //    }
            //    else if (85 < ort && ort <= 100)
            //    {
            //        lblSonuc.Text = "AA";
            //    }
            //    else lblSonuc.Text = "Lütfen tekrar deneyiniz.";
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); } 
            #endregion

            #region Kadir
            //try
            //{
            //    vize = Convert.ToDouble(txtVize.Text);
            //    final = Convert.ToDouble(txtFinal.Text);
            //    double ort = ((vize * 30 / 100) + (final * 70 / 100));

            //    if (ort >= 0 && ort <= 30)
            //    {
            //        MessageBox.Show("Notunuz : " + ort + "  FF ALDINIZ!");
            //    }
            //    else if (ort > 30 && ort < 50)
            //    {
            //        MessageBox.Show("Notunuz : " + ort + "  DD ALDINIZ!");
            //    }
            //    else if (ort > 50 && ort <= 70)
            //    {
            //        MessageBox.Show("Notunuz : " + ort + "  CC ALDINIZ!");
            //    }
            //    else if (ort > 70 && ort <= 85)
            //    {
            //        MessageBox.Show("Notunuz : " + ort + "  BB ALDINIZ!");

            //    }
            //    else if (ort > 85 && ort <= 100)
            //    {
            //        MessageBox.Show("Notunuz : " + ort + "  AA ALDINIZ!");

            //    }
            //    else
            //    {
            //        MessageBox.Show("Girilen Notlar Hatalıdır!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //} 
            #endregion

            #region Burcu
            double vize = Convert.ToDouble(txtVize.Text);
            double final = Convert.ToDouble(txtFinal.Text);

            double ort = ((vize * 30) / 100) + ((final * 70) / 100);
            MessageBox.Show(ort.ToString());

            if (ort >= 0 && ort <= 30)
            {
                MessageBox.Show("FF");
            }
            else if (ort >= 31 && ort <= 50)
            {
                MessageBox.Show("DD");
            }
            else if (ort >= 51 && ort <= 70)
            {
                MessageBox.Show("CC");
            }
            else if (ort >= 71 && ort <= 85)
            {
                MessageBox.Show("BB");
            }
            else if (ort >= 86 && ort <= 100)
            {
                MessageBox.Show("AA");
            }
            else
            {
                MessageBox.Show("Lutfen vize ve final notlarinizi 0-100 arasi giris yapip tekrar deneyin...");
            } 
            #endregion

        }
    }
}
