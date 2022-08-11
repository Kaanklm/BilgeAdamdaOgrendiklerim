using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_UrunYonetimi.Class;
using WFA_UrunYonetimi.Data;

namespace WFA_UrunYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Category category = new Category();
        Product product = new Product();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Category category in category.GetCategories())
            {
                cmbCategory.Items.Add(category);
            }


            if (product.GetProducts().Count > 0)
            {
                FillListBox();
            }
            else
            {
                listBox1.Items.Add("herhangi bir ürün eklenmemiş!");
            }

            foreach (Category c in Database.categories)
            {
                CheckBox chk = new CheckBox();
                chk.Text = c.CategoryName;
                chk.Tag = c;
                flowLayoutPanel1.Controls.Add(chk);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.UnitPrice = nudUnitPrice.Value;
            product.Category = (Category)cmbCategory.SelectedItem;
            string result = product.AddProduct(product);
            MessageBox.Show(result);
            FillListBox();
        }

        public void FillListBox()
        {
            listBox1.Items.Clear();
            foreach (Product product in product.GetProducts())
            {
                listBox1.Items.Add(product);
            }
        }

        private void rbLast_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = Database.products.Count-1; i >=0 ; i--)
            {
                listBox1.Items.Add(Database.products[i]);
            }
        }

        private void rbHighPrice_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Product product = new Product();
            product = Database.products[0];
            for (int i = 0; i <= Database.products.Count-1; i++)
            {
                if (Database.products[i].UnitPrice >= product.UnitPrice)
                {
                    product = Database.products[i];
                }
            }
            listBox1.Items.Add(product);

        }

        private void rbLowPrice_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Product product = new Product();
            product = Database.products[0];
            for (int i = 0; i <= Database.products.Count - 1; i++)
            {
                if (Database.products[i].UnitPrice <= product.UnitPrice)
                {
                    product = Database.products[i];
                }
            }
            listBox1.Items.Add(product);
        }
    }
}
