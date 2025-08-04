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
using static MusicPlayer.Playlists;

namespace MusicPlayer
{
    public partial class Playlists : Form
    {

        string connectionString = @"Server=COLORSETTINGS;Database=MusicPlayerDB;Trusted_Connection=True;";

        public Playlists()
        {
            InitializeComponent();
            LoadAllSongs();
            track_volume.Value = 50;
            lbl_Volume.Text = "50%";
            this.Load += new EventHandler(Playlist_Load);
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

        private void Playlist_Load(object sender, EventArgs e)
        {
            LoadPlaylists();
        }

        private void LoadPlaylists()
        {
            lstPlaylists.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PlaylistID, PlaylistName FROM Playlists";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstPlaylists.Items.Add(new PlaylistItem
                    {
                        ID = (int)reader["PlaylistID"],
                        Name = reader["PlaylistName"].ToString()
                    });
                }

                conn.Close();
            }

            lstPlaylists.DisplayMember = "Name";
            lstPlaylists.ValueMember = "ID";
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlaylists.SelectedItem != null)
            {
                PlaylistItem selectedPlaylist = (PlaylistItem)lstPlaylists.SelectedItem;

                // Debug test
                MessageBox.Show("Selected Playlist ID: " + selectedPlaylist.ID);

                LoadSongsByPlaylist(selectedPlaylist.ID);
            }
        }

        private void LoadSongsByPlaylist(int playlistId)
        {
            lstAllSongs.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT s.SongID, s.Title, s.FilePath
                FROM Songs s
                INNER JOIN PlaylistSongs ps ON s.SongID = ps.SongID
                WHERE ps.PlaylistID = @PlaylistID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PlaylistID", playlistId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        lstAllSongs.Items.Add(new SongItem
                        {
                            SongID = (int)reader["SongID"],
                            Title = reader["Title"].ToString(),
                            FilePath = reader["FilePath"].ToString()
                        });
                        count++;
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("No songs found for PlaylistID: " + playlistId);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            lstAllSongs.DisplayMember = "Title";
        }

        // --- Classes ---
        public class PlaylistItem
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString() => Name;
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MP3 files (*.mp3)|*.mp3";
                ofd.Title = "Select an MP3 file";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    string title = System.IO.Path.GetFileNameWithoutExtension(filePath);

                    int newSongID = -1;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Insert into Songs
                        string insertSong = "INSERT INTO Songs (Title, FilePath, Lyrics, ArtistID, GenreID) OUTPUT INSERTED.SongID VALUES (@Title, @Path, '', 1, 1)";
                        SqlCommand cmd = new SqlCommand(insertSong, conn);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Path", filePath);
                        newSongID = (int)cmd.ExecuteScalar();

                        // Optional: Assign to playlist if one is selected
                        if (lstPlaylists.SelectedItem != null)
                        {
                            PlaylistItem selected = (PlaylistItem)lstPlaylists.SelectedItem;
                            string insertToPlaylist = "INSERT INTO PlaylistSongs (PlaylistID, SongID) VALUES (@PlaylistID, @SongID)";
                            SqlCommand cmd2 = new SqlCommand(insertToPlaylist, conn);
                            cmd2.Parameters.AddWithValue("@PlaylistID", selected.ID);
                            cmd2.Parameters.AddWithValue("@SongID", newSongID);
                            cmd2.ExecuteNonQuery();
                        }

                        conn.Close();
                    }

                    MessageBox.Show("Song added successfully!");

                    // Reload songs if a playlist is selected
                    if (lstPlaylists.SelectedItem != null)
                    {
                        PlaylistItem selected = (PlaylistItem)lstPlaylists.SelectedItem;
                        LoadSongsByPlaylist(selected.ID);
                    }
                }
            }
        }

        private void btn_mini(object sender, EventArgs e)
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

        private void btn_explore_Click(object sender, EventArgs e)
        {
            StopMusic();

            Explore newForm = new Explore();
            newForm.Show();

            // Close or hide the current form
            this.Hide();
        }
        private void StopMusic()
        {
            player.Ctlcontrols.stop();
        }
    }
}

