
namespace PawelKaminskiProject
{
    partial class frmBookingAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gboBookingAnalysis = new System.Windows.Forms.GroupBox();
            this.txtTotalBookings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartBooking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gboBookingAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // gboBookingAnalysis
            // 
            this.gboBookingAnalysis.Controls.Add(this.txtTotalBookings);
            this.gboBookingAnalysis.Controls.Add(this.label2);
            this.gboBookingAnalysis.Controls.Add(this.chartBooking);
            this.gboBookingAnalysis.Controls.Add(this.cboYear);
            this.gboBookingAnalysis.Controls.Add(this.label1);
            this.gboBookingAnalysis.Controls.Add(this.btnSubmit);
            this.gboBookingAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboBookingAnalysis.Location = new System.Drawing.Point(12, 62);
            this.gboBookingAnalysis.Name = "gboBookingAnalysis";
            this.gboBookingAnalysis.Size = new System.Drawing.Size(776, 376);
            this.gboBookingAnalysis.TabIndex = 9;
            this.gboBookingAnalysis.TabStop = false;
            this.gboBookingAnalysis.Text = "Booking Analysis";
            this.gboBookingAnalysis.Enter += new System.EventHandler(this.gboBookingAnalysis_Enter);
            // 
            // txtTotalBookings
            // 
            this.txtTotalBookings.Location = new System.Drawing.Point(185, 263);
            this.txtTotalBookings.MaxLength = 3;
            this.txtTotalBookings.Name = "txtTotalBookings";
            this.txtTotalBookings.ReadOnly = true;
            this.txtTotalBookings.Size = new System.Drawing.Size(97, 31);
            this.txtTotalBookings.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Bookings:";
            // 
            // chartBooking
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBooking.ChartAreas.Add(chartArea1);
            legend1.ItemColumnSpacing = 20;
            legend1.Name = "Legend1";
            this.chartBooking.Legends.Add(legend1);
            this.chartBooking.Location = new System.Drawing.Point(338, 19);
            this.chartBooking.Margin = new System.Windows.Forms.Padding(2);
            this.chartBooking.Name = "chartBooking";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Bookings";
            this.chartBooking.Series.Add(series1);
            this.chartBooking.Size = new System.Drawing.Size(433, 287);
            this.chartBooking.TabIndex = 13;
            this.chartBooking.Text = "chrtBookingAnalysis";
            title1.Name = "BookingChart";
            title1.Text = "Booking Chart";
            this.chartBooking.Titles.Add(title1);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(97, 94);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(92, 33);
            this.cboYear.TabIndex = 6;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(326, 325);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 45);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBookingAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboBookingAnalysis);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookingAnalysis";
            this.Text = "Booking Analysis (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmBookingAnalysis_Load);
            this.gboBookingAnalysis.ResumeLayout(false);
            this.gboBookingAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboBookingAnalysis;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalBookings;
    }
}