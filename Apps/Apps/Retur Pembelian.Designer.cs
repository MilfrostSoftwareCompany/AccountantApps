﻿namespace Apps
{
    partial class Retur_Pembelian
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
            this.buttonRetur = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namasupplier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.RichTextBox();
            this.tambahProdukBtn = new System.Windows.Forms.Button();
            this.alamat = new System.Windows.Forms.Label();
            this.noFaktur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetur
            // 
            this.buttonRetur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonRetur.FlatAppearance.BorderSize = 0;
            this.buttonRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetur.ForeColor = System.Drawing.Color.White;
            this.buttonRetur.Location = new System.Drawing.Point(1281, 727);
            this.buttonRetur.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRetur.Name = "buttonRetur";
            this.buttonRetur.Size = new System.Drawing.Size(187, 38);
            this.buttonRetur.TabIndex = 116;
            this.buttonRetur.Text = "RETUR";
            this.buttonRetur.UseVisualStyleBackColor = false;
            this.buttonRetur.Click += new System.EventHandler(this.buttonRetur_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(1280, 654);
            this.total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(65, 22);
            this.total.TabIndex = 109;
            this.total.Text = "Rp. 0,-";
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc.Location = new System.Drawing.Point(1280, 615);
            this.disc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(65, 22);
            this.disc.TabIndex = 108;
            this.disc.Text = "Rp. 0,-";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(1280, 580);
            this.subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(65, 22);
            this.subtotal.TabIndex = 107;
            this.subtotal.Text = "Rp. 0,-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1157, 654);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 22);
            this.label18.TabIndex = 106;
            this.label18.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1157, 615);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 22);
            this.label17.TabIndex = 105;
            this.label17.Text = "Disc";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1157, 580);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 22);
            this.label16.TabIndex = 104;
            this.label16.Text = "Subtotal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 221);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1421, 313);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1079, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 102;
            this.label8.Text = "No. Faktur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1079, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 22);
            this.label7.TabIndex = 101;
            this.label7.Text = "Tanggal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Nama  Supplier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 35);
            this.label3.TabIndex = 99;
            this.label3.Text = "RETUR PEMBELIAN";
            // 
            // namasupplier
            // 
            this.namasupplier.AutoSize = true;
            this.namasupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namasupplier.Location = new System.Drawing.Point(213, 63);
            this.namasupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namasupplier.Name = "namasupplier";
            this.namasupplier.Size = new System.Drawing.Size(129, 22);
            this.namasupplier.TabIndex = 117;
            this.namasupplier.Text = "Nama Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 580);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = "Deskripsi :";
            // 
            // deskripsi
            // 
            this.deskripsi.Location = new System.Drawing.Point(148, 580);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(859, 96);
            this.deskripsi.TabIndex = 114;
            this.deskripsi.Text = "";
            // 
            // tambahProdukBtn
            // 
            this.tambahProdukBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.tambahProdukBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahProdukBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tambahProdukBtn.Location = new System.Drawing.Point(1239, 159);
            this.tambahProdukBtn.Name = "tambahProdukBtn";
            this.tambahProdukBtn.Size = new System.Drawing.Size(228, 47);
            this.tambahProdukBtn.TabIndex = 119;
            this.tambahProdukBtn.Text = "+ Tambah Produk";
            this.tambahProdukBtn.UseVisualStyleBackColor = false;
            this.tambahProdukBtn.Click += new System.EventHandler(this.tambahProdukBtn_Click);
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.Location = new System.Drawing.Point(213, 107);
            this.alamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(129, 22);
            this.alamat.TabIndex = 120;
            this.alamat.Text = "Nama Supplier";
            // 
            // noFaktur
            // 
            this.noFaktur.AutoSize = true;
            this.noFaktur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFaktur.Location = new System.Drawing.Point(1234, 80);
            this.noFaktur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noFaktur.Name = "noFaktur";
            this.noFaktur.Size = new System.Drawing.Size(17, 22);
            this.noFaktur.TabIndex = 121;
            this.noFaktur.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1079, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 122;
            this.label5.Text = "No. Retur :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1238, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 22);
            this.textBox1.TabIndex = 123;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(1238, 124);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(230, 22);
            this.tanggal.TabIndex = 124;
            // 
            // Retur_Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 796);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noFaktur);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.tambahProdukBtn);
            this.Controls.Add(this.namasupplier);
            this.Controls.Add(this.buttonRetur);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Retur_Pembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retur_Pembelian";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetur;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label disc;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namasupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox deskripsi;
        private System.Windows.Forms.Button tambahProdukBtn;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.Label noFaktur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker tanggal;
    }
}