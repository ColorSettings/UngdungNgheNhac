using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void profileBox_Click(object sender, EventArgs e)
        {
            // Create and show the new form
            Explore newForm = new Explore();
            newForm.Show();

            // Close or hide the current form
            this.Hide();
        }
    }
}
