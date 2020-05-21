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
    public partial class Car2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");
        public Car2()
        {
            InitializeComponent();
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            Car1 d = new Car1();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car1 d = new Car1();
            d.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Car2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet4.car_delete' table. You can move, or remove it, as needed.
            this.car_deleteTableAdapter1.Fill(this.carRentalDataSet4.car_delete);
            

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"delete from car_details where car_id=@car",con);
            cmd.Parameters.Add("@car",SqlDbType.Int ).Value=comboBox1.SelectedValue;
           
                con.Open();
                cmd.ExecuteNonQuery();
                label1.Text = "Delete Successful";
                con.Close();
                this.car_deleteTableAdapter1.Fill(this.carRentalDataSet4.car_delete);
           
        }
    }
}
