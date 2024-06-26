﻿namespace CarRentSystem.Dashboard
{
    partial class DashboardAdmin
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
            this.logoutLabel = new System.Windows.Forms.Label();
            this.tipeIdentitasManagemen = new System.Windows.Forms.Label();
            this.managemenCarSeatLabel = new System.Windows.Forms.Label();
            this.manajemenMobilLabel = new System.Windows.Forms.Label();
            this.manajemenUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SettingsLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SettingsLabel);
            this.panel1.Controls.Add(this.logoutLabel);
            this.panel1.Controls.Add(this.tipeIdentitasManagemen);
            this.panel1.Controls.Add(this.managemenCarSeatLabel);
            this.panel1.Controls.Add(this.manajemenMobilLabel);
            this.panel1.Controls.Add(this.manajemenUserLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.panel1.Size = new System.Drawing.Size(410, 522);
            this.panel1.TabIndex = 0;
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
            this.logoutLabel.TabIndex = 5;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.Click += new System.EventHandler(this.logoutLabel_Click);
            // 
            // tipeIdentitasManagemen
            // 
            this.tipeIdentitasManagemen.AutoSize = true;
            this.tipeIdentitasManagemen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipeIdentitasManagemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipeIdentitasManagemen.Location = new System.Drawing.Point(32, 187);
            this.tipeIdentitasManagemen.Name = "tipeIdentitasManagemen";
            this.tipeIdentitasManagemen.Size = new System.Drawing.Size(350, 32);
            this.tipeIdentitasManagemen.TabIndex = 4;
            this.tipeIdentitasManagemen.Text = "Managemen Tipe Identitas";
            this.tipeIdentitasManagemen.Click += new System.EventHandler(this.tipeIdentitasManagemen_Click);
            // 
            // managemenCarSeatLabel
            // 
            this.managemenCarSeatLabel.AutoSize = true;
            this.managemenCarSeatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managemenCarSeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managemenCarSeatLabel.Location = new System.Drawing.Point(32, 155);
            this.managemenCarSeatLabel.Name = "managemenCarSeatLabel";
            this.managemenCarSeatLabel.Size = new System.Drawing.Size(278, 32);
            this.managemenCarSeatLabel.TabIndex = 3;
            this.managemenCarSeatLabel.Text = "Managemen Carseat";
            this.managemenCarSeatLabel.Click += new System.EventHandler(this.managemenCarSeatLabel_Click);
            // 
            // manajemenMobilLabel
            // 
            this.manajemenMobilLabel.AutoSize = true;
            this.manajemenMobilLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manajemenMobilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenMobilLabel.Location = new System.Drawing.Point(32, 123);
            this.manajemenMobilLabel.Name = "manajemenMobilLabel";
            this.manajemenMobilLabel.Size = new System.Drawing.Size(239, 32);
            this.manajemenMobilLabel.TabIndex = 2;
            this.manajemenMobilLabel.Text = "Manajemen Mobil";
            this.manajemenMobilLabel.Click += new System.EventHandler(this.manajemenMobilLabel_Click);
            // 
            // manajemenUserLabel
            // 
            this.manajemenUserLabel.AutoSize = true;
            this.manajemenUserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manajemenUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manajemenUserLabel.Location = new System.Drawing.Point(32, 91);
            this.manajemenUserLabel.Name = "manajemenUserLabel";
            this.manajemenUserLabel.Size = new System.Drawing.Size(229, 32);
            this.manajemenUserLabel.TabIndex = 1;
            this.manajemenUserLabel.Text = "Manajemen User";
            this.manajemenUserLabel.Click += new System.EventHandler(this.manajemenUserLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
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
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.Location = new System.Drawing.Point(32, 431);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(162, 32);
            this.SettingsLabel.TabIndex = 6;
            this.SettingsLabel.Text = "Pengaturan";
            this.SettingsLabel.Click += new System.EventHandler(this.SettingsLabel_Click);
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manajemenUserLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label manajemenMobilLabel;
        private System.Windows.Forms.Label managemenCarSeatLabel;
        private System.Windows.Forms.Label tipeIdentitasManagemen;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Label SettingsLabel;
    }
}