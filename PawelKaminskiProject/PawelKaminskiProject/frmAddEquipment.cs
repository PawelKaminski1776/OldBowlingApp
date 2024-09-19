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
    public partial class frmAddEquipment : Form
    {
        frmMainMenu parent;
        public frmAddEquipment()
        {
            InitializeComponent();
        }

        public frmAddEquipment(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
