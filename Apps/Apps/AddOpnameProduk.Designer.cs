namespace Apps
{
    partial class AddOpnameProduk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.produkList = new System.Windows.Forms.ComboBox();
            this.jlhBarang = new System.Windows.Forms.NumericUpDown();
            this.buttonTambahProduk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jlhBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // produkList
            // 
            this.produkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produkList.FormattingEnabled = true;
            this.produkList.Location = new System.Drawing.Point(141, 41);
            this.produkList.Margin = new System.Windows.Forms.Padding(2);
            this.produkList.Name = "produkList";
            this.produkList.Size = new System.Drawing.Size(237, 25);
            this.produkList.TabIndex = 2;
            this.produkList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produkList_KeyDown);
            // 
            // jlhBarang
            // 
            this.jlhBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlhBarang.Location = new System.Drawing.Point(141, 91);
            this.jlhBarang.Margin = new System.Windows.Forms.Padding(2);
            this.jlhBarang.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(86, 23);
            this.jlhBarang.TabIndex = 3;
            this.jlhBarang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jlhBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jlhBarang_KeyDown);
            // 
            // buttonTambahProduk
            // 
            this.buttonTambahProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonTambahProduk.FlatAppearance.BorderSize = 0;
            this.buttonTambahProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambahProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahProduk.ForeColor = System.Drawing.Color.White;
            this.buttonTambahProduk.Location = new System.Drawing.Point(211, 135);
            this.buttonTambahProduk.Name = "buttonTambahProduk";
            this.buttonTambahProduk.Size = new System.Drawing.Size(167, 31);
            this.buttonTambahProduk.TabIndex = 28;
            this.buttonTambahProduk.Text = "Tambah Produk";
            this.buttonTambahProduk.UseVisualStyleBackColor = false;
            this.buttonTambahProduk.Click += new System.EventHandler(this.buttonTambahProduk_Click);
            // 
            // AddOpnameProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 196);
            this.Controls.Add(this.buttonTambahProduk);
            this.Controls.Add(this.jlhBarang);
            this.Controls.Add(this.produkList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOpnameProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Produk";
            ((System.ComponentModel.ISupportInitialize)(this.jlhBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox produkList;
        private System.Windows.Forms.NumericUpDown jlhBarang;
        private System.Windows.Forms.Button buttonTambahProduk;
    }
}