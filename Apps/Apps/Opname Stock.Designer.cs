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
            this.buttonSave = new System.Windows.Forms.Button();
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
            this.labelDariTgl.Location = new System.Drawing.Point(16, 32);
            this.labelDariTgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDariTgl.Name = "labelDariTgl";
            this.labelDariTgl.Size = new System.Drawing.Size(116, 25);
            this.labelDariTgl.TabIndex = 0;
            this.labelDariTgl.Text = "Dari tanggal";
            // 
            // labelSampaiTgl
            // 
            this.labelSampaiTgl.AutoSize = true;
            this.labelSampaiTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampaiTgl.Location = new System.Drawing.Point(16, 92);
            this.labelSampaiTgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSampaiTgl.Name = "labelSampaiTgl";
            this.labelSampaiTgl.Size = new System.Drawing.Size(148, 25);
            this.labelSampaiTgl.TabIndex = 1;
            this.labelSampaiTgl.Text = "Sampai tanggal";
            // 
            // tabelOpname
            // 
            this.tabelOpname.AllowUserToAddRows = false;
            this.tabelOpname.AllowUserToDeleteRows = false;
            this.tabelOpname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelOpname.Location = new System.Drawing.Point(21, 149);
            this.tabelOpname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabelOpname.Name = "tabelOpname";
            this.tabelOpname.Size = new System.Drawing.Size(835, 295);
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
            this.buttonAddProduk.Location = new System.Drawing.Point(653, 80);
            this.buttonAddProduk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddProduk.Name = "buttonAddProduk";
            this.buttonAddProduk.Size = new System.Drawing.Size(203, 37);
            this.buttonAddProduk.TabIndex = 5;
            this.buttonAddProduk.Text = "+ ADD PRODUK";
            this.buttonAddProduk.UseVisualStyleBackColor = false;
            this.buttonAddProduk.Click += new System.EventHandler(this.buttonAddProduk_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(477, 495);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 37);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // DariTgl
            // 
            this.DariTgl.Location = new System.Drawing.Point(204, 35);
            this.DariTgl.Name = "DariTgl";
            this.DariTgl.Size = new System.Drawing.Size(251, 22);
            this.DariTgl.TabIndex = 7;
            // 
            // SampaiTgl
            // 
            this.SampaiTgl.Location = new System.Drawing.Point(204, 95);
            this.SampaiTgl.Name = "SampaiTgl";
            this.SampaiTgl.Size = new System.Drawing.Size(251, 22);
            this.SampaiTgl.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 501);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 27);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 501);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
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
            this.button1.Location = new System.Drawing.Point(612, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPDATE AND SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opname_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SampaiTgl);
            this.Controls.Add(this.DariTgl);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddProduk);
            this.Controls.Add(this.tabelOpname);
            this.Controls.Add(this.labelSampaiTgl);
            this.Controls.Add(this.labelDariTgl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Opname_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opname_Stock";
            this.Load += new System.EventHandler(this.Opname_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelOpname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDariTgl;
        private System.Windows.Forms.Label labelSampaiTgl;
        private System.Windows.Forms.DataGridView tabelOpname;
        private System.Windows.Forms.Button buttonAddProduk;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker DariTgl;
        private System.Windows.Forms.DateTimePicker SampaiTgl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}