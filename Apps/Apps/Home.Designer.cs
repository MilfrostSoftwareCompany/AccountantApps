namespace Apps
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.pointer = new System.Windows.Forms.Panel();
            this.pengaturan = new System.Windows.Forms.Button();
            this.penjualan = new System.Windows.Forms.Button();
            this.pembelian = new System.Windows.Forms.Button();
            this.inventori = new System.Windows.Forms.Button();
            this.pelanggan = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.beliPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pengaturan2 = new Apps.Pengaturan();
            this.penjualan2 = new Apps.Penjualan();
            this.inventori2 = new Apps.Inventori();
            this.customer2 = new Apps.Customer();
            this.supplier2 = new Apps.Supplier();
            this.pembelian3 = new Apps.Pembelian();
            this.sidePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.beliPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointer
            // 
            this.pointer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.pointer.Location = new System.Drawing.Point(0, 25);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(13, 52);
            this.pointer.TabIndex = 2;
            // 
            // pengaturan
            // 
            this.pengaturan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pengaturan.FlatAppearance.BorderSize = 0;
            this.pengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pengaturan.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengaturan.ForeColor = System.Drawing.Color.White;
            this.pengaturan.Location = new System.Drawing.Point(0, 335);
            this.pengaturan.Name = "pengaturan";
            this.pengaturan.Size = new System.Drawing.Size(194, 52);
            this.pengaturan.TabIndex = 8;
            this.pengaturan.Text = "PENGATURAN";
            this.pengaturan.UseVisualStyleBackColor = false;
            this.pengaturan.Click += new System.EventHandler(this.button6_Click);
            // 
            // penjualan
            // 
            this.penjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.penjualan.FlatAppearance.BorderSize = 0;
            this.penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penjualan.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penjualan.ForeColor = System.Drawing.Color.White;
            this.penjualan.Location = new System.Drawing.Point(0, 273);
            this.penjualan.Name = "penjualan";
            this.penjualan.Size = new System.Drawing.Size(194, 52);
            this.penjualan.TabIndex = 7;
            this.penjualan.Text = "PENJUALAN";
            this.penjualan.UseVisualStyleBackColor = false;
            this.penjualan.Click += new System.EventHandler(this.button5_Click);
            // 
            // pembelian
            // 
            this.pembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pembelian.FlatAppearance.BorderSize = 0;
            this.pembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pembelian.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembelian.ForeColor = System.Drawing.Color.White;
            this.pembelian.Location = new System.Drawing.Point(0, 211);
            this.pembelian.Name = "pembelian";
            this.pembelian.Size = new System.Drawing.Size(194, 52);
            this.pembelian.TabIndex = 6;
            this.pembelian.Text = "PEMBELIAN";
            this.pembelian.UseVisualStyleBackColor = false;
            this.pembelian.Click += new System.EventHandler(this.button4_Click);
            // 
            // inventori
            // 
            this.inventori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inventori.FlatAppearance.BorderSize = 0;
            this.inventori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventori.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventori.ForeColor = System.Drawing.Color.White;
            this.inventori.Location = new System.Drawing.Point(0, 149);
            this.inventori.Name = "inventori";
            this.inventori.Size = new System.Drawing.Size(194, 52);
            this.inventori.TabIndex = 4;
            this.inventori.Text = "INVENTORI";
            this.inventori.UseVisualStyleBackColor = false;
            this.inventori.Click += new System.EventHandler(this.button3_Click);
            // 
            // pelanggan
            // 
            this.pelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pelanggan.FlatAppearance.BorderSize = 0;
            this.pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pelanggan.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelanggan.ForeColor = System.Drawing.Color.White;
            this.pelanggan.Location = new System.Drawing.Point(0, 87);
            this.pelanggan.Name = "pelanggan";
            this.pelanggan.Size = new System.Drawing.Size(194, 52);
            this.pelanggan.TabIndex = 5;
            this.pelanggan.Text = "PELANGGAN";
            this.pelanggan.UseVisualStyleBackColor = false;
            this.pelanggan.Click += new System.EventHandler(this.button2_Click);
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.supplier.FlatAppearance.BorderSize = 0;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.ForeColor = System.Drawing.Color.White;
            this.supplier.Location = new System.Drawing.Point(0, 25);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(194, 52);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "SUPPLIER";
            this.supplier.UseVisualStyleBackColor = false;
            this.supplier.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sidePanel.Controls.Add(this.pointer);
            this.sidePanel.Controls.Add(this.pengaturan);
            this.sidePanel.Controls.Add(this.penjualan);
            this.sidePanel.Controls.Add(this.pembelian);
            this.sidePanel.Controls.Add(this.inventori);
            this.sidePanel.Controls.Add(this.pelanggan);
            this.sidePanel.Controls.Add(this.supplier);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(205, 609);
            this.sidePanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.beliPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sidePanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 609);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // beliPanel
            // 
            this.beliPanel.Controls.Add(this.pembelian3);
            this.beliPanel.Controls.Add(this.pengaturan2);
            this.beliPanel.Controls.Add(this.penjualan2);
            this.beliPanel.Controls.Add(this.inventori2);
            this.beliPanel.Controls.Add(this.customer2);
            this.beliPanel.Controls.Add(this.supplier2);
            this.beliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beliPanel.Location = new System.Drawing.Point(207, 2);
            this.beliPanel.Margin = new System.Windows.Forms.Padding(2);
            this.beliPanel.Name = "beliPanel";
            this.beliPanel.Size = new System.Drawing.Size(819, 605);
            this.beliPanel.TabIndex = 11;
            // 
            // pengaturan2
            // 
            this.pengaturan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pengaturan2.Location = new System.Drawing.Point(0, 0);
            this.pengaturan2.Name = "pengaturan2";
            this.pengaturan2.Size = new System.Drawing.Size(819, 605);
            this.pengaturan2.TabIndex = 5;
            // 
            // penjualan2
            // 
            this.penjualan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penjualan2.Location = new System.Drawing.Point(0, 0);
            this.penjualan2.Name = "penjualan2";
            this.penjualan2.Size = new System.Drawing.Size(819, 605);
            this.penjualan2.TabIndex = 4;
            // 
            // inventori2
            // 
            this.inventori2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventori2.Location = new System.Drawing.Point(0, 0);
            this.inventori2.Name = "inventori2";
            this.inventori2.Size = new System.Drawing.Size(819, 605);
            this.inventori2.TabIndex = 2;
            // 
            // customer2
            // 
            this.customer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customer2.Location = new System.Drawing.Point(0, 0);
            this.customer2.Name = "customer2";
            this.customer2.Size = new System.Drawing.Size(819, 605);
            this.customer2.TabIndex = 1;
            // 
            // supplier2
            // 
            this.supplier2.BackColor = System.Drawing.SystemColors.Control;
            this.supplier2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplier2.Location = new System.Drawing.Point(0, 0);
            this.supplier2.Name = "supplier2";
            this.supplier2.Size = new System.Drawing.Size(819, 605);
            this.supplier2.TabIndex = 0;
            // 
            // pembelian3
            // 
            this.pembelian3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pembelian3.Location = new System.Drawing.Point(0, 0);
            this.pembelian3.Name = "pembelian3";
            this.pembelian3.Size = new System.Drawing.Size(819, 605);
            this.pembelian3.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.beliPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pointer;
        private System.Windows.Forms.Button pengaturan;
        private System.Windows.Forms.Button penjualan;
        private System.Windows.Forms.Button pembelian;
        private System.Windows.Forms.Button inventori;
        private System.Windows.Forms.Button pelanggan;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Panel sidePanel;
        private Customer customer1;
        private Supplier supplier1;
        private Pembelian pembelian1;
        private Pengaturan pengaturan1;
        private Inventori inventori1;
        private Penjualan penjualan1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel beliPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Supplier supplier2;
        private Customer customer2;
        private Inventori inventori2;
        private Pembelian pembelian2;
        private Pengaturan pengaturan2;
        private Penjualan penjualan2;
        private Pembelian pembelian3;
    }
}