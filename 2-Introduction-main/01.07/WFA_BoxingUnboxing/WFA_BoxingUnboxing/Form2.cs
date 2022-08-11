using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BoxingUnboxing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is ComboBox)
                {
                    ComboBox cmb =(ComboBox) ctrl;//unboxing
                    cmb.SelectedIndex = -1;
                }
                else if(ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;//unboxing
                    txt.Text = "";
                }
                else if(ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if(ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    rb.Checked = false;
                }
                else if(ctrl is NumericUpDown)
                {
                    NumericUpDown nud = ctrl as NumericUpDown;
                    nud.Value = 0;
                }
                else if(ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    dtp.Value = DateTime.Now;
                }
                else if(ctrl is ListBox)
                {
                    ListBox lst = ctrl as ListBox;
                    lst.SelectedIndex = -1;
                }
            }
        }
    }
}
