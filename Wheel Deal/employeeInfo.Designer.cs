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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeInfo));
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.myDB = new Wheel_Deal.myDB();
            this.myDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.WELCOME = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientButton12 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LOG_OUT2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GradientButton11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel19 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton10 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 20;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(68)))), ((int)(((byte)(24)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Location = new System.Drawing.Point(820, 541);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(131, 45);
            this.guna2GradientButton2.TabIndex = 33;
            this.guna2GradientButton2.Text = "Retrieve Data";
            this.guna2GradientButton2.UseWaitCursor = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // myDB
            // 
            this.myDB.DataSetName = "myDBDataSet";
            this.myDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee
            // 
            this.employee.AllowUserToAddRows = false;
            this.employee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employee.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.employee.GridColor = System.Drawing.Color.Black;
            this.employee.Location = new System.Drawing.Point(589, 92);
            this.employee.Name = "employee";
            this.employee.ReadOnly = true;
            this.employee.RowHeadersVisible = false;
            this.employee.RowHeadersWidth = 51;
            this.employee.Size = new System.Drawing.Size(628, 401);
            this.employee.TabIndex = 34;
            this.employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.employee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.employee.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.employee.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.ThemeStyle.HeaderStyle.Height = 4;
            this.employee.ThemeStyle.ReadOnly = true;
            this.employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.employee.ThemeStyle.RowsStyle.Height = 22;
            this.employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_CellContentClick);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel5);
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
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(11, 754);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel5.TabIndex = 36;
            this.guna2HtmlLabel5.Text = "guna2HtmlLabel5";
            // 
            // WELCOME
            // 
            this.WELCOME.BackColor = System.Drawing.Color.Transparent;
            this.WELCOME.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.WELCOME.Location = new System.Drawing.Point(11, 716);
            this.WELCOME.Margin = new System.Windows.Forms.Padding(2);
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
            this.LOG_OUT2.Margin = new System.Windows.Forms.Padding(2);
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
            // employeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wheel_Deal.Properties.Resources.abstract_black_background_sports_background_vector_327712121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 791);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.guna2GradientButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "employeeInfo";
            this.Text = "employeeInfo";
            this.Load += new System.EventHandler(this.employeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private myDB myDB;
        private System.Windows.Forms.BindingSource myDBBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView employee;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel WELCOME;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton12;
        private Guna.UI2.WinForms.Guna2ImageButton LOG_OUT2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel19;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton10;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}