using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCarpimTablosu_Click(object sender, EventArgs e)
        {
            //1'den 10'a kadar çarpım tablosunu listbox'a yazdırın.
            //break point kullanarak yazdığınız kodları incelemeyi unutmayın!!!

            /*
             Çarpım Tablosu

            1x1=1
            1x2=2
            1x3=3
            1x4=4
            1x5=5
            1x6=6
            1x7=7
            1x8=8
            1x9=9
            1x10=10
            --------
            2x1=2
            2x2=4
            2x3=6
            2x4=8
            2x5=10
            2x6=12
            2x7=14
            2x8=16
            2x9=18
            2x10=20

             */


            for(int a=1; a<=10; a++)
            {
                for (int z = 1; z <= 10; z++)
                {
                    string format = string.Format("{0}x{1}={2}", a, z, a * z);
                    //listBox1.Items.Add(a+"x"+z+"="+a*z);
                    listBox1.Items.Add(format);
                }
                listBox1.Items.Add("--------------");
            }

        }
    }
}
