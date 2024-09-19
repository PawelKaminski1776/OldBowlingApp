﻿using System;
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
    public partial class frmRevenueAnalysis : Form
    {
        frmAdmin parent;
        List<String> Years = new List<String>();
        List<String> BookingYears = new List<String>();
        String[] month = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
        public frmRevenueAnalysis(frmAdmin Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cboYear.Text == "")
            {
                MessageBox.Show("Error! No Bookings in the database!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYear.Focus();
                return;
            }
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }

            double answer = 0;
            int answer1 = 0;
            String answer2 = "";

            string Stringselected = this.cboYear.GetItemText(this.cboYear.SelectedItem);
            for (int i = 0; i < Years.Count; i++)
            {
                if (Stringselected == Years[i])
                {
                    chartRevenue.ChartAreas[0].AxisX.Interval = 1;

                    for (int k = 0; k < month.Length; k++)
                    {
                        answer += Admin.GetMonthlyRevenue(month[k], Years[i].ToString().Substring(2));
                        answer1 += Admin.GetMonthlyBookings(month[k], Years[i].ToString().Substring(2));
                        answer2 = Years[i];
                        // chartRevenue.Series["Revenue"].Points.AddXY(month[k], monthEarnings[k]);
                        chartRevenue.Series["Revenue"].Points.Add(Admin.GetMonthlyRevenue(month[k], Years[i].ToString().Substring(2)));
                        chartRevenue.Series["Revenue"].Points[k].AxisLabel = month[k];
                        chartRevenue.Series["Revenue"].Points[k].LegendText = month[k];
                        chartRevenue.Series["Revenue"].Points[k].Label = Admin.GetMonthlyRevenue(month[k], Years[i].ToString().Substring(2)).ToString();
                    }

                }
            }

            Boolean Valid = true; ;
            Admin theadmin = new Admin(Convert.ToInt32(answer2), answer, answer1);
            Admin.getBooking_Year(BookingYears);
            theadmin.setBookingYear(Convert.ToInt32(answer2));
            theadmin.setTotalBookings(answer1);
            theadmin.setTotalRevenue(answer);

            if (BookingYears.Count == 0)
            {
                Valid = true;
            }
            for(int y = 0; y < BookingYears.Count; y++)
            {
                if (BookingYears[y] == answer2)
                {
                    Valid = false;
                }
            }

            if(Valid == true)
            {
                theadmin.addAdmin();
            }

            if(Valid == false)
            {
                theadmin.UpdateAdmin();
            }

            txtTotalRevenue.Text = answer.ToString();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Admin.getYears(Years);
            Years = Years.Distinct().ToList();
            for (int i = 0; i < Years.Count; i++)
            {
                cboYear.Items.Add(Years[i]);
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }
        }
    }
}