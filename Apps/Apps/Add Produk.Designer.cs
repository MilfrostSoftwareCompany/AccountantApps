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
            this.labelIdBarang = new System.Windows.Forms.Label();
            this.labelStokBarang = new System.Windows.Forms.Label();
            this.comboBoxIdBarang = new System.Windows.Forms.ComboBox();
            this.StokBarang = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIdBarang
            // 
            this.labelIdBarang.AutoSize = true;
            this.labelIdBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBarang.Location = new System.Drawing.Point(22, 22);
            this.labelIdBarang.Name = "labelIdBarang";
            this.labelIdBarang.Size = new System.Drawing.Size(79, 20);
            this.labelIdBarang.TabIndex = 0;
            this.labelIdBarang.Text = "Id Barang";
            // 
            // labelStokBarang
            // 
            this.labelStokBarang.AutoSize = true;
            this.labelStokBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStokBarang.Location = new System.Drawing.Point(22, 71);
            this.labelStokBarang.Name = "labelStokBarang";
            this.labelStokBarang.Size = new System.Drawing.Size(104, 20);
            this.labelStokBarang.TabIndex = 1;
            this.labelStokBarang.Text = "Stok Gudang";
            // 
            // comboBoxIdBarang
            // 
            this.comboBoxIdBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdBarang.FormattingEnabled = true;
            this.comboBoxIdBarang.Location = new System.Drawing.Point(180, 19);
            this.comboBoxIdBarang.Name = "comboBoxIdBarang";
            this.comboBoxIdBarang.Size = new System.Drawing.Size(163, 28);
            this.comboBoxIdBarang.TabIndex = 2;
            // 
            // StokBarang
            // 
            this.StokBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokBarang.Location = new System.Drawing.Point(180, 70);
            this.StokBarang.Name = "StokBarang";
            this.StokBarang.Size = new System.Drawing.Size(163, 26);
            this.StokBarang.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(230, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 41);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Add_Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 182);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.StokBarang);
            this.Controls.Add(this.comboBoxIdBarang);
            this.Controls.Add(this.labelStokBarang);
            this.Controls.Add(this.labelIdBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Produk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Produk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdBarang;
        private System.Windows.Forms.Label labelStokBarang;
        private System.Windows.Forms.ComboBox comboBoxIdBarang;
        private System.Windows.Forms.TextBox StokBarang;
        private System.Windows.Forms.Button buttonSave;
    }
}