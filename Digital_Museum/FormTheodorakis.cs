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
    public partial class FormTheodorakis : Form
    {
        private List<Image> images;
        private int currentImageIndex = 0;
        SoundPlayer player = new SoundPlayer("./music/Μίκης.wav");

        public FormTheodorakis()
        {
            InitializeComponent();
            images = new List<Image>
            {
                Properties.Resources.Theodorakis2,
                Properties.Resources.Theodorakis3,
                Properties.Resources.Theodorakis4,
            };

            // Κατά τη φόρτωση της φόρμας, δεν ρυθμίζουμε εικόνα στο PictureBox
            pictureBoxSlides.Image = null;
            // Διασφάλιση ότι ο Timer δεν είναι ενεργός
            timer1.Stop();
        }

        private void labelbio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
