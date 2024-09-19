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
    public partial class frmUpdateLane : Form
    {
        frmLanes parent;
        Lane theLane = new Lane();
        public frmUpdateLane()
        {
            InitializeComponent();
        }

        public frmUpdateLane(frmLanes Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUpdateLane_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            cboStatus.Items.Add("U");
            cboStatus.Items.Add("A");
            grpRemoveLane.Visible = true;
            grdLanes.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String LaneNum = txtLaneNumber.Text;
            Boolean valid = true;
            // Check if lane number is empty
            if (LaneNum.Equals(""))
            {
                valid = false;
                MessageBox.Show("Error! Please enter a lane number",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLaneNumber.Focus();
                return;
            }
            // Check if lane number is made up of digits
            for (int i = 0; i < LaneNum.Length; i++)
            {
                if (!Char.IsDigit(LaneNum[i]))
                {
                    valid = false;
                    MessageBox.Show("Error! Please make sure lane number is made up of digits",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLaneNumber.Focus();
                    return;
                }
            }

            // Check if lane number exists in the database

            if(valid == true)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to set " + LaneNum + " as " + cboStatus.SelectedItem.ToString(),
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    //instantiate the object variables
                    int Lnumber = Convert.ToInt32(txtLaneNumber.Text);
                    theLane.setLaneID(Lnumber);
                    theLane.setLaneStatus(cboStatus.SelectedItem.ToString());

                    //update the data in the database
                    theLane.UpdateLane();

                    //Reset UI
                    grpRemoveLane.Visible = false;
                    grdLanes.Visible = false;
                    txtLaneNumber.Clear();
                    txtLaneNumber.Focus();
                    // Set Lane status as Unavailable
                    Lane.findLane(txtLaneNumber.Text);
                    // Show confirmation message
                    MessageBox.Show("Lane number: " + LaneNum + " has been set as " + cboStatus.SelectedItem.ToString(),
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpRemoveLane.Visible = true;
                    grdLanes.Visible = true;
                }
                else if (answer == DialogResult.No)
                {
                    txtLaneNumber.Clear();
                    txtLaneNumber.Focus();
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String LaneNum = txtLaneNumber.Text;
            Boolean valid = true;
            // Check if lane number is empty
            if (LaneNum.Equals(""))
            {
                valid = false;
                MessageBox.Show("Error! Please enter a lane number",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLaneNumber.Focus();
                return;
            }
            // Check if lane number is made up of digits
            for (int i = 0; i < LaneNum.Length; i++)
            {
                if (!Char.IsDigit(LaneNum[i]))
                {
                    valid = false;
                    MessageBox.Show("Error! Please make sure lane number is made up of digits",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLaneNumber.Focus();
                    return;
                }
            }
           
            if(valid == true)
            {
                //find matching products
                grdLanes.DataSource = Lane.findLane(txtLaneNumber.Text).Tables["Prod"];

                if (grdLanes.Rows.Count == 1)
                {
                    MessageBox.Show("No Data Found");
                    txtLaneNumber.Focus();
                    return;
                }

                //make the matching products visible
                grdLanes.Visible = true;
            }
        }
    }
}
