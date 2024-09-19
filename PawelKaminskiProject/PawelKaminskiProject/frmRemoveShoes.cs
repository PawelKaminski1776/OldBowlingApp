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
    public partial class frmRemoveShoes : Form
    {
        frmShoes parent;
        Shoes theShoe = new Shoes();
        int i;
        public frmRemoveShoes(frmShoes Parent)
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
            String shoeNumber = txtShoeNumber.Text;
            
            for (int i = 0; i < shoeNumber.Length; i++)
                {
                    if (!Char.IsDigit(shoeNumber[i]))
                    {
                        MessageBox.Show("Error! Shoe ID must only contain letters!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtShoeNumber.Focus();
                        return;
                    }
                }
            if (shoeNumber.Equals("")){
                MessageBox.Show("Error! Shoe ID must be entered!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtShoeNumber.Focus();
                return;
            }
            else {
                int Snumber = Convert.ToInt32(txtShoeNumber.Text);
                theShoe.setShoeID(Snumber);
                theShoe.setShoeSize(0);

                theShoe.UpdateShoesSize();


                //Reset UI
                gboRemoveShoes.Visible = false;
                grdShoes.Visible = false;
                txtShoeNumber.Clear();
                txtShoeNumber.Focus();
                // Show confirmation message
                MessageBox.Show("Shoe number: " + Snumber + " has been removed",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gboRemoveShoes.Visible = true;
                grdShoes.Visible = true;
            }

        }

        private void frmUpdateShoes_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            grdShoes.Visible = true;
            gboRemoveShoes.Visible = true;


            // Select date to be deleted
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String ShoeNumber = txtShoeNumber.Text;
            Boolean valid = true;
            // Check if lane number is empty
            if (ShoeNumber.Equals(""))
            {
                valid = false;
                MessageBox.Show("Error! Please enter a lane number",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtShoeNumber.Focus();
                return;
            }
            // Check if lane number is made up of digits
            for (int i = 0; i < ShoeNumber.Length; i++)
            {
                if (!Char.IsDigit(ShoeNumber[i]))
                {
                    valid = false;
                    MessageBox.Show("Error! Please make sure lane number is made up of digits",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShoeNumber.Focus();
                    return;
                }
            }

            if (valid == true)
            {
                //find matching products
                grdShoes.DataSource = Shoes.findShoes(txtShoeNumber.Text).Tables["Prod"];

                if (grdShoes.Rows.Count == 1)
                {
                    MessageBox.Show("No Data Found");
                    txtShoeNumber.Focus();
                    return;
                }

                //make the matching products visible
                grdShoes.Visible = true;
            }
        }
    }
}
