using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOPMcAdam.Tools
{
    public static class Function
    {
        //Temizleme

        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control ctrl in collection)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
                else if(ctrl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctrl;
                    Temizle(gb.Controls);
                }
                else if(ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    rb.Checked = false;
                    if (rb.Text == "Küçük")
                    {
                        rb.Checked = true;
                    }
                }
                else if(ctrl is CheckBox)
                {
                    CheckBox cb = (CheckBox)ctrl;
                    cb.Checked = false;
                }
                else if(ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if(ctrl is FlowLayoutPanel)
                {
                    FlowLayoutPanel flw = (FlowLayoutPanel)ctrl;
                    //Recursive
                    Temizle(flw.Controls);
                }
                else if(ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
            }
        }

    }
}
