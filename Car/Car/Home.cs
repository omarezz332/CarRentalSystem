using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            Car d = new Car();
            d.Show();
        }

        private void ex_Click(object sender, EventArgs e)
        {
            exep d = new exep();
            d.Show();
        }

        private void services_Click(object sender, EventArgs e)
        {
            Service d = new Service();
            d.Show();
        }

        private void garage_Click(object sender, EventArgs e)
        {
            Garage d = new Garage();
            d.Show();
           
        }
    }
}
