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
    public partial class frmMakeBooking : Form
    {
        frmBookings parent;
        double Price;
        public frmMakeBooking()
        {
            InitializeComponent();
        }

        public frmMakeBooking(frmBookings Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtForename.Clear();
            txtSurname.Clear();
            txtLane.Clear();
            txtPrice.Clear();
            dtpBookingdate.Value = DateTime.Today;

            txtBookingId.Text = Bookings.getNextBooking().ToString();

            // Check if time is in between 16 and 21 on weekdays, 14 and 22 on weekends

            if (dtpBookingdate.Value.DayOfWeek == DayOfWeek.Saturday || dtpBookingdate.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                for (int k = 14; k < 23; k++)
                {
                    cboTime.Items.Add(k);
                }
            }
            else
            {
                for (int k = 16; k < 22; k++)
                {
                    cboTime.Items.Add(k);
                }
            }

            for (int i = 1; i < 7; i++)
            {
                cboNumOfPeop.Items.Add(i);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String forename = txtForename.Text;
            String surname = txtSurname.Text;

            // Forename Validation
            // Check if forename is empty

            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Error! forename must be entered!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            // Check if forename only contains letters

            for (int i = 0; i < forename.Length; i++)
            {
                if (!Char.IsLetter(forename[i]))
                {
                    MessageBox.Show("Error! Forename must only contain letters!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtForename.Focus();
                    return;
                }
            }

            // Surname Validation
            // Check if surname is empty

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Error! surname must be entered!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            // Check if surname only contains letters

            for (int i = 0; i < surname.Length; i++)
            {
                if (!Char.IsLetter(surname[i]))
                {
                    MessageBox.Show("Error! Surname must only contain letters!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }
            }

            int laneAsint = int.Parse(txtLane.Text);

            // Check if lane is between 1 and 99

            if (laneAsint <= 0 && laneAsint > 99)
            {
                MessageBox.Show("Error! Please enter a number between 1 and 99!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLane.Focus();
                return;
            }

            if (String.IsNullOrEmpty(cboTime.Text))
            {
                MessageBox.Show("Error! Please enter the amount of people on the booking",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(cboNumOfPeop.Text))
            {
                MessageBox.Show("Error! Please enter the amount of people on the booking",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else
            {
                String date = String.Format("{0:dd-MMM-yy}", dtpBookingdate.Value);
                int NumOfPeop = Convert.ToInt32(cboNumOfPeop.Text);
                int bookingid = Convert.ToInt32(txtBookingId.Text);
                int laneid = Convert.ToInt32(txtLane.Text);
                // Save data in database
                Bookings aBooking = new Bookings(txtForename.Text, txtSurname.Text, date, cboTime.Text, "B", NumOfPeop, Price, bookingid, laneid);
                aBooking.addBooking();
                MessageBox.Show("Thank you for Submitting a booking!  " + forename,
                    "submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // reset ui

                frmMakeBooking_Load(sender, e);

            }
        }

        private void cboNumOfPeop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price = 0;
            if (cboNumOfPeop.SelectedItem.ToString().Equals("1"))
            {
                Price = 15 + 2.5;
                txtPrice.Text = "€" + Price.ToString();
            }
            if (cboNumOfPeop.SelectedItem.ToString().Equals("2"))
            {
                Price = 15 + (2.5 * 2);
                txtPrice.Text = "€" + Price.ToString();
            }
            if (cboNumOfPeop.SelectedItem.ToString().Equals("3"))
            {
                Price = 15 + (2.5 * 3);
                txtPrice.Text = "€" + Price.ToString();
            }
            if (cboNumOfPeop.SelectedItem.ToString().Equals("4"))
            {
                Price = 15 + (2.5 * 4);
                txtPrice.Text = "€" + Price.ToString();
            }
            if (cboNumOfPeop.SelectedItem.ToString().Equals("5"))
            {
                Price = 15 + (2.5 * 5);
                txtPrice.Text = "€" + Price.ToString();
            }
            if (cboNumOfPeop.SelectedItem.ToString().Equals("6"))
            {
                Price = 15 + (2.5 * 6);
                txtPrice.Text = "€" + Price.ToString();
            }
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            String date = String.Format("{0:dd-MMM-yy}", dtpBookingdate.Value);
            int comparetime = Convert.ToInt32(cboTime.SelectedItem.ToString());

            if (String.IsNullOrEmpty(dtpBookingdate.Value.ToString()))
            {
                // Do nothing
                return;
            }
            else
            {
                txtLane.Text = Bookings.GetNextAvailableLane(date, comparetime).ToString();

            }
        }

        private void dtpBookingdate_ValueChanged(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(cboTime.Text))
            {
                // Do nothing
                return;
            }
            else
            {
           
            }
        }
    }
}
