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
    public partial class Show_car : Form
    {
        public Show_car()
        {
            InitializeComponent();
        }
        public Show_car(string status)
        {
            InitializeComponent();
            Show( status);
        }

        private void Show(string status)
        {
            if (status == "avaliable")
            {
                avalibale_car.Visible = true;
            }
            else if (status == "rent")
            {
                rented.Visible = true;
            }
            else dataGridView1.Visible = true;
        }

        private void Show_car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet10.repair_cars' table. You can move, or remove it, as needed.
            this.repair_carsTableAdapter.Fill(this.carRentalDataSet10.repair_cars);
            // TODO: This line of code loads data into the 'carRentalDataSet9.rent_cars' table. You can move, or remove it, as needed.
            this.rent_carsTableAdapter.Fill(this.carRentalDataSet9.rent_cars);
            // TODO: This line of code loads data into the 'carRentalDataSet8.rent_contract' table. You can move, or remove it, as needed.
            this.rent_contractTableAdapter.Fill(this.carRentalDataSet8.rent_contract);
            // TODO: This line of code loads data into the 'carRentalDataSet6.car_details' table. You can move, or remove it, as needed.
            this.car_detailsTableAdapter.Fill(this.carRentalDataSet6.car_details);

        }

        private void rented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            avalibale_car.Visible = false;
            rented.Visible = false;
            dataGridView1.Visible = false;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
