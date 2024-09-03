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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonArtists = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonShows = new System.Windows.Forms.Button();
            this.buttonConcert = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNewLogin = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.buttonCancelLogin = new System.Windows.Forms.Button();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
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
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 25;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(333, 152);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 40);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login ";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1345, 616);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(67, 53);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(1345, 12);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(67, 59);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 3;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(1176, 78);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(72, 18);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Welcome";
            this.usernameLabel.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(164, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 20);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Username : ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(164, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Σύνδεση Υπαλλήλων";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonCancelLogin);
            this.panelLogin.Controls.Add(this.labelerror);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBox2);
            this.panelLogin.Controls.Add(this.labelName);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Location = new System.Drawing.Point(972, 120);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(440, 250);
            this.panelLogin.TabIndex = 10;
            this.panelLogin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNewLogin
            // 
            this.buttonNewLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewLogin.Location = new System.Drawing.Point(1234, 19);
            this.buttonNewLogin.Name = "buttonNewLogin";
            this.buttonNewLogin.Size = new System.Drawing.Size(94, 40);
            this.buttonNewLogin.TabIndex = 12;
            this.buttonNewLogin.Text = "Σύνδεση";
            this.buttonNewLogin.UseVisualStyleBackColor = true;
            this.buttonNewLogin.Click += new System.EventHandler(this.buttonNewLogin_Click);
            this.buttonNewLogin.MouseEnter += new System.EventHandler(this.buttonNewLogin_MouseEnter);
            this.buttonNewLogin.MouseLeave += new System.EventHandler(this.buttonNewLogin_MouseLeave);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.BackColor = System.Drawing.SystemColors.Control;
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(20, 211);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 13);
            this.labelerror.TabIndex = 11;
            // 
            // buttonCancelLogin
            // 
            this.buttonCancelLogin.FlatAppearance.BorderSize = 0;
            this.buttonCancelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelLogin.Location = new System.Drawing.Point(168, 152);
            this.buttonCancelLogin.Name = "buttonCancelLogin";
            this.buttonCancelLogin.Size = new System.Drawing.Size(94, 40);
            this.buttonCancelLogin.TabIndex = 12;
            this.buttonCancelLogin.Text = "Cancel";
            this.buttonCancelLogin.UseMnemonic = false;
            this.buttonCancelLogin.UseVisualStyleBackColor = true;
            this.buttonCancelLogin.Click += new System.EventHandler(this.buttonCancelLogin_Click);
            this.buttonCancelLogin.MouseEnter += new System.EventHandler(this.buttonCancelLogin_MouseEnter);
            this.buttonCancelLogin.MouseLeave += new System.EventHandler(this.buttonCancelLogin_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 681);
            this.Controls.Add(this.buttonNewLogin);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.Sidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNewLogin;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Button buttonCancelLogin;
    }
}

