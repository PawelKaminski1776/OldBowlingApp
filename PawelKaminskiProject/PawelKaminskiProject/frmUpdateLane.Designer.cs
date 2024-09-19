
namespace PawelKaminskiProject
{
    partial class frmUpdateLane
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
            this.grpRemoveLane = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdLanes = new System.Windows.Forms.DataGridView();
            this.txtLaneNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpRemoveLane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLanes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRemoveLane
            // 
            this.grpRemoveLane.Controls.Add(this.cboStatus);
            this.grpRemoveLane.Controls.Add(this.label1);
            this.grpRemoveLane.Controls.Add(this.btnSearch);
            this.grpRemoveLane.Controls.Add(this.grdLanes);
            this.grpRemoveLane.Controls.Add(this.txtLaneNumber);
            this.grpRemoveLane.Controls.Add(this.btnSubmit);
            this.grpRemoveLane.Controls.Add(this.label2);
            this.grpRemoveLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemoveLane.Location = new System.Drawing.Point(12, 62);
            this.grpRemoveLane.Name = "grpRemoveLane";
            this.grpRemoveLane.Size = new System.Drawing.Size(776, 376);
            this.grpRemoveLane.TabIndex = 0;
            this.grpRemoveLane.TabStop = false;
            this.grpRemoveLane.Text = "Remove Lane";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(610, 49);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 33);
            this.cboStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lane Status: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 45);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdLanes
            // 
            this.grdLanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLanes.Location = new System.Drawing.Point(37, 105);
            this.grdLanes.Name = "grdLanes";
            this.grdLanes.RowHeadersWidth = 51;
            this.grdLanes.Size = new System.Drawing.Size(274, 176);
            this.grdLanes.TabIndex = 8;
            // 
            // txtLaneNumber
            // 
            this.txtLaneNumber.Location = new System.Drawing.Point(182, 48);
            this.txtLaneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLaneNumber.MaxLength = 2;
            this.txtLaneNumber.Name = "txtLaneNumber";
            this.txtLaneNumber.Size = new System.Drawing.Size(129, 31);
            this.txtLaneNumber.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(666, 325);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 45);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lane Number: ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmUpdateLane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpRemoveLane);
            this.Name = "frmUpdateLane";
            this.Text = "Update Lane (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmUpdateLane_Load);
            this.grpRemoveLane.ResumeLayout(false);
            this.grpRemoveLane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRemoveLane;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLaneNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdLanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}