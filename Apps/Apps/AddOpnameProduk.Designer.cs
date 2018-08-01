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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jlhBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // produkList
            // 
            this.produkList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produkList.FormattingEnabled = true;
            this.produkList.Location = new System.Drawing.Point(194, 111);
            this.produkList.Name = "produkList";
            this.produkList.Size = new System.Drawing.Size(315, 28);
            this.produkList.TabIndex = 2;
            // 
            // jlhBarang
            // 
            this.jlhBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlhBarang.Location = new System.Drawing.Point(194, 172);
            this.jlhBarang.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(115, 27);
            this.jlhBarang.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tambah Produk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOpnameProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jlhBarang);
            this.Controls.Add(this.produkList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOpnameProduk";
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
        private System.Windows.Forms.Button button1;
    }
}