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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPembelian)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelPembelian
            // 
            this.tabelPembelian.AllowUserToAddRows = false;
            this.tabelPembelian.AllowUserToDeleteRows = false;
            this.tabelPembelian.AllowUserToResizeColumns = false;
            this.tabelPembelian.AllowUserToResizeRows = false;
            this.tabelPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPembelian.Location = new System.Drawing.Point(3, 86);
            this.tabelPembelian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelPembelian.Name = "tabelPembelian";
            this.tabelPembelian.ReadOnly = true;
            this.tabelPembelian.Size = new System.Drawing.Size(1529, 758);
            this.tabelPembelian.TabIndex = 23;
            // 
            // buttonAddPembelian
            // 
            this.buttonAddPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddPembelian.FlatAppearance.BorderSize = 0;
            this.buttonAddPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPembelian.ForeColor = System.Drawing.Color.White;
            this.buttonAddPembelian.Location = new System.Drawing.Point(1272, 30);
            this.buttonAddPembelian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPembelian.Name = "buttonAddPembelian";
            this.buttonAddPembelian.Size = new System.Drawing.Size(261, 41);
            this.buttonAddPembelian.TabIndex = 22;
            this.buttonAddPembelian.Text = "+ ADD PEMBELIAN";
            this.buttonAddPembelian.UseVisualStyleBackColor = false;
            //this.buttonAddPembelian.Click += new System.EventHandler(this.buttonAddPembelian_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(493, 26);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 41);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            //this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(4, 31);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(463, 30);
            this.search.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonAddPembelian);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 78);
            this.panel1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabelPembelian, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1535, 846);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pembelian";
            this.Size = new System.Drawing.Size(1535, 846);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPembelian)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelPembelian;
        private System.Windows.Forms.Button buttonAddPembelian;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
