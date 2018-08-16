namespace Apps
{
    partial class Add_Penjualan
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonAddBarang = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.disc = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namaToko = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.noFaktur = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tglInvoice = new System.Windows.Forms.DateTimePicker();
            this.wilayahToko = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(962, 593);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(140, 31);
            this.buttonNext.TabIndex = 64;
            this.buttonNext.Text = "SAVE";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonAddBarang
            // 
            this.buttonAddBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddBarang.FlatAppearance.BorderSize = 0;
            this.buttonAddBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBarang.ForeColor = System.Drawing.Color.White;
            this.buttonAddBarang.Location = new System.Drawing.Point(36, 195);
            this.buttonAddBarang.Name = "buttonAddBarang";
            this.buttonAddBarang.Size = new System.Drawing.Size(140, 31);
            this.buttonAddBarang.TabIndex = 63;
            this.buttonAddBarang.Text = "+ ADD BARANG";
            this.buttonAddBarang.UseVisualStyleBackColor = false;
            this.buttonAddBarang.Click += new System.EventHandler(this.buttonAddBarang_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(963, 551);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(53, 19);
            this.total.TabIndex = 62;
            this.total.Text = "Rp. 0,-";
            // 
            // disc
            // 
            this.disc.AutoSize = true;
            this.disc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disc.Location = new System.Drawing.Point(963, 520);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(53, 19);
            this.disc.TabIndex = 61;
            this.disc.Text = "Rp. 0,-";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(963, 491);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(53, 19);
            this.subtotal.TabIndex = 60;
            this.subtotal.Text = "Rp. 0,-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(871, 551);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 19);
            this.label18.TabIndex = 59;
            this.label18.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(871, 520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 19);
            this.label17.TabIndex = 58;
            this.label17.Text = "Disc";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(871, 491);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 19);
            this.label16.TabIndex = 57;
            this.label16.Text = "Subtotal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(92, 593);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(411, 19);
            this.label14.TabIndex = 56;
            this.label14.Text = "- Pembayaran dengan giro/cheque dianggap sah setelah diuangkan.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 574);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "- Barang yang sudah dibeli tidak dapat dikembalikan.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "NB :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 491);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 52;
            this.label13.Text = "Terbilang :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1066, 229);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(812, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "No. Faktur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(812, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tanggal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nama Customer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "FAKTUR JUAL";
            // 
            // namaToko
            // 
            this.namaToko.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaToko.Location = new System.Drawing.Point(32, 22);
            this.namaToko.Name = "namaToko";
            this.namaToko.Size = new System.Drawing.Size(318, 32);
            this.namaToko.TabIndex = 37;
            this.namaToko.Text = "[Nama toko]";
            this.namaToko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 141);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 25);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // noFaktur
            // 
            this.noFaktur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFaktur.Location = new System.Drawing.Point(931, 96);
            this.noFaktur.Name = "noFaktur";
            this.noFaktur.Size = new System.Drawing.Size(172, 26);
            this.noFaktur.TabIndex = 66;
            this.noFaktur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noFaktur_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(112, 491);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 79);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            // 
            // tglInvoice
            // 
            this.tglInvoice.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglInvoice.Location = new System.Drawing.Point(931, 135);
            this.tglInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.tglInvoice.Name = "tglInvoice";
            this.tglInvoice.Size = new System.Drawing.Size(172, 20);
            this.tglInvoice.TabIndex = 69;
            this.tglInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tglInvoice_KeyDown);
            // 
            // wilayahToko
            // 
            this.wilayahToko.Location = new System.Drawing.Point(32, 64);
            this.wilayahToko.Name = "wilayahToko";
            this.wilayahToko.Size = new System.Drawing.Size(318, 32);
            this.wilayahToko.TabIndex = 0;
            this.wilayahToko.Text = "[wilayahToko]";
            this.wilayahToko.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Add_Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 647);
            this.Controls.Add(this.wilayahToko);
            this.Controls.Add(this.tglInvoice);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.noFaktur);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonAddBarang);
            this.Controls.Add(this.total);
            this.Controls.Add(this.disc);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namaToko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_Penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAddBarang;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label disc;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namaToko;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox noFaktur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker tglInvoice;
        private System.Windows.Forms.Label wilayahToko;
    }
}