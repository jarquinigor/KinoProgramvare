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
    public partial class FrmOrder : Form
    {
        private Order_SnackService Order_SnackService = new Order_SnackService();
        private OrderService orderService = new OrderService();
        private CustomerService customerService = new CustomerService();
        private MovieService movieService = new MovieService();
        private SnackService snackService = new SnackService();
        private List<Snack> Snacks = new List<Snack>();
        private double TotalSnacks; //Monto
        private double TotalTickets; //Monto
        public FrmOrder()
        {
            InitializeComponent();
        }
        private void PopulateSnackComboBox()
        {
            cboSnack.DataSource = snackService.GetAllSnacks();
            cboSnack.DisplayMember = "FullName";
            cboSnack.ValueMember = "SnackId";
        }
        private void PopulateDataGridViews()
        {
            dgOrders.DataSource = orderService.GetAllOrders();
            dgCustomers.DataSource = customerService.GetAllCustomers();
            dgMovies.DataSource = movieService.GetAllMovies();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Clear();
            cboSnack.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateDataGridViews();
            PopulateSnackComboBox();
        }

        private void btnAddSnacks_Click(object sender, EventArgs e)
        {
            if (cboSnack.SelectedItem != null && txtCantidad.Text != "")
            {
                dgSnacks.DataSource = null;
                Snack snack = new Snack();
                snack = snackService.GetSnackById(Convert.ToInt32(cboSnack.SelectedValue));
                Snacks.Add(snack);
                TotalSnacks = TotalSnacks + (snack.Price * Convert.ToInt32(txtCantidad.Text));
                dgSnacks.DataSource = Snacks;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese la cantidad del Snack que desee comprar correctamente.");
            }
        }

        private void dgMovies_DoubleClick(object sender, EventArgs e)
        {
            if (dgMovies.CurrentRow.Index != -1)
            {
                FrmShowTimeSeats frmShowTimeSeats = new FrmShowTimeSeats();
                frmShowTimeSeats.SetMovieId(Convert.ToInt32(dgMovies.CurrentRow.Cells["MovieId"].Value));
                frmShowTimeSeats.ShowDialog();
            }
        }
        private void Clear()
        {
            txtAdultosMayores.Text = "0";
            txtEntradasGenerales.Text = "0";
            txtNinosMenores.Text = "0";
            txtNiños.Text = "0";
            txtCantidad.Text = "0";
            TotalSnacks = 0;
            TotalTickets = 0;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (txtAdultosMayores.Text != "" && txtEntradasGenerales.Text != "" && txtNinosMenores.Text != "" && txtNiños.Text != ""
                && MessageBox.Show("¿Está seguro de realizar esta compra?", "Comprar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                FrmShowTimeSeats frmShowTimeSeats = new FrmShowTimeSeats();
                Order order = new Order();
                order.CustomerId = Convert.ToInt32(dgCustomers.CurrentRow.Cells["CustomerId"].Value);
                order.Seats = frmShowTimeSeats.GetSelectedSeatsNames();
                order.TheaterId = frmShowTimeSeats.GetSelectedShowTimeTheaterId();
                order.ShowTimeId = frmShowTimeSeats.GetSelectedShowTimeId();
                order.MovieId = Convert.ToInt32(dgMovies.CurrentRow.Cells["MovieId"].Value);
                if (txtCreditCard.Text != "")
                {
                    order.CreditCard = txtCreditCard.Text;
                }
                order.Tickets = Convert.ToInt32(txtAdultosMayores.Text) + Convert.ToInt32(txtEntradasGenerales.Text) + Convert.ToInt32(txtNinosMenores.Text)
                    + Convert.ToInt32(txtNiños.Text);
                TotalTickets = Convert.ToInt32(txtAdultosMayores.Text) * 0 + Convert.ToInt32(txtEntradasGenerales.Text) * 13
                    + Convert.ToInt32(txtNiños.Text) * 8 + Convert.ToInt32(txtNinosMenores.Text) * 0;
                order.TotalAmount = TotalSnacks + TotalTickets;
                orderService.CreateOrder(order);
                ///
                foreach (var snack in Snacks)
                {
                    Order_Snack order_Snack = new Order_Snack();
                    order_Snack.OrderId = order.OrderId;
                    order_Snack.SnackId = snackService.GetSnackIdByNameSize(snack.Name, snack.Size);
                    Order_SnackService.CreateOrder_Snack(order_Snack);
                }
                dgOrders.DataSource = orderService.GetAllOrders();
                Clear();
                Snacks.Clear();
                dgSnacks.DataSource = null;
                MessageBox.Show("Se ha realizado una compra correctamente.");
            }
            else
            {
                MessageBox.Show("Hubo un error en el registro de la compra. Por favor, verifique que los campos de tickets y el horario se hayan ingresado correctamente.");
            }
        }
    }
}
