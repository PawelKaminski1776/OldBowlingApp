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
    public partial class frmLanes : Form
    {
        frmMainMenu parent;
        public frmLanes(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddLane_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddLane nextForm = new frmAddLane(this);
            nextForm.Show();
        }

        private void btnRemoveLane_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateLane nextForm = new frmUpdateLane(this);
            nextForm.Show();
        }

        private void frmLanes_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
