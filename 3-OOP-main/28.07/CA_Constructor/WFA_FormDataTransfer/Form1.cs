
using System.Windows.Forms;

namespace WFA_FormDataTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, System.EventArgs e)
        {
           
            Form2 frm2 = new Form2("Form2 yüklendi");
            frm2.Show();
        }
    }
}
