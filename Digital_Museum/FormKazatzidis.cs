﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Museum
{
    public partial class FormKazatzidis : Form
    {
        private List<Image> images;
        private int currentImageIndex = 0;
        SoundPlayer player = new SoundPlayer("./music/Υπάρχω  Στέλιος Καζαντζίδης.wav");
        bool sidebarExpand;
        LoginInfo loginInfo;
        bool buttonClicked = false;
        public FormKazatzidis()
        {
            InitializeComponent();
            images = new List<Image>
            {
                Properties.Resources.stelios,
                Properties.Resources.stelios2,
                Properties.Resources.stelios3,
                Properties.Resources.stelios4,

            };

            // Κατά τη φόρτωση της φόρμας, δεν ρυθμίζουμε εικόνα στο PictureBox
            pictureBoxSlides.ImageLocation = null;
            // Διασφάλιση ότι ο Timer δεν είναι ενεργός
            timer1.Stop();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormKazatzidis_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Ορισμός της πρώτης εικόνας πριν την εκκίνηση του Timer
            pictureBoxSlides.Image = images[currentImageIndex];
            // Εκκίνηση του Timer
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Διακοπή του Timer
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Μετάβαση στην επόμενη εικόνα
            currentImageIndex++;
            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 0; // Επαναφορά στο πρώτο
            }

            // Αλλαγή της εικόνας στο PictureBox
            pictureBoxSlides.Image = images[currentImageIndex];
        }

        private void pictureBoxSlides_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonArtists_Click(object sender, EventArgs e)
        {
            FormArtists formArtists = new FormArtists();
            formArtists.ShowDialog();
        }

        private void buttonConcert_Click(object sender, EventArgs e)
        {
            FormConcert formConcert = new FormConcert();
            formConcert.ShowDialog();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            FormVideoEvents formVideoEvents = new FormVideoEvents(loginInfo);
            formVideoEvents.ShowDialog();
        }

        private void buttonShows_Click(object sender, EventArgs e)
        {
            FormPrivateSpace formPrivateSpace = new FormPrivateSpace(loginInfo);
            formPrivateSpace.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                FormOnlineOrder onlineOrder = new FormOnlineOrder(loginInfo);
                onlineOrder.TopLevel = false;
                panelOnlineOrder.Visible = true;
                panelOnlineOrder.Controls.Add(onlineOrder);
                onlineOrder.BringToFront();
                onlineOrder.Show();
                buttonClicked = true;
            }
            else
            {
                panelOnlineOrder.Visible = false;
                buttonClicked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string helping = @"helper\help_musee.chm";
            Help.ShowHelp(this, helping, HelpNavigator.TopicId, "50");
        }
    }
}
