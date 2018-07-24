namespace Apps
{
    partial class Add_Supplier
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
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.telp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.RichTextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonAddSupplier.FlatAppearance.BorderSize = 0;
            this.buttonAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonAddSupplier.Location = new System.Drawing.Point(399, 231);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(167, 31);
            this.buttonAddSupplier.TabIndex = 27;
            this.buttonAddSupplier.Text = "ADD SUPPLIER";
            this.buttonAddSupplier.UseVisualStyleBackColor = false;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // telp
            // 
            this.telp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telp.Location = new System.Drawing.Point(178, 189);
            this.telp.Name = "telp";
            this.telp.Size = new System.Drawing.Size(388, 26);
            this.telp.TabIndex = 26;
            this.telp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.telp_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telepon";
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(178, 62);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(388, 110);
            this.alamat.TabIndex = 24;
            this.alamat.Text = "";
            this.alamat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alamat_KeyDown);
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(178, 19);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(388, 26);
            this.nama.TabIndex = 23;
            this.nama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nama_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nama";
            // 
            // Add_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 281);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.telp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.TextBox telp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}