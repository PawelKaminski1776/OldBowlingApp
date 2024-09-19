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
    public partial class frmShoes : Form
    {
        frmMainMenu parent;
        public frmShoes(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnUpdateShoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveShoes nextForm = new frmRemoveShoes(this);
            nextForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddShoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddShoes nextForm = new frmAddShoes(this);
            nextForm.Show();
        }

        private void frmShoes_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
