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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car1 d = new Car1();
            d.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            Car2 d = new Car2();
            d.Show();
            this.Hide();
        }

        private void EDITC_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_Click(object sender, EventArgs e)
        {
            Car_cateogry d = new Car_cateogry();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_car d = new Show_car("avaliable");
            d.Show();
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_car d = new Show_car("rent");
            d.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Show_car d = new Show_car("garage");
            d.Show();
            this.Hide();
        }
    }
}
