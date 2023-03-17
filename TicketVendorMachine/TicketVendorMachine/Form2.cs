using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendorMachine
{
    public partial class Form2 : Form
    {
        int dffee = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fee.Text = dffee.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location.SelectedIndex == 0)
            {
                dffee += 100;
                fee.Text = dffee.ToString();
            }
            if (location.SelectedIndex == 1)
            {
                dffee += 200;
                fee.Text = dffee.ToString();
            }
            if (location.SelectedIndex == 2)
            {
                dffee += 300;
                fee.Text = dffee.ToString();
            }
            if (location.SelectedIndex == 3)
            {
                dffee += 400;
                fee.Text = dffee.ToString();
            }
        }

        private void vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicle.SelectedIndex == 0)
            {
                dffee += 100;
                fee.Text = dffee.ToString();
            }
            if (vehicle.SelectedIndex == 1)
            {
                dffee += 200;
                fee.Text = dffee.ToString();
            }
            if (vehicle.SelectedIndex == 2)
            {
                dffee += 300;
                fee.Text = dffee.ToString();
            }
            if (vehicle.SelectedIndex == 3)
            {
                dffee += 400;
                fee.Text = dffee.ToString();
            }
        }
    }
}
