using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Metot1 : Form
    {
        public Metot1()
        {
            InitializeComponent();
        }

        //Geriye değer döndürmeyen ve parametre almayan metot. Toplama İşlemi
        void Topla()
        {
            int sayiBir = 5;
            int sayiIki = 10;

            int toplam = sayiBir + sayiIki;

            MessageBox.Show(toplam.ToString());
        }

        //Geriye değer döndürmeyen ve parametre almayan metot. Toplama İşlemi
        void TxtTopla()
        {
            try
            {
                int sayiBir = Convert.ToInt32(txtSayiBir.Text);
                int sayiIki = Convert.ToInt32(txtSayiIki.Text);
                int toplam = sayiBir + sayiIki;

                MessageBox.Show(toplam.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Metotlar

            /*
               Bir program geliştirirken aynı kod bloklarını defalarca kullanmamız gereken durumlar olabilir. Yazdığımız bir kodu birden fazla yerde (event) kullanmak istediğimizde kullanacağımız her event içerisinde çalışmasını istediğimiz kod bloklarını yazmamız gerekecektir. Böyle durumlarda yazılımcı aynı kodları yazarken vakit kaybetmiş olacaktır. Aynı zamanda birden fazla yerde kullandığımız kodlara bir değişiklik yaptığımızda her yerde bu değişikliği yapmamız da gerekecektir. Bu tür durumlarda metotlar yardımımıza koşar. Biz birden fazla yerde kullanacağımız kodları tek bir yapı içerisinde toplarız. Bu yapıyı istediğimiz yerden çağırarak kullanabiliriz.

                Metotlar kullanım alanlarına göre ikiye ayrılır;

                    --Geriye değer döndüren metotlar.
                        --Parametre alan
                        --Parametre almayan
                    --Geriye değer döndürmeyen metotlar. (void)
                        --Parametre alan
                        --Parametre almayan

            Bir metot kesinlikle global alanlarda tanımlanır.

            Metotlar isimlendirilirken kesinlikle emir kipi kullanılmalı ve PascalCase tanımlanmalı.

            --Metotlar bize geliştirilebilir yapı sunar.
            --kod kalabalığını engeller
            --tek elden yönetim imkanı sağlar.
             */



        }

        

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Topla();
        }

        private void btnTopla2_Click(object sender, EventArgs e)
        {
            //ilgili textboxlardan alınan değerlerin toplamını mesaj kutusunda gösteren metodu yazın.
            TxtTopla();
        }
    }
}
