namespace CarRentSystem.Manajemen.User
{
    partial class UserManagement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.dataCard3 = new System.Windows.Forms.Panel();
            this.editButton3 = new System.Windows.Forms.PictureBox();
            this.trashButton3 = new System.Windows.Forms.PictureBox();
            this.levelLabel3 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.usernameLabel3 = new System.Windows.Forms.Label();
            this.dataCard2 = new System.Windows.Forms.Panel();
            this.editButton2 = new System.Windows.Forms.PictureBox();
            this.trashButton2 = new System.Windows.Forms.PictureBox();
            this.levelLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.usernameLabel2 = new System.Windows.Forms.Label();
            this.dataCard1 = new System.Windows.Forms.Panel();
            this.editButton1 = new System.Windows.Forms.PictureBox();
            this.trashButton1 = new System.Windows.Forms.PictureBox();
            this.levelLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.usernameLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carRentSystemDataSet = new CarRentSystem.CarRentSystemDataSet();
            this.usersTableAdapter = new CarRentSystem.CarRentSystemDataSetTableAdapters.usersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dataCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton3)).BeginInit();
            this.dataCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton2)).BeginInit();
            this.dataCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carRentSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard → Manajemen User";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.prevButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.dataCard3);
            this.panel1.Controls.Add(this.dataCard2);
            this.panel1.Controls.Add(this.dataCard1);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 699);
            this.panel1.TabIndex = 6;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(385, 43);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 30);
            this.searchBar.TabIndex = 10;
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // newButton
            // 
            this.newButton.AutoSize = true;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(38, 38);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(91, 35);
            this.newButton.TabIndex = 9;
            this.newButton.Text = "+ New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevButton.AutoSize = true;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevButton.Location = new System.Drawing.Point(38, 634);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(123, 35);
            this.prevButton.TabIndex = 8;
            this.prevButton.Text = "← Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextButton.AutoSize = true;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(192, 634);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(87, 35);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next →";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // dataCard3
            // 
            this.dataCard3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCard3.BackColor = System.Drawing.SystemColors.Control;
            this.dataCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataCard3.Controls.Add(this.editButton3);
            this.dataCard3.Controls.Add(this.trashButton3);
            this.dataCard3.Controls.Add(this.levelLabel3);
            this.dataCard3.Controls.Add(this.nameLabel3);
            this.dataCard3.Controls.Add(this.usernameLabel3);
            this.dataCard3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataCard3.Location = new System.Drawing.Point(38, 438);
            this.dataCard3.Name = "dataCard3";
            this.dataCard3.Size = new System.Drawing.Size(709, 153);
            this.dataCard3.TabIndex = 6;
            // 
            // editButton3
            // 
            this.editButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton3.Image = global::CarRentSystem.Properties.Resources.edit_icon_png_3602;
            this.editButton3.Location = new System.Drawing.Point(588, 20);
            this.editButton3.Name = "editButton3";
            this.editButton3.Size = new System.Drawing.Size(45, 45);
            this.editButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButton3.TabIndex = 4;
            this.editButton3.TabStop = false;
            this.editButton3.Click += new System.EventHandler(this.editButton3_Click);
            // 
            // trashButton3
            // 
            this.trashButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trashButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashButton3.Image = global::CarRentSystem.Properties.Resources.trash_can_icon_28689;
            this.trashButton3.Location = new System.Drawing.Point(639, 20);
            this.trashButton3.Name = "trashButton3";
            this.trashButton3.Size = new System.Drawing.Size(45, 45);
            this.trashButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trashButton3.TabIndex = 3;
            this.trashButton3.TabStop = false;
            this.trashButton3.Click += new System.EventHandler(this.trashButton3_Click);
            // 
            // levelLabel3
            // 
            this.levelLabel3.AutoSize = true;
            this.levelLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.levelLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel3.Location = new System.Drawing.Point(21, 108);
            this.levelLabel3.Name = "levelLabel3";
            this.levelLabel3.Size = new System.Drawing.Size(59, 25);
            this.levelLabel3.TabIndex = 2;
            this.levelLabel3.Text = "Level";
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.Location = new System.Drawing.Point(21, 83);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(61, 25);
            this.nameLabel3.TabIndex = 1;
            this.nameLabel3.Text = "name";
            // 
            // usernameLabel3
            // 
            this.usernameLabel3.AutoSize = true;
            this.usernameLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel3.Location = new System.Drawing.Point(20, 20);
            this.usernameLabel3.Name = "usernameLabel3";
            this.usernameLabel3.Size = new System.Drawing.Size(152, 32);
            this.usernameLabel3.TabIndex = 0;
            this.usernameLabel3.Text = "Username";
            // 
            // dataCard2
            // 
            this.dataCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCard2.BackColor = System.Drawing.SystemColors.Control;
            this.dataCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataCard2.Controls.Add(this.editButton2);
            this.dataCard2.Controls.Add(this.trashButton2);
            this.dataCard2.Controls.Add(this.levelLabel2);
            this.dataCard2.Controls.Add(this.nameLabel2);
            this.dataCard2.Controls.Add(this.usernameLabel2);
            this.dataCard2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataCard2.Location = new System.Drawing.Point(38, 263);
            this.dataCard2.Name = "dataCard2";
            this.dataCard2.Size = new System.Drawing.Size(709, 153);
            this.dataCard2.TabIndex = 5;
            // 
            // editButton2
            // 
            this.editButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton2.Image = global::CarRentSystem.Properties.Resources.edit_icon_png_3602;
            this.editButton2.Location = new System.Drawing.Point(588, 20);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(45, 45);
            this.editButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButton2.TabIndex = 4;
            this.editButton2.TabStop = false;
            this.editButton2.Click += new System.EventHandler(this.editButton2_Click);
            // 
            // trashButton2
            // 
            this.trashButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trashButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashButton2.Image = global::CarRentSystem.Properties.Resources.trash_can_icon_28689;
            this.trashButton2.Location = new System.Drawing.Point(639, 20);
            this.trashButton2.Name = "trashButton2";
            this.trashButton2.Size = new System.Drawing.Size(45, 45);
            this.trashButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trashButton2.TabIndex = 3;
            this.trashButton2.TabStop = false;
            this.trashButton2.Click += new System.EventHandler(this.trashButton2_Click);
            // 
            // levelLabel2
            // 
            this.levelLabel2.AutoSize = true;
            this.levelLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.levelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel2.Location = new System.Drawing.Point(21, 108);
            this.levelLabel2.Name = "levelLabel2";
            this.levelLabel2.Size = new System.Drawing.Size(59, 25);
            this.levelLabel2.TabIndex = 2;
            this.levelLabel2.Text = "Level";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(21, 83);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(61, 25);
            this.nameLabel2.TabIndex = 1;
            this.nameLabel2.Text = "name";
            // 
            // usernameLabel2
            // 
            this.usernameLabel2.AutoSize = true;
            this.usernameLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel2.Location = new System.Drawing.Point(20, 20);
            this.usernameLabel2.Name = "usernameLabel2";
            this.usernameLabel2.Size = new System.Drawing.Size(152, 32);
            this.usernameLabel2.TabIndex = 0;
            this.usernameLabel2.Text = "Username";
            // 
            // dataCard1
            // 
            this.dataCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCard1.BackColor = System.Drawing.SystemColors.Control;
            this.dataCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataCard1.Controls.Add(this.editButton1);
            this.dataCard1.Controls.Add(this.trashButton1);
            this.dataCard1.Controls.Add(this.levelLabel1);
            this.dataCard1.Controls.Add(this.nameLabel1);
            this.dataCard1.Controls.Add(this.usernameLabel1);
            this.dataCard1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataCard1.Location = new System.Drawing.Point(38, 88);
            this.dataCard1.Name = "dataCard1";
            this.dataCard1.Size = new System.Drawing.Size(709, 153);
            this.dataCard1.TabIndex = 0;
            // 
            // editButton1
            // 
            this.editButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton1.Image = global::CarRentSystem.Properties.Resources.edit_icon_png_3602;
            this.editButton1.Location = new System.Drawing.Point(588, 20);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(45, 45);
            this.editButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButton1.TabIndex = 4;
            this.editButton1.TabStop = false;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // trashButton1
            // 
            this.trashButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trashButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trashButton1.Image = global::CarRentSystem.Properties.Resources.trash_can_icon_28689;
            this.trashButton1.Location = new System.Drawing.Point(639, 20);
            this.trashButton1.Name = "trashButton1";
            this.trashButton1.Size = new System.Drawing.Size(45, 45);
            this.trashButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trashButton1.TabIndex = 3;
            this.trashButton1.TabStop = false;
            this.trashButton1.Click += new System.EventHandler(this.trashButton1_Click);
            // 
            // levelLabel1
            // 
            this.levelLabel1.AutoSize = true;
            this.levelLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.levelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel1.Location = new System.Drawing.Point(21, 108);
            this.levelLabel1.Name = "levelLabel1";
            this.levelLabel1.Size = new System.Drawing.Size(59, 25);
            this.levelLabel1.TabIndex = 2;
            this.levelLabel1.Text = "Level";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(21, 83);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(61, 25);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "name";
            // 
            // usernameLabel1
            // 
            this.usernameLabel1.AutoSize = true;
            this.usernameLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usernameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel1.Location = new System.Drawing.Point(20, 20);
            this.usernameLabel1.Name = "usernameLabel1";
            this.usernameLabel1.Size = new System.Drawing.Size(152, 32);
            this.usernameLabel1.TabIndex = 0;
            this.usernameLabel1.Text = "Username";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(791, 805);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // carRentSystemDataSet
            // 
            this.carRentSystemDataSet.DataSetName = "CarRentSystemDataSet";
            this.carRentSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search :";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilterButton.AutoSize = true;
            this.clearFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterButton.Location = new System.Drawing.Point(656, 41);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(91, 35);
            this.clearFilterButton.TabIndex = 12;
            this.clearFilterButton.Text = "Clear";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dataCard3.ResumeLayout(false);
            this.dataCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton3)).EndInit();
            this.dataCard2.ResumeLayout(false);
            this.dataCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton2)).EndInit();
            this.dataCard1.ResumeLayout(false);
            this.dataCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashButton1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carRentSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CarRentSystemDataSet carRentSystemDataSet;
        private CarRentSystemDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel dataCard1;
        private System.Windows.Forms.Label usernameLabel1;
        private System.Windows.Forms.PictureBox trashButton1;
        private System.Windows.Forms.Label levelLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox editButton1;
        private System.Windows.Forms.Panel dataCard3;
        private System.Windows.Forms.PictureBox editButton3;
        private System.Windows.Forms.PictureBox trashButton3;
        private System.Windows.Forms.Label levelLabel3;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label usernameLabel3;
        private System.Windows.Forms.Panel dataCard2;
        private System.Windows.Forms.PictureBox editButton2;
        private System.Windows.Forms.PictureBox trashButton2;
        private System.Windows.Forms.Label levelLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label usernameLabel2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Label label2;
    }
}