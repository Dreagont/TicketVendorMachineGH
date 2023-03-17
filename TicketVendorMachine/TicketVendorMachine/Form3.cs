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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please insert your card");
        }

        private void qrcode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please scan the code");
            PictureBox pb = new PictureBox();
            pb.Location = new Point(0, 0);
            pb.Size = new Size(150, 150);
            pb.Image = Image.FromFile("C:\\Users\\ACER\\Desktop\\Code\\SoftWare Tech\\Lab1\\TicketVendorMachine\\TicketVendorMachine\\qr.png");
            pb.Visible = true;
            this.Controls.Add(pb);
        }

        private void Done(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }
    }
}
