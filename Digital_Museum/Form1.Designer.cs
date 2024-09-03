namespace Digital_Museum
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonArtists = new System.Windows.Forms.Button();
            this.buttonConcert = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonShows = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebar.Controls.Add(this.panel1);
            this.Sidebar.Controls.Add(this.buttonHome);
            this.Sidebar.Controls.Add(this.buttonArtists);
            this.Sidebar.Controls.Add(this.buttonEvents);
            this.Sidebar.Controls.Add(this.buttonShows);
            this.Sidebar.Controls.Add(this.buttonConcert);
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(142, 681);
            this.Sidebar.MinimumSize = new System.Drawing.Size(59, 681);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(142, 681);
            this.Sidebar.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(3, 157);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(142, 67);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "       Αρχική";
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 25;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // buttonArtists
            // 
            this.buttonArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonArtists.FlatAppearance.BorderSize = 0;
            this.buttonArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArtists.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArtists.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonArtists.Image = ((System.Drawing.Image)(resources.GetObject("buttonArtists.Image")));
            this.buttonArtists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArtists.Location = new System.Drawing.Point(3, 230);
            this.buttonArtists.Name = "buttonArtists";
            this.buttonArtists.Size = new System.Drawing.Size(167, 67);
            this.buttonArtists.TabIndex = 5;
            this.buttonArtists.Text = "            Αίθουσες                 Καλλιτεχνών";
            this.buttonArtists.UseVisualStyleBackColor = false;
            // 
            // buttonConcert
            // 
            this.buttonConcert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonConcert.FlatAppearance.BorderSize = 0;
            this.buttonConcert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConcert.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConcert.Image = ((System.Drawing.Image)(resources.GetObject("buttonConcert.Image")));
            this.buttonConcert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConcert.Location = new System.Drawing.Point(3, 449);
            this.buttonConcert.Name = "buttonConcert";
            this.buttonConcert.Size = new System.Drawing.Size(142, 67);
            this.buttonConcert.TabIndex = 7;
            this.buttonConcert.Text = "            Αίθουσα                Συναυλιών";
            this.buttonConcert.UseVisualStyleBackColor = false;
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonEvents.FlatAppearance.BorderSize = 0;
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEvents.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEvents.Image = ((System.Drawing.Image)(resources.GetObject("buttonEvents.Image")));
            this.buttonEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.Location = new System.Drawing.Point(3, 303);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(167, 67);
            this.buttonEvents.TabIndex = 7;
            this.buttonEvents.Text = "            Αίθουσες                  Εκδηλώσεων";
            this.buttonEvents.UseVisualStyleBackColor = false;
            // 
            // buttonShows
            // 
            this.buttonShows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonShows.FlatAppearance.BorderSize = 0;
            this.buttonShows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShows.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShows.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShows.Image = ((System.Drawing.Image)(resources.GetObject("buttonShows.Image")));
            this.buttonShows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShows.Location = new System.Drawing.Point(3, 376);
            this.buttonShows.Name = "buttonShows";
            this.buttonShows.Size = new System.Drawing.Size(167, 67);
            this.buttonShows.TabIndex = 8;
            this.buttonShows.Text = "             Χώροι                Προβολής";
            this.buttonShows.UseVisualStyleBackColor = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(0, 19);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(142, 110);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.Text = "            Μενού    ";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 154);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.Sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Button buttonArtists;
        private System.Windows.Forms.Button buttonConcert;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonShows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
    }
}

