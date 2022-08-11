using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeIsmleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
                uygulama açıldığında bakiye 0 olarak form açılacak.
                kullanıcı bir hesap oluşturduktan sonra bakiye 500 olarak güncellenecek.
                txtHesapAdi pasif olacak.
                
                para çek isimli kutuda bulunan numeric up down'a girilen değer kadar bakiyeden düşülecek.
                para yatır isimli kutuda bulunan numeric up down'a girilen değer kadar bakiyeden eklenecek.

                yapılan bütün işlemler altta tanımlı olan listbox içerisine satır satır aşağıdaki formatta olduğu gibi eklenecek;
                    
                Hesap Adı: Fatih    çekilen tutar: 10   Bakiye: 490

             */
        }
    }
}
