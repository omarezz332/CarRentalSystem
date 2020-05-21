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
    public partial class Car_cateogry : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=CarRental;Integrated Security=True");

        public Car_cateogry()
        {
            InitializeComponent();
        }

        private void Car_cateogry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDataSet1.car_model' table. You can move, or remove it, as needed.
            this.car_modelTableAdapter.Fill(this.carRentalDataSet1.car_model);
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row == dataGridView1.Rows[dataGridView1.Rows.Count - 1])
                    continue;
                row.Cells["NUM"].Value = i;
                i++;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            Car_Cateogry_2 d = new Car_Cateogry_2();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            SqlCommand cmd = new SqlCommand("delete from car_model where id=@id", con);
            con.Open();
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            con.Close();
            Car_cateogry_Load( sender,  e);

        }
    }
}
