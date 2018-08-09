namespace Apps
{
    partial class Add_Produk
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
            this.labelStokBarang = new System.Windows.Forms.Label();
            this.namaBarang = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.jenisSatuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStokBarang
            // 
            this.labelStokBarang.AutoSize = true;
            this.labelStokBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokBarang.Location = new System.Drawing.Point(29, 86);
            this.labelStokBarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStokBarang.Name = "labelStokBarang";
            this.labelStokBarang.Size = new System.Drawing.Size(132, 25);
            this.labelStokBarang.TabIndex = 1;
            this.labelStokBarang.Text = "Nama Barang";
            // 
            // namaBarang
            // 
            this.namaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBarang.Location = new System.Drawing.Point(240, 85);
            this.namaBarang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(312, 30);
            this.namaBarang.TabIndex = 3;
            this.namaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StokBarang_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(401, 361);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 50);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // jenisSatuan
            // 
            this.jenisSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisSatuan.Location = new System.Drawing.Point(240, 145);
            this.jenisSatuan.Margin = new System.Windows.Forms.Padding(4);
            this.jenisSatuan.Name = "jenisSatuan";
            this.jenisSatuan.Size = new System.Drawing.Size(312, 30);
            this.jenisSatuan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jenis Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Harga";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jumlah";
            // 
            // jumlah
            // 
            this.jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(240, 268);
            this.jumlah.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(312, 30);
            this.jumlah.TabIndex = 15;
            this.jumlah.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rp.";
            // 
            // harga
            // 
            this.harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.harga.Location = new System.Drawing.Point(283, 207);
            this.harga.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(269, 30);
            this.harga.TabIndex = 17;
            this.harga.ThousandsSeparator = true;
            // 
            // Add_Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 479);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jenisSatuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.namaBarang);
            this.Controls.Add(this.labelStokBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Produk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Produk";
            ((System.ComponentModel.ISupportInitialize)(this.jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStokBarang;
        private System.Windows.Forms.TextBox namaBarang;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox jenisSatuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown jumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown harga;
    }
}