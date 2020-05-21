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

    public partial class Customer1 : Form
    {           SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Customer1()
        {
            InitializeComponent();

        }

        private void ADDC_Click(object sender, EventArgs e)
        {
           
        }

        private void EDITC_Click(object sender, EventArgs e)
        {
            Customer2 d = new Customer2();
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

        private void button_Click(object sender, EventArgs e)
        {
            Customer d = new Customer();
            d.Show();
            this.Hide();
        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            if (fisrt_name.Text == "")
                MessageBox.Show("please enter firstName");
            else if (last_name.Text == "")
                MessageBox.Show("please enter lastName");
            else if (phone.Text == "")
                MessageBox.Show("please enter phone");
            else if (address.Text == "")
                MessageBox.Show("please enter address");
            else
            {




                try
                {
                    SqlCommand cmd = new SqlCommand("enter_customer @f_name,@l_name,@address,@phone", con);
                    cmd.Parameters.Add("@f_name", SqlDbType.VarChar).Value = fisrt_name.Text;
                    cmd.Parameters.Add("@l_name", SqlDbType.VarChar).Value = last_name.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Add Sucessful");


                }
                catch
                {
                    MessageBox.Show("error in DataBase");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cphc1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADC_Click(object sender, EventArgs e)
        {

        }

        private void last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void LC_Click(object sender, EventArgs e)
        {

        }

        private void fisrt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void FC_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
