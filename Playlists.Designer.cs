namespace MusicPlayer
{
    partial class Playlists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlists));
            this.lstAllSongs = new System.Windows.Forms.ListBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.lbl_Volume = new MetroFramework.Controls.MetroLabel();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.gradientSidebar = new MusicPlayer.GradientPanel();
            this.btn_playing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.btn_explore = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.palSideBar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_bar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.btn_stop = new MetroFramework.Controls.MetroButton();
            this.btn_Pause = new MetroFramework.Controls.MetroButton();
            this.btn_play = new MetroFramework.Controls.MetroButton();
            this.btn_Previous = new MetroFramework.Controls.MetroButton();
            this.btn_Next = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.gradientSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            this.palSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllSongs
            // 
            this.lstAllSongs.BackColor = System.Drawing.Color.Azure;
            this.lstAllSongs.Font = new System.Drawing.Font("EagleSans-Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllSongs.FormattingEnabled = true;
            this.lstAllSongs.ItemHeight = 16;
            this.lstAllSongs.Location = new System.Drawing.Point(408, 153);
            this.lstAllSongs.Name = "lstAllSongs";
            this.lstAllSongs.ScrollAlwaysVisible = true;
            this.lstAllSongs.Size = new System.Drawing.Size(547, 356);
            this.lstAllSongs.TabIndex = 15;
            this.lstAllSongs.SelectedIndexChanged += new System.EventHandler(this.lstAllSongs_SelectedIndexChanged);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(955, 153);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(56, 350);
            this.track_volume.TabIndex = 16;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_Volume.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_Volume.Location = new System.Drawing.Point(955, 495);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(40, 17);
            this.lbl_Volume.TabIndex = 17;
            this.lbl_Volume.Text = "100%";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_start.Font = new System.Drawing.Font("EagleSans-Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Black;
            this.lbl_track_start.Location = new System.Drawing.Point(231, 542);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(51, 18);
            this.lbl_track_start.TabIndex = 20;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.BackColor = System.Drawing.Color.Transparent;
            this.lbl_track_end.Font = new System.Drawing.Font("EagleSans-Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.Black;
            this.lbl_track_end.Location = new System.Drawing.Point(944, 542);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(51, 18);
            this.lbl_track_end.TabIndex = 21;
            this.lbl_track_end.Text = "00:00";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(225, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(786, 198);
            this.player.TabIndex = 10;
            // 
            // gradientSidebar
            // 
            this.gradientSidebar.Angle = 30F;
            this.gradientSidebar.BackColor = System.Drawing.Color.Azure;
            this.gradientSidebar.BackgroundImage = global::MusicPlayer.Properties.Resources.bg_sidebar2;
            this.gradientSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientSidebar.BottomColor = System.Drawing.Color.Empty;
            this.gradientSidebar.Controls.Add(this.btn_playing);
            this.gradientSidebar.Controls.Add(this.button1);
            this.gradientSidebar.Controls.Add(this.btn_minimize);
            this.gradientSidebar.Controls.Add(this.btnAddSong);
            this.gradientSidebar.Controls.Add(this.pic_art);
            this.gradientSidebar.Controls.Add(this.btn_explore);
            this.gradientSidebar.Controls.Add(this.btn_exit);
            this.gradientSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientSidebar.Location = new System.Drawing.Point(0, 0);
            this.gradientSidebar.Name = "gradientSidebar";
            this.gradientSidebar.Size = new System.Drawing.Size(225, 607);
            this.gradientSidebar.TabIndex = 7;
            this.gradientSidebar.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // btn_playing
            // 
            this.btn_playing.BackColor = System.Drawing.Color.Transparent;
            this.btn_playing.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_playing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_playing.FlatAppearance.BorderSize = 0;
            this.btn_playing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playing.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playing.Image = global::MusicPlayer.Properties.Resources.home_btn;
            this.btn_playing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_playing.Location = new System.Drawing.Point(25, 232);
            this.btn_playing.Name = "btn_playing";
            this.btn_playing.Size = new System.Drawing.Size(175, 59);
            this.btn_playing.TabIndex = 1;
            this.btn_playing.Text = "Home";
            this.btn_playing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_playing.UseVisualStyleBackColor = false;
            this.btn_playing.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MusicPlayer.Properties.Resources.playlist_btn;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(25, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Playlists";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_minimize.Location = new System.Drawing.Point(3, 551);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(105, 44);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.Text = "Mini";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_mini);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSong.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btnAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSong.FlatAppearance.BorderSize = 0;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSong.Image")));
            this.btnAddSong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSong.Location = new System.Drawing.Point(25, 462);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(175, 59);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::MusicPlayer.Properties.Resources.profile;
            this.pic_art.Location = new System.Drawing.Point(25, 12);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(175, 195);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 0;
            this.pic_art.TabStop = false;
            this.pic_art.Click += new System.EventHandler(this.pic_art_Click);
            // 
            // btn_explore
            // 
            this.btn_explore.BackColor = System.Drawing.Color.Transparent;
            this.btn_explore.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_explore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_explore.FlatAppearance.BorderSize = 0;
            this.btn_explore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_explore.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_explore.Image = global::MusicPlayer.Properties.Resources.explore_btn;
            this.btn_explore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_explore.Location = new System.Drawing.Point(25, 309);
            this.btn_explore.Name = "btn_explore";
            this.btn_explore.Size = new System.Drawing.Size(175, 59);
            this.btn_explore.TabIndex = 2;
            this.btn_explore.Text = "Explore";
            this.btn_explore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_explore.UseVisualStyleBackColor = false;
            this.btn_explore.Click += new System.EventHandler(this.btn_explore_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("EagleSans-Regular", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(117, 551);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(105, 44);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // palSideBar
            // 
            this.palSideBar.BackColor = System.Drawing.Color.Gainsboro;
            this.palSideBar.Controls.Add(this.gradientSidebar);
            this.palSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.palSideBar.Location = new System.Drawing.Point(0, 0);
            this.palSideBar.Name = "palSideBar";
            this.palSideBar.Size = new System.Drawing.Size(225, 607);
            this.palSideBar.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p_bar
            // 
            this.p_bar.BackColor = System.Drawing.Color.Transparent;
            this.p_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_bar.Location = new System.Drawing.Point(231, 515);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(724, 24);
            this.p_bar.TabIndex = 24;
            this.p_bar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.BackColor = System.Drawing.Color.Azure;
            this.lstPlaylists.Font = new System.Drawing.Font("EagleSans-Regular", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 16;
            this.lstPlaylists.Location = new System.Drawing.Point(225, 153);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(183, 356);
            this.lstPlaylists.TabIndex = 25;
            this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Location = new System.Drawing.Point(816, 560);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(128, 44);
            this.btn_stop.TabIndex = 23;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseSelectable = true;
            this.btn_stop.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.Location = new System.Drawing.Point(682, 560);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(128, 44);
            this.btn_Pause.TabIndex = 14;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseSelectable = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Location = new System.Drawing.Point(548, 560);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(128, 44);
            this.btn_play.TabIndex = 13;
            this.btn_play.Text = "Play";
            this.btn_play.UseSelectable = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_Previous.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previous.Location = new System.Drawing.Point(414, 560);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(128, 44);
            this.btn_Previous.TabIndex = 12;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseSelectable = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.BackgroundImage = global::MusicPlayer.Properties.Resources.home_bg;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.Location = new System.Drawing.Point(280, 560);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(128, 44);
            this.btn_Next.TabIndex = 11;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseSelectable = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1011, 607);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lbl_Volume);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.lstAllSongs);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.player);
            this.Controls.Add(this.palSideBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Playlists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlists - Xây dựng ứng dụng nghe nhạc đơn giản";
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.gradientSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            this.palSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_Next;
        private MetroFramework.Controls.MetroButton btn_Previous;
        private MetroFramework.Controls.MetroButton btn_play;
        private MetroFramework.Controls.MetroButton btn_Pause;
        private System.Windows.Forms.ListBox lstAllSongs;
        private System.Windows.Forms.TrackBar track_volume;
        private MetroFramework.Controls.MetroLabel lbl_Volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private GradientPanel gradientSidebar;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.Button btn_playing;
        private System.Windows.Forms.Button btn_explore;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel palSideBar;
        private MetroFramework.Controls.MetroButton btn_stop;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TrackBar p_bar;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Button btn_minimize;
    }
}

