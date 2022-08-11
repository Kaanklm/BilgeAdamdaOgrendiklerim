using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //ForEach

            /*
                Koleksiyon Döngüsü

            //Kesinlikle iterasyon bulunmamaktadır.
            //Tip bağımlı döngüdür.

             */
            string[] sehirler = { "Yozgat", "Bayburt", "Burdur", "Uşak" };

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //123,54,876,4532,23,77,734,83,45,190

            //ikiye bölünenleri listbox1'e aktarın, ikiye bölünmeyenleri listbox2'e aktarın. Hem ikiye hem de üçe bölünenlerin kaç adet olduklarını mesaj kutusunda gösterin.

            int[] sayilar = { 123, 54, 876, 4532, 23, 77, 734, 83, 45, 190 };
            int count = 0;

            foreach(int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Hem ikiye hem de üçe bölünenlerin adedi: " + count);
        }
    }
}
