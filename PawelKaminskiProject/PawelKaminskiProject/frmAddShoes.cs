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
    public partial class frmAddShoes : Form
    {
        frmShoes parent;
        List<int> AvailableSlots = new List<int>();
        List<int> RemainingSlots = new List<int>();
        public frmAddShoes()
        {
            InitializeComponent();
        }

        public frmAddShoes(frmShoes Parent)
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
            String shoeNum = txtShoeNumber.Text;

            // Check if shoe number if only contains digits

            for (int i = 0; i < shoeNum.Length; i++)
            {
                if (!Char.IsDigit(shoeNum[i]))
                {
                    MessageBox.Show("Error! Please make sure shoe number only contains digits",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShoeNumber.Focus();
                    return;
                }
            }

            // Check if shoe number is empty

            if (shoeNum.Equals(""))
            {
                MessageBox.Show("Error! Please make sure shoe number is entered",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtShoeNumber.Focus();
                return;
            }


            else
            {
                int Number = Convert.ToInt32(shoeNum);
                int shoesID = Convert.ToInt32(txtShoeId.Text);
                int shoesSize = Convert.ToInt32(cboShoeSize.SelectedItem.ToString());
                Shoes ashoes = new Shoes(shoesID, shoesSize, Number);

                Shoes.getExistingSlots(AvailableSlots);

                if (shoesID > 200)
                {
                    if (AvailableSlots.Count == Number)
                    {
                        ashoes.UpdatePigeonHoles(AvailableSlots);
                        MessageBox.Show("Thank you for Submitting shoes!",
                    "submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAddEquipment_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error! No slots available!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtShoeId.Focus();
                        return;
                    }
                }
                else
                {

                    if (AvailableSlots != null)
                    {
                        ashoes.UpdatePigeonHoles(AvailableSlots);
                    }

                    int nextshoes = Shoes.getNextShoes();

                    int desiredSlots = Number - AvailableSlots.Count;

                    for (int i = 0; i < desiredSlots; i++)
                    {
                        RemainingSlots.Add(nextshoes);
                        nextshoes++;
                    }

                    ashoes.addShoes(RemainingSlots);
                    MessageBox.Show("Thank you for Submitting shoes!",
                        "submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset UI by calling frmAddEquipment_Load method
                    frmAddEquipment_Load(sender, e);

                }
            
            }
        }
    

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            txtShoeNumber.Clear();
            txtShoeId.Clear();
            cboShoeSize.Items.Clear();
            txtShoeStatus.Clear();
            CenterToScreen();
            for (int i = 4; i < 14; i++) {
                cboShoeSize.Items.Add(i);
                    }
            txtShoeId.Text = Shoes.getNextShoes().ToString();
            txtShoeStatus.Text = "A";
        }
    }
}
