using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class exep : Form
    {
        public exep()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet28.garage_contract' table. You can move, or remove it, as needed.
            this.garage_contractTableAdapter3.Fill(this.carRentalDataSet28.garage_contract);
            // TODO: This line of code loads data into the 'carRentalDataSet27.garage_contract' table. You can move, or remove it, as needed.
            this.garage_contractTableAdapter2.Fill(this.carRentalDataSet27.garage_contract);
            // TODO: This line of code loads data into the 'carRentalDataSet26.garage_contract' table. You can move, or remove it, as needed.
            this.garage_contractTableAdapter1.Fill(this.carRentalDataSet26.garage_contract);
            // TODO: This line of code loads data into the 'carRentalDataSet25.repair_cars' table. You can move, or remove it, as needed.
            this.repair_carsTableAdapter.Fill(this.carRentalDataSet25.repair_cars);
            // TODO: This line of code loads data into the 'carRentalDataSet24.Repair_contracts' table. You can move, or remove it, as needed.
            this.repair_contractsTableAdapter1.Fill(this.carRentalDataSet24.Repair_contracts);
            // TODO: This line of code loads data into the 'carRentalDataSet23.Repair_contracts' table. You can move, or remove it, as needed.
            this.repair_contractsTableAdapter.Fill(this.carRentalDataSet23.Repair_contracts);
            // TODO: This line of code loads data into the 'carRentalDataSet12.garage_contract' table. You can move, or remove it, as needed.
            this.garage_contractTableAdapter.Fill(this.carRentalDataSet12.garage_contract);
            // TODO: This line of code loads data into the 'carRentalDataSet11.rent_contract' table. You can move, or remove it, as needed.
            this.rent_contractTableAdapter.Fill(this.carRentalDataSet11.rent_contract);

        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            Rent.Visible = true;
            garage.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rent.Visible = false;
            garage.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rent.Visible = false;
            garage.Visible = false;
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void garage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
