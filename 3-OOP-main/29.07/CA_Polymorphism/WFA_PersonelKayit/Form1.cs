using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PersonelKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Personel> personelListesi = new List<Personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Personel personel1 = new Personel();
            personel1.Ad = "Fatih";
            personel1.Soyad = "Günalp";
            personel1.IseGirisTarihi = DateTime.Now;

            Personel personel2 = new Personel();
            personel2.Ad = "Ali";
            personel2.Soyad = "Kardaş";
            personel2.IseGirisTarihi = DateTime.Now;

            personelListesi.Add(personel1);
            personelListesi.Add(personel2);

            foreach (Personel p in personelListesi)
            {
                listBox1.Items.Add(p);
            }

        }
    }
}
