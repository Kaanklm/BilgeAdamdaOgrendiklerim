using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Basit işlem
            //HamburgerMenu hamburgerMenu = new HamburgerMenu();
            //hamburgerMenu.MdiParent = this;
            //hamburgerMenu.FormBorderStyle = FormBorderStyle.None;
            //hamburgerMenu.Width = this.Width-20;
            //hamburgerMenu.Height = this.Height-68;
            //hamburgerMenu.Show(); 
            #endregion
            HamburgerMenu hamburgerMenu = new HamburgerMenu();
            ChildForm(hamburgerMenu);
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ReportForm());
        }

        //Todo: aşağıdaki metodun çalışma yapısını inceleyin!!
        void ChildForm(Form _childForm)
        {
            
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 68;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.MdiParent = this;
                _childForm.Show();
            }


           
        }
    }
}
