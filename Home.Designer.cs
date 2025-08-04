namespace MusicPlayer
{
    partial class Home
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
            this.dateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.welcomeText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.profileBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTime.BackColor = System.Drawing.Color.Transparent;
            this.dateTime.BorderRadius = 20;
            this.dateTime.Checked = true;
            this.dateTime.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTime.FillColor = System.Drawing.Color.Transparent;
            this.dateTime.FocusedColor = System.Drawing.Color.Black;
            this.dateTime.Font = new System.Drawing.Font("EagleSans-Regular", 9F);
            this.dateTime.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime.Location = new System.Drawing.Point(750, 81);
            this.dateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(249, 36);
            this.dateTime.TabIndex = 2;
            this.dateTime.UseTransparentBackground = true;
            this.dateTime.Value = new System.DateTime(2025, 8, 4, 4, 0, 48, 508);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblTime.Location = new System.Drawing.Point(845, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 61);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // welcomeText
            // 
            this.welcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Font = new System.Drawing.Font("EagleSans-Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.White;
            this.welcomeText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.welcomeText.Location = new System.Drawing.Point(364, 111);
            this.welcomeText.Margin = new System.Windows.Forms.Padding(30);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Padding = new System.Windows.Forms.Padding(40);
            this.welcomeText.Size = new System.Drawing.Size(359, 130);
            this.welcomeText.TabIndex = 4;
            this.welcomeText.Text = "Welcome, User!       ";
            this.welcomeText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeText.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // profileBox
            // 
            this.profileBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.profileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBox.Image = global::MusicPlayer.Properties.Resources.profile;
            this.profileBox.Location = new System.Drawing.Point(391, 193);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(257, 256);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileBox.TabIndex = 5;
            this.profileBox.TabStop = false;
            this.profileBox.Click += new System.EventHandler(this.profileBox_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MusicPlayer.Properties.Resources.bg_home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 607);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - Xây dựng ứng dụng nghe nhạc đơn giản";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcomeText;
        private System.Windows.Forms.PictureBox profileBox;
    }
}