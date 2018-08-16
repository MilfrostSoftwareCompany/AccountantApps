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
            this.labelStokBarang.Location = new System.Drawing.Point(22, 31);
            this.labelStokBarang.Name = "labelStokBarang";
            this.labelStokBarang.Size = new System.Drawing.Size(107, 20);
            this.labelStokBarang.TabIndex = 1;
            this.labelStokBarang.Text = "Nama Barang";
            // 
            // namaBarang
            // 
            this.namaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBarang.Location = new System.Drawing.Point(180, 30);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(235, 26);
            this.namaBarang.TabIndex = 3;
            this.namaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namaBarang_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(301, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 41);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // jenisSatuan
            // 
            this.jenisSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisSatuan.Location = new System.Drawing.Point(180, 79);
            this.jenisSatuan.Name = "jenisSatuan";
            this.jenisSatuan.Size = new System.Drawing.Size(235, 26);
            this.jenisSatuan.TabIndex = 10;
            this.jenisSatuan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jenisSatuan_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jenis Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Jumlah";
            // 
            // jumlah
            // 
            this.jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(180, 179);
            this.jumlah.Margin = new System.Windows.Forms.Padding(2);
            this.jumlah.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.jumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(234, 26);
            this.jumlah.TabIndex = 15;
            this.jumlah.ThousandsSeparator = true;
            this.jumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jumlah_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
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
            this.harga.Location = new System.Drawing.Point(212, 129);
            this.harga.Margin = new System.Windows.Forms.Padding(2);
            this.harga.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(202, 26);
            this.harga.TabIndex = 17;
            this.harga.ThousandsSeparator = true;
            this.harga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.harga_KeyDown);
            // 
            // Add_Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 313);
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
            this.MaximizeBox = false;
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