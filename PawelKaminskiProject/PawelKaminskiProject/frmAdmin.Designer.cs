
namespace PawelKaminskiProject
{
    partial class frmAdmin
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteShoes = new System.Windows.Forms.Button();
            this.btnBookingAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 55);
            this.label1.TabIndex = 26;
            this.label1.Text = "Admin";
            // 
            // btnDeleteShoes
            // 
            this.btnDeleteShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShoes.Location = new System.Drawing.Point(449, 142);
            this.btnDeleteShoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteShoes.Name = "btnDeleteShoes";
            this.btnDeleteShoes.Size = new System.Drawing.Size(104, 45);
            this.btnDeleteShoes.TabIndex = 24;
            this.btnDeleteShoes.Text = "Revenue Analysis";
            this.btnDeleteShoes.UseVisualStyleBackColor = true;
            this.btnDeleteShoes.Click += new System.EventHandler(this.btnDeleteShoes_Click);
            // 
            // btnBookingAnalysis
            // 
            this.btnBookingAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingAnalysis.Location = new System.Drawing.Point(289, 142);
            this.btnBookingAnalysis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBookingAnalysis.Name = "btnBookingAnalysis";
            this.btnBookingAnalysis.Size = new System.Drawing.Size(104, 45);
            this.btnBookingAnalysis.TabIndex = 23;
            this.btnBookingAnalysis.Text = "Booking Analysis";
            this.btnBookingAnalysis.UseVisualStyleBackColor = true;
            this.btnBookingAnalysis.Click += new System.EventHandler(this.btnBookingAnalysis_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteShoes);
            this.Controls.Add(this.btnBookingAnalysis);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdmin";
            this.Text = "Admin (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteShoes;
        private System.Windows.Forms.Button btnBookingAnalysis;
    }
}