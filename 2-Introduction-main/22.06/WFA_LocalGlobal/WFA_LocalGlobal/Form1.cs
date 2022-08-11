using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LocalGlobal
{
    public partial class Form1 : Form
    {
        /*
            Local ve Global Alanlar

            C#'ta oluşturmuş olduğumuz yapıların scope {} alanlarına göre erişeblirlik durumları vardır. Bunlara yaşam alanı denir. Bir event içerisinde tanımlanan bir değişkene başka bir event içerisinden erişemeyiz. Bir değişkene birden fazla event içerisinden ulaşmak istediğimizde değişkeni scope {} alanları dışında yani global alana tanımlamamız gerekmektedir.
         */
        public Form1()
        {
            InitializeComponent();
        }
        string gelenDeger;
        private void Form1_Load(object sender, EventArgs e)
        {
            //btnEkle tıklandığında txtDeger'in değeri silinecek.
            //btnGoster tıklandığında silinen değer label'da gösterilecek.
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            gelenDeger = txtDeger.Text;
            txtDeger.Clear();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lblDeger.Text = gelenDeger;
        }
    }
}
