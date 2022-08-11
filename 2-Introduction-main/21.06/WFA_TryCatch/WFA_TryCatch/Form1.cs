using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            //stackoverflow.com
            try
            {
                int sayiBir = Convert.ToInt32(textBox1.Text);
                int sayiIki = Convert.ToInt32(textBox2.Text);

                int sonuc = sayiBir / sayiIki;

                MessageBox.Show(sonuc.ToString());
            }
            //catch
            //{
            //    MessageBox.Show("Bir hata meydana geldi");
            //}
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
