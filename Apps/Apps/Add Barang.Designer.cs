namespace Apps
{
    partial class Add_Barang
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
            this.buttonAddBarang = new System.Windows.Forms.Button();
            this.jumlah = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jlhBarang = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jlhBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddBarang
            // 
            this.buttonAddBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddBarang.FlatAppearance.BorderSize = 0;
            this.buttonAddBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBarang.ForeColor = System.Drawing.Color.White;
            this.buttonAddBarang.Location = new System.Drawing.Point(268, 284);
            this.buttonAddBarang.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddBarang.Name = "buttonAddBarang";
            this.buttonAddBarang.Size = new System.Drawing.Size(187, 38);
            this.buttonAddBarang.TabIndex = 143;
            this.buttonAddBarang.Text = "Add Barang";
            this.buttonAddBarang.UseVisualStyleBackColor = false;
            this.buttonAddBarang.Click += new System.EventHandler(this.buttonAddBarang_Click);
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(20, 291);
            this.jumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(76, 25);
            this.jumlah.TabIndex = 141;
            this.jumlah.Text = "Jumlah";
            // 
            // Result
            // 
            this.Result.Controls.Add(this.label4);
            this.Result.Controls.Add(this.label3);
            this.Result.Controls.Add(this.label2);
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(65, 115);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(4);
            this.Result.Size = new System.Drawing.Size(353, 145);
            this.Result.TabIndex = 140;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock : 0 pcs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rp. 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 137;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 24);
            this.comboBox1.TabIndex = 144;
            // 
            // jlhBarang
            // 
            this.jlhBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlhBarang.Location = new System.Drawing.Point(102, 289);
            this.jlhBarang.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(68, 30);
            this.jlhBarang.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 146;
            this.label5.Text = "Select Product";
            // 
            // Add_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jlhBarang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAddBarang);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Barang";
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jlhBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBarang;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown jlhBarang;
        private System.Windows.Forms.Label label5;
    }
}