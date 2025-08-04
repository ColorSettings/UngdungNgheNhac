using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Media;

namespace MusicPlayer
{
    public partial class Explore : Form
    {

        string connectionString = @"Server=COLORSETTINGS;Database=MusicPlayerDB;Trusted_Connection=True;";

        public Explore()
        {
            InitializeComponent();
            LoadAllSongs();
            track_volume.Value = 50;
            lbl_Volume.Text = "50%";
        }

        private void LoadAllSongs()
        {
            lstAllSongs.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT SongID, Title, FilePath FROM Songs";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lstAllSongs.Items.Add(new SongItem
                        {
                            SongID = (int)reader["SongID"],
                            Title = reader["Title"].ToString(),
                            FilePath = reader["FilePath"].ToString()
                        });
                    }

                    conn.Close();
                }

                lstAllSongs.DisplayMember = "Title";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading songs: " + ex.Message);
            }
        }

        public Point mouseLocation;
        public class SongItem
        {
            public int SongID { get; set; }
            public string Title { get; set; }
            public string FilePath { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }

        private void lstAllSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAllSongs.SelectedItem is SongItem selectedSong)
            {
                player.URL = selectedSong.FilePath;
                player.Ctlcontrols.play();

                try
                {
                    var file = TagLib.File.Create(selectedSong.FilePath);
                    if (file.Tag.Pictures.Length > 0)
                    {
                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                        pic_art.Image = Image.FromStream(new MemoryStream(bin));
                    }
                    else
                    {
                        pic_art.Image = Properties.Resources.profile; // No album art
                    }
                }
                catch
                {

                    pic_art.Image = Properties.Resources.profile;
                }
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (lstAllSongs.SelectedIndex < lstAllSongs.Items.Count - 1)
            {
                lstAllSongs.SelectedIndex = lstAllSongs.SelectedIndex + 1;
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (lstAllSongs.SelectedIndex > 0)
            {
                lstAllSongs.SelectedIndex = lstAllSongs.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying && player.currentMedia != null)
                {
                    p_bar.Maximum = (int)player.currentMedia.duration;
                    p_bar.Value = (int)player.Ctlcontrols.currentPosition;

                    lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_track_end.Text = player.currentMedia.durationString;
                }
                else
                {
                    lbl_track_start.Text = "00:00";
                    lbl_track_end.Text = "00:00";
                    p_bar.Value = 0;
                }
            }
            catch
            {

            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_Volume.Text = track_volume.Value.ToString() + "%";
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void p_bar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pic_art_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopMusic();

            Playlists newForm = new Playlists();
            newForm.Show();

            // Close or hide the current form
            this.Hide();
        }

        private void StopMusic()
        {
            player.Ctlcontrols.stop();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_playing_Click(object sender, EventArgs e)
        {
            StopMusic();

            Home newForm = new Home();
            newForm.Show();

            // Close or hide the current form
            this.Hide();
        }

        private void p_bar_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}
