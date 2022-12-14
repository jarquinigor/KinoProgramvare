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
    public partial class FrmSnack : Form
    {
        SnackService snackService = new SnackService();
        public FrmSnack()
        {
            InitializeComponent();
        }
        private void PopulateSnackDataGridView()
        {
            dgSnacks.DataSource = snackService.GetAllSnacks();
        }
        private void PopulateComboBoxSize()
        {
            cboSize.Items.Add("Pequeño");
            cboSize.Items.Add("Mediano");
            cboSize.Items.Add("Grande");
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cboSize.Text != "" && txtPrice.Text!="" && snackService.ExistsSnackByNameSize(txtName.Text, cboSize.Text) == false)
            {
                Snack snack = new Snack();
                snack.Name = txtName.Text;
                snack.Size = cboSize.Text;
                snack.Price = Convert.ToDouble(txtPrice.Text);
                snack.FullName = txtName.Text + " " +cboSize.Text;
                MessageBox.Show(snackService.CreateSnack(snack));
                PopulateSnackDataGridView();
            }
            else
            {
                MessageBox.Show("Los datos de ese snack son incorrectos o ese snack ya está registrado. Por favor, inténtelo de nuevo.");
            }
        }
        private void FrmSnack_Load(object sender, EventArgs e)
        {
            PopulateComboBoxSize();
            PopulateSnackDataGridView();
            cboSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
