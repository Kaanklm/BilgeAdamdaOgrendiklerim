using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Labirent
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;
        private void label2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kaybettiniz!");
        }
        //global alan
        private void label7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız!\n"+puan);
        }
        //global alan
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            lblOyuncuAd.Text = txtAd.Text;
            txtAd.Text = "";
            //txtAd.Text = string.Empty;
            //txtAd.Clear();
        }
        //global alan
        private void button1_MouseHover(object sender, EventArgs e)
        {
            //local alan
            
            button1.Visible = false;
            puan++;
            lblPuan.Text = puan.ToString();
          
        }
        //global alan
        private void button2_MouseHover(object sender, EventArgs e)
        {
            puan++;
            lblPuan.Text = puan.ToString();
            button2.Visible = false;
        }
        //global alan
        private void button3_MouseHover(object sender, EventArgs e)
        {
            puan++;
            lblPuan.Text = puan.ToString();
            button3.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            puan++;
            lblPuan.Text = puan.ToString();
            button4.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            puan++;
            lblPuan.Text = puan.ToString();
            button5.Visible = false;
        }

    }
}
