using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Museum
{
    public partial class FormConsole : Form
    {
        LoginInfo loginInfo;
        bool playlistClicked = false;
        private int currentIndex = 0;
        SoundPlayer player = new SoundPlayer();
        Random random = new Random();
        String[] music = new string[]
        {
            "./music/Dimitris Mitropanos - Ta Ladadika.wav",
            "./music/ΕΡΩΤΑΣ ΑΡΧΑΓΓΕΛΟΣ - ΔΗΜΗΤΡΗΣ ΜΗΤΡΟΠΑΝΟΣ.wav",
            "./music/Κωνσταντίνος Αργυρός - Αθήνα Μου - Official Music Video  Konstantinos Argiros- Athina Mou.wav",
            "./music/Υπάρχω  Στέλιος Καζαντζίδης.wav"
        };

        public FormConsole(LoginInfo loginfo)
        {
            InitializeComponent();
            this.loginInfo = loginfo;
        }
        private void LoadMusic(int index)
        {
            string selectedMusic = music[index];
            player.SoundLocation = selectedMusic;
            try
            {
                player.Load();
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sound: {ex.Message}");
            }
        }

        private void comboBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = comboBoxPlaylist.SelectedIndex;
            LoadMusic(currentIndex);
        }

        private void buttonPlaylist_Click(object sender, EventArgs e)
            {
                if(playlistClicked == false) 
                {
                    comboBoxPlaylist.Visible = true;
                    playlistClicked = true;
                }
                else
                {
                    comboBoxPlaylist.Visible = false;
                    playlistClicked = false;
                }
            }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void buttonPlayRandom_Click(object sender, EventArgs e)
        {
            int randomNum = random.Next(0, 3);
            LoadMusic(randomNum);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            int volume = trackBarVolume.Value;
         
        }
    }
}
