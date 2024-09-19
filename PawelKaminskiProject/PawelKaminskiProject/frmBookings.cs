using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawelKaminskiProject
{
    public partial class frmBookings : Form
    {
        frmMainMenu parent;
        public frmBookings(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking nextForm = new frmMakeBooking(this);
            nextForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking nextForm = new frmCancelBooking(this);
            nextForm.Show();
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBooking nextForm = new frmUpdateBooking(this);
            nextForm.Show();
        }

        private void btnCheckArrival_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckArrival nextForm = new frmCheckArrival(this);
            nextForm.Show();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
