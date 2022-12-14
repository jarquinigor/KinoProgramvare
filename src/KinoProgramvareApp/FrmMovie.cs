using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoProgramvareApp
{
    public partial class FrmMovie : Form
    {
        private MovieService movieService = new MovieService();
        public FrmMovie()
        {
            InitializeComponent();
        }
        private void PopulateComboBoxes()
        {
            cboGenre.Items.Add("Acción");
            cboGenre.Items.Add("Ciencia Ficción");
            cboGenre.Items.Add("Comedia");
            cboGenre.Items.Add("Drama");
            cboGenre.Items.Add("Terror");
            cboGenre.Items.Add("Musical");
            cboGenre.Items.Add("Infantil");
            //
            cboRating.Items.Add("G-General Audiences");
            cboRating.Items.Add("PG-Parental Guidance Suggested");
            cboRating.Items.Add("PG-13-Parental Strongly Cauted");
            cboRating.Items.Add("R-Restricted");
            cboRating.Items.Add("NC-17-Adults Only");
        }
        private void PopulateMoviesDataGridView()
        {
            dgMovies.DataSource = movieService.GetAllMovies();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cboGenre.Text != "" && cboRating.Text != "" && movieService.ExistsMovieByName(txtName.Text) == false)
            {
                Movie movie = new Movie();
                movie.Name = txtName.Text;
                movie.Genre = cboGenre.Text;
                movie.Rating = cboRating.Text;
                MessageBox.Show(movieService.CreateMovie(movie));
                PopulateMoviesDataGridView();
            }
            else
            {
                MessageBox.Show("Los datos de esa película son incorrectos o esa película ya está registrado. Por favor, inténtelo de nuevo.");
            }
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            PopulateMoviesDataGridView();
            PopulateComboBoxes();
            cboGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRating.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
