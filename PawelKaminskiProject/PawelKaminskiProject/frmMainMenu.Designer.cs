
namespace PawelKaminskiProject
{
    partial class frmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLanes = new System.Windows.Forms.Button();
            this.btnShoes = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to BowlingSYS";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLanes
            // 
            this.btnLanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanes.Location = new System.Drawing.Point(153, 114);
            this.btnLanes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLanes.Name = "btnLanes";
            this.btnLanes.Size = new System.Drawing.Size(104, 45);
            this.btnLanes.TabIndex = 4;
            this.btnLanes.Text = "Lanes";
            this.btnLanes.UseVisualStyleBackColor = true;
            this.btnLanes.Click += new System.EventHandler(this.btnLanes_Click);
            // 
            // btnShoes
            // 
            this.btnShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoes.Location = new System.Drawing.Point(282, 114);
            this.btnShoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShoes.Name = "btnShoes";
            this.btnShoes.Size = new System.Drawing.Size(104, 45);
            this.btnShoes.TabIndex = 5;
            this.btnShoes.Text = "Shoes";
            this.btnShoes.UseVisualStyleBackColor = true;
            this.btnShoes.Click += new System.EventHandler(this.btnShoes_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.Location = new System.Drawing.Point(418, 114);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(104, 45);
            this.btnBookings.TabIndex = 6;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(550, 114);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(104, 45);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnShoes);
            this.Controls.Add(this.btnLanes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmMainMenu";
            this.Text = "Menu Main (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLanes;
        private System.Windows.Forms.Button btnShoes;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnAdmin;
    }
}