
namespace PawelKaminskiProject
{
    partial class frmUpdateBooking
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
            this.btmBack = new System.Windows.Forms.Button();
            this.grpUpdateBooking = new System.Windows.Forms.GroupBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.dtpBookingdate = new System.Windows.Forms.DateTimePicker();
            this.cboNumOfPeop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBookingNum = new System.Windows.Forms.TextBox();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLane = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpUpdateBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // btmBack
            // 
            this.btmBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBack.Location = new System.Drawing.Point(686, 11);
            this.btmBack.Name = "btmBack";
            this.btmBack.Size = new System.Drawing.Size(104, 45);
            this.btmBack.TabIndex = 7;
            this.btmBack.Text = "Back";
            this.btmBack.UseVisualStyleBackColor = true;
            this.btmBack.Click += new System.EventHandler(this.btmBack_Click);
            // 
            // grpUpdateBooking
            // 
            this.grpUpdateBooking.Controls.Add(this.txtPrice);
            this.grpUpdateBooking.Controls.Add(this.label8);
            this.grpUpdateBooking.Controls.Add(this.txtLane);
            this.grpUpdateBooking.Controls.Add(this.label7);
            this.grpUpdateBooking.Controls.Add(this.cboTime);
            this.grpUpdateBooking.Controls.Add(this.txtSurname);
            this.grpUpdateBooking.Controls.Add(this.txtForename);
            this.grpUpdateBooking.Controls.Add(this.dtpBookingdate);
            this.grpUpdateBooking.Controls.Add(this.cboNumOfPeop);
            this.grpUpdateBooking.Controls.Add(this.label5);
            this.grpUpdateBooking.Controls.Add(this.label4);
            this.grpUpdateBooking.Controls.Add(this.label3);
            this.grpUpdateBooking.Controls.Add(this.label6);
            this.grpUpdateBooking.Controls.Add(this.label2);
            this.grpUpdateBooking.Controls.Add(this.label1);
            this.grpUpdateBooking.Controls.Add(this.btnSearch);
            this.grpUpdateBooking.Controls.Add(this.txtBookingNum);
            this.grpUpdateBooking.Controls.Add(this.grdBookings);
            this.grpUpdateBooking.Controls.Add(this.btnSubmit);
            this.grpUpdateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateBooking.Location = new System.Drawing.Point(12, 54);
            this.grpUpdateBooking.Name = "grpUpdateBooking";
            this.grpUpdateBooking.Size = new System.Drawing.Size(776, 384);
            this.grpUpdateBooking.TabIndex = 8;
            this.grpUpdateBooking.TabStop = false;
            this.grpUpdateBooking.Text = "Update a Booking";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(505, 178);
            this.cboTime.Margin = new System.Windows.Forms.Padding(2);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(92, 33);
            this.cboTime.TabIndex = 50;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(559, 90);
            this.txtSurname.MaxLength = 30;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(147, 31);
            this.txtSurname.TabIndex = 49;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(559, 44);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(147, 31);
            this.txtForename.TabIndex = 48;
            // 
            // dtpBookingdate
            // 
            this.dtpBookingdate.Location = new System.Drawing.Point(504, 133);
            this.dtpBookingdate.Name = "dtpBookingdate";
            this.dtpBookingdate.Size = new System.Drawing.Size(259, 31);
            this.dtpBookingdate.TabIndex = 47;
            // 
            // cboNumOfPeop
            // 
            this.cboNumOfPeop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumOfPeop.FormattingEnabled = true;
            this.cboNumOfPeop.Location = new System.Drawing.Point(630, 255);
            this.cboNumOfPeop.Margin = new System.Windows.Forms.Padding(2);
            this.cboNumOfPeop.Name = "cboNumOfPeop";
            this.cboNumOfPeop.Size = new System.Drawing.Size(92, 33);
            this.cboNumOfPeop.TabIndex = 46;
            this.cboNumOfPeop.SelectedIndexChanged += new System.EventHandler(this.cboNumOfPeop_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Number of People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Forename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(301, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 45);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBookingNum
            // 
            this.txtBookingNum.Location = new System.Drawing.Point(148, 47);
            this.txtBookingNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingNum.MaxLength = 2;
            this.txtBookingNum.Name = "txtBookingNum";
            this.txtBookingNum.Size = new System.Drawing.Size(129, 31);
            this.txtBookingNum.TabIndex = 11;
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(17, 102);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.RowHeadersWidth = 51;
            this.grdBookings.Size = new System.Drawing.Size(388, 224);
            this.grdBookings.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(351, 332);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 45);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Lane:";
            // 
            // txtLane
            // 
            this.txtLane.Location = new System.Drawing.Point(504, 218);
            this.txtLane.MaxLength = 30;
            this.txtLane.Name = "txtLane";
            this.txtLane.ReadOnly = true;
            this.txtLane.Size = new System.Drawing.Size(93, 31);
            this.txtLane.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(504, 289);
            this.txtPrice.MaxLength = 30;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(93, 31);
            this.txtPrice.TabIndex = 54;
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpUpdateBooking);
            this.Controls.Add(this.btmBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateBooking";
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            this.grpUpdateBooking.ResumeLayout(false);
            this.grpUpdateBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btmBack;
        private System.Windows.Forms.GroupBox grpUpdateBooking;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.TextBox txtBookingNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNumOfPeop;
        private System.Windows.Forms.DateTimePicker dtpBookingdate;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtLane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
    }
}