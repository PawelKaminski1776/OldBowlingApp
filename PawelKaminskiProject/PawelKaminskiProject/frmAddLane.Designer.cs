
namespace PawelKaminskiProject
{
    partial class frmAddLane
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
            this.grpAddLane = new System.Windows.Forms.GroupBox();
            this.btmAddLaneSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLaneNumber = new System.Windows.Forms.TextBox();
            this.btmBack = new System.Windows.Forms.Button();
            this.grpAddLane.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddLane
            // 
            this.grpAddLane.Controls.Add(this.btmAddLaneSubmit);
            this.grpAddLane.Controls.Add(this.label1);
            this.grpAddLane.Controls.Add(this.txtLaneNumber);
            this.grpAddLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddLane.Location = new System.Drawing.Point(58, 73);
            this.grpAddLane.Name = "grpAddLane";
            this.grpAddLane.Size = new System.Drawing.Size(669, 343);
            this.grpAddLane.TabIndex = 0;
            this.grpAddLane.TabStop = false;
            this.grpAddLane.Text = "Add Lane";
            // 
            // btmAddLaneSubmit
            // 
            this.btmAddLaneSubmit.Location = new System.Drawing.Point(281, 287);
            this.btmAddLaneSubmit.Name = "btmAddLaneSubmit";
            this.btmAddLaneSubmit.Size = new System.Drawing.Size(104, 45);
            this.btmAddLaneSubmit.TabIndex = 4;
            this.btmAddLaneSubmit.Text = "Submit";
            this.btmAddLaneSubmit.UseVisualStyleBackColor = true;
            this.btmAddLaneSubmit.Click += new System.EventHandler(this.btmAddLaneSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lane Number:";
            // 
            // txtLaneNumber
            // 
            this.txtLaneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaneNumber.Location = new System.Drawing.Point(164, 114);
            this.txtLaneNumber.MaxLength = 3;
            this.txtLaneNumber.Name = "txtLaneNumber";
            this.txtLaneNumber.ReadOnly = true;
            this.txtLaneNumber.Size = new System.Drawing.Size(125, 29);
            this.txtLaneNumber.TabIndex = 0;
            // 
            // btmBack
            // 
            this.btmBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBack.Location = new System.Drawing.Point(686, 11);
            this.btmBack.Name = "btmBack";
            this.btmBack.Size = new System.Drawing.Size(104, 45);
            this.btmBack.TabIndex = 6;
            this.btmBack.Text = "Back";
            this.btmBack.UseVisualStyleBackColor = true;
            this.btmBack.Click += new System.EventHandler(this.btmBack_Click);
            // 
            // frmAddLane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmBack);
            this.Controls.Add(this.grpAddLane);
            this.Name = "frmAddLane";
            this.Text = "Add Lane (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmAddLane_Load);
            this.grpAddLane.ResumeLayout(false);
            this.grpAddLane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddLane;
        private System.Windows.Forms.Button btmAddLaneSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLaneNumber;
        private System.Windows.Forms.Button btmBack;
    }
}

