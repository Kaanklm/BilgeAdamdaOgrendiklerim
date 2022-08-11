using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TryCatchSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //txtDeger'in içerisine yazılan değeri int'a çevirin.

            //çevirme işleminde eğer int değer aralığı aşılırsa label'da kullanıcıya uyarı mesajı gösterin. (Örn. int max değeri aşıldı.)

            //çevirme işleminde bir format hatası oluşursa label'da kullanıcıya uyarı mesajı gösterin. (Örn. girilen değer belirtilen format'a uymuyor.)

            //herhangi bir sorun yaşanmadan çeviri işlemi tamamlanırsa çevrilen değeri label'da gösterin.

            try
            {
               
                int gelenDeger = Convert.ToInt32(txtDeger.Text);
                lblDeger.Text = gelenDeger.ToString();
                int sonuc = gelenDeger / 0;
            }
            catch (OverflowException) //OverFlowException, değer aşımı hatası anlamına gelmektedir ve try içerisinde değişken tipinin min ve max değerleri aşıldığı zaman kod akışı buradan devam eder.
            {
                lblDeger.Text = "Int değerini aştınız!";
            }
            catch (FormatException)//FormatException, format hatası anlamında kullanılmaktadır ve try içerisinde belirtilen format hatalı oalrak yakalanmışsa kod akışı burdan devam eder.
            {
                lblDeger.Text = "Format hatası!";
            }
            catch (DivideByZeroException)//DivideByZeroException, sıfıra bölünme hatası anlamına gelmektedir. Eğer herhangi bir sayı 0'a bölünmeye çalışılırsa kod akışı buradan devam eder.
            {
                lblDeger.Text = "sıfıra bölünme hatası!";
            }
            catch (Exception ex)
            {
                lblDeger.Text = ex.Message;
            }




        }
    }
}
