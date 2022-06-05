using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form_MovieGenres : Form
    {
        public delegate void Mydel();
        public Mydel d_LoadComboboxMovieGenres { get; set; }
        public delegate void Mydel1(string txt);
        public Mydel1 d_ShowDGV { get; set; }
        public Form_MovieGenres()
        {
            InitializeComponent();
            ShowDGV();
        }
        public MovieGenres GetMovieGenresInScreen(bool check = false) // false: update, true: add
        {
            MovieGenres MovieGenres = new MovieGenres();
            if (check == false) MovieGenres.movie_genres_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["movie_genres_id"].Value.ToString().Trim());
            MovieGenres.movie_genres = txtMovieGenres.Text;
            return MovieGenres;
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = MovieGenresBLL.Instance.LoadAllMovieGenres();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MovieGenresBLL.Instance.Add(GetMovieGenresInScreen(true)));
            ShowDGV();
        }

        private void gunaDelete_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "NOTIFICATION", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    }
                    MovieGenresBLL.Instance.Delete(id);
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtMovieGenres.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = MovieGenresBLL.Instance.LoadMovieGenresByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    txtMovieGenres.Text = row[1].ToString().Trim();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(MovieGenresBLL.Instance.Update(GetMovieGenresInScreen()));
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Please choose a row to update.");
            }
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            d_LoadComboboxMovieGenres();
            d_ShowDGV("All");
            Close();
        }
    }
}
