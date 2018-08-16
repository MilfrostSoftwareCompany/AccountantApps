namespace Apps
{
    partial class Opname_Stock
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
            this.labelDariTgl = new System.Windows.Forms.Label();
            this.labelSampaiTgl = new System.Windows.Forms.Label();
            this.tabelOpname = new System.Windows.Forms.DataGridView();
            this.buttonAddProduk = new System.Windows.Forms.Button();
            this.DariTgl = new System.Windows.Forms.DateTimePicker();
            this.SampaiTgl = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelOpname)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDariTgl
            // 
            this.labelDariTgl.AutoSize = true;
            this.labelDariTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDariTgl.Location = new System.Drawing.Point(12, 26);
            this.labelDariTgl.Name = "labelDariTgl";
            this.labelDariTgl.Size = new System.Drawing.Size(95, 20);
            this.labelDariTgl.TabIndex = 0;
            this.labelDariTgl.Text = "Dari tanggal";
            // 
            // labelSampaiTgl
            // 
            this.labelSampaiTgl.AutoSize = true;
            this.labelSampaiTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampaiTgl.Location = new System.Drawing.Point(12, 75);
            this.labelSampaiTgl.Name = "labelSampaiTgl";
            this.labelSampaiTgl.Size = new System.Drawing.Size(120, 20);
            this.labelSampaiTgl.TabIndex = 1;
            this.labelSampaiTgl.Text = "Sampai tanggal";
            // 
            // tabelOpname
            // 
            this.tabelOpname.AllowUserToAddRows = false;
            this.tabelOpname.AllowUserToDeleteRows = false;
            this.tabelOpname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelOpname.Location = new System.Drawing.Point(16, 121);
            this.tabelOpname.Name = "tabelOpname";
            this.tabelOpname.Size = new System.Drawing.Size(626, 240);
            this.tabelOpname.TabIndex = 4;
            this.tabelOpname.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelOpname_CellContentClick);
            // 
            // buttonAddProduk
            // 
            this.buttonAddProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddProduk.FlatAppearance.BorderSize = 0;
            this.buttonAddProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduk.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduk.Location = new System.Drawing.Point(490, 65);
            this.buttonAddProduk.Name = "buttonAddProduk";
            this.buttonAddProduk.Size = new System.Drawing.Size(152, 30);
            this.buttonAddProduk.TabIndex = 5;
            this.buttonAddProduk.Text = "+ ADD PRODUK";
            this.buttonAddProduk.UseVisualStyleBackColor = false;
            this.buttonAddProduk.Click += new System.EventHandler(this.buttonAddProduk_Click);
            // 
            // DariTgl
            // 
            this.DariTgl.Location = new System.Drawing.Point(153, 28);
            this.DariTgl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DariTgl.Name = "DariTgl";
            this.DariTgl.Size = new System.Drawing.Size(189, 20);
            this.DariTgl.TabIndex = 7;
            this.DariTgl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DariTgl_KeyDown);
            // 
            // SampaiTgl
            // 
            this.SampaiTgl.Location = new System.Drawing.Point(153, 77);
            this.SampaiTgl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SampaiTgl.Name = "SampaiTgl";
            this.SampaiTgl.Size = new System.Drawing.Size(189, 20);
            this.SampaiTgl.TabIndex = 8;
            this.SampaiTgl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SampaiTgl_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 407);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dikerjakan Oleh";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPDATE AND SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opname_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SampaiTgl);
            this.Controls.Add(this.DariTgl);
            this.Controls.Add(this.buttonAddProduk);
            this.Controls.Add(this.tabelOpname);
            this.Controls.Add(this.labelSampaiTgl);
            this.Controls.Add(this.labelDariTgl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Opname_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opname_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.tabelOpname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDariTgl;
        private System.Windows.Forms.Label labelSampaiTgl;
        private System.Windows.Forms.DataGridView tabelOpname;
        private System.Windows.Forms.Button buttonAddProduk;
        private System.Windows.Forms.DateTimePicker DariTgl;
        private System.Windows.Forms.DateTimePicker SampaiTgl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}