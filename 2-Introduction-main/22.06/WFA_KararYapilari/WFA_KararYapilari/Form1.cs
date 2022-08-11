using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            /*
             İlişkisel operatörler

            == (Karşılıklı iki değerin birbirine eşit olma durumu ) => sonuc bool
            != (Karşılıklı iki değerin birbirine eşit olmama durumu) => sonuc bool
            < (Soldaki değerin sağdaki değerden küçük olma durumu) => sonuc bool
            > (Soldaki değerin sağdaki değerden büyük olma durumu) => sonuc bool
            <= (oldaki değerin sağdaki değerden küçük veya eşit olma durumu) => sonuc bool
            >= (Soldaki değerin sağdaki değerden büyük veya eşit olma durumu) => sonuc bool
             */

            /*
             Mantıksal Operatörler
                && => Mutlak ve (operantın her iki tarafında kalan sonuçlardan biri bile false dönerse sonuç false tanımlanır.)
                || => Mutlak veya (operantın her iki tarafından dönen sonuçlardan biri bile true ise sonuç true döner.)
             */


            //textbox içerisine girilen değer "admin"  ise "hoşgeldin admin",
            //"moderatör" ise "hoşgeldin moderatör",

            //harici bir değer girilmişse "seni tanımıyorum" yazısını mesaj kutusunda gösterin.
            string gelenDeger = txtDeger.Text;

            //karar yapısı (if,else)

            if (gelenDeger == "admin")//sonuç true ise if bloğu içerisine girilecek. sonuç false ise else bloğu içerisine girilecek.
            {
                MessageBox.Show("hoşgeldin admin");
            }
            else if (gelenDeger=="moderatör")
            {
                MessageBox.Show("hoşgeldin moderatör");
            }
            else
            {
                MessageBox.Show("seni tanımıyorum!");
            }

           
        }
        
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //Eğer textbox'a girilen not 0'dan küçük ise "0'dan küçük bir not girişi yapamazsınız", 100'den büyük ise "100'den büyük bir not girişi yapamazsınız" uyarısnı mesaj kutusunda gösterin. Eğer girilen not 0 ile 100 arasında ise "doğru tanımlama" yazısını mesaj kutusunda gösterin.

            //try
            //{
            //    int gelenDeger = Convert.ToInt32(txtDeger.Text);

            //    if (gelenDeger < 0)
            //    {
            //        MessageBox.Show("0'dan küçük bir not girişi yapamazsınız");
            //    }
            //    else if (gelenDeger > 100)
            //    {
            //        MessageBox.Show("100'den büyük bir not girişi yapamazsınız");
            //    }
            //    else
            //    {
            //        MessageBox.Show("doğru tanımlama");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    listBox1.Items.Add(ex.Message+" "+txtDeger.Text);
            //}


            try
            {
                int gelenDeger = Convert.ToInt32(txtDeger.Text);
                if (gelenDeger > 0 && gelenDeger < 100)
                {
                    MessageBox.Show("doğru tanımlama");
                }
                else if (gelenDeger < 0)
                {
                    MessageBox.Show("0 dan küçük değer giremezsiniz!");
                }
                else
                {
                    MessageBox.Show("100'den büyük bir değer giremezsiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                listBox1.Items.Add(ex.Message + " " + txtDeger.Text);
            }


        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            //textbox'a girilen sayı çift ise mesaj kutusunda  "sayı çift" tek ise "sayı tek" mesajını gösterin.
            try
            {
                int gelenSayi = Convert.ToInt32(txtDeger.Text);
                if (gelenSayi % 2 == 0)
                {
                    MessageBox.Show("sayı çift");
                }
                else
                {
                    MessageBox.Show("sayı tek");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
