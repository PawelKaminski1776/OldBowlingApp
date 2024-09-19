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
    public partial class frmAddLane : Form
    {
        frmLanes parent;
        public frmAddLane()
        {
            InitializeComponent();
        }

        public frmAddLane(frmLanes Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void btmAddLaneSubmit_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtLaneNumber.Text);
            Lane aLane = new Lane(number, "A");
            aLane.addLane();
            MessageBox.Show("Thank you for Submitting a Lane!",
                    "submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLaneNumber.Text = Lane.getNextLane().ToString();
        
        }

        private void btmBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddLane_Load(object sender, EventArgs e)
        {
            txtLaneNumber.Text = Lane.getNextLane().ToString();
            CenterToScreen();
        }
    }
}
