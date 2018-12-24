using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace BeatSaberAutoMapper
{
    public partial class BeatSaberAutoMapper : Form
    {
        public BeatSaberAutoMapper()
        {
            InitializeComponent();

            this.MinimumSize = new Size(600, 480);
            this.MaximumSize = new Size(600, 480);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("https://github.com/UntouchedOdin0/BeatSaberAutoMapper");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog songFile = new OpenFileDialog();

            songFile.Filter = "Beat Saber Audio File|*.ogg";
            songFile.Title = "Select the audio file";
            songFile.ShowDialog();

            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "Find your .ogg Song Path!";
            //fdlg.InitialDirectory = @"c:\";
            //fdlg.Filter = "All files (*.*) |*.*|All Files (*.*)|*.*)";
            //fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            //if (fdlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BeatSaberAutoMapper_Load(object sender, EventArgs e)
        {

        }

        private void debugInstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/invite/beatsabermods");
        }
    }
}
