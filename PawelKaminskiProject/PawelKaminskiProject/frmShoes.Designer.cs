
namespace PawelKaminskiProject
{
    partial class frmShoes
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
            this.btnAddShoes = new System.Windows.Forms.Button();
            this.btnRemoveShoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(915, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 55);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 69);
            this.label1.TabIndex = 20;
            this.label1.Text = "Shoes";
            // 
            // btnAddShoes
            // 
            this.btnAddShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShoes.Location = new System.Drawing.Point(368, 174);
            this.btnAddShoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddShoes.Name = "btnAddShoes";
            this.btnAddShoes.Size = new System.Drawing.Size(139, 55);
            this.btnAddShoes.TabIndex = 17;
            this.btnAddShoes.Text = "Add Shoes";
            this.btnAddShoes.UseVisualStyleBackColor = true;
            this.btnAddShoes.Click += new System.EventHandler(this.btnAddShoes_Click);
            // 
            // btnRemoveShoes
            // 
            this.btnRemoveShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveShoes.Location = new System.Drawing.Point(552, 174);
            this.btnRemoveShoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveShoes.Name = "btnRemoveShoes";
            this.btnRemoveShoes.Size = new System.Drawing.Size(139, 55);
            this.btnRemoveShoes.TabIndex = 22;
            this.btnRemoveShoes.Text = "Remove Shoes";
            this.btnRemoveShoes.UseVisualStyleBackColor = true;
            this.btnRemoveShoes.Click += new System.EventHandler(this.btnUpdateShoes_Click);
            // 
            // frmShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoveShoes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddShoes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmShoes";
            this.Text = "Shoes (BowlingSYS)";
            this.Load += new System.EventHandler(this.frmShoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddShoes;
        private System.Windows.Forms.Button btnRemoveShoes;
    }
}