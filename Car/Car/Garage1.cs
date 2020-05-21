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
    public partial class Garage1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Garage1()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EDITC_Click(object sender, EventArgs e)
        {
            Garage2 d = new Garage2();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("enter_garage @namegarage,@adress,@phone,@range", con);
                cmd.Parameters.Add("@namegarage", SqlDbType.VarChar).Value = name.Text;
                cmd.Parameters.Add("@adress", SqlDbType.VarChar).Value = adress.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone.Text;
                cmd.Parameters.Add("@range", SqlDbType.VarChar).Value = range.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Sueccessful");
            }
            catch
            {
                MessageBox.Show("Add UNSueccessful");
            }
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

        private void range_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADC_Click(object sender, EventArgs e)
        {

        }

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void LC_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void FC_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADDC_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
