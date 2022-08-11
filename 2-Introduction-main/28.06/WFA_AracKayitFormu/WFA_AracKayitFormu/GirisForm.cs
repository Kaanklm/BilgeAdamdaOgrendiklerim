using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKayitFormu
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kullanıcı adı: bilgeadam
            //şifre: 1234

            string userName = txtUserName.Text.ToLower();
            string password = txtPassword.Text;

            switch (userName)
            {
                case "bilgeadam":
                    switch (password)
                    {
                        case "1234":
                            //MessageBox.Show("giriş başarılı!");

                            AracEklemeForm aracEkle = new AracEklemeForm();
                            aracEkle.Show();
                            this.Hide();

                            break;
                        default:
                            lblError.Text = "şifre hatalı!";
                            break;
                    }
                    break;
                default:
                    lblError.Text = "kullanıcı adı hatalı!";
                    break;
            }
        }
    }
}
