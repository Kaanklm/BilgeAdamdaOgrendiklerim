using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string mevsim = txtDeger.Text.ToLower();
            //ToLower() => yazının tamamını küçük harf yapar.
            //ToUpper()=> yazının tamamını BÜYÜK harf yapar.

            #region If else
            //if (mevsim == "kış")
            //{
            //    MessageBox.Show("aralık,ocak,şubat");
            //}
            //else if (mevsim == "ilkbahar")
            //{
            //    MessageBox.Show("mart,nisan,mayıs");
            //}
            //else if (mevsim == "yaz")
            //{
            //    MessageBox.Show("haziran,temmuz,ağustos");
            //}
            //else if (mevsim == "sonbahar")
            //{
            //    MessageBox.Show("eylül,ekim,kasım");
            //}
            //else
            //{
            //    MessageBox.Show("böyle bir mevsim duymadım");
            //}
            #endregion

            switch (mevsim)//string
            {
                //birden fazla case kullanılabilir.
                case "kış":
                case "ayaz":
                case "soğuk":
                    MessageBox.Show("aralık,ocak,şubat");
                    break;
                    //break anahtar kelimesi kod akışının switch bloğunu terk etmesini sağlar.

                case "ilkbahar":
                    MessageBox.Show("mart,nisan,mayıs");
                    break;
                case "yaz":
                    MessageBox.Show("haziran,temmuz,ağustos");
                    break;
                case "sonbahar":
                    MessageBox.Show("eylül,ekim,kasım");
                    break;

                    //default anahtar kelimesi case içerisinde eşitlenmeyen değer yerine çalıştırılacak kdoları temsil eder. (if else işleminde else'in yapmış olduğu işlem!)
                default:
                    MessageBox.Show("böyle bir mevsim duymadım!");
                    break;
            }

        }
       
        private void btnRol_Click(object sender, EventArgs e)
        {
            //Eğer txtRol'e "Admin","Moderatör","Yönetici","Başkan" değerlerinden biri girilirtse "Yönetim paneline yönlendiriliyorsunuz" mesajını mesaj kutusunda gösterin.
            //"üye" girilirse "anasayfaya yönlendiriliyorsunuz",
            //harici bir değer girilirse "bu sayfayı görüntülemeye yetkiniz yok!"

            string rol = txtRol.Text.ToLower();
            string mesaj = "";

            switch (rol)
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "başkan":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz";
                    break;
                case "üye":
                    mesaj = "anasayfaya yönlendiriliyorsunuz";
                    break;
                default:
                    mesaj = "bu sayfayı görüntülemeye yetkiniz yok!";
                    break;

            }
            MessageBox.Show(mesaj);
        }

        private void txtGirisYap_Click(object sender, EventArgs e)
        {
            //kullanıcı adı: bilgeadam
            //şifre : 1234

            /*
                Eğer kullanıcı txtKullanıcı adına girilen değer "bilgeadam" ve txtSifreye girilen değer "1234" ise "Tebrikler hem kullanıcı adı hem de şifre doğru"
                //kullanıcı adı doğru şifre yanlışsa "kullanıcı adınız doğru ancak şifre yanlış"
                //kullanıcı adı yanlışsa "kullanıcı adınız yanlış şifreye bakmadım bile" 
                //uyarısını mesaj kutusunda gösterin.
             */
        }
    }
}
