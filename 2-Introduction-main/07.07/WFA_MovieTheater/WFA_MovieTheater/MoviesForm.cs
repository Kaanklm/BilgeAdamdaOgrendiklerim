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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            string[] salloons = { "A", "B", "C" };
            foreach (string salloon in salloons)
            {
                cmbSalon.Items.Add(salloon);
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] movies = AddMovie();
            ListViewItem lvi = new ListViewItem();
            for (int i=0; i<movies.Length; i++)
            {
                
                if (i == 0)
                {
                    lvi.Text = movies[i];
                }
                else
                {
                    lvi.SubItems.Add(movies[i]);
                }
                
            }
            listView1.Items.Add(lvi);
        }

        string[] AddMovie()
        {
            string movieName = txtFilmAdi.Text;
            string description = txtAciklama.Text;
            string duration = nudSure.Value.ToString();
            string director = txtYonetmenAd.Text;
            string salloon = cmbSalon.Text;
            string firstDate = dtpIlkHafta.Value.Day + " " + dtpIlkHafta.Value.Month + " " + dtpIlkHafta.Value.Year;
            string lastDate = dtpSonHafta.Value.Day + " " + dtpSonHafta.Value.Month + " " + dtpSonHafta.Value.Year;

            string[] movies = new string[6];
            movies[0] = movieName;
            movies[1] = description;
            movies[2] = duration;
            movies[3] = director;
            movies[4] = salloon;
            movies[5] = firstDate+" "+lastDate;

            return movies;

        }

    }
}
