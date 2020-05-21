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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
            button6.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void Addc1_Click(object sender, EventArgs e)
        {
            rent d = new rent();
            d.Show();
            this.Hide();
        }

        private void ADDC_Click(object sender, EventArgs e)
        {
            rent d = new rent();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EDITC_Click(object sender, EventArgs e)
        {
            Repair d = new Repair();
            d.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
