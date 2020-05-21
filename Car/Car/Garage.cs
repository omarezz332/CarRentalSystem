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
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void Garage_Load(object sender, EventArgs e)
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

        private void ADDC_Click(object sender, EventArgs e)
        {
            Garage1 d = new Garage1();
            d.Show();
            this.Hide();
        }

        private void EDITC_Click(object sender, EventArgs e)
        {
            Garage2 d = new Garage2();
            d.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
