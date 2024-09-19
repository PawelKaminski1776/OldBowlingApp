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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }



      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnLanes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLanes nextForm = new frmLanes(this);
            nextForm.Show();
        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShoes nextForm = new frmShoes(this);
            nextForm.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookings nextForm = new frmBookings(this);
            nextForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin nextForm = new frmAdmin(this);
            nextForm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
