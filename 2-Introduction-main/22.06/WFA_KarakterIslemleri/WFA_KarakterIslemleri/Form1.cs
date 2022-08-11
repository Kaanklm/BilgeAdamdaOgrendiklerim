using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KarakterIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int karakterSayisi=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblKarakter.Text = karakterSayisi.ToString();
            //karakter sayısı girilip onaylandıktan sonra txtDeger'in içerisine değer girilebilecek. aksi takdirde değer girişi yapılamayacak.
            txtDeger.Enabled = false;
        }

       
        private void txtDeger_TextChanged(object sender, EventArgs e)
        {
            #region Length
            //int karakterSayisi = txtDeger.Text.Length;//length,girilen değerin karakter sayısını teslim eder.
            //MessageBox.Show(karakterSayisi.ToString()); 
            #endregion

            int suanKacKarakterVar = txtDeger.Text.Length;
            int fark = karakterSayisi - suanKacKarakterVar;
            lblKarakter.Text = fark.ToString();

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            karakterSayisi = Convert.ToInt32(txtKarakterSayisi.Text);
            lblKarakter.Text = karakterSayisi.ToString();
            txtDeger.Enabled = true;
        }
    }
}
