namespace Apps
{
    partial class List_Opname_Stock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddOpnameStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabelCustomer = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonAddOpnameStock);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 697);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 607);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonAddOpnameStock
            // 
            this.buttonAddOpnameStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOpnameStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddOpnameStock.FlatAppearance.BorderSize = 0;
            this.buttonAddOpnameStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOpnameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOpnameStock.ForeColor = System.Drawing.Color.White;
            this.buttonAddOpnameStock.Location = new System.Drawing.Point(781, 30);
            this.buttonAddOpnameStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddOpnameStock.Name = "buttonAddOpnameStock";
            this.buttonAddOpnameStock.Size = new System.Drawing.Size(293, 41);
            this.buttonAddOpnameStock.TabIndex = 14;
            this.buttonAddOpnameStock.Text = "+ ADD OPNAME STOCK";
            this.buttonAddOpnameStock.UseVisualStyleBackColor = false;
            this.buttonAddOpnameStock.Click += new System.EventHandler(this.buttonAddOpnameStock_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 90);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 97);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 599);
            this.panel3.TabIndex = 17;
            // 
            // tabelCustomer
            // 
            this.tabelCustomer.AllowUserToAddRows = false;
            this.tabelCustomer.AllowUserToDeleteRows = false;
            this.tabelCustomer.AllowUserToResizeColumns = false;
            this.tabelCustomer.AllowUserToResizeRows = false;
            this.tabelCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelCustomer.Location = new System.Drawing.Point(-573, -175);
            this.tabelCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelCustomer.Name = "tabelCustomer";
            this.tabelCustomer.ReadOnly = true;
            this.tabelCustomer.Size = new System.Drawing.Size(2221, 1132);
            this.tabelCustomer.TabIndex = 17;
            // 
            // List_Opname_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabelCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "List_Opname_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Opname_Stock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddOpnameStock;
        private System.Windows.Forms.DataGridView tabelCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}