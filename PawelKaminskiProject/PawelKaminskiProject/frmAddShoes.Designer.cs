
namespace PawelKaminskiProject
{
    partial class frmAddShoes
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
            this.grpAddEquipment = new System.Windows.Forms.GroupBox();
            this.cboShoeSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShoeStatus = new System.Windows.Forms.TextBox();
            this.txtShoeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShoeNumber = new System.Windows.Forms.TextBox();
            this.grpAddEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddEquipment
            // 
            this.grpAddEquipment.Controls.Add(this.cboShoeSize);
            this.grpAddEquipment.Controls.Add(this.label3);
            this.grpAddEquipment.Controls.Add(this.txtShoeStatus);
            this.grpAddEquipment.Controls.Add(this.txtShoeNumber);
            this.grpAddEquipment.Controls.Add(this.txtShoeId);
            this.grpAddEquipment.Controls.Add(this.label2);
            this.grpAddEquipment.Controls.Add(this.btnSubmit);
            this.grpAddEquipment.Controls.Add(this.label4);
            this.grpAddEquipment.Controls.Add(this.label1);
            this.grpAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddEquipment.Location = new System.Drawing.Point(58, 73);
            this.grpAddEquipment.Name = "grpAddEquipment";
            this.grpAddEquipment.Size = new System.Drawing.Size(669, 343);
            this.grpAddEquipment.TabIndex = 0;
            this.grpAddEquipment.TabStop = false;
            this.grpAddEquipment.Text = "Add Shoes";
            // 
            // cboShoeSize
            // 
            this.cboShoeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShoeSize.FormattingEnabled = true;
            this.cboShoeSize.Location = new System.Drawing.Point(231, 100);
            this.cboShoeSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboShoeSize.Name = "cboShoeSize";
            this.cboShoeSize.Size = new System.Drawing.Size(92, 33);
            this.cboShoeSize.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Shoe Size: ";
            // 
            // txtShoeStatus
            // 
            this.txtShoeStatus.Location = new System.Drawing.Point(231, 146);
            this.txtShoeStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShoeStatus.MaxLength = 1;
            this.txtShoeStatus.Name = "txtShoeStatus";
            this.txtShoeStatus.ReadOnly = true;
            this.txtShoeStatus.Size = new System.Drawing.Size(48, 31);
            this.txtShoeStatus.TabIndex = 1;
            // 
            // txtShoeId
            // 
            this.txtShoeId.Location = new System.Drawing.Point(231, 51);
            this.txtShoeId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShoeId.MaxLength = 999;
            this.txtShoeId.Name = "txtShoeId";
            this.txtShoeId.ReadOnly = true;
            this.txtShoeId.Size = new System.Drawing.Size(76, 31);
            this.txtShoeId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Shoe Status: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(281, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shoe ID:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(686, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoe Number: ";
            // 
            // txtShoeNumber
            // 
            this.txtShoeNumber.Location = new System.Drawing.Point(231, 193);
            this.txtShoeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtShoeNumber.MaxLength = 2;
            this.txtShoeNumber.Name = "txtShoeNumber";
            this.txtShoeNumber.Size = new System.Drawing.Size(57, 31);
            this.txtShoeNumber.TabIndex = 11;
            // 
            // frmAddShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpAddEquipment);
            this.Name = "frmAddShoes";
            this.Text = "Add Shoes (Pawel\'s Bowling Alley)";
            this.Load += new System.EventHandler(this.frmAddEquipment_Load);
            this.grpAddEquipment.ResumeLayout(false);
            this.grpAddEquipment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddEquipment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShoeId;
        private System.Windows.Forms.TextBox txtShoeStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboShoeSize;
        private System.Windows.Forms.TextBox txtShoeNumber;
        private System.Windows.Forms.Label label1;
    }
}