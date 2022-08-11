using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //oluştur butonuna tıklandığında nudSutun'un değeri kadar buton ve nudSatir'ın değeri kadar buton'u formun içerisine dahil edin.

            int x = Convert.ToInt32(nudSutun.Value);
            int y = Convert.ToInt32(nudSatir.Value);

            SatirveSutunOlustur(x, y);

        }

        void SatirveSutunOlustur(int _x, int _y)
        {
            for (int x = 0; x < _x; x++)
            {
                for (int y = 0; y < _y; y++)
                {
                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 20;
                    btn.Top = y * 20;
                    btn.Left = x * 90;
                    btn.Text = string.Format("{0}x{1}", x + 1, y + 1);

                    this.Controls.Add(btn);

                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
                {
                    GroupBox gb = (GroupBox)ctrl;
                    gb.Hide();
                }
            }
        }

    }
}
