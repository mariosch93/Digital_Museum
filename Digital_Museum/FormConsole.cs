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
using System.Windows.Forms;

namespace Digital_Museum
{
    public partial class FormConsole : Form
    {
        LoginInfo loginInfo;
        bool playlistClicked = false;
        private int currentIndex = 0;
        SoundPlayer player = new SoundPlayer();
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

            //comboBoxPlaylist.SelectedIndexChanged += comboBoxPlaylist_SelectedIndexChanged;
        }

        /*protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadMusic(currentIndex);
        }*/

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


    }
}
