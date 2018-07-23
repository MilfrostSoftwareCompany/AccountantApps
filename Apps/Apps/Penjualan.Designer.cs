namespace Apps
{
    partial class Penjualan
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
            this.tabelPenjualan = new System.Windows.Forms.DataGridView();
            this.buttonAddPenjualan = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelPenjualan
            // 
            this.tabelPenjualan.AllowUserToAddRows = false;
            this.tabelPenjualan.AllowUserToDeleteRows = false;
            this.tabelPenjualan.AllowUserToResizeColumns = false;
            this.tabelPenjualan.AllowUserToResizeRows = false;
            this.tabelPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPenjualan.Location = new System.Drawing.Point(14, 93);
            this.tabelPenjualan.Name = "tabelPenjualan";
            this.tabelPenjualan.ReadOnly = true;
            this.tabelPenjualan.Size = new System.Drawing.Size(1121, 576);
            this.tabelPenjualan.TabIndex = 19;
            // 
            // buttonAddPenjualan
            // 
            this.buttonAddPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddPenjualan.FlatAppearance.BorderSize = 0;
            this.buttonAddPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPenjualan.ForeColor = System.Drawing.Color.White;
            this.buttonAddPenjualan.Location = new System.Drawing.Point(939, 10);
            this.buttonAddPenjualan.Name = "buttonAddPenjualan";
            this.buttonAddPenjualan.Size = new System.Drawing.Size(196, 33);
            this.buttonAddPenjualan.TabIndex = 18;
            this.buttonAddPenjualan.Text = "+ ADD PENJUALAN";
            this.buttonAddPenjualan.UseVisualStyleBackColor = false;
            this.buttonAddPenjualan.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonSearch.TabIndex = 17;
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
            this.search.TabIndex = 16;
            // 
            // Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelPenjualan);
            this.Controls.Add(this.buttonAddPenjualan);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Name = "Penjualan";
            this.Size = new System.Drawing.Size(1151, 687);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelPenjualan;
        private System.Windows.Forms.Button buttonAddPenjualan;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
    }
}
