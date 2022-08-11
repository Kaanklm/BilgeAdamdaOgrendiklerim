using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PersonelEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Personel oluşturma (Basit yöntem)
            //Personel personel = new Personel();
            //personel.Ad = txtAd.Text;
            //personel.Soyad = txtSoyad.Text;
            //personel.Tckn = txtTckn.Text;
            //personel.DogumTarihi = dtpDogumTarihi.Value;
            //personel.IseGirisTarihi = dtpIseGirisTarih.Value;
            //personel.Adres = txtAdres.Text;
            //personel.Telefon = txtTelefon.Text; 
            #endregion

            Personel personel = new Personel();
            personel = PersonelOlustur(personel);

            ListViewItem lvi=ListViewItemDoldur(personel);
            listView1.Items.Add(lvi);
            Temizle();

        }

        //Personel Ekleme Metodu
        Personel PersonelOlustur(Personel p)
        {
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.Tckn = txtTckn.Text;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.IseGirisTarihi = dtpIseGirisTarih.Value;
            p.Adres = txtAdres.Text;
            p.Telefon = txtTelefon.Text;

            return p;
        }

        ListViewItem ListViewItemDoldur(Personel p)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = p.Tckn;
            lvi.SubItems.Add(p.Ad);
            lvi.SubItems.Add(p.Soyad);
            lvi.SubItems.Add(p.DogumTarihi.ToString());
            lvi.SubItems.Add(p.Telefon);
            lvi.SubItems.Add(p.Adres);
            lvi.SubItems.Add(p.IseGirisTarihi.ToString());
            lvi.Tag = p;//boxing
            return lvi;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //listView1.SelectedItems[0].Remove();

                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                }
            }
        }

        void Temizle()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
                else if(ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
                else if(ctrl is RichTextBox)
                {
                    RichTextBox txt = (RichTextBox)ctrl;
                    txt.Clear();
                }
            }
            txtTckn.Focus();
        }
        Personel secili;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            if (listView1.SelectedItems.Count > 0)
            {
               secili= (Personel)listView1.SelectedItems[0].Tag;
                txtAd.Text = secili.Ad;
                txtSoyad.Text = secili.Soyad;
                txtTckn.Text = secili.Tckn;
                txtTelefon.Text = secili.Telefon;
                txtAdres.Text = secili.Adres;
                dtpDogumTarihi.Value = secili.DogumTarihi;
                dtpIseGirisTarih.Value = secili.IseGirisTarihi;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili = PersonelOlustur(secili);
           int index= listView1.SelectedItems[0].Index;
            listView1.Items.RemoveAt(index);//bağlı bulunduğu satırın içini boşaltır. (Satırı Silmez!)
            listView1.Items.Insert(index, ListViewItemDoldur(secili));
        }
    }
}
