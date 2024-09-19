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
    public partial class frmCancelBooking : Form
    {
        frmBookings parent;
        List<String> list = new List<String>();
        public frmCancelBooking(frmBookings Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                DialogResult answer = MessageBox.Show("Are you sure you want to delete "+cboBookingID.SelectedItem.ToString()+" from booking files?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                // Delete booking id from booking files
                Bookings.deleteBooking(Convert.ToInt32(cboBookingID.SelectedItem.ToString()));
                MessageBox.Show("Booking Id: " + cboBookingID.SelectedItem.ToString() + " has been deleted from booking files",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBookingID.Items.Clear();
            }
            else if (answer == DialogResult.No)
            {
                cboBookingID.Items.Clear();
            }       
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Bookings.getBooking_ID(list);
            for (int k = 0; k < list.Count; k++)
            {
                cboBookingID.Items.Add(list[k]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
