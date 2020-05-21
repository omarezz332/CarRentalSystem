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
    public partial class Customer2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Customer2()
        {
            InitializeComponent();
        }

        private void addc2_Click(object sender, EventArgs e)
        {
            Customer1 c = new Customer1();
            c.Show();
            this.Hide();
        }

        private void editc2_Click(object sender, EventArgs e)
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

        private void button_Click(object sender, EventArgs e)
        {
            Customer d = new Customer();
            d.Show();
            this.Hide();
        }

        private void Customer2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerphone.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerphone.customer);
          
            
        
          

        }

        private void edc2_Click(object sender, EventArgs e)
        {
            if (combo.SelectedItem == null)
            {
                MessageBox.Show("please selected customer phone");

            }

            else
            {

                if (fisrt_name.Text == "" && last_name.Text == "" && address.Text == "" && phone.Text == "")
                    MessageBox.Show("please enter any edited data");

                else
                {
                    string x = fisrt_name.Text;
                    SqlCommand cmd = new SqlCommand("edit_customer @f_name ,@l_name ,@phone ,@phone_new,@address", con);
                    if(phone.Text!="") 
                    cmd.Parameters.Add("@phone_new", SqlDbType.VarChar).Value = phone.Text;
                    else
                     cmd.Parameters.Add("@phone_new", SqlDbType.VarChar).Value = combo.Text;
                    cmd.Parameters.Add("@f_name", SqlDbType.VarChar).Value = fisrt_name.Text;
                    cmd.Parameters.Add("@l_name", SqlDbType.VarChar).Value = last_name.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = combo.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Edit Successful");

                }

            }

            }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

   
        }
    }
