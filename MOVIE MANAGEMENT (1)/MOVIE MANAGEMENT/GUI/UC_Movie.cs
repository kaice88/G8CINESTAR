using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class UC_Movie : UserControl
    {
        public UC_Movie()
        {
            InitializeComponent();
            ShowDGV();
        }
        private static string file = "";
        public void LoadComboboxMovieGenres()
        {
            cbbgenres.Items.Clear();
            foreach (string i in MovieBLL.Instance.GetListMovieGenres().Distinct())
            {
                cbbgenres.Items.Add(i.Trim());
            }
        }
        public void ShowDGV(string txt = "All")
        {
 	        LoadComboboxMovieGenres();
            if (txt == "All") dataGridView1.DataSource = MovieBLL.Instance.LoadAllMovie();
            else dataGridView1.DataSource = MovieBLL.Instance.LoadSearchMovie(txt.Trim());
        }
        public Image byteArrayToImage(byte[] image)
        {
            MemoryStream memoryStream = new MemoryStream(image, 0, image.Length);
            memoryStream.Write(image, 0, image.Length);
            //Exception occurs here
            return Image.FromStream(memoryStream, true); 
        }
        public Byte[] ImagetoByteArray(PictureBox picturebox) // doi kieu image sang byte[]
        {
            MemoryStream memoryStream = new MemoryStream();
            picturebox.Image.Save(memoryStream, picturebox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        public Movie GetMovieInScreen(bool check = false) // false: update, true: add
        {
            Movie movie = new Movie();
            if (check == false) movie.movie_id = Convert.ToInt32(txtid.Text);
            movie.movie_name = txtname.Text;
            movie.movie_genres_id = MovieGenresBLL.Instance.GetMovieGenreByMovieGenres(cbbgenres.Text);
            movie.movie_length = Convert.ToInt32(txtlength.Text);
            movie.movie_release = Convert.ToDateTime(dtrelease.Value.ToString());
            movie.movie_description = txtdescription.Text;
            movie.movie_image = ImagetoByteArray(picbox_imagemovie);
            movie.movie_price = Convert.ToInt32(txtprice.Text);
            return movie;
        }
        public string CheckScreen()
        {
            if (picbox_imagemovie.Image == null)
            {
                return "Invalid Movie image. Please enter movie image.";
            }
            else if(cbbgenres.SelectedIndex == -1)
            {
                return "Invalid Movie genres. Please choose movie genres.";
            }
            else if(txtname.Text == null)
            {
                return "Invalid Movie name. Please enter movie name.";
            }
            else if(txtdescription.Text == null)
            {
                return "Invalid Movie description. Please enter movie description.";
            }
            try
            {
                Convert.ToInt32(txtlength.Text);

            }
            catch (Exception)
            {
                return "Invalid Movie length. Please enter your movie length by number.";
            }
            try
            {
                Convert.ToInt32(txtprice.Text); ;

            }
            catch (Exception)
            {
                return "Invalid Movie price. Please enter your movie length by number.";
            }
            return "OK";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string check = CheckScreen();

            if (check != "OK") MessageBox.Show(check);
            else
            {
                MessageBox.Show(MovieBLL.Instance.Add(GetMovieInScreen(true)));
                ShowDGV();
            }
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
                        id.Add(Convert.ToInt32(row.Cells["movie_id"].Value.ToString()));
                    }
                    List<int> list_invalid_id = MovieBLL.Instance.Delete(id);
                    if (list_invalid_id.Count > 0)
                    {
                        string mes = "Movies with id: ";
                        for (int i = 0; i < list_invalid_id.Count; i++)
                        {
                            if (i == list_invalid_id.Count - 1) mes += list_invalid_id[i].ToString();
                            else mes += list_invalid_id[i].ToString() + ", ";
                        }
                        MessageBox.Show(mes + " can't be deleted because some unfinished schedules have this movie.");
                    }
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
            txtid.Text = "";
            txtname.Text = "";
            cbbgenres.SelectedIndex = 0;
            txtdescription.Text = "";
            txtlength.Text = "";
            picbox_imagemovie.Image = null;
            txtprice.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string check = CheckScreen();

                if (check != "OK") MessageBox.Show(check);
                else
                {
                    MessageBox.Show(MovieBLL.Instance.Update(GetMovieInScreen()));
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to update.");
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    picbox_imagemovie.Image = null;
                    DataRow row = MovieBLL.Instance.LoadMovieByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row["movie_id"].ToString().Trim();
                    txtname.Text = row["movie_name"].ToString().Trim();
                    if(row["movie_genres"].ToString().Trim() == "NULL")
                    {
                        cbbgenres.SelectedIndex = -1;
                    }
                    else cbbgenres.Text = row["movie_genres"].ToString().Trim();
                    txtdescription.Text = row["movie_description"].ToString().Trim();
                    txtlength.Text = row["movie_length"].ToString().Trim();
                    dtrelease.Value = Convert.ToDateTime(row["movie_release"].ToString());
                    txtprice.Text = row["movie_price"].ToString().Trim();
                    try
                    {
                        picbox_imagemovie.Image = byteArrayToImage((byte[])row["movie_image"]);
                    }
                    catch { }
                }
            }
        }
        public string GetFileNameofImage()
        {
            openFileDialog1.ShowDialog();
            return openFileDialog1.FileName.ToString();
        }
        private void btimage_Click(object sender, EventArgs e)
        {
            file = GetFileNameofImage();
            if (string.IsNullOrEmpty(file)) return;
            try
            {
                Image image = Image.FromFile(file);
                picbox_imagemovie.Image = image;
            }
            catch{ }
        }

        private void butGenres_Click(object sender, EventArgs e)
        {
            Form_MovieGenres f = new Form_MovieGenres();
            f.Show();
            f.d_LoadComboboxMovieGenres = new Form_MovieGenres.Mydel(LoadComboboxMovieGenres);
            f.d_ShowDGV = new Form_MovieGenres.Mydel1(ShowDGV);
        }

    }
}
