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
    public partial class FrmTheater : Form
    {
        private TheaterService theaterService = new TheaterService();
        public FrmTheater()
        {
            InitializeComponent();
        }
        private void PopulateDataGridViewTheaters()
        {
            dgTheaters.DataSource = theaterService.GetAllTheaters();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != "" && theaterService.ExistsTheaterByName("Sala " + txtNumber.Text) == false)
            {
                Theater theater = new Theater();
                theater.Name = "Sala " + txtNumber.Text;
                MessageBox.Show(theaterService.CreateTheater(theater));
                PopulateDataGridViewTheaters();
            }
            else
            {
                MessageBox.Show("Los datos de esa sala son incorrectos o ese sala ya está registrada. Por favor, inténtelo de nuevo.");
            }
        }

        private void FrmTheater_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewTheaters();
        }

        private void dgTheaters_DoubleClick(object sender, EventArgs e)
        {
            if (dgTheaters.CurrentRow.Index != -1)
            {
                FrmShowTime frmShowTime = new FrmShowTime();
                frmShowTime.SetTheater(Convert.ToInt32(dgTheaters.CurrentRow.Cells["TheaterId"].Value));
                frmShowTime.ShowDialog();
            }
        }
    }
}
