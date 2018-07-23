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
            this.DariTgl = new System.Windows.Forms.TextBox();
            this.SampaiTgl = new System.Windows.Forms.TextBox();
            this.tabelOpname = new System.Windows.Forms.DataGridView();
            this.buttonAddProduk = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
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
            // DariTgl
            // 
            this.DariTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DariTgl.Location = new System.Drawing.Point(168, 28);
            this.DariTgl.Name = "DariTgl";
            this.DariTgl.Size = new System.Drawing.Size(155, 26);
            this.DariTgl.TabIndex = 2;
            // 
            // SampaiTgl
            // 
            this.SampaiTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampaiTgl.Location = new System.Drawing.Point(168, 72);
            this.SampaiTgl.Name = "SampaiTgl";
            this.SampaiTgl.Size = new System.Drawing.Size(155, 26);
            this.SampaiTgl.TabIndex = 3;
            // 
            // tabelOpname
            // 
            this.tabelOpname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelOpname.Location = new System.Drawing.Point(16, 121);
            this.tabelOpname.Name = "tabelOpname";
            this.tabelOpname.Size = new System.Drawing.Size(570, 240);
            this.tabelOpname.TabIndex = 4;
            // 
            // buttonAddProduk
            // 
            this.buttonAddProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddProduk.FlatAppearance.BorderSize = 0;
            this.buttonAddProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduk.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduk.Location = new System.Drawing.Point(434, 65);
            this.buttonAddProduk.Name = "buttonAddProduk";
            this.buttonAddProduk.Size = new System.Drawing.Size(152, 30);
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
            this.buttonSave.Location = new System.Drawing.Point(473, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Opname_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 432);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddProduk);
            this.Controls.Add(this.tabelOpname);
            this.Controls.Add(this.SampaiTgl);
            this.Controls.Add(this.DariTgl);
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
        private System.Windows.Forms.TextBox DariTgl;
        private System.Windows.Forms.TextBox SampaiTgl;
        private System.Windows.Forms.DataGridView tabelOpname;
        private System.Windows.Forms.Button buttonAddProduk;
        private System.Windows.Forms.Button buttonSave;
    }
}