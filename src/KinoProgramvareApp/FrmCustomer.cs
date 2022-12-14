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
    public partial class FrmCustomer : Form
    {
        private CustomerService customerService = new CustomerService();
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtName.Text != "" && customerService.ExistsCustomerByDni(txtDni.Text) == false)
            {
                Customer customer = new Customer();
                customer.Name = txtName.Text;
                customer.dni = txtDni.Text;
                MessageBox.Show(customerService.CreateCustomer(customer));
            }
            else
            {
                MessageBox.Show("Los datos de ese cliente son incorrectos o ese cliente ya está registrado. Por favor, inténtelo de nuevo.");
            }
        }
        private void PopulateDataGridViewCustomers()
        {
            dgCustomers.DataSource = customerService.GetAllCustomers();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewCustomers();
        }
    }
}
