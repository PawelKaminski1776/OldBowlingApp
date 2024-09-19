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
    public partial class frmCheckArrival : Form
    {
        frmBookings parent;
        List<String> list = new List<String>();
        List<String> ShoesID = new List<String>();
        List<String> distinctShoes = new List<string>();
        public frmCheckArrival(frmBookings Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboShoes1.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes1.Items[cboShoes1.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));

            }

            if (cboShoes2.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes2.Items[cboShoes2.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
            }

            if (cboShoes3.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes3.Items[cboShoes3.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
            }

            if (cboShoes4.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes4.Items[cboShoes4.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
            }

            if (cboShoes5.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes5.Items[cboShoes5.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
            }

            if (cboShoes6.SelectedIndex > -1)
            {
                Bookings.UpdateShoesStatus(Bookings.getNextAvailableShoes(Convert.ToInt32(cboShoes6.Items[cboShoes6.SelectedIndex].ToString())), Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
            }
            int selected = cboBookingId.SelectedIndex;
            string Stringselected = this.cboBookingId.GetItemText(this.cboBookingId.SelectedItem);
            DialogResult answer = MessageBox.Show("Has Booking Id " + Stringselected + " Arrived?",
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                // Set Lane status as Unavailable
                Bookings a = new Bookings();
                a.setBookingID(Convert.ToInt32(cboBookingId.SelectedItem.ToString()));
                a.setLaneID(a.getLane());
                a.UpdateBookingStatus();
                a.UpdateLaneStatus();
                // Save data in the database
                cboBookingId.Items.Remove(selected);
                MessageBox.Show("Booking Id " + Stringselected + " has arrived",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboBookingId.Items.Clear();
                cboShoes1.Visible = false;
                cboShoes2.Visible = false;
                cboShoes3.Visible = false;
                cboShoes4.Visible = false;
                cboShoes5.Visible = false;
                cboShoes6.Visible = false;
            }
            else if (answer == DialogResult.No)
            {
                cboBookingId.Focus();
            }
        }

        private void frmCheckArrival_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Bookings.getBooking_ID(list);
            for (int k = 0; k < list.Count; k++)
            {
                cboBookingId.Items.Add(list[k]);
            }

            Bookings.getAvailableShoes(ShoesID);

            distinctShoes = ShoesID.Distinct().ToList();

            for (int k = 0; k < distinctShoes.Count; k++)
            {

                cboShoes1.Items.Add(distinctShoes[k]);
            }

            cboShoes1.Visible = false;
            cboShoes2.Visible = false;
            cboShoes3.Visible = false;
            cboShoes4.Visible = false;
            cboShoes5.Visible = false;
            cboShoes6.Visible = false;
        }

        private void cboBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfPeople = Bookings.GetNumberOfPeople(Convert.ToInt32(cboBookingId.SelectedItem.ToString()));

            if (numOfPeople == 1)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = false;
                cboShoes3.Visible = false;
                cboShoes4.Visible = false;
                cboShoes5.Visible = false;
                cboShoes6.Visible = false;
            }
            if (numOfPeople == 2)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = true;
                cboShoes3.Visible = false;
                cboShoes4.Visible = false;
                cboShoes5.Visible = false;
                cboShoes6.Visible = false;
            }
            if (numOfPeople == 3)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = true;
                cboShoes3.Visible = true;
                cboShoes4.Visible = false;
                cboShoes5.Visible = false;
                cboShoes6.Visible = false;
            }
            if (numOfPeople == 4)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = true;
                cboShoes3.Visible = true;
                cboShoes4.Visible = true;
                cboShoes5.Visible = false;
                cboShoes6.Visible = false;
            }
            if (numOfPeople == 5)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = true;
                cboShoes3.Visible = true;
                cboShoes4.Visible = true;
                cboShoes5.Visible = true;
                cboShoes6.Visible = false;
            }
            if (numOfPeople == 6)
            {
                cboShoes1.Visible = true;
                cboShoes2.Visible = true;
                cboShoes3.Visible = true;
                cboShoes4.Visible = true;
                cboShoes5.Visible = true;
                cboShoes6.Visible = true;
            }
        }

        private void cboShoes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShoes2.Items.Clear();

            ShoesID.Remove(cboShoes1.SelectedItem.ToString());

            distinctShoes = ShoesID.Distinct().ToList();

            for (int i = 0; i < distinctShoes.Count; i++)
            {
                cboShoes2.Items.Add(distinctShoes[i]);
            }

        }

        private void cboShoes2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShoes3.Items.Clear();

            ShoesID.Remove(cboShoes2.SelectedItem.ToString());

            distinctShoes = ShoesID.Distinct().ToList();

            for (int i = 0; i < distinctShoes.Count; i++)
            {
                cboShoes3.Items.Add(distinctShoes[i]);
            }
        }

        private void cboShoes3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShoes4.Items.Clear();

            ShoesID.Remove(cboShoes3.SelectedItem.ToString());

            distinctShoes = ShoesID.Distinct().ToList();

            for (int i = 0; i < distinctShoes.Count; i++)
            {
                cboShoes4.Items.Add(distinctShoes[i]);
            }
        }

        private void cboShoes4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShoes5.Items.Clear();

            ShoesID.Remove(cboShoes4.SelectedItem.ToString());

            distinctShoes = ShoesID.Distinct().ToList();

            for (int i = 0; i < distinctShoes.Count; i++)
            {
                cboShoes5.Items.Add(distinctShoes[i]);
            }
        }

        private void cboShoes5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShoes6.Items.Clear();

            ShoesID.Remove(cboShoes5.SelectedItem.ToString());

            distinctShoes = ShoesID.Distinct().ToList();

            for (int i = 0; i < distinctShoes.Count; i++)
            {
                cboShoes6.Items.Add(distinctShoes[i]);
            }
        }
    }
}
