namespace Digital_Museum
{
    partial class FormMpithikotsis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMpithikotsis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPortrait = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelLegend = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelbio = new System.Windows.Forms.Label();
            this.pictureBoxPortraito = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlides = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortraito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 753);
            this.panel1.TabIndex = 20;
            // 
            // labelPortrait
            // 
            this.labelPortrait.AutoSize = true;
            this.labelPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPortrait.Location = new System.Drawing.Point(321, 71);
            this.labelPortrait.Name = "labelPortrait";
            this.labelPortrait.Size = new System.Drawing.Size(332, 25);
            this.labelPortrait.TabIndex = 30;
            this.labelPortrait.Text = "Πορτραίτο Γρηγόρη Μπιθικώτση";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelSong.Location = new System.Drawing.Point(997, 86);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(439, 50);
            this.labelSong.TabIndex = 29;
            this.labelSong.Text = "Τα τραγούδια του που χάραξαν την πορεία \r\nτου Ελληνικού λαϊκού τραγουδιού!";
            // 
            // labelLegend
            // 
            this.labelLegend.AutoSize = true;
            this.labelLegend.BackColor = System.Drawing.Color.Transparent;
            this.labelLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend.Location = new System.Drawing.Point(580, 19);
            this.labelLegend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(638, 31);
            this.labelLegend.TabIndex = 28;
            this.labelLegend.Text = "Αίθουσα αφιερωμένη στον Γρηγόρη Μπιθικώτση";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(286, 464);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 267);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labelbio
            // 
            this.labelbio.AutoSize = true;
            this.labelbio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelbio.Location = new System.Drawing.Point(321, 420);
            this.labelbio.Name = "labelbio";
            this.labelbio.Size = new System.Drawing.Size(267, 25);
            this.labelbio.TabIndex = 31;
            this.labelbio.Text = "Η βιογραφία του Γρηγόρη";
            // 
            // pictureBoxPortraito
            // 
            this.pictureBoxPortraito.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPortraito.Image")));
            this.pictureBoxPortraito.Location = new System.Drawing.Point(286, 108);
            this.pictureBoxPortraito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPortraito.Name = "pictureBoxPortraito";
            this.pictureBoxPortraito.Size = new System.Drawing.Size(407, 282);
            this.pictureBoxPortraito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPortraito.TabIndex = 33;
            this.pictureBoxPortraito.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox2.Location = new System.Drawing.Point(1002, 156);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(434, 256);
            this.richTextBox2.TabIndex = 34;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // pictureBoxSlides
            // 
            this.pictureBoxSlides.ErrorImage = null;
            this.pictureBoxSlides.Location = new System.Drawing.Point(858, 426);
            this.pictureBoxSlides.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlides.Name = "pictureBoxSlides";
            this.pictureBoxSlides.Size = new System.Drawing.Size(578, 316);
            this.pictureBoxSlides.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlides.TabIndex = 35;
            this.pictureBoxSlides.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1465, 516);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(118, 37);
            this.buttonStop.TabIndex = 38;
            this.buttonStop.Text = "Stop Slides";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1465, 420);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 43);
            this.buttonStart.TabIndex = 37;
            this.buttonStart.Text = "Start Slides";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1494, 675);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(89, 65);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 36;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // FormMpithikotsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 753);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxSlides);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBoxPortraito);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelbio);
            this.Controls.Add(this.labelPortrait);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.labelLegend);
            this.Controls.Add(this.panel1);
            this.Name = "FormMpithikotsis";
            this.Text = "FormMpithikotsis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPortraito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPortrait;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Label labelLegend;
        private System.Windows.Forms.PictureBox pictureBoxPortraito;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelbio;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBoxSlides;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}