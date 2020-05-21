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
    public partial class Car1 : Form
    {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Car1()
        { 
            InitializeComponent();
            purchase_date.MaxDate = DateTime.Now;
           

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            Car2 d = new Car2();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Car1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet5.car_model' table. You can move, or remove it, as needed.
            this.car_modelTableAdapter.Fill(this.carRentalDataSet5.car_model);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            if (car_model.Text == "" || name.Text == "" || purchase_price.Text == "" || purchase_date.Text == "")
                MessageBox.Show("please fill all data");
            else if (year_of_prod.Text == "" || engine_size.Text == "" || num_of_pas.Text == "" || regesteration_num.Text == "")
                MessageBox.Show("please fill all data");
            else if (s.Text == "" || ins_type.Text == "" || fueltype.Text == "" || s.Text == "")
                MessageBox.Show("please fill all data");
            else
            {
              
                SqlCommand cmd = new SqlCommand(@"insert_car @car_model,@name,@purchase_price,@purchase_date,
@year_of_prod,@engine_size,@num_of_pas,@regesteration_num,@ins_num,@ins_type,@fueltype,@rent_price", con);
                cmd.Parameters.Add("@car_model", SqlDbType.Int).Value = car_model.SelectedValue;
                car_model.Text = "";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Text;
                name.Text = "";
                cmd.Parameters.Add("@purchase_price", SqlDbType.Int).Value = purchase_price.Text;
                purchase_price.Text = "";
                cmd.Parameters.Add("@purchase_date", SqlDbType.Date).Value = purchase_date.Text;
                purchase_date.Text = "";
                cmd.Parameters.Add("@year_of_prod", SqlDbType.Int).Value = year_of_prod.Text;
                year_of_prod.Text = "";
                cmd.Parameters.Add("@engine_size", SqlDbType.Int).Value = engine_size.Text;
                engine_size.Text = "";
                cmd.Parameters.Add("@num_of_pas", SqlDbType.Int).Value = num_of_pas.Text;
                num_of_pas.Text = "";
                cmd.Parameters.Add("@regesteration_num", SqlDbType.Int).Value = regesteration_num.Text;
                regesteration_num.Text = "";
                cmd.Parameters.Add("@ins_num", SqlDbType.Int).Value = ins_num.Text;
                ins_num.Text = "";
                cmd.Parameters.Add("@ins_type", SqlDbType.VarChar).Value = ins_type.Text;
                ins_type.Text = "";
                cmd.Parameters.Add("@fueltype", SqlDbType.VarChar).Value = fueltype.Text;
                fueltype.Text = "";
                cmd.Parameters.Add("@rent_price", SqlDbType.Float).Value = s.Text;
                s.Text = "";
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("ADD Sucessful");
            }
        }

        private void fueltype_TextChanged(object sender, EventArgs e)
        {

        }

        private void car_model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
