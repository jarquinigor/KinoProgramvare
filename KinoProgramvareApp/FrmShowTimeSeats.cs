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
    public partial class FrmShowTimeSeats : Form
    {
        private ShowTimeService showTimeService = new ShowTimeService();
        private SeatService seatService = new SeatService();
        private List<Button> buttons;
        private Button button;
        private int MovieId;
        private static int SelectedShowTimeId;
        private static int SelectedShowTimeTheaterId;
        private List<Seat> SelectedSeats = new List<Seat>();
        private static string SelectedSeatsNames;
        public FrmShowTimeSeats()
        {
            InitializeComponent();
        }
        public void CreateButtons()
        {
            int posX = 300;
            int posY = 70;
            int dx = 40;
            int dy = 30;
            buttons = new List<Button>();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (j == 1 || j == 12)
                    {
                        dx = 85;
                    }
                    else
                    {
                        dx = 40;
                    }
                    button = new Button();
                    button.Size = new Size(40, 25);
                    button.Location = new Point(posX, posY);
                    button.Click += btn_Click;
                    button.BackColor = Color.Green;

                    buttons.Add(button);
                    posX = posX + dx;
                }
                posX = 300;
                posY = posY + dy;
            }
        }
        public void GiveInformationToButtons()
        {
            foreach (var button in buttons)
            {
                button.Parent = null;
            }

            List<Seat> Seats = seatService.GetAllSeatsByShowTimeId(Convert.ToInt32(dgMovieShowTimes.CurrentRow.Cells["ShowTimeId"].Value));

            for (int i = 0; i < 225; i++)//butaca
            {
                for (int j = 0; j < 225; j++)//boton
                {
                    if (Seats[i].X == buttons[j].Location.X && Seats[i].Y == buttons[j].Location.Y && Seats[i].Status == "Ocupada")
                    {
                        buttons[j].Text = Seats[i].Letter + "-" + Seats[i].Number;
                        buttons[j].BackColor = Color.Red;
                        break;
                    }
                    if (Seats[i].X == buttons[j].Location.X && Seats[i].Y == buttons[j].Location.Y && Seats[i].Status == "Desocupada")
                    {
                        buttons[j].Text = Seats[i].Letter + "-" + Seats[i].Number;
                        buttons[j].BackColor = Color.Green;
                        break;
                    }
                }
            }
        }
        public void ShowButtons()
        {
            foreach (var button in buttons)
            {
                button.Parent = this;
            }
        }
        private void btn_Click(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Seat seat = seatService.GetSeatByXYSId(button.Location.X, button.Location.Y, Convert.ToInt32(dgMovieShowTimes.CurrentRow.Cells["ShowTimeId"].Value));  //ERROR ...!!! Y POR SHOWTIMEID

            seat.Flag = 1;
            if (seat.Flag == 1 && seat.Status == "Desocupada")
            {
                seat.Status = "Ocupada";
                button.BackColor = Color.Red;
                seat.Flag = 0;
            }
            if (seat.Flag == 1 && seat.Status == "Ocupada")
            {
                if (MessageBox.Show("¿Estás seguro de desocupar esta butaca?", "Desocupar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    seat.Status = "Desocupada";
                    button.BackColor = Color.Green;
                    seat.Flag = 1;
                }
            }
            Seat NewSeat = new Seat();
            NewSeat.SeatId = seat.SeatId;
            NewSeat.Letter = seat.Letter;
            NewSeat.Number = seat.Number;
            NewSeat.Status = seat.Status;
            NewSeat.X = seat.X;
            NewSeat.Y = seat.Y;
            NewSeat.Flag = seat.Flag;
            NewSeat.ShowTimeId = seat.ShowTimeId;
            seatService.UpdateSeat(NewSeat);
            ////

            SelectedSeats.Add(NewSeat);
        }
        private void PopulateDataGridView()
        {
            dgMovieShowTimes.DataSource = showTimeService.GetShowTimesByMovieId(MovieId);
        }
        public void SetMovieId(int movieId)
        {
            MovieId = movieId;
        }
        private void FrmShowTimeSeats_Load(object sender, EventArgs e)
        {
            CreateButtons();
            PopulateDataGridView();
        }

        private void dgMovieShowTimes_DoubleClick(object sender, EventArgs e)
        {
            if (dgMovieShowTimes.CurrentRow != null)
            {
                GiveInformationToButtons();
                ShowButtons();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un horario de función.");
            }
        }

        private void SelectShowTime_Click(object sender, EventArgs e)
        {
            SelectedSeatsNames="";
            List<Seat> ReservedSeats = SelectedSeats.Where(s => s.Status.Equals("Ocupada")).ToList<Seat>();
            //Me filtra los valores repetidos 
            List<Seat> uniqueList = ReservedSeats.GroupBy(s => s.SeatId).Select(g => g.First()).ToList();
            foreach (var seat in uniqueList)
            {
                SelectedSeatsNames = SelectedSeatsNames + seat.Letter + "-" + seat.Number + ", ";
            }
            ///
            SelectedShowTimeId = Convert.ToInt32(dgMovieShowTimes.CurrentRow.Cells["ShowTimeId"].Value);
            SelectedShowTimeTheaterId = Convert.ToInt32(dgMovieShowTimes.CurrentRow.Cells["TheaterId"].Value);
            MessageBox.Show("Se ha seleccionado un horario de función correctamente.");
        }
        public int GetSelectedShowTimeId()
        {
            return SelectedShowTimeId;
        }
        public int GetSelectedShowTimeTheaterId()
        {
            return SelectedShowTimeTheaterId;
        }
        public string GetSelectedSeatsNames()
        {
            return SelectedSeatsNames;
        }
    }
}
