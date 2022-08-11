using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class MetotOrnek : Form
    {
        public MetotOrnek()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            foreach (Control ctrl in this.Controls)
            {
                //Textbox temizleme
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();

                }
                //checkbox temizle
                else if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                //radiobutton temizleme
                else if (ctrl is RadioButton)
                {
                    RadioButton rb = (RadioButton)ctrl;
                    rb.Checked = false;
                }
                //datetimepicker temizleme
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = ctrl as DateTimePicker;
                    dtp.Value = DateTime.Now;
                }
                //combobox temizleme
                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.Text = "";
                }
                //listbox temizleme
                else if (ctrl is ListBox)
                {
                    ListBox lst = ctrl as ListBox;
                    lst.SelectedIndex = -1;
                }
                //numericupdown temizleme
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 0;
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //kaydet butonuna tıklandığında veriler veritabanına kaydedilip ardından bütün kontroller temizlenecek.

            //veritabanı kayıt işlemi...
            Temizle();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
