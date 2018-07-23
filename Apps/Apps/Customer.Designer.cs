namespace Apps
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelCustomer = new System.Windows.Forms.DataGridView();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelCustomer
            // 
            this.tabelCustomer.AllowUserToAddRows = false;
            this.tabelCustomer.AllowUserToDeleteRows = false;
            this.tabelCustomer.AllowUserToResizeColumns = false;
            this.tabelCustomer.AllowUserToResizeRows = false;
            this.tabelCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelCustomer.Location = new System.Drawing.Point(14, 93);
            this.tabelCustomer.Name = "tabelCustomer";
            this.tabelCustomer.ReadOnly = true;
            this.tabelCustomer.Size = new System.Drawing.Size(1121, 576);
            this.tabelCustomer.TabIndex = 15;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonAddCustomer.Location = new System.Drawing.Point(939, 10);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(196, 33);
            this.buttonAddCustomer.TabIndex = 14;
            this.buttonAddCustomer.Text = "+ ADD CUSTOMER";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(377, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 33);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(14, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(348, 26);
            this.search.TabIndex = 12;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1151, 687);
            ((System.ComponentModel.ISupportInitialize)(this.tabelCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
    }
}
