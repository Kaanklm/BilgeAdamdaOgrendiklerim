using System;
using System.Windows.Forms;
using System.Text; //UTF8Encoding kullanabilmek için.

//System.IO kütüphanesi
using System.IO;

namespace WFA_SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDirectoryExist_Click(object sender, EventArgs e)
        {
            //"C:\\Users\\Fatih\\Desktop\\Yazılım"
            if (Directory.Exists(@"C:\Users\Fatih\Desktop\Yazılım"))//belirtilen yolda klasör var mı yok mu kontrol eder.
            {
                MessageBox.Show("klasör mevcut!");
            }
            else
            {
                MessageBox.Show("klasör mevcut değil!");
            }
        }

        private void btnDirectoryDelete_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Users\Fatih\Desktop\Yazılım"))//belirtilen yolda klasör var mı yok mu kontrol eder.
            {
                Directory.Delete(@"C:\Users\Fatih\Desktop\Yazılım");
            }
            else
            {
                MessageBox.Show("klasör mevcut değil!");
            }
        }

        private void btnDirectoryCreate_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(@"C:\Users\Fatih\Desktop\Yazılım"))
            {
                MessageBox.Show("Zaten klasör mevcut!");
            }
            else
            {
                Directory.CreateDirectory(@"C:\Users\Fatih\Desktop\Yazılım");
                MessageBox.Show("Klasör oluşturuldu!");
            }
        }

        private void btnGetFiles_Click(object sender, EventArgs e)
        {
           string[] files= Directory.GetFiles(@"C:\Users\Fatih\Desktop\Yazılım");

            listBox1.Items.Clear();
            foreach (string file in files)
            {
               
                listBox1.Items.Add(file);
            }
        }

        private void btnFileCreate_Click(object sender, EventArgs e)
        {
            FileStream stream = File.Create(@"C:\Users\Fatih\Desktop\Yazılım\yzl3148.txt");
            MessageBox.Show("Dosya oluşturuldu!");

            string[] files = Directory.GetFiles(@"C:\Users\Fatih\Desktop\Yazılım");

            listBox1.Items.Clear();
            foreach (string file in files)
            {

                listBox1.Items.Add(file);
            }
        }

        private void btnFileWrite_Click(object sender, EventArgs e)
        {
            FileStream stream = File.Create(@"C:\Users\Fatih\Desktop\Yazılım\yzl3148.txt");

            Byte[] info = new UTF8Encoding(true).GetBytes("YZL3148 C# kursu...");//oluşturulan string tipteki metni GetBytes() ile ascii kdoları haline dönüştürüyoruz ve bir byte dizisi içerisine aktarıyoruz. Burada kullandığımız UTF8Encoding(true) ile Türkçe karakterlere destek vermesini sağlıyoruz.

            stream.Write(info, 0, info.Length);//byte şeklinde oluşturulan yazımızı (aslında ascii) write metodu ile dosyaya yazdırıyoruz.
            stream.Close();//yapılan yazma işlemini sonlandırmak için Close() metodu kullanıyoruz. Eğer Close() metodu ile sonlandırmazsak yazma işlemi devam eder.
            MessageBox.Show("dosya yazıldı!");

        }

        private void btnFileRead_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText(@"C:\Users\Fatih\Desktop\Yazılım\yzl3148.txt");
            MessageBox.Show(file);
        }
    }
}
