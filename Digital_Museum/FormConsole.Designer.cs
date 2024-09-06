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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxPlaylist = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlayRandom = new System.Windows.Forms.Button();
            this.buttonKaraoke = new System.Windows.Forms.Button();
            this.buttonPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(429, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlaylist
            // 
            this.comboBoxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaylist.FormattingEnabled = true;
            this.comboBoxPlaylist.Items.AddRange(new object[] {
            "Δημήτρης Μητροπάνος - Λαδάδικα",
            "Δημήτρης Μητροπάνος - Έρωτας Αρχάγγελος",
            "Στέλιος Καζαντζίδης - Υπάρχω",
            "Κώνσταντίνος Αργυρός - Αθήνα μου"});
            this.comboBoxPlaylist.Location = new System.Drawing.Point(255, 12);
            this.comboBoxPlaylist.Name = "comboBoxPlaylist";
            this.comboBoxPlaylist.Size = new System.Drawing.Size(335, 24);
            this.comboBoxPlaylist.TabIndex = 12;
            this.comboBoxPlaylist.Visible = false;
            this.comboBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaylist_SelectedIndexChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(150, 287);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(34, 33);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlayRandom
            // 
            this.buttonPlayRandom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayRandom.BackgroundImage")));
            this.buttonPlayRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayRandom.Location = new System.Drawing.Point(470, 287);
            this.buttonPlayRandom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayRandom.Name = "buttonPlayRandom";
            this.buttonPlayRandom.Size = new System.Drawing.Size(34, 33);
            this.buttonPlayRandom.TabIndex = 10;
            this.buttonPlayRandom.UseVisualStyleBackColor = true;
            this.buttonPlayRandom.Click += new System.EventHandler(this.buttonPlayRandom_Click);
            // 
            // buttonKaraoke
            // 
            this.buttonKaraoke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKaraoke.BackgroundImage")));
            this.buttonKaraoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaraoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKaraoke.Location = new System.Drawing.Point(516, 289);
            this.buttonKaraoke.Margin = new System.Windows.Forms.Padding(0);
            this.buttonKaraoke.Name = "buttonKaraoke";
            this.buttonKaraoke.Size = new System.Drawing.Size(30, 28);
            this.buttonKaraoke.TabIndex = 7;
            this.buttonKaraoke.UseVisualStyleBackColor = true;
            this.buttonKaraoke.Click += new System.EventHandler(this.buttonKaraoke_Click);
            // 
            // buttonPlaylist
            // 
            this.buttonPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlaylist.BackgroundImage")));
            this.buttonPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaylist.Location = new System.Drawing.Point(108, 289);
            this.buttonPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlaylist.Name = "buttonPlaylist";
            this.buttonPlaylist.Size = new System.Drawing.Size(30, 28);
            this.buttonPlaylist.TabIndex = 5;
            this.buttonPlaylist.UseVisualStyleBackColor = true;
            this.buttonPlaylist.Click += new System.EventHandler(this.buttonPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, -86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 538);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 372);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxPlaylist);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlayRandom);
            this.Controls.Add(this.buttonKaraoke);
            this.Controls.Add(this.buttonPlaylist);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPlaylist;
        private System.Windows.Forms.Button buttonKaraoke;
        private System.Windows.Forms.Button buttonPlayRandom;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxPlaylist;
    }
}