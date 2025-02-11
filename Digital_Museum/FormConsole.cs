﻿using System;
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
        SoundPlayer playerKaraoke = new SoundPlayer("./musicKaraoke/karaoke.wav");
        Random random = new Random();
        string[] music = new string[]
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
            playerKaraoke.Stop();
        }

        private void buttonPlayRandom_Click(object sender, EventArgs e)
        {
            int randomNum = random.Next(0, 4);
            comboBoxPlaylist.SelectedIndex = randomNum;
        }

        private void buttonKaraoke_Click(object sender, EventArgs e)
        {
            playerKaraoke.Play();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void buttonNextSong_Click(object sender, EventArgs e)
        {
            if (currentIndex < comboBoxPlaylist.Items.Count - 1)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
            }
            comboBoxPlaylist.SelectedIndex = currentIndex;
        }

        private void buttonPreviousSong_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = comboBoxPlaylist.Items.Count - 1;
            }
            comboBoxPlaylist.SelectedIndex = currentIndex;
        }

        private void buttonLooping_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
