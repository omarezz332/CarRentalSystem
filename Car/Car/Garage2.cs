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
    public partial class Garage2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Garage2()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            Garage1 d = new Garage1();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Garage2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet15.garage' table. You can move, or remove it, as needed.
            this.garageTableAdapter.Fill(this.carRentalDataSet15.garage);

        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("edit_garage1 @namegarage,@adress,@phone,@range", con);
            con.Open();
            cmd.Parameters.Add("@namegarage", SqlDbType.VarChar).Value = comboBox1.Text;
            cmd.Parameters.Add("@adress", SqlDbType.VarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@range", SqlDbType.Int).Value = textBox4.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("EDIT Sueccessful");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
