using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PawelKaminskiProject
{
    public partial class frmConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnOpenCon_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                return;
            conn.Open();
            label1.Text = "Connection is now open";
        }

        private void btnCloseCon_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                return;
            conn.Close();
            label1.Text = "Connection is now closed";
        }
    }
}
