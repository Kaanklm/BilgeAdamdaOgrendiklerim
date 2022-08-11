using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<User> userList = new List<User>();
        private void Form2_Load(object sender, EventArgs e)
        {

            //Alternatif 1 => Object initializer (Nesne oluşturulurken)
            User user1 = new User()
            {
                FirstName = "Fatih",
                LastName = "Günalp",
                Email = "a@a.com",
                Password = "1234",
                UserName="fatih",
                Role = Roller.Admin
            };

            //Alternatif 2=>Nesne oluşturulduktan sonra
            User user2 = new User();
            user2.FirstName = "İrem";
            user2.LastName = "Pınar";
            user2.Email = "b@b.com";
            user2.Password = "1234";
            user2.UserName = "irem";
            user2.Role = Roller.Customer;

            userList.Add(user1);
            userList.Add(user2);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (User user in userList)
            {
                switch (user.Role)
                {
                    case Roller.Admin:
                        MessageBox.Show("Admin paneline yönlendiriliyorsunuz!");
                        break;

                    case Roller.Customer:
                        MessageBox.Show("Müşteri paneline yönlendiriliyorsunuz!");
                        break;
                }
            }
        }
    }
}
