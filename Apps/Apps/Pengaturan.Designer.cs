namespace Apps
{
    partial class Pengaturan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.gantiPassword = new System.Windows.Forms.Button();
            this.labelNamaToko = new System.Windows.Forms.Label();
            this.namaToko = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDaftarPemakai = new System.Windows.Forms.Label();
            this.tabelPemakai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPemakai)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(27, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(165, 31);
            this.username.TabIndex = 0;
            this.username.Text = "[Username]";
            // 
            // gantiPassword
            // 
            this.gantiPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.gantiPassword.FlatAppearance.BorderSize = 0;
            this.gantiPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gantiPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gantiPassword.ForeColor = System.Drawing.Color.White;
            this.gantiPassword.Location = new System.Drawing.Point(33, 66);
            this.gantiPassword.Name = "gantiPassword";
            this.gantiPassword.Size = new System.Drawing.Size(166, 36);
            this.gantiPassword.TabIndex = 1;
            this.gantiPassword.Text = "Ganti Password";
            this.gantiPassword.UseVisualStyleBackColor = false;
            this.gantiPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNamaToko
            // 
            this.labelNamaToko.AutoSize = true;
            this.labelNamaToko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaToko.Location = new System.Drawing.Point(27, 127);
            this.labelNamaToko.Name = "labelNamaToko";
            this.labelNamaToko.Size = new System.Drawing.Size(99, 20);
            this.labelNamaToko.TabIndex = 2;
            this.labelNamaToko.Text = "Nama Toko";
            // 
            // namaToko
            // 
            this.namaToko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaToko.Location = new System.Drawing.Point(155, 127);
            this.namaToko.Name = "namaToko";
            this.namaToko.Size = new System.Drawing.Size(374, 26);
            this.namaToko.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(196)))), ((int)(((byte)(252)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(554, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelDaftarPemakai
            // 
            this.labelDaftarPemakai.AutoSize = true;
            this.labelDaftarPemakai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarPemakai.Location = new System.Drawing.Point(29, 187);
            this.labelDaftarPemakai.Name = "labelDaftarPemakai";
            this.labelDaftarPemakai.Size = new System.Drawing.Size(163, 20);
            this.labelDaftarPemakai.TabIndex = 5;
            this.labelDaftarPemakai.Text = "DAFTAR PEMAKAI";
            // 
            // tabelPemakai
            // 
            this.tabelPemakai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPemakai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tabelPemakai.Location = new System.Drawing.Point(33, 233);
            this.tabelPemakai.Name = "tabelPemakai";
            this.tabelPemakai.Size = new System.Drawing.Size(596, 229);
            this.tabelPemakai.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Aktif";
            this.Column3.Name = "Column3";
            // 
            // Pengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelPemakai);
            this.Controls.Add(this.labelDaftarPemakai);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.namaToko);
            this.Controls.Add(this.labelNamaToko);
            this.Controls.Add(this.gantiPassword);
            this.Controls.Add(this.username);
            this.Name = "Pengaturan";
            this.Size = new System.Drawing.Size(1151, 687);
            ((System.ComponentModel.ISupportInitialize)(this.tabelPemakai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button gantiPassword;
        private System.Windows.Forms.Label labelNamaToko;
        private System.Windows.Forms.TextBox namaToko;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDaftarPemakai;
        private System.Windows.Forms.DataGridView tabelPemakai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
