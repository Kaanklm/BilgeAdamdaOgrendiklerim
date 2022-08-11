using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UrunYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kategori = { "Kitap", "Telefon" };

        Data data = new Data();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string kategori in kategori)
            {
                comboBox1.Items.Add(kategori);
            }

            ListBoxDoldur();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            switch (comboBox1.Text)
            {
                case "Kitap":
                    Kitap kitap = new Kitap();
                    kitap.Ad = textBox1.Text;
                    kitap.Fiyat = numericUpDown1.Value;
                    data.Kaydet(kitap);
                    ListBoxDoldur();

                    break;

                case "Telefon":
                    Telefon telefon = new Telefon();
                    telefon.Ad = textBox1.Text;
                    telefon.Fiyat = numericUpDown1.Value;
                    data.Kaydet(telefon);
                    ListBoxDoldur();
                    break;


            }
        }

        public void ListBoxDoldur()
        {
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is ListBox)
                {
                   
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                }
            }

            foreach (Urun urun in data.Listele())
            {
                if (urun is Kitap)
                {
                    lstKitap.Items.Add(urun);
                }
                else if (urun is Telefon)
                {
                    lstTelefon.Items.Add(urun);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kitap seciliKitap = new Kitap();
            Telefon seciliTelefon = new Telefon();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ListBox)
                {

                    ListBox lst = (ListBox)ctrl;
                    if (lst.SelectedItem != null)
                    {
                        object secili = lst.SelectedItem;
                        data.Sil((Urun)secili);
                    }
                }
            }
            ListBoxDoldur();
            
        }
    }
}
