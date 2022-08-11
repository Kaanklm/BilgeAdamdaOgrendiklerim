using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MovieTheater
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Bir sonraki konuda aşağıdaki bilgiler Array (dizi) içerisinden daha ileride de bu bilgiler veritabanından alınacak.
        string userName = "bilgeadam";
        string password = "1234";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginFormUserName = txtUserName.Text.ToLower();
            string loginFormPassword = txtPassword.Text;

            switch (loginFormUserName)
            {
                case "bilgeadam":
                    switch (loginFormPassword)
                    {
                        case "1234":
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                            break;

                        default:
                            lblError.Text = "şifre yanlış";
                            break;
                    }
                    break;
                default:
                    lblError.Text = "kullanıcı adı yanlış";
                    break;

            }
        }
    }
}
