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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrder frmOrder = new FrmOrder();
            frmOrder.ShowDialog();
        }

        private void películaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovie frmMovie = new FrmMovie();
            frmMovie.ShowDialog();
        }

        private void snackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSnack frmSnack = new FrmSnack();
            frmSnack.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheater frmTheater = new FrmTheater();
            frmTheater.ShowDialog();
        }
    }
}
