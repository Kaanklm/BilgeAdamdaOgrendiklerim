using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region While
            //int sayi = 1;

            //while (sayi<=100)
            //{
            //    //işlem
            //    sayi++;
            //} 
            #endregion

            //For

            //Döngüye ilk giriş anında derleyici başlangıç değerine bakar ve bir daha asla bu bloğa uğramaz. bundan sonraki işlemler önce koşula bak sonra artır mantığı ile devam eder.
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }


        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //1000'den 1' doğru sayıları listbox'a ekleyin.
            for(int i=1000; i>=1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //butona tıklandığında a'dan z'ye alfabeyi listbox'a ekleyin.
            listBox1.Items.Clear();

            for(char i ='a'; i<='z'; i++)
            {
                //int kod = Convert.ToInt32(i);
                //listBox1.Items.Add("Harf: "+i+" Kod:"+kod);

                string result = string.Format("Harf kodu: {0} Harf: {1}", Convert.ToInt32(i), i);

                listBox1.Items.Add(result);
            }

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime tarih = DateTime.Now;

            //int yil = DateTime.Now.Year;
            //int gun = DateTime.Now.Day;
            //int ay = DateTime.Now.Month;

            //1945 - günümüz yılı arasındaki yılları listbox'a ekleyin. ancak herkes 1990 ile 1995 yıllarını dahil etmeyin.

            for(int i=1945; i<=tarih.Year; i++)
            {
                if(i!=1990 && i != 1995)
                {
                    listBox1.Items.Add(i);
                }
                
            }

        }
    }
}
