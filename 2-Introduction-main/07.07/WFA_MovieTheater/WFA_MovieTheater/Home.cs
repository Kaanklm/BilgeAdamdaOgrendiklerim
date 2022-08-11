using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MovieTheater
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void filmListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.MdiParent = this;
            moviesForm.WindowState = FormWindowState.Maximized;
            moviesForm.Show();
        }
    }
}
