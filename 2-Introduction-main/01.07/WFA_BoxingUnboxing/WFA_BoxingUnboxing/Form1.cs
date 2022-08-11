using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BoxingUnboxing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Boxing And Unboxing

            //Primitive Types
            int sayi = 5;

            object nesne = 5; //boxing

            //if (nesne.GetType() == typeof(int))
            //{
            //    MessageBox.Show("tip int");
            //}
            //else
            //{
            //    MessageBox.Show("tip int değil!");
            //}

            int sayi2 = Convert.ToInt32(nesne);

            //Cast (Rica)

            int sayiCast = (int)nesne;

            //boxing
            object nesne1 = "Fatih";
            object nesne2 = 1.25f;
            object nesne3 = 'c';//nesne
            object nesne4 = true;

            //unboxing
            string isim=(string)nesne1; //cast
            float ondalikliDeger=(float)nesne2;
            char karakter = (char)nesne3;//unboxing
            int karakterDegeri = (int)karakter;
            int intNesne = (int)nesne;
            string stringNesne = intNesne.ToString();

            string stringNesne2 = nesne2.ToString();
          //MessageBox.Show(stringNesne2 +" "+ stringNesne2.GetType());

          
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //Form içerisinde kullanılan her şey özünde birer control'dür. bu yüzden aşağıdaki foreach döngüsünde butonun bağlı bulunduğu (this.Controls) yerdeki bütün controllerde dönmesini ve her defasında bize bir Control tipi teslim edeceğini söyledik.
            foreach(Control ctrl in this.Controls)
            {
                //bize teslim edilen control eğer button ise o butonun spesifik özelliklerine ulaşmak için karar yapısı kullanıldı.
                if(ctrl is Button)
                {
                    if (ctrl.Name != "btnRenkDegistir")
                    {
                        ctrl.BackColor = Color.Red;
                    }
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
           
        }
    }
}
