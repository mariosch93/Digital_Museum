namespace Digital_Museum
{
    partial class FormConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
            this.buttonPreviousSong = new System.Windows.Forms.Button();
            this.buttonNextSong = new System.Windows.Forms.Button();
            this.comboBoxPlaylist = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlayRandom = new System.Windows.Forms.Button();
            this.buttonKaraoke = new System.Windows.Forms.Button();
            this.buttonPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonLooping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreviousSong
            // 
            this.buttonPreviousSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousSong.Location = new System.Drawing.Point(259, 356);
            this.buttonPreviousSong.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPreviousSong.Name = "buttonPreviousSong";
            this.buttonPreviousSong.Size = new System.Drawing.Size(40, 34);
            this.buttonPreviousSong.TabIndex = 1;
            this.buttonPreviousSong.Text = "<<";
            this.buttonPreviousSong.UseVisualStyleBackColor = true;
            this.buttonPreviousSong.Click += new System.EventHandler(this.buttonPreviousSong_Click);
            // 
            // buttonNextSong
            // 
            this.buttonNextSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextSong.Location = new System.Drawing.Point(572, 356);
            this.buttonNextSong.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextSong.Name = "buttonNextSong";
            this.buttonNextSong.Size = new System.Drawing.Size(40, 34);
            this.buttonNextSong.TabIndex = 2;
            this.buttonNextSong.Text = ">>";
            this.buttonNextSong.UseVisualStyleBackColor = true;
            this.buttonNextSong.Click += new System.EventHandler(this.buttonNextSong_Click);
            // 
            // comboBoxPlaylist
            // 
            this.comboBoxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaylist.FormattingEnabled = true;
            this.comboBoxPlaylist.Items.AddRange(new object[] {
            "Δημήτρης Μητροπάνος - Λαδάδικα",
            "Δημήτρης Μητροπάνος - Έρωτας Αρχάγγελος",
            "Κώνσταντίνος Αργυρός - Αθήνα μου",
            "Στέλιος Καζαντζίδης - Υπάρχω"});
            this.comboBoxPlaylist.Location = new System.Drawing.Point(340, 15);
            this.comboBoxPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPlaylist.Name = "comboBoxPlaylist";
            this.comboBoxPlaylist.Size = new System.Drawing.Size(445, 28);
            this.comboBoxPlaylist.TabIndex = 12;
            this.comboBoxPlaylist.Visible = false;
            this.comboBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaylist_SelectedIndexChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(200, 353);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(45, 41);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlayRandom
            // 
            this.buttonPlayRandom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayRandom.BackgroundImage")));
            this.buttonPlayRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayRandom.Location = new System.Drawing.Point(627, 353);
            this.buttonPlayRandom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayRandom.Name = "buttonPlayRandom";
            this.buttonPlayRandom.Size = new System.Drawing.Size(45, 41);
            this.buttonPlayRandom.TabIndex = 10;
            this.buttonPlayRandom.UseVisualStyleBackColor = true;
            this.buttonPlayRandom.Click += new System.EventHandler(this.buttonPlayRandom_Click);
            // 
            // buttonKaraoke
            // 
            this.buttonKaraoke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKaraoke.BackgroundImage")));
            this.buttonKaraoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaraoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKaraoke.Location = new System.Drawing.Point(747, 356);
            this.buttonKaraoke.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKaraoke.Name = "buttonKaraoke";
            this.buttonKaraoke.Size = new System.Drawing.Size(40, 34);
            this.buttonKaraoke.TabIndex = 7;
            this.buttonKaraoke.UseVisualStyleBackColor = true;
            this.buttonKaraoke.Click += new System.EventHandler(this.buttonKaraoke_Click);
            // 
            // buttonPlaylist
            // 
            this.buttonPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlaylist.BackgroundImage")));
            this.buttonPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaylist.Location = new System.Drawing.Point(85, 356);
            this.buttonPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlaylist.Name = "buttonPlaylist";
            this.buttonPlaylist.Size = new System.Drawing.Size(40, 34);
            this.buttonPlaylist.TabIndex = 5;
            this.buttonPlaylist.UseVisualStyleBackColor = true;
            this.buttonPlaylist.Click += new System.EventHandler(this.buttonPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-27, -106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(921, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(144, 356);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(40, 34);
            this.buttonPlay.TabIndex = 13;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonLooping
            // 
            this.buttonLooping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLooping.BackgroundImage")));
            this.buttonLooping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLooping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLooping.Location = new System.Drawing.Point(685, 356);
            this.buttonLooping.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLooping.Name = "buttonLooping";
            this.buttonLooping.Size = new System.Drawing.Size(45, 41);
            this.buttonLooping.TabIndex = 14;
            this.buttonLooping.UseVisualStyleBackColor = true;
            this.buttonLooping.Click += new System.EventHandler(this.buttonLooping_Click);
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 458);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLooping);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.comboBoxPlaylist);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlayRandom);
            this.Controls.Add(this.buttonKaraoke);
            this.Controls.Add(this.buttonPlaylist);
            this.Controls.Add(this.buttonNextSong);
            this.Controls.Add(this.buttonPreviousSong);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPreviousSong;
        private System.Windows.Forms.Button buttonNextSong;
        private System.Windows.Forms.Button buttonPlaylist;
        private System.Windows.Forms.Button buttonKaraoke;
        private System.Windows.Forms.Button buttonPlayRandom;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxPlaylist;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonLooping;
    }
}