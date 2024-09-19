
namespace PawelKaminskiProject
{
    partial class frmConnect
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
            this.btnOpenCon = new System.Windows.Forms.Button();
            this.btnCloseCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenCon
            // 
            this.btnOpenCon.Location = new System.Drawing.Point(205, 63);
            this.btnOpenCon.Name = "btnOpenCon";
            this.btnOpenCon.Size = new System.Drawing.Size(400, 100);
            this.btnOpenCon.TabIndex = 0;
            this.btnOpenCon.Text = "Open Connection";
            this.btnOpenCon.UseVisualStyleBackColor = true;
            this.btnOpenCon.Click += new System.EventHandler(this.btnOpenCon_Click);
            // 
            // btnCloseCon
            // 
            this.btnCloseCon.Location = new System.Drawing.Point(205, 260);
            this.btnCloseCon.Name = "btnCloseCon";
            this.btnCloseCon.Size = new System.Drawing.Size(400, 100);
            this.btnCloseCon.TabIndex = 1;
            this.btnCloseCon.Text = "Close Connection";
            this.btnCloseCon.UseVisualStyleBackColor = true;
            this.btnCloseCon.Click += new System.EventHandler(this.btnCloseCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection is closed";
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseCon);
            this.Controls.Add(this.btnOpenCon);
            this.Name = "frmConnect";
            this.Text = "frmConnect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCon;
        private System.Windows.Forms.Button btnCloseCon;
        private System.Windows.Forms.Label label1;
    }
}