
namespace PawelKaminskiProject
{
    partial class frmRemoveShoes
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
            this.gboRemoveShoes = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtShoeNumber = new System.Windows.Forms.TextBox();
            this.grdShoes = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboRemoveShoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(915, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 55);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gboRemoveShoes
            // 
            this.gboRemoveShoes.Controls.Add(this.btnSearch);
            this.gboRemoveShoes.Controls.Add(this.txtShoeNumber);
            this.gboRemoveShoes.Controls.Add(this.grdShoes);
            this.gboRemoveShoes.Controls.Add(this.btnSubmit);
            this.gboRemoveShoes.Controls.Add(this.label1);
            this.gboRemoveShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboRemoveShoes.Location = new System.Drawing.Point(13, 76);
            this.gboRemoveShoes.Margin = new System.Windows.Forms.Padding(4);
            this.gboRemoveShoes.Name = "gboRemoveShoes";
            this.gboRemoveShoes.Padding = new System.Windows.Forms.Padding(4);
            this.gboRemoveShoes.Size = new System.Drawing.Size(1041, 465);
            this.gboRemoveShoes.TabIndex = 7;
            this.gboRemoveShoes.TabStop = false;
            this.gboRemoveShoes.Text = "Remove Shoes";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(456, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 55);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtShoeNumber
            // 
            this.txtShoeNumber.Location = new System.Drawing.Point(252, 47);
            this.txtShoeNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShoeNumber.MaxLength = 2;
            this.txtShoeNumber.Name = "txtShoeNumber";
            this.txtShoeNumber.Size = new System.Drawing.Size(171, 37);
            this.txtShoeNumber.TabIndex = 10;
            // 
            // grdShoes
            // 
            this.grdShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShoes.Location = new System.Drawing.Point(79, 118);
            this.grdShoes.Margin = new System.Windows.Forms.Padding(4);
            this.grdShoes.Name = "grdShoes";
            this.grdShoes.RowHeadersWidth = 51;
            this.grdShoes.Size = new System.Drawing.Size(883, 276);
            this.grdShoes.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(785, 402);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 55);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoe ID:";
            // 
            // frmRemoveShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gboRemoveShoes);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRemoveShoes";
            this.Text = "Remove Shoes";
            this.Load += new System.EventHandler(this.frmUpdateShoes_Load);
            this.gboRemoveShoes.ResumeLayout(false);
            this.gboRemoveShoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gboRemoveShoes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView grdShoes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtShoeNumber;
        private System.Windows.Forms.Label label1;
    }
}