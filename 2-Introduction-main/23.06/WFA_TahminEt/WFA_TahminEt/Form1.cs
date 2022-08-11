using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int tutulanSayi = 0;
        int tahminHakki = 5;
        int seviye = 1;
        int carpan = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
                 Uygulama çalıştırıldığında (Form yüklendiğinde) arka planda 1 ile 10 arasıbda rastgele bir sayı tutulacak.

                 kullanıcı textbox'a bir rakam girecek.
                 Girilen rakam arkaplanda tutulan rakamdan küçük ise "lütfen daha büyük bir sayı girin" yazacak.
                 Girilen rakam arkaplanda tutulan rakamdan büyükse 
            "lütfen daha küçük bir sayı girin" yazacak.
                 yukarıdaki mesajlardan herhangi bir gösterildiğinde tahmin hakkı bir kez azaltılacak.
            tahmin hakkı 0 ise "oyunu kaybettiniz" yazacak. tahmin et butonu pasif olacak.
             textbox'a girilen sayı arkaplanda tutulan sayıya eşit ise "tebrikler bildiniz!" yazacak. ve seviye 1 kez artırılacak.
                 diğer oyunda arkaplanda tutulacak olan sayı 1 ile 20 arasında olacak.
             */
            tutulanSayi = rnd.Next(1, 11);
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            try
            {
                int tahminEdilenSayi = Convert.ToInt32(txtTahmin.Text);//5
                if (tahminHakki > 0)
                {
                    if (tutulanSayi==tahminEdilenSayi)
                    {
                        lblSonuc.Text = "Tebrikler Bildiniz";
                        seviye++;
                        lblSeviye.Text = seviye.ToString();
                       tutulanSayi=rnd.Next(1, carpan*seviye+1);
                       
                        tahminHakki = 5;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                    else if (tahminEdilenSayi < tutulanSayi)
                    {
                        lblSonuc.Text = "lütfen daha büyük bir sayı girin";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();
                    }
                    else
                    {
                        lblSonuc.Text = "lütfen daha küçük bir sayı girin";
                        tahminHakki--;
                        lblTahminHakki.Text = tahminHakki.ToString();

                    }
                }
                else
                {
                    btnTahminEt.Enabled = false;
                    MessageBox.Show("Tahmin hakkınız bitti!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
