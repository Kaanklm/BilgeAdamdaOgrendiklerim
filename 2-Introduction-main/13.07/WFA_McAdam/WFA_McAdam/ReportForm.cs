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

namespace WFA_McAdam
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            lblRevenue.Text = GetRevenue();
        }

        string GetRevenue()
        {
            //belirtilen yolda bulunan dosyanın içerisindeki bütün satırları dizi içerisine alın.
            //dizide dönerek sadece fiyatları temsil eden satırın değerini yakalayın.
            //yakalanan değerleri toplayarak bir değişkene aktarın.
            //değişkeni lblRevenue.Text'e yazdırın.
            string path = @"C:\Users\Fatih\Desktop\Hamburgerci";
            string file = @"\siparisler.txt";

           string[] orderLines= File.ReadAllLines(path + file);
            int count = 0;
            decimal[] prices = new decimal[orderLines.Length];

            for (int i = 4; i < orderLines.Length; i+=6 )
            {
                prices[count] = Convert.ToDecimal(orderLines[i]);
                count++;
            }

            decimal totalPrice = 0;
            foreach (decimal price in prices)
            {
                totalPrice += price;
            }
            return totalPrice.ToString();

        }
    }
}
