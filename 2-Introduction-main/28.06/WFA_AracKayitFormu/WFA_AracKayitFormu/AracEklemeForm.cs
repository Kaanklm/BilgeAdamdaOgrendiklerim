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
    public partial class AracEklemeForm : Form
    {
        public AracEklemeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Markalar

            //cmbMarka.Items.Add("");
            cmbMarka.Items.Add("Volvo");
            cmbMarka.Items.Add("Audi");
            cmbMarka.Items.Add("BMW");

            //Modellere



        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aşağıdaki tanımlar combox içerisinde bize sunulan index numaralarını temsil etmektedir.
            //-1    => boş
            //0     => volvo
            //1     => Audi
            //2     => BMW

            cmbModel.Items.Clear(); //seçim yapıldığında cmbModel'in itemlerını temizliyoruz.
            string gelenMarka = cmbMarka.Text;

            switch (gelenMarka)//eğer cmbMarka.Text özelliği Volvo olarak seçilmişse aşağıdaki case işlemlerinden ilki (Volvo) devreye girerek cmbModel'in içerisine volvo'nun modelleri eklenecek. 
            {
                case "Volvo":
                    cmbModel.Items.Add("s60");
                    cmbModel.Items.Add("s90");
                    cmbModel.Items.Add("v40");
                    break;
                case "BMW":
                    cmbModel.Items.Add("3.20");
                    cmbModel.Items.Add("4.20");
                    cmbModel.Items.Add("5.20");
                    break;
                case "Audi":
                    cmbModel.Items.Add("A3");
                    cmbModel.Items.Add("A5");
                    cmbModel.Items.Add("A6");
                    break;

            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Instance (Örnek alma)

            //Class (sınıf)'ların örneği alınır.
            ListViewItem lvi = new ListViewItem();

            lvi.UseItemStyleForSubItems = false; //eğer Subitem (öğe) ların stillerine bir müdehale gerçekleştirmek istiyorsanız bu özellikle kesinlikle false tanımlanması lazım.


            lvi.Text = cmbMarka.Text;//0. kolon (Text özelliği listviewitem'ın her zaman ilk kolonunu temsil eder.)
            lvi.SubItems.Add(cmbModel.Text);//1. kolon
            lvi.SubItems.Add(cmbYakit.Text);//2. kolon
            lvi.SubItems.Add(cmbVites.Text);//3. kolon
            lvi.SubItems.Add(cmbKasaTip.Text);//4. kolon
            lvi.SubItems.Add("");//5.kolon
                                 //lvi.SubItems[5].Text = btnRenk.BackColor.Name;// rengin adını gönderir.
            lvi.SubItems[5].BackColor = btnRenk.BackColor;
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString());
            listView1.Items.Add(lvi);



        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)//
            {
                MessageBox.Show("silmek için araç seçin!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("aracı silmek istediğinize emin misiniz?", "araç silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    ListViewItem selected = listView1.SelectedItems[0];
                    listView1.Items.Remove(selected);
                }
                else
                {
                    MessageBox.Show("işlem iptal edildi!");
                }
            }

        }
    }
}
