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
    public partial class Car_Cateogry_2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Car_Cateogry_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Car_cateogry d = new Car_cateogry();
            d.Show();
            this.Hide();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select(count(*)) from car_model where name=@name ", con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = catname.Text;
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            if (count == 0)
            {
                cmd = new SqlCommand("insert into car_model values (@name)", con);
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = catname.Text;
                cmd.ExecuteNonQuery();
                catname.Text = "";
                label1.Text = "success";
                label1.ForeColor = Color.Red; ;
            }
            else
                label1.Text = "faild this name is exist";
            label1.ForeColor = Color.Red; ;
            con.Close();
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
