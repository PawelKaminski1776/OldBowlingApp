
namespace PawelKaminskiProject
{
    partial class frmMakeBooking
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
            this.grpMakeBooking = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cboNumOfPeop = new System.Windows.Forms.ComboBox();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLane = new System.Windows.Forms.TextBox();
            this.dtpBookingdate = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpMakeBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMakeBooking
            // 
            this.grpMakeBooking.Controls.Add(this.txtPrice);
            this.grpMakeBooking.Controls.Add(this.label8);
            this.grpMakeBooking.Controls.Add(this.cboTime);
            this.grpMakeBooking.Controls.Add(this.cboNumOfPeop);
            this.grpMakeBooking.Controls.Add(this.txtBookingId);
            this.grpMakeBooking.Controls.Add(this.label7);
            this.grpMakeBooking.Controls.Add(this.txtLane);
            this.grpMakeBooking.Controls.Add(this.dtpBookingdate);
            this.grpMakeBooking.Controls.Add(this.txtSurname);
            this.grpMakeBooking.Controls.Add(this.label6);
            this.grpMakeBooking.Controls.Add(this.txtForename);
            this.grpMakeBooking.Controls.Add(this.label5);
            this.grpMakeBooking.Controls.Add(this.label4);
            this.grpMakeBooking.Controls.Add(this.label3);
            this.grpMakeBooking.Controls.Add(this.label2);
            this.grpMakeBooking.Controls.Add(this.label1);
            this.grpMakeBooking.Controls.Add(this.btnSubmit);
            this.grpMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMakeBooking.Location = new System.Drawing.Point(13, 69);
            this.grpMakeBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMakeBooking.Name = "grpMakeBooking";
            this.grpMakeBooking.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMakeBooking.Size = new System.Drawing.Size(1029, 473);
            this.grpMakeBooking.TabIndex = 0;
            this.grpMakeBooking.TabStop = false;
            this.grpMakeBooking.Text = "Make a Booking";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(360, 346);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.MaxLength = 2;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(188, 37);
            this.txtPrice.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 31);
            this.label8.TabIndex = 42;
            this.label8.Text = "Price of Booking:";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(188, 238);
            this.cboTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 38);
            this.cboTime.TabIndex = 41;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // cboNumOfPeop
            // 
            this.cboNumOfPeop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumOfPeop.FormattingEnabled = true;
            this.cboNumOfPeop.Location = new System.Drawing.Point(360, 293);
            this.cboNumOfPeop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNumOfPeop.Name = "cboNumOfPeop";
            this.cboNumOfPeop.Size = new System.Drawing.Size(121, 38);
            this.cboNumOfPeop.TabIndex = 29;
            this.cboNumOfPeop.SelectedIndexChanged += new System.EventHandler(this.cboNumOfPeop_SelectedIndexChanged);
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(259, 76);
            this.txtBookingId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingId.MaxLength = 3;
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(76, 37);
            this.txtBookingId.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "Booking Id:";
            // 
            // txtLane
            // 
            this.txtLane.Location = new System.Drawing.Point(429, 241);
            this.txtLane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLane.MaxLength = 2;
            this.txtLane.Name = "txtLane";
            this.txtLane.ReadOnly = true;
            this.txtLane.Size = new System.Drawing.Size(119, 37);
            this.txtLane.TabIndex = 25;
            // 
            // dtpBookingdate
            // 
            this.dtpBookingdate.Location = new System.Drawing.Point(188, 183);
            this.dtpBookingdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBookingdate.MinDate = new System.DateTime(2023, 5, 18, 0, 0, 0, 0);
            this.dtpBookingdate.Name = "dtpBookingdate";
            this.dtpBookingdate.Size = new System.Drawing.Size(468, 37);
            this.dtpBookingdate.TabIndex = 23;
            this.dtpBookingdate.Value = new System.DateTime(2023, 5, 25, 23, 59, 59, 0);
            this.dtpBookingdate.ValueChanged += new System.EventHandler(this.dtpBookingdate_ValueChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(628, 129);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.MaxLength = 30;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(195, 37);
            this.txtSurname.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Surname:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(259, 129);
            this.txtForename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(195, 37);
            this.txtForename.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Number of People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lane: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Forename:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(468, 409);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 55);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(915, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 55);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpMakeBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMakeBooking";
            this.Text = "Make Booking (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpMakeBooking.ResumeLayout(false);
            this.grpMakeBooking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMakeBooking;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLane;
        private System.Windows.Forms.DateTimePicker dtpBookingdate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNumOfPeop;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
    }
}