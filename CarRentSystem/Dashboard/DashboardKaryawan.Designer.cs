namespace CarRentSystem.Dashboard
{
    partial class DashboardKaryawan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.manajemenPelangganLabel = new System.Windows.Forms.Label();
            this.manajemenRiwayatTransasksiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 522);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SettingsLabel);
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.manajemenPelangganLabel);
            this.panel1.Controls.Add(this.manajemenRiwayatTransasksiLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.panel1.Size = new System.Drawing.Size(410, 522);
            this.panel1.TabIndex = 0;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(32, 431);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(162, 32);
            this.SettingsLabel.TabIndex = 7;
            this.SettingsLabel.Text = "Pengaturan";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            // 
            // logoutLabel
            // 
            this.logoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Location = new System.Drawing.Point(32, 463);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(102, 32);
            this.logoutLabel.TabIndex = 6;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // manajemenPelangganLabel
            // 
            this.manajemenPelangganLabel.AutoSize = true;
            this.manajemenPelangganLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manajemenPelangganLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenPelangganLabel.Location = new System.Drawing.Point(32, 158);
            this.manajemenPelangganLabel.Name = "manajemenPelangganLabel";
            this.manajemenPelangganLabel.Size = new System.Drawing.Size(308, 32);
            this.manajemenPelangganLabel.TabIndex = 2;
            this.manajemenPelangganLabel.Text = "Manajemen Pelanggan";
            this.manajemenPelangganLabel.Click += new System.EventHandler(this.manajemenPelangganLabel_Click);
            // 
            // manajemenRiwayatTransasksiLabel
            // 
            this.manajemenRiwayatTransasksiLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manajemenRiwayatTransasksiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenRiwayatTransasksiLabel.Location = new System.Drawing.Point(32, 91);
            this.manajemenRiwayatTransasksiLabel.Name = "manajemenRiwayatTransasksiLabel";
            this.manajemenRiwayatTransasksiLabel.Size = new System.Drawing.Size(274, 67);
            this.manajemenRiwayatTransasksiLabel.TabIndex = 1;
            this.manajemenRiwayatTransasksiLabel.Text = "Manajemen Riwayat Transaksi";
            this.manajemenRiwayatTransasksiLabel.Click += new System.EventHandler(this.manajemenRiwayatTransasksiLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karyawan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(410, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(540, 522);
            this.contentPanel.TabIndex = 1;
            // 
            // DashboardKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardKaryawan";
            this.Text = "DashboardKaryawan";
            this.Load += new System.EventHandler(this.DashboardKaryawan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label manajemenPelangganLabel;
        private System.Windows.Forms.Label manajemenRiwayatTransasksiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label SettingsLabel;
    }
}