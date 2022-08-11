using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FormDataTransfer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string _value)
        {
            InitializeComponent();
            value = _value;
        }


        string value = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            lblTestValue.Text = value;
        }
    }
}
