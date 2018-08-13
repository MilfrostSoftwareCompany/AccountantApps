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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelInventori)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddProduk
            // 
            this.buttonAddProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddProduk.FlatAppearance.BorderSize = 0;
            this.buttonAddProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduk.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduk.Location = new System.Drawing.Point(1237, 49);
            this.buttonAddProduk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduk.Name = "buttonAddProduk";
            this.buttonAddProduk.Size = new System.Drawing.Size(261, 41);
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
            this.buttonSearch.Location = new System.Drawing.Point(488, 49);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 41);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(4, 52);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(463, 30);
            this.search.TabIndex = 23;
            // 
            // buttonOpnameStock
            // 
            this.buttonOpnameStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpnameStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonOpnameStock.FlatAppearance.BorderSize = 0;
            this.buttonOpnameStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpnameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpnameStock.ForeColor = System.Drawing.Color.White;
            this.buttonOpnameStock.Location = new System.Drawing.Point(1237, 109);
            this.buttonOpnameStock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpnameStock.Name = "buttonOpnameStock";
            this.buttonOpnameStock.Size = new System.Drawing.Size(261, 41);
            this.buttonOpnameStock.TabIndex = 26;
            this.buttonOpnameStock.Text = "OPNAME STOCK";
            this.buttonOpnameStock.UseVisualStyleBackColor = false;
            this.buttonOpnameStock.Click += new System.EventHandler(this.buttonOpnameStock_Click);
            // 
            // tabelInventori
            // 
            this.tabelInventori.AllowUserToAddRows = false;
            this.tabelInventori.AllowUserToDeleteRows = false;
            this.tabelInventori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelInventori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelInventori.Location = new System.Drawing.Point(4, 173);
            this.tabelInventori.Margin = new System.Windows.Forms.Padding(4);
            this.tabelInventori.Name = "tabelInventori";
            this.tabelInventori.ReadOnly = true;
            this.tabelInventori.Size = new System.Drawing.Size(1527, 669);
            this.tabelInventori.TabIndex = 27;
            this.tabelInventori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelInventori_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.buttonAddProduk);
            this.panel2.Controls.Add(this.buttonOpnameStock);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1529, 163);
            this.panel2.TabIndex = 29;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabelInventori, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1535, 846);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // Inventori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventori";
            this.Size = new System.Drawing.Size(1535, 846);
            ((System.ComponentModel.ISupportInitialize)(this.tabelInventori)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduk;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button buttonOpnameStock;
        private System.Windows.Forms.DataGridView tabelInventori;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
