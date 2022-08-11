using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPMcAdam
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HamburgerMenu menu = new HamburgerMenu();
            menu.MenuAd = txtMenuAd.Text;
            menu.Fiyat = nudFiyat.Value;

            Form1.menuListesi.Add(menu);

            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
