namespace Wheel_Deal
{
    partial class employeeInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeInfo));
            this.Employee_Retrieve = new Guna.UI2.WinForms.Guna2GradientButton();
            this.myDB = new Wheel_Deal.myDB();
            this.myDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.name_txt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.WELCOME = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientButton12 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LOG_OUT2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientButton11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel19 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton10 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtEmployee_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.Employee_Add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_Retrieve
            // 
            this.Employee_Retrieve.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Retrieve.BorderRadius = 20;
            this.Employee_Retrieve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Employee_Retrieve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Employee_Retrieve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Employee_Retrieve.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Employee_Retrieve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Employee_Retrieve.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
            this.Employee_Retrieve.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(68)))), ((int)(((byte)(24)))));
            this.Employee_Retrieve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Employee_Retrieve.ForeColor = System.Drawing.Color.White;
            this.Employee_Retrieve.Location = new System.Drawing.Point(484, 518);
            this.Employee_Retrieve.Name = "Employee_Retrieve";
            this.Employee_Retrieve.Size = new System.Drawing.Size(131, 45);
            this.Employee_Retrieve.TabIndex = 33;
            this.Employee_Retrieve.Text = "Retrieve Data";
            this.Employee_Retrieve.UseWaitCursor = true;
            this.Employee_Retrieve.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // myDB
            // 
            this.myDB.DataSetName = "myDBDataSet";
            this.myDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDGV
            // 
            this.employeeDGV.AllowUserToAddRows = false;
            this.employeeDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.employeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.employeeDGV.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.employeeDGV.ColumnHeadersHeight = 4;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.employeeDGV.GridColor = System.Drawing.Color.Black;
            this.employeeDGV.Location = new System.Drawing.Point(330, 27);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.ReadOnly = true;
            this.employeeDGV.RowHeadersVisible = false;
            this.employeeDGV.RowHeadersWidth = 51;
            this.employeeDGV.Size = new System.Drawing.Size(992, 454);
            this.employeeDGV.TabIndex = 34;
            this.employeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employeeDGV.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.employeeDGV.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.employeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.employeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employeeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.employeeDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.employeeDGV.ThemeStyle.ReadOnly = true;
            this.employeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.employeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employeeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.employeeDGV.ThemeStyle.RowsStyle.Height = 22;
            this.employeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.employeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.employeeDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDGV_CellClick);
            this.employeeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_CellContentClick);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.name_txt);
            this.guna2GradientPanel1.Controls.Add(this.WELCOME);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton12);
            this.guna2GradientPanel1.Controls.Add(this.LOG_OUT2);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton11);
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel19);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton10);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientButton9);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(235, 791);
            this.guna2GradientPanel1.TabIndex = 35;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.Transparent;
            this.name_txt.Location = new System.Drawing.Point(11, 754);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(86, 15);
            this.name_txt.TabIndex = 36;
            this.name_txt.Text = "guna2HtmlLabel5";
            // 
            // WELCOME
            // 
            this.WELCOME.BackColor = System.Drawing.Color.Transparent;
            this.WELCOME.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.WELCOME.Location = new System.Drawing.Point(11, 716);
            this.WELCOME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(83, 28);
            this.WELCOME.TabIndex = 35;
            this.WELCOME.Text = "WELCOME";
            // 
            // guna2GradientButton12
            // 
            this.guna2GradientButton12.Animated = true;
            this.guna2GradientButton12.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton12.BorderRadius = 10;
            this.guna2GradientButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton12.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton12.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton12.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.guna2GradientButton12.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton12.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton12.Image")));
            this.guna2GradientButton12.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton12.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton12.Location = new System.Drawing.Point(0, 424);
            this.guna2GradientButton12.Name = "guna2GradientButton12";
            this.guna2GradientButton12.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.guna2GradientButton12.Size = new System.Drawing.Size(232, 45);
            this.guna2GradientButton12.TabIndex = 4;
            this.guna2GradientButton12.Text = "Employees";
            // 
            // LOG_OUT2
            // 
            this.LOG_OUT2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LOG_OUT2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.LOG_OUT2.Image = ((System.Drawing.Image)(resources.GetObject("LOG_OUT2.Image")));
            this.LOG_OUT2.ImageOffset = new System.Drawing.Point(0, 0);
            this.LOG_OUT2.ImageRotate = 0F;
            this.LOG_OUT2.ImageSize = new System.Drawing.Size(30, 30);
            this.LOG_OUT2.Location = new System.Drawing.Point(173, 726);
            this.LOG_OUT2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LOG_OUT2.Name = "LOG_OUT2";
            this.LOG_OUT2.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.LOG_OUT2.Size = new System.Drawing.Size(48, 44);
            this.LOG_OUT2.TabIndex = 34;
            // 
            // guna2GradientButton11
            // 
            this.guna2GradientButton11.Animated = true;
            this.guna2GradientButton11.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton11.BorderRadius = 10;
            this.guna2GradientButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton11.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton11.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton11.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton11.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton11.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton11.Image")));
            this.guna2GradientButton11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton11.Location = new System.Drawing.Point(3, 347);
            this.guna2GradientButton11.Name = "guna2GradientButton11";
            this.guna2GradientButton11.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.guna2GradientButton11.Size = new System.Drawing.Size(229, 45);
            this.guna2GradientButton11.TabIndex = 3;
            this.guna2GradientButton11.Text = "Customers";
            this.guna2GradientButton11.Click += new System.EventHandler(this.guna2GradientButton11_Click);
            // 
            // guna2Panel19
            // 
            this.guna2Panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.guna2Panel19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel19.Location = new System.Drawing.Point(-2, 697);
            this.guna2Panel19.Name = "guna2Panel19";
            this.guna2Panel19.Size = new System.Drawing.Size(237, 3);
            this.guna2Panel19.TabIndex = 33;
            // 
            // guna2GradientButton10
            // 
            this.guna2GradientButton10.Animated = true;
            this.guna2GradientButton10.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton10.BorderRadius = 10;
            this.guna2GradientButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton10.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton10.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton10.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.guna2GradientButton10.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton10.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton10.Image")));
            this.guna2GradientButton10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton10.Location = new System.Drawing.Point(0, 271);
            this.guna2GradientButton10.Name = "guna2GradientButton10";
            this.guna2GradientButton10.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.guna2GradientButton10.Size = new System.Drawing.Size(232, 45);
            this.guna2GradientButton10.TabIndex = 2;
            this.guna2GradientButton10.Text = "Cars";
            this.guna2GradientButton10.Click += new System.EventHandler(this.guna2GradientButton10_Click);
            // 
            // guna2GradientButton9
            // 
            this.guna2GradientButton9.Animated = true;
            this.guna2GradientButton9.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton9.BorderRadius = 10;
            this.guna2GradientButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientButton9.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientButton9.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton9.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton9.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton9.Image")));
            this.guna2GradientButton9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton9.Location = new System.Drawing.Point(0, 193);
            this.guna2GradientButton9.Name = "guna2GradientButton9";
            this.guna2GradientButton9.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
            this.guna2GradientButton9.Size = new System.Drawing.Size(232, 45);
            this.guna2GradientButton9.TabIndex = 1;
            this.guna2GradientButton9.Text = "Dashboard";
            this.guna2GradientButton9.Click += new System.EventHandler(this.guna2GradientButton9_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(11, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(210, 88);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AutoRoundedCorners = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 22;
            this.guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(68)))), ((int)(((byte)(24)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Location = new System.Drawing.Point(945, 592);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(183, 47);
            this.guna2GradientButton3.TabIndex = 39;
            this.guna2GradientButton3.Text = "Delete Employee";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // txtEmployee_search
            // 
            this.txtEmployee_search.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployee_search.BorderRadius = 20;
            this.txtEmployee_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployee_search.DefaultText = "";
            this.txtEmployee_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployee_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployee_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployee_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployee_search.FillColor = System.Drawing.Color.Transparent;
            this.txtEmployee_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployee_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployee_search.ForeColor = System.Drawing.Color.White;
            this.txtEmployee_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployee_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmployee_search.IconLeft")));
            this.txtEmployee_search.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtEmployee_search.Location = new System.Drawing.Point(674, 525);
            this.txtEmployee_search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmployee_search.Name = "txtEmployee_search";
            this.txtEmployee_search.PasswordChar = '\0';
            this.txtEmployee_search.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmployee_search.PlaceholderText = "search employee name.";
            this.txtEmployee_search.SelectedText = "";
            this.txtEmployee_search.Size = new System.Drawing.Size(499, 37);
            this.txtEmployee_search.TabIndex = 42;
            this.txtEmployee_search.TextChanged += new System.EventHandler(this.txtEmployee_search_TextChanged);
            // 
            // Employee_Add
            // 
            this.Employee_Add.Animated = true;
            this.Employee_Add.AutoRoundedCorners = true;
            this.Employee_Add.BackColor = System.Drawing.Color.Transparent;
            this.Employee_Add.BorderColor = System.Drawing.Color.Transparent;
            this.Employee_Add.BorderRadius = 22;
            this.Employee_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employee_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Employee_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Employee_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Employee_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Employee_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Employee_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
            this.Employee_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(68)))), ((int)(((byte)(24)))));
            this.Employee_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Employee_Add.ForeColor = System.Drawing.Color.MintCream;
            this.Employee_Add.Location = new System.Drawing.Point(587, 592);
            this.Employee_Add.Name = "Employee_Add";
            this.Employee_Add.Size = new System.Drawing.Size(183, 47);
            this.Employee_Add.TabIndex = 43;
            this.Employee_Add.Text = "Add Employee";
            this.Employee_Add.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1398, 9);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(48, 52);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 44;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // employeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wheel_Deal.Properties.Resources.abstract_black_background_sports_background_vector_327712121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 791);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.Employee_Add);
            this.Controls.Add(this.txtEmployee_search);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.employeeDGV);
            this.Controls.Add(this.Employee_Retrieve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "employeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeInfo";
            this.Load += new System.EventHandler(this.employeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Employee_Retrieve;
        private myDB myDB;
        private System.Windows.Forms.BindingSource myDBBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView employeeDGV;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel name_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel WELCOME;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton12;
        private Guna.UI2.WinForms.Guna2ImageButton LOG_OUT2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel19;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton10;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployee_search;
        private Guna.UI2.WinForms.Guna2GradientButton Employee_Add;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}