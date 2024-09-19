
namespace PawelKaminskiProject
{
    partial class frmLanes
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
            this.btnAddLane = new System.Windows.Forms.Button();
            this.btnUpdateLane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddLane
            // 
            this.btnAddLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLane.Location = new System.Drawing.Point(274, 141);
            this.btnAddLane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLane.Name = "btnAddLane";
            this.btnAddLane.Size = new System.Drawing.Size(104, 45);
            this.btnAddLane.TabIndex = 0;
            this.btnAddLane.Text = "Add Lane";
            this.btnAddLane.UseVisualStyleBackColor = true;
            this.btnAddLane.Click += new System.EventHandler(this.btnAddLane_Click);
            // 
            // btnUpdateLane
            // 
            this.btnUpdateLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLane.Location = new System.Drawing.Point(404, 141);
            this.btnUpdateLane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateLane.Name = "btnUpdateLane";
            this.btnUpdateLane.Size = new System.Drawing.Size(104, 45);
            this.btnUpdateLane.TabIndex = 1;
            this.btnUpdateLane.Text = "Update Lane";
            this.btnUpdateLane.UseVisualStyleBackColor = true;
            this.btnUpdateLane.Click += new System.EventHandler(this.btnRemoveLane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lanes";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateLane);
            this.Controls.Add(this.btnAddLane);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLanes";
            this.Text = "Lanes (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmLanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLane;
        private System.Windows.Forms.Button btnUpdateLane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}