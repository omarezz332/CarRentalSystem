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
    public partial class rent : Form
    {                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public rent()
    {
       
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = dateTimePicker1.MinDate.AddDays(30);
            Addc1.Enabled = false;
            button2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
          

        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button5.Visible = true;
            Addc1.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            dateTimePicker2.MaxDate = dateTimePicker2.MinDate.AddDays(30);
            check_date();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

           check_date();
        }

        private void check_date()
        {
            if (comboBox2.SelectedValue != null)
            {
                string sql = "check_date";
                con.Open();
                SqlCommand q = new SqlCommand("select name from car_details where car_id=@car ", con);
                q.Parameters.Add("@car", SqlDbType.Int).Value = comboBox2.SelectedValue;



                string name1 = q.ExecuteScalar().ToString();

                SqlCommand cmd1 = new SqlCommand("select car_id from car_owened where name=@name", con);
                cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = name1;

                string idd = cmd1.ExecuteScalar().ToString();


                // Create the command, setting the command text to be the stored procedure name


                SqlCommand cmd = new SqlCommand(sql, con);


                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                // Create the input/output/return paramenter





                cmd.Parameters.Add("@s_date", System.Data.SqlDbType.Date).Value = dateTimePicker1.Value;

                cmd.Parameters.Add("@e_date", System.Data.SqlDbType.Date).Value = dateTimePicker2.Value;
                cmd.Parameters.Add("@car_id", System.Data.SqlDbType.Int).Value = idd;
                cmd.Parameters.Add("@count", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;


                // Execute the command


                cmd.ExecuteNonQuery();





                // Get the values


                int retval = (int)cmd.Parameters["@count"].Value;
                if (retval == 1)
                {
                    Addc1.Enabled = false;
                    label1.Text = "rented before";
                }
                else
                {
                    label1.Text = "";
                    Addc1.Enabled = true;
                }








                con.Close();






            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                SqlCommand c = new SqlCommand("select status from car_details where car_id=@car_id", con);
                c.Parameters.Add("@car_id", SqlDbType.Int).Value = comboBox2.SelectedValue;
                con.Open();
                string status = c.ExecuteScalar().ToString();
                con.Close();
                if (status != "a")
                {
                    Addc1.Enabled = false;

                }
                else
                    Addc1.Enabled = true;

            }
            check_date();
        }

        private void rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet14.get_cars' table. You can move, or remove it, as needed.
            this.get_carsTableAdapter.Fill(this.carRentalDataSet14.get_cars);
            // TODO: This line of code loads data into the 'carRentalDataSet13.get_data_customer' table. You can move, or remove it, as needed.
            this.get_data_customerTableAdapter.Fill(this.carRentalDataSet13.get_data_customer);
            check_date();

        }

        private void ADDC_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void EDITC_Click(object sender, EventArgs e)
        {
            Repair d = new Repair();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select credit from customer where c_id=@c_id", con);
            cmd.Parameters.Add("@c_id", SqlDbType.Int).Value = comboBox1.SelectedValue;
            con.Open();
           object result = cmd.ExecuteScalar();
            if (result is DBNull)
            {
                textBox1.Visible = true;
                button7.Visible = true;
            }
            else
            {
                SqlCommand q = new SqlCommand("select name from car_details where car_id=@carr_id ", con);
                SqlCommand cmd1 = new SqlCommand("select car_id from car_owened where name=@name", con);
                q.Parameters.Add("@carr_id", SqlDbType.Int).Value = comboBox2.SelectedValue;
                
                string name1 = q.ExecuteScalar().ToString();
                cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = name1;
               
                string idd = cmd1.ExecuteScalar().ToString();
                con.Close();
                SqlCommand cmd2 = new SqlCommand("price @car_id,@s_date,@e_date,@price", con);
               
                cmd2.Parameters.Add("@car_id", SqlDbType.Int).Value = idd;
                cmd2.Parameters.Add("@s_date", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd2.Parameters.Add("@e_date", SqlDbType.DateTime).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                cmd2.Parameters.Add("@price", SqlDbType.Float).Direction = System.Data.ParameterDirection.Output;
                con.Open();
                cmd2.ExecuteNonQuery();
                   con.Close();
                button8.Visible = true;
                Addc1.Visible = false;
            }
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {


            SqlCommand c = new SqlCommand("select status from car_details where car_id=@car_id", con);
            SqlCommand q = new SqlCommand("select name from car_details where car_id=@car_id ", con);
            c.Parameters.Add("@car_id", SqlDbType.Int).Value = comboBox2.SelectedValue;
            q.Parameters.Add("@car_id", SqlDbType.Int).Value = comboBox2.SelectedValue;
            con.Open();
            string status = c.ExecuteScalar().ToString();
            string name1 = q.ExecuteScalar().ToString();
            con.Close();
            if (status == "a")
            {
                SqlCommand cmd1 = new SqlCommand("select car_id from car_owened where name=@name", con);
                cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = name1;
                con.Open();
                string idd = cmd1.ExecuteScalar().ToString();
                con.Close();
                SqlCommand cmd = new SqlCommand("rent @c_id, @car_id,@s_date,@e_date", con);
                cmd.Parameters.Add("@c_id", SqlDbType.Int).Value = comboBox1.SelectedValue;
                cmd.Parameters.Add("@car_id", SqlDbType.Int).Value = idd;
                cmd.Parameters.Add("@s_date", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@e_date", SqlDbType.DateTime).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("success");
                button8.Visible = false;
                Addc1.Visible = true;
                button3.Visible = false;
                button5.Visible = false;
                
                check_date();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand q = new SqlCommand("select name from car_details where car_id=@car_id ", con);
            SqlCommand cmd1 = new SqlCommand("select car_id from car_owened where name=@name", con);
            q.Parameters.Add("@car_id", SqlDbType.Int).Value = comboBox2.SelectedValue;
            con.Open();
            string name1 = q.ExecuteScalar().ToString();
            cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = name1;

            string idd = cmd1.ExecuteScalar().ToString();
            con.Close();
            SqlCommand cmd2 = new SqlCommand("price @car_id,@s_date,@e_date,@price", con);

            cmd2.Parameters.Add("@car_id", SqlDbType.Int).Value = idd;
            cmd2.Parameters.Add("@s_date", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cmd2.Parameters.Add("@e_date", SqlDbType.DateTime).Value = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            cmd2.Parameters.Add("@price", SqlDbType.Float).Direction = System.Data.ParameterDirection.Output;
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            button8.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insertcredit @c_id,@credit", con);
            cmd.Parameters.Add("@c_id", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd.Parameters.Add("@credit", SqlDbType.Decimal).Value =Convert.ToDecimal( textBox1.Text);
            con.Open();
               cmd.ExecuteNonQuery(); 
            con.Close();
            button3_Click( sender,  e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 14)
            {
                button7.Enabled = true;
            }
        }
    }
}
