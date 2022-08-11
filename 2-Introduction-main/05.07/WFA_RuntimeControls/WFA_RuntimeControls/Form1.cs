using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RuntimeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //for (int i = 0; i < 50; i++)
            //{
            //    Button btn = new Button();
            //    btn.Text = "Örnek "+(i+1);
            //    //this.Controls.Add(btn);
            //    flowLayoutPanel1.Controls.Add(btn);
            //}


            //FlowLayout panel oluşturma.
            FlowLayoutPanel flw = new FlowLayoutPanel();
            flw.Width = 776;
            flw.Height = 426;

            //oluşturulan FlowLayoutPanel nesnesini Form1'in içerisine ekliyoruz.
            this.Controls.Add(flw);

            //10 adet buton için 0 ile 10 arasında dönerek her döngüde bir adet buton oluşturup, oluşturulan butonu yukarıda Form1 içerisine dahil ettiğimiz flw (FlowLayoutPanel)'in içerisine ekliyoruz. aşağıdaki kodun başlangıcına break point bıraktığınızda işlemi detaylı olarak inceleyebilirsiniz.
            for(int i=0; i<10; i++)
            {
                Button btn = new Button();
                btn.Text = "Örnek " + (i + 1);
                flw.Controls.Add(btn);
            }



        }
    }
}
