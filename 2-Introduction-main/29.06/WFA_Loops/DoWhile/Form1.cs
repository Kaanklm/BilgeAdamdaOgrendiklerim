using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Do While

            do while döngüsü while döngüsü ile aynı yapıya sahiptir. Tek farkı do while döngüsünde koşul ne olursa olsun en az bir kez işlem yapılır.

            While
            For
            Foreach
             */

            int sayi = 1;
            do
            {
                listBox1.Items.Add(sayi);
                sayi++;
            }
            while (sayi<=100);
        }
    }
}
