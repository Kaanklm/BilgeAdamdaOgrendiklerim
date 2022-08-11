using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();


        void AtlariKostur(int minValue, int maxValue)
        {
            #region Atları Koşturma
            pbAt1.Left += rnd.Next(minValue, maxValue);
            pbAt2.Left += rnd.Next(minValue, maxValue);
            pbAt3.Left += rnd.Next(minValue, maxValue);
            #endregion
        }

        void KazananAt(string at)
        {
            DialogResult dr = MessageBox.Show(at+"\nTekrar oynamak ister misin?", "Yarış Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                pbAt1.Left = 32;
                pbAt2.Left = 32;
                pbAt3.Left = 32;
            }
            else
            {
                Application.Exit();
            }
        }

        void KazanmaDurumu()
        {
            #region Kazanma Durumu
            if (pbAt1.Right >= lblFinish.Left)
            {

                timer1.Stop();
                //DialogResult => MessageBox.Show() metodu bize bir dialogresult tipi döndürür. Bu tip içerisinde belirlemiş olduğumuz butonların listesine ulaşabilmekteyiz. Bu sayede mesaj kutusunda tıklanan bir butona DialogResult sayesinde ulaşıp karar yapısı içerisinde kullanabiliriz.
                //MessageBox.Show()=> 1. parametre içeriği temsil eder. 2. parametre başlığı temsil eder. 3. parametre butonu temsil eder. 4. parametre ikonu temsil.

                KazananAt("1. at kazandı");

            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();

                KazananAt("2. at kazandı!");

            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();

                KazananAt("3. at kazandı!");
            }
            #endregion
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            /*
                Başlat tıklandığında picturebox'ın sol tarafına bir değer ataması gerçekleştirilerek pb'nin sağ'a doğru ilerlemesi sağlanır.

             */

            //pbAt1.Right = 10; //picture box nesnesinin sağına ve altına bir değer ataması gerçekleştirilemez. sadece tanımlı olan değer okunabilir.
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtlariKostur(50,100);

            KazanmaDurumu();


            //Spiker yapılacak.
        }
    }
}
