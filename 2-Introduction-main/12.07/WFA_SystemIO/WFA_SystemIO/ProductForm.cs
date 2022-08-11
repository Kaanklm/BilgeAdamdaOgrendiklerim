using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_SystemIO
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        string[] categories = { "Beverages", "Condiments", "Diary Products", "Desserts" };
        string path = @"C:\Users\Fatih\Desktop\Product";
        string file = @"C:\Users\Fatih\Desktop\Product\products.txt";
        private void ProductForm_Load(object sender, EventArgs e)
        {
            foreach (string category in categories)
            {
                cmbCategory.Items.Add(category);
            }

            ReadFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (Directory.Exists(path))
            {
                
                if (File.Exists(file))
                {
                    WriteFile();
                    
                }
                else
                {
                    WriteFile();
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Klasör oluşturuldu");
            }
           ReadFile();
        }

        //Ürünü oluşturan geriye değer (string) dönen ve parametre alan metot.
        string SaveProduct(string _productName, decimal _unitPrice, short _unitsInStock, string _categoryName)
        {
            string product = string.Format("{0}\n{1}\n{2}\n{3}\n*******************",
                _productName, _unitPrice, _unitsInStock, _categoryName);

            return product;
        }


        //oluşturulan ürünü dosyaya yazan metot.
        void WriteFile()
        {
            string product = SaveProduct(txtProductName.Text, nudUnitPrice.Value, Convert.ToInt16(nudUnitsInStock.Value), cmbCategory.Text);
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(product);
            writer.Close();
            MessageBox.Show("Ürün kaydedildi!");
        }

        //aşağıdaki işlemi tamamlayın. belirtilen dosyanın içerisinde bulunan değerleri listview'da bulunan kolonlara ekleyin.
        void ReadFile()
        {
            listView1.Items.Clear();
           string[] products= File.ReadAllLines(file);
            for (int i = 0; i+4 < products.Length; i+=5)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = products[i];
                lvi.SubItems.Add(products[i + 1]);
                lvi.SubItems.Add(products[i + 2]);
                lvi.SubItems.Add(products[i + 3]);
                lvi.SubItems.Add(products[i + 4]);
                listView1.Items.Add(lvi);


            }
        }

    }
}
