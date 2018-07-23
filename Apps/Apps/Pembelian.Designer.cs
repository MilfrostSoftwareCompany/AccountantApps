namespace Apps
{
    partial class Pembelian
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
            this.tabelPembelian = new System.Windows.Forms.DataGridView();
            this.buttonAddPembelian = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelPembelian
            // 
            this.tabelPembelian.AllowUserToAddRows = false;
            this.tabelPembelian.AllowUserToDeleteRows = false;
            this.tabelPembelian.AllowUserToResizeColumns = false;
            this.tabelPembelian.AllowUserToResizeRows = false;
            this.tabelPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPembelian.Location = new System.Drawing.Point(14, 93);
            this.tabelPembelian.Name = "tabelPembelian";
            this.tabelPembelian.ReadOnly = true;
            this.tabelPembelian.Size = new System.Drawing.Size(1121, 576);
            this.tabelPembelian.TabIndex = 23;
            // 
            // buttonAddPembelian
            // 
            this.buttonAddPembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddPembelian.FlatAppearance.BorderSize = 0;
            this.buttonAddPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPembelian.ForeColor = System.Drawing.Color.White;
            this.buttonAddPembelian.Location = new System.Drawing.Point(939, 10);
            this.buttonAddPembelian.Name = "buttonAddPembelian";
            this.buttonAddPembelian.Size = new System.Drawing.Size(196, 33);
            this.buttonAddPembelian.TabIndex = 22;
            this.buttonAddPembelian.Text = "+ ADD PEMBELIAN";
            this.buttonAddPembelian.UseVisualStyleBackColor = false;
            this.buttonAddPembelian.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonSearch.TabIndex = 21;
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
            this.search.TabIndex = 20;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelPembelian);
            this.Controls.Add(this.buttonAddPembelian);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Name = "Pembelian";
            this.Size = new System.Drawing.Size(1151, 687);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelPembelian;
        private System.Windows.Forms.Button buttonAddPembelian;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
    }
}
