using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Car
{
    public partial class Repair : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Repair()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EDITC_Click(object sender, EventArgs e)
        {

        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            rent d = new rent();
            d.Show();
            this.Hide();
        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            int car_id, garage_id;
            car_id = (int)Car.SelectedValue;
            garage_id = (int)Garage.SelectedValue;
            string theDate = dateTimePicker1.Value.ToShortDateString();
            SqlCommand check_avilable = new SqlCommand("select status from car_details where car_id =" + car_id, conn);
            SqlCommand insert_Repair = new SqlCommand("execute add_repair  " + car_id + " , " + garage_id + " , " + textBox1.Text + " , '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'", conn);
            SqlCommand Edit_Car_stat = new SqlCommand("update car_details set status = 'g' where car_id =" + car_id, conn);

            conn.Open();
            string check = (string)check_avilable.ExecuteScalar();
            if (textBox1.Text == "")
                MessageBox.Show("please enter price first");
            else
            {
                if (check == "a")
                {
                    insert_Repair.ExecuteNonQuery();
                    Edit_Car_stat.ExecuteNonQuery();
                    MessageBox.Show("ADDED");
                }
                else if (check == "r")
                    MessageBox.Show("Car Is Already Rented");
                else if (check == "g")
                    MessageBox.Show("Car Is Already IN Garage");
               
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int car_id;

            car_id = (int)Car.SelectedValue;

            SqlCommand check_avilable = new SqlCommand("select status from car_details where car_id =" + car_id, conn);
            SqlCommand delete_repaired = new SqlCommand("delete from Repair_contracts where car_id =" + car_id, conn);
            SqlCommand Edit_Car_stat = new SqlCommand("update car_details set status = 'a' where car_id =" + car_id, conn);
            conn.Open();
            string check = (string)check_avilable.ExecuteScalar();
            if (check == "g")
            {
                delete_repaired.ExecuteNonQuery();
                Edit_Car_stat.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            else if (check == "r")
                MessageBox.Show("Car Is Already Rented");
            else if (check == "a")
                MessageBox.Show("Car Is Not At Garage");
            conn.Close();
        
        }

        private void Repair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet22.garage' table. You can move, or remove it, as needed.
            this.garageTableAdapter1.Fill(this.carRentalDataSet22.garage);
            // TODO: This line of code loads data into the 'carRentalDataSet21.car_details' table. You can move, or remove it, as needed.
            this.car_detailsTableAdapter1.Fill(this.carRentalDataSet21.car_details);
            // TODO: This line of code loads data into the 'carRentalDataSet19.car_owened' table. You can move, or remove it, as needed.
            this.car_owenedTableAdapter1.Fill(this.carRentalDataSet19.car_owened);
            // TODO: This line of code loads data into the 'carRentalDataSet18.car_owened' table. You can move, or remove it, as needed.
            this.car_owenedTableAdapter.Fill(this.carRentalDataSet18.car_owened);
            // TODO: This line of code loads data into the 'carRentalDataSet17.garage' table. You can move, or remove it, as needed.
            this.garageTableAdapter.Fill(this.carRentalDataSet17.garage);
            // TODO: This line of code loads data into the 'carRentalDataSet16.car_details' table. You can move, or remove it, as needed.
            this.car_detailsTableAdapter.Fill(this.carRentalDataSet16.car_details);

        }
    }
}
