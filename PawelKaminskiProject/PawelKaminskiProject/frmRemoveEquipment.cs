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
    public partial class frmRemoveEquipment : Form
    {
        frmMainMenu parent;
        public frmRemoveEquipment()
        {
            InitializeComponent();
        }

        public frmRemoveEquipment(frmMainMenu Parent)
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

        }
    }
}
