namespace Wheel_Deal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Login_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Pass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UName_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.Login_btn);
            this.guna2Panel1.Controls.Add(this.Pass_txt);
            this.guna2Panel1.Controls.Add(this.UName_txt);
            this.guna2Panel1.Location = new System.Drawing.Point(55, 73);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(453, 375);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(141, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(159, 97);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BorderRadius = 20;
            this.Login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(32)))));
            this.Login_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(68)))), ((int)(((byte)(24)))));
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(130, 279);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(180, 45);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Login";
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Pass_txt
            // 
            this.Pass_txt.BorderRadius = 15;
            this.Pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_txt.DefaultText = "";
            this.Pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("Pass_txt.IconLeft")));
            this.Pass_txt.Location = new System.Drawing.Point(79, 198);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '\0';
            this.Pass_txt.PlaceholderText = "Password";
            this.Pass_txt.SelectedText = "";
            this.Pass_txt.Size = new System.Drawing.Size(290, 36);
            this.Pass_txt.TabIndex = 1;
            // 
            // UName_txt
            // 
            this.UName_txt.BorderRadius = 15;
            this.UName_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UName_txt.DefaultText = "";
            this.UName_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UName_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UName_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UName_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UName_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UName_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UName_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UName_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("UName_txt.IconLeft")));
            this.UName_txt.Location = new System.Drawing.Point(79, 137);
            this.UName_txt.Name = "UName_txt";
            this.UName_txt.PasswordChar = '\0';
            this.UName_txt.PlaceholderText = "Username";
            this.UName_txt.SelectedText = "";
            this.UName_txt.Size = new System.Drawing.Size(290, 36);
            this.UName_txt.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 570);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton Login_btn;
        private Guna.UI2.WinForms.Guna2TextBox Pass_txt;
        private Guna.UI2.WinForms.Guna2TextBox UName_txt;
    }
}