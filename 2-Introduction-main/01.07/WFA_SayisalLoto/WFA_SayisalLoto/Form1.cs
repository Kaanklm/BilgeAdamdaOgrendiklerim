using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnOyna_Click(object sender, EventArgs e)
        {
            /*
             buton tıklandığında form içerisinde bulunan bütün listboxlara 6 adet rakam eklenecek.
            eklenecek rakamlar 1-49 arasında rastgele seçilecek.
            aynı listbox içerisinde tekrar eden rakam bulunmayacak.
            butona her tıkladığımızda işlem baştan alınıp yeni rakamlar eklenecek.

             */

            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is ListBox)
                {
                    ListBox lst = (ListBox)ctrl;
                    lst.Items.Clear();
                    int sayac = 0;
                    while (sayac < 6)
                    {
                        int sayi = rnd.Next(1, 50);
                       
                        if (!lst.Items.Contains(sayi))
                        {
                            lst.Items.Add(sayi);
                            sayac++;
                        }
                    }
                }
            }
        }
    }
}
