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

        decimal bakiye = 0;
        decimal cekilen = 0;
        decimal yatirilan = 0;
        string hesapAdi;

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Ödev
            /*
                   uygulama açıldığında bakiye 0 olarak form açılacak.
                   kullanıcı bir hesap oluşturduktan sonra bakiye 500 olarak güncellenecek.
                   txtHesapAdi pasif olacak.

                   para çek isimli kutuda bulunan numeric up down'a girilen değer kadar bakiyeden düşülecek.
                   para yatır isimli kutuda bulunan numeric up down'a girilen değer kadar bakiyeden eklenecek.

                   yapılan bütün işlemler altta tanımlı olan listbox içerisine satır satır aşağıdaki formatta olduğu gibi eklenecek;

                   Hesap Adı: Fatih    çekilen tutar: 10   Bakiye: 490

                */
            #endregion

            lblBakiye.Text = bakiye.ToString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            bakiye = 500;
            lblBakiye.Text = bakiye.ToString();
            txtHesapAdi.Enabled = false;
            hesapAdi = txtHesapAdi.Text;

            lblHesapAdi.Text = "Hoşgeldin! " + hesapAdi;
        }

        private void btnParaCEk_Click(object sender, EventArgs e)
        {

            try
            {
                cekilen = Convert.ToDecimal(txtParaCek.Text);//10
                if (bakiye >= cekilen)
                {
                    bakiye -= cekilen;
                    lblBakiye.Text = bakiye.ToString();
                    listBox1.Items.Add("Hesap Adı: " + hesapAdi + " Çekilen Tutar: " + cekilen + " Bakiye: " + bakiye);
                }
                else
                {
                    MessageBox.Show("bakiyeniz yetersiz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtParaCek.Text = "";
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            try
            {

               
                yatirilan = Convert.ToDecimal(txtParaYatir.Text);
                if (yatirilan > 0)
                {
                    bakiye += yatirilan;
                    lblBakiye.Text = bakiye.ToString();
                    listBox1.Items.Add("Hesap Adı: " + hesapAdi + " Yatırılan Tutar: " + yatirilan + " Bakiye: " + bakiye);
                }
                else
                {
                    MessageBox.Show("En az 1 TL yükleyin!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtParaYatir.Text = "";
        }
    }
}
