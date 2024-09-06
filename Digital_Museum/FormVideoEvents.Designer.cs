namespace Digital_Museum
{
    partial class FormVideoEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoEvents));
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelOnlineOrder = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.MessageGianni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(1345, 12);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(67, 59);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 413;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1345, 616);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(67, 53);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 414;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 681);
            this.panel1.TabIndex = 415;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(376, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 26);
            this.label1.TabIndex = 416;
            this.label1.Text = "Καλως ήρθατε στην αίθουσα προβολής βιντεοσκοπημένων εκδηλώσεων!";
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Moccasin;
            this.buttonOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOrder.BackgroundImage")));
            this.buttonOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonOrder.Location = new System.Drawing.Point(1280, 12);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(60, 59);
            this.buttonOrder.TabIndex = 421;
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(275, 144);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(687, 249);
            this.webBrowser1.TabIndex = 426;
            // 
            // panelOnlineOrder
            // 
            this.panelOnlineOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOnlineOrder.Location = new System.Drawing.Point(1122, 77);
            this.panelOnlineOrder.Name = "panelOnlineOrder";
            this.panelOnlineOrder.Size = new System.Drawing.Size(290, 524);
            this.panelOnlineOrder.TabIndex = 427;
            this.panelOnlineOrder.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(870, 399);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(92, 26);
            this.buttonNext.TabIndex = 431;
            this.buttonNext.Text = "Επόμενο";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(772, 399);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(92, 26);
            this.buttonPrevious.TabIndex = 432;
            this.buttonPrevious.Text = "Προηγούμενο";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // MessageGianni
            // 
            this.MessageGianni.AutoSize = true;
            this.MessageGianni.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageGianni.Location = new System.Drawing.Point(276, 468);
            this.MessageGianni.Name = "MessageGianni";
            this.MessageGianni.Size = new System.Drawing.Size(686, 150);
            this.MessageGianni.TabIndex = 433;
            this.MessageGianni.Text = resources.GetString("MessageGianni.Text");
            // 
            // FormVideoEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.ControlBox = false;
            this.Controls.Add(this.MessageGianni);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelOnlineOrder);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Name = "FormVideoEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVideoEvents";
            this.Load += new System.EventHandler(this.FormVideoEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panelOnlineOrder;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label MessageGianni;
    }
}