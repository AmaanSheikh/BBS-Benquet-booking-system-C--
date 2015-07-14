using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBS
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking fb = new frmBooking();
            fb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmBooking fb = new frmBooking();
            fb.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmchkavlibility fc = new frmchkavlibility();
            fc.Show();
        }

      
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchkavlibility fc = new frmchkavlibility();
            fc.Show();
        }

      
    }
}
