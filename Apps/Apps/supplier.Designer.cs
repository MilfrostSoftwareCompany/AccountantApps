namespace Apps
{
    partial class Supplier
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
            this.tabelSupplier = new System.Windows.Forms.DataGridView();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelSupplier
            // 
            this.tabelSupplier.AllowUserToAddRows = false;
            this.tabelSupplier.AllowUserToDeleteRows = false;
            this.tabelSupplier.AllowUserToResizeColumns = false;
            this.tabelSupplier.AllowUserToResizeRows = false;
            this.tabelSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelSupplier.Location = new System.Drawing.Point(14, 93);
            this.tabelSupplier.Name = "tabelSupplier";
            this.tabelSupplier.ReadOnly = true;
            this.tabelSupplier.Size = new System.Drawing.Size(1121, 577);
            this.tabelSupplier.TabIndex = 11;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddSupplier.FlatAppearance.BorderSize = 0;
            this.buttonAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonAddSupplier.Location = new System.Drawing.Point(939, 10);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(196, 33);
            this.buttonAddSupplier.TabIndex = 10;
            this.buttonAddSupplier.Text = "+ ADD SUPPLIER";
            this.buttonAddSupplier.UseVisualStyleBackColor = false;
            this.buttonAddSupplier.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonSearch.TabIndex = 9;
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
            this.search.TabIndex = 8;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(1151, 687);
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelSupplier;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
    }
}
