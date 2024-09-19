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
    public partial class frmAdmin : Form
    {
        frmMainMenu parent;
        public frmAdmin(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBookingAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookingAnalysis nextForm = new frmBookingAnalysis(this);
            nextForm.Show();
        }

        private void btnDeleteShoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis nextForm = new frmRevenueAnalysis(this);
            nextForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
