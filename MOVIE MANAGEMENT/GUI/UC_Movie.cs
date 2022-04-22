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
	        txtid.Enabled = false;	
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
            else dataGridView1.DataSource = MovieBLL.Instance.LoadSearchMovie(txt);
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
            if (check == false) movie.ID = Convert.ToInt32(txtid.Text);
            movie.Name = txtname.Text;
            movie.Genres = cbbgenres.Text;
            movie.Length = Convert.ToInt32(txtlength.Text);
            movie.Release = Convert.ToDateTime(dtrelease.Value.ToString());
            movie.Description = txtdescription.Text;
            movie.Image = ImagetoByteArray(picbox_imagemovie);
            return movie;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add = MovieBLL.Instance.Add(GetMovieInScreen(true));

            switch (add)
            {
                case "OK":
                    MessageBox.Show("ADD SUCCESSFUL");
                    ShowDGV();
                    break;
                default:
                    MessageBox.Show(add);
                    break;
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
                        id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    }
                    MovieBLL.Instance.Delete(id);
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
            cbbgenres.Text = "";
            txtdescription.Text = "";
            txtlength.Text = "";
            picbox_imagemovie.Image = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string update = MovieBLL.Instance.Update(GetMovieInScreen());
                switch (update)
                {
                    case "OK":
                        ShowDGV();
                        MessageBox.Show("UPDATE SUCCESSFUL");
                        break;
                    default:
                        MessageBox.Show(update);
                        break;
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

                    txtid.Text = row[0].ToString().Trim();
                    txtname.Text = row[1].ToString().Trim();
                    cbbgenres.Text = row[2].ToString().Trim();
                    txtdescription.Text = row[3].ToString().Trim();
                    txtlength.Text = row[4].ToString().Trim();
                    dtrelease.Value = Convert.ToDateTime(row[5].ToString());
                    try
                    {
                        picbox_imagemovie.Image = byteArrayToImage((byte[])row[6]);
                    }
                    catch { 

                    }
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
            Image image = Image.FromFile(file);
            picbox_imagemovie.Image = image;
        }
    }
}
