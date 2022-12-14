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
    public partial class FrmShowTime : Form
    {
        private ShowTimeService ShowTimeService = new ShowTimeService();
        private MovieService movieService = new MovieService();
        private SeatService seatService = new SeatService();
        private int TheaterId;
        public FrmShowTime()
        {
            InitializeComponent();
        }
        public void SetTheater(int TheaterId)
        {
            this.TheaterId = TheaterId;
        }
        private void PopulateMovieComboBox()
        {
            cboMovies.DataSource = movieService.GetAllMovies();
            cboMovies.DisplayMember = "Name";
            cboMovies.ValueMember = "MovieId";
        }
        private void PopulateDataGridViewShowTimes()
        {
            dgShowTimes.DataSource = ShowTimeService.GetShowTimesByTheaterId(TheaterId);
        }

        private void FrmShowTime_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewShowTimes();
            cboMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateMovieComboBox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtHour.Text != "" && txtMinutes.Text != "" /*ShowTime.exists(DateTime)*/)
            {
                DateTime d = DateTime.Now;
                DateTime startTime = new DateTime(d.Year, d.Month, d.Day, Convert.ToInt32(txtHour.Text), Convert.ToInt32(txtMinutes.Text), 0);
                ShowTime showTime = new ShowTime();
                showTime.TheaterId = TheaterId;
                showTime.MovieId = Convert.ToInt32(cboMovies.SelectedValue);
                showTime.StartTime = startTime;
                ShowTimeService.CreateShowTime(showTime);
                ///CREAMOS LAS 225 BUTACAS EN EL HORARIO
                seatService.CreateSeats(showTime.ShowTimeId);///
                MessageBox.Show("Se registró un horario correctamente con todas sus butacas.");
                PopulateDataGridViewShowTimes();
            }
            else
            {
                /////
            }
        }
    }
}
