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
    public partial class frmUpdateBooking : Form
    {

        frmBookings parent;
        Bookings theBooking = new Bookings();
        double Price;
        List<String> Booking_Dates = new List<String>();
        List<String> Booking_Times = new List<String>();
        List<String> Booking_Lanes = new List<String>();
        public frmUpdateBooking(frmBookings Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
              
            String forename = txtForename.Text;
            String surname = txtSurname.Text;


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

            // Check if date is valid

            DateTime chosendate = dtpBookingdate.Value;
            DateTime now = DateTime.Now;

            if (chosendate < now)
            {
                MessageBox.Show("Error! Please choose a valid date",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpBookingdate.Focus();
                return;
            }

            // Check if time is empty

     

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

            // Check if time and date are available in the booking files


            // Check if lane is Available in the booking files

            // Check if forename is empty

            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Error! forename must be entered!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }


            else
            {
                MessageBox.Show("Thank you for Submitting a booking!",
                    "submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Save data in database
                // Clear text boxes
                txtForename.Clear();
                txtSurname.Clear();
            }
        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            grdBookings.Visible = true;
            grpUpdateBooking.Visible = true;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String Bookingnum = txtBookingNum.Text;
            Boolean valid = true;
            // Check if lane number is empty
            if (Bookingnum.Equals(""))
            {
                valid = false;
                MessageBox.Show("Error! Please enter a Booking number",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingNum.Focus();
                return;
            }
            // Check if lane number is made up of digits
            for (int i = 0; i < Bookingnum.Length; i++)
            {
                if (!Char.IsDigit(Bookingnum[i]))
                {
                    valid = false;
                    MessageBox.Show("Error! Please make sure Booking number is made up of digits",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookingNum.Focus();
                    return;
                }
            }

            if (valid == true)
            {
                //find matching products
                grdBookings.DataSource = Bookings.findBooking(txtBookingNum.Text).Tables["Prod"];

                if (grdBookings.Rows.Count == 1)
                {
                    MessageBox.Show("No Data Found");
                    txtBookingNum.Focus();
                    return;
                }

                //make the matching products visible
                grdBookings.Visible = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String forename = txtForename.Text;
            String surname = txtSurname.Text;
            String date = String.Format("{0:dd-MMM-yy}", dtpBookingdate.Value);
            int NumOfShoes = Convert.ToInt32(cboNumOfPeop.SelectedItem.ToString());
            int BookingID = Convert.ToInt32(txtBookingNum.Text);
            String time = cboTime.SelectedItem.ToString();
            int timeAsint = int.Parse(time);


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

            // Check if date is valid

            DateTime chosendate = dtpBookingdate.Value;
            DateTime now = DateTime.Now;

            if (chosendate < now)
            {
                MessageBox.Show("Error! Please choose a valid date",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpBookingdate.Focus();
                return;
            }


            if (String.IsNullOrEmpty(cboNumOfPeop.Text))
            {
                MessageBox.Show("Error! Please enter the amount of people on the booking",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            else
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to change " + BookingID + " ?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    //instantiate the object variables
                    int Bnumber = Convert.ToInt32(txtBookingNum.Text);
                    int Lnumber = Convert.ToInt32(txtLane.Text);
                    theBooking.setBookingID(BookingID);
                    theBooking.setForename(forename);
                    theBooking.setSurname(surname);
                    theBooking.seBookingDate(date);
                    theBooking.setLaneID(Lnumber);
                    theBooking.setBookingTime(time);
                    theBooking.setBookingCost(Price);
                    theBooking.setNumOfShoes(NumOfShoes);

                    //update the data in the database
                    theBooking.UpdateBooking();

                    //Reset UI
                    grpUpdateBooking.Visible = false;
                    grdBookings.Visible = false;
                    txtBookingNum.Clear();
                    txtForename.Clear();
                    txtSurname.Clear();
                    txtPrice.Clear();
                    txtLane.Clear();
                    txtBookingNum.Focus();
                    // Set Lane status as Unavailable
                    Bookings.findBooking(txtBookingNum.Text);
                    // Show confirmation message
                    MessageBox.Show("The following booking has been changed " + Bnumber,
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpUpdateBooking.Visible = true;
                    grdBookings.Visible = true;
                }
                else if (answer == DialogResult.No)
                {
                    txtBookingNum.Clear();
                    txtBookingNum.Focus();
                }

            }
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
