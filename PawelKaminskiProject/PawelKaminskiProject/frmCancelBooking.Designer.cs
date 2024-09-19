
namespace PawelKaminskiProject
{
    partial class frmCancelBooking
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
            this.grpCancelBooking = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboBookingID = new System.Windows.Forms.ComboBox();
            this.grpCancelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCancelBooking
            // 
            this.grpCancelBooking.Controls.Add(this.cboBookingID);
            this.grpCancelBooking.Controls.Add(this.btnSubmit);
            this.grpCancelBooking.Controls.Add(this.label1);
            this.grpCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCancelBooking.Location = new System.Drawing.Point(58, 73);
            this.grpCancelBooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCancelBooking.Name = "grpCancelBooking";
            this.grpCancelBooking.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCancelBooking.Size = new System.Drawing.Size(669, 343);
            this.grpCancelBooking.TabIndex = 0;
            this.grpCancelBooking.TabStop = false;
            this.grpCancelBooking.Text = "Cancel Booking";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(281, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 45);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking ID:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboBookingID
            // 
            this.cboBookingID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookingID.FormattingEnabled = true;
            this.cboBookingID.Location = new System.Drawing.Point(167, 71);
            this.cboBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.cboBookingID.Name = "cboBookingID";
            this.cboBookingID.Size = new System.Drawing.Size(92, 34);
            this.cboBookingID.TabIndex = 51;
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpCancelBooking);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.grpCancelBooking.ResumeLayout(false);
            this.grpCancelBooking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCancelBooking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboBookingID;
    }
}