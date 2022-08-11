using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Enumarator (Enum)
             
             Program içerisinde kullanılan sabitlerin anlamlandırılması için bir grup altında o sabitleri toplamamızı sağlayan yapıdır. (Numaralandırma)
             */


        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);

            Gunler gunAdi = (Gunler)i;
            MessageBox.Show(gunAdi.ToString());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);

            Gunler gunAdi = (Gunler)i;

            //Pazartesi: Nohut
            //Salı: Patlıcan Kebabı
            //Çarşamba: Adana Kebap
            //Perşembe: Lahmacun
            //Cuma: Pizza
            //Cumartesi: Kayseri Mantısı
            //Pazar: Balık

            switch (gunAdi)
            {
                case Gunler.Pazartesi:
                    MessageBox.Show("Nohut");
                    break;
                case Gunler.Salı:
                    MessageBox.Show("Patlıcan Kebabı");
                    break;
                case Gunler.Çarşamba:
                    MessageBox.Show("Adana Kebap");
                    break;
                case Gunler.Perşembe:
                    MessageBox.Show("Lahmacun");
                    break;
                case Gunler.Cuma:
                    MessageBox.Show("Pizza");
                    break;
                case Gunler.Cumartesi:
                    MessageBox.Show("Kayseri Mantısı");
                    break;
                case Gunler.Pazar:
                    MessageBox.Show("Balık");
                    break;

                default:
                    MessageBox.Show("Böyle bir gün yok");
                    break;

            }

        }
    }
}
