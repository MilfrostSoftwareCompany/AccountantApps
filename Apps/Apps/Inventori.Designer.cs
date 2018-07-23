namespace Apps
{
    partial class Inventori
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
            this.buttonAddProduk = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.buttonOpnameStock = new System.Windows.Forms.Button();
            this.tabelInventori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelInventori)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProduk
            // 
            this.buttonAddProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddProduk.FlatAppearance.BorderSize = 0;
            this.buttonAddProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduk.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduk.Location = new System.Drawing.Point(940, 20);
            this.buttonAddProduk.Name = "buttonAddProduk";
            this.buttonAddProduk.Size = new System.Drawing.Size(196, 33);
            this.buttonAddProduk.TabIndex = 25;
            this.buttonAddProduk.Text = "+ ADD PRODUK";
            this.buttonAddProduk.UseVisualStyleBackColor = false;
            this.buttonAddProduk.Click += new System.EventHandler(this.buttonAddProduk_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(378, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 33);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(15, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(348, 26);
            this.search.TabIndex = 23;
            // 
            // buttonOpnameStock
            // 
            this.buttonOpnameStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonOpnameStock.FlatAppearance.BorderSize = 0;
            this.buttonOpnameStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpnameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpnameStock.ForeColor = System.Drawing.Color.White;
            this.buttonOpnameStock.Location = new System.Drawing.Point(940, 69);
            this.buttonOpnameStock.Name = "buttonOpnameStock";
            this.buttonOpnameStock.Size = new System.Drawing.Size(196, 33);
            this.buttonOpnameStock.TabIndex = 26;
            this.buttonOpnameStock.Text = "OPNAME STOCK";
            this.buttonOpnameStock.UseVisualStyleBackColor = false;
            this.buttonOpnameStock.Click += new System.EventHandler(this.buttonOpnameStock_Click);
            // 
            // tabelInventori
            // 
            this.tabelInventori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelInventori.Location = new System.Drawing.Point(15, 85);
            this.tabelInventori.Name = "tabelInventori";
            this.tabelInventori.Size = new System.Drawing.Size(758, 306);
            this.tabelInventori.TabIndex = 27;
            // 
            // Inventori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelInventori);
            this.Controls.Add(this.buttonOpnameStock);
            this.Controls.Add(this.buttonAddProduk);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.search);
            this.Name = "Inventori";
            this.Size = new System.Drawing.Size(1151, 687);
            ((System.ComponentModel.ISupportInitialize)(this.tabelInventori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduk;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button buttonOpnameStock;
        private System.Windows.Forms.DataGridView tabelInventori;
    }
}
