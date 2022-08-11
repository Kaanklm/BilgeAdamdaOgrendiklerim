using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LoopKeywords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Döngü kaçış komutları
                //Break

           
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            //1'den 10'a kadar sayıları listbox'a yazdırın. ancak 5 olduğunda fazlası eklenmesin.

            //Bir döngü içerisinde koşullara sahipseniz ve bu koşullar sağlandığı takdirde döngüye devam etme gereği duymayacaksanız "break" anahtar kelimesiyle döngüyü sonlandırabilirsiniz.
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                    MessageBox.Show("bu mesaj kutusu kesinlikle görünmeyecek");
                }
            }
            MessageBox.Show("döngü sonlandırıldı!");




        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Döngü şartı sağlandığında kod akşınının bağlı bulunduğu metottan (olay/event) komple çıkmasını sağlar.

            for(int i=1; i<=10; i++)
            {
                if (i == 5)
                {
                    return;
                    MessageBox.Show("bu mesaj kutusu kesinlikle görünmeyecek");
                }
            }
            MessageBox.Show("döngü sonlandırıldı!");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //continue: döngü şartı sağlandığında kod akışını doğrudan iterasyona gönderir.


            listBox1.Items.Clear();
            Random rnd = new Random();

            for(int i=1; i<=10; i++)
            {
                int rastgeleSayi = rnd.Next(1, 50);

                if (listBox1.Items.Contains(rastgeleSayi))
                {
                    //MessageBox.Show(rastgeleSayi.ToString() + " daha önce eklenmiş");
                    i--;
                    continue;
                }
                listBox1.Items.Add(rastgeleSayi);

            }
        }
    }
}
