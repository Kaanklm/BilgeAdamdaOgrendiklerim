using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        //rastgele sayılar üretmek için Random nesnesinin örneğini (instance) alıyoruz.
        Random rnd = new Random();
        int sayac = 1;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Soru
            /*butona her tıklandığında form alanı içerisinde herhangi bir yerde yeni bir buton eklensin. her eklenen butonun arkaplan rengi farklı olsun. her eklenen butonun üzerinde buton numarası yazsın. tıklanan butonun numarası mesaj kutusunda gösterilsin.
             * 
             
             */
            //Color renk = Color.FromArgb(255,255,255);
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            //ilk olarak Button nesnesinin bir örneği (instance) alıyoruz.

            Button btn = new Button();

            //butonlara varsayılan bir genişlik bir de yükseklik veriyoruz.
            btn.Width = 90;
            btn.Height = 20;
            btn.Text = sayac.ToString();
            btn.Tag = "Örnek Yazı";

            //oluşturulan butonun arkaplan rengi rastgele olarak tanımlansın.
            btn.BackColor = Color.FromArgb(red, green, blue);
            //yatay alanda butonu bir alana dahil edebilmek için Form'un güncel boyutunu (ClientSize.Width) yakalayıp ardından butonun genişliğini (btn.width) çıkarıyoruz. Bu durumda ortaya çıkan fark ile buton yatayda formu taşmayarak formun içerisinde eklenecek.
            int x=rnd.Next(0, this.ClientSize.Width-btn.Width);
            //yukarıdaki işlemin aynısı dikey pozisyon için gerçekleştirildi.
            int y = rnd.Next(0, this.ClientSize.Height-btn.Height);

            //elde etmiş olduğumuz x değerini butonun soluna (Left) tanımlıyoruz.
            btn.Left = x;
            //elde etmiş olduğumuz y değerini butonun üstüne (Top) tanımlıyoruz.
            btn.Top = y;

            this.Controls.Add(btn);
            sayac++;

            btn.Click += Btn_Click;//runtime da event oluşturmak için Button nesnesinden alınan btn isimli instance'ı kullanarak += işleminin ardından TAB tuşuna basarak aşağıdaki Btn_Click olayı otomatik olarak tanımlandı.

           
        }

        //Aşağıdaki event tıklanan nesnenin bütün özelliklerini object sender içerisine gönderdi.
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//unboxing
            string gelenTag = btn.Tag.ToString();
            MessageBox.Show(gelenTag);
        }

        //ÖDEV 1
        /*
         Sayısal lotoyu runtime'da oluşturun.
         */

        //ÖDEV 2
        /*
         sınıfın mevcudu kadar runtime'da buton oluşturun. oluşturulan her bir butona index nuamrası yazdırın. tıklnan butonda rastgele bir öğrencinin adını mesaj kutusunda yazdırın.
         */
    }
}
