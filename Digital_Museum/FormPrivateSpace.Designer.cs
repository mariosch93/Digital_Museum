namespace Digital_Museum
{
    partial class FormPrivateSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrivateSpace));
            this.panelHello = new System.Windows.Forms.Panel();
            this.comboBoxHello = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.panelConsole = new System.Windows.Forms.Panel();
            this.panelOnlineOrder = new System.Windows.Forms.Panel();
            this.labelConsole = new System.Windows.Forms.Label();
            this.buttonLights = new System.Windows.Forms.Button();
            this.pictureBoxConsole = new System.Windows.Forms.PictureBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.buttonTherm = new System.Windows.Forms.Button();
            this.labelLights = new System.Windows.Forms.Label();
            this.labelTherm = new System.Windows.Forms.Label();
            this.buttonMinusTherm = new System.Windows.Forms.Button();
            this.buttonPlusTherm = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.richTextBoxPlaylist = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonArtists = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonShows = new System.Windows.Forms.Button();
            this.buttonConcert = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelHello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.Color.Transparent;
            this.panelHello.Controls.Add(this.comboBoxHello);
            this.panelHello.Controls.Add(this.label1);
            this.panelHello.Controls.Add(this.labelHello);
            this.panelHello.Controls.Add(this.buttonRent);
            this.panelHello.Location = new System.Drawing.Point(495, 53);
            this.panelHello.Margin = new System.Windows.Forms.Padding(4);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(917, 287);
            this.panelHello.TabIndex = 421;
            // 
            // comboBoxHello
            // 
            this.comboBoxHello.FormattingEnabled = true;
            this.comboBoxHello.Items.AddRange(new object[] {
            "Αίθουσα Α ",
            "Αίθουσα Β"});
            this.comboBoxHello.Location = new System.Drawing.Point(361, 94);
            this.comboBoxHello.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHello.Name = "comboBoxHello";
            this.comboBoxHello.Size = new System.Drawing.Size(237, 24);
            this.comboBoxHello.TabIndex = 419;
            this.comboBoxHello.SelectedIndexChanged += new System.EventHandler(this.comboBoxHello_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 24);
            this.label1.TabIndex = 420;
            this.label1.Text = "Πατήστε για να ολοκληρώσετε την ενοικίαση σας\r\n";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(4, 20);
            this.labelHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(851, 216);
            this.labelHello.TabIndex = 418;
            this.labelHello.Text = resources.GetString("labelHello.Text");
            // 
            // buttonRent
            // 
            this.buttonRent.BackColor = System.Drawing.Color.Transparent;
            this.buttonRent.Enabled = false;
            this.buttonRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.Location = new System.Drawing.Point(521, 234);
            this.buttonRent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(141, 42);
            this.buttonRent.TabIndex = 417;
            this.buttonRent.Text = "Ενοικίαση";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // panelConsole
            // 
            this.panelConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelConsole.Location = new System.Drawing.Point(251, 245);
            this.panelConsole.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(872, 458);
            this.panelConsole.TabIndex = 432;
            this.panelConsole.Visible = false;
            // 
            // panelOnlineOrder
            // 
            this.panelOnlineOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOnlineOrder.Location = new System.Drawing.Point(1496, 95);
            this.panelOnlineOrder.Margin = new System.Windows.Forms.Padding(4);
            this.panelOnlineOrder.Name = "panelOnlineOrder";
            this.panelOnlineOrder.Size = new System.Drawing.Size(387, 645);
            this.panelOnlineOrder.TabIndex = 428;
            this.panelOnlineOrder.Visible = false;
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.BackColor = System.Drawing.Color.Transparent;
            this.labelConsole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsole.ForeColor = System.Drawing.Color.White;
            this.labelConsole.Location = new System.Drawing.Point(193, 788);
            this.labelConsole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(822, 24);
            this.labelConsole.TabIndex = 430;
            this.labelConsole.Text = "Πατήστε το κουμπί της κονσόλας ώστε να σας εμφανιστούν οι επιλογές της αίθουσας";
            this.labelConsole.Visible = false;
            // 
            // buttonLights
            // 
            this.buttonLights.BackColor = System.Drawing.Color.Transparent;
            this.buttonLights.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLights.BackgroundImage")));
            this.buttonLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLights.Location = new System.Drawing.Point(0, 27);
            this.buttonLights.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLights.Name = "buttonLights";
            this.buttonLights.Size = new System.Drawing.Size(103, 86);
            this.buttonLights.TabIndex = 433;
            this.buttonLights.UseVisualStyleBackColor = false;
            this.buttonLights.Click += new System.EventHandler(this.buttonLights_Click);
            // 
            // pictureBoxConsole
            // 
            this.pictureBoxConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConsole.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsole.Image")));
            this.pictureBoxConsole.Location = new System.Drawing.Point(1064, 758);
            this.pictureBoxConsole.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxConsole.Name = "pictureBoxConsole";
            this.pictureBoxConsole.Size = new System.Drawing.Size(76, 65);
            this.pictureBoxConsole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConsole.TabIndex = 431;
            this.pictureBoxConsole.TabStop = false;
            this.pictureBoxConsole.Visible = false;
            this.pictureBoxConsole.Click += new System.EventHandler(this.pictureBoxConsole_Click);
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
            this.buttonOrder.Location = new System.Drawing.Point(1723, 14);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(80, 73);
            this.buttonOrder.TabIndex = 422;
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Visible = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1793, 758);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(89, 65);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 5;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(1809, 15);
            this.pictureBoxUnipi.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(89, 73);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 4;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // buttonTherm
            // 
            this.buttonTherm.BackColor = System.Drawing.Color.Transparent;
            this.buttonTherm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTherm.BackgroundImage")));
            this.buttonTherm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTherm.Location = new System.Drawing.Point(4, 309);
            this.buttonTherm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTherm.Name = "buttonTherm";
            this.buttonTherm.Size = new System.Drawing.Size(103, 86);
            this.buttonTherm.TabIndex = 434;
            this.buttonTherm.UseVisualStyleBackColor = false;
            this.buttonTherm.Click += new System.EventHandler(this.buttonTherm_Click);
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLights.ForeColor = System.Drawing.Color.White;
            this.labelLights.Location = new System.Drawing.Point(20, 129);
            this.labelLights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(0, 20);
            this.labelLights.TabIndex = 435;
            // 
            // labelTherm
            // 
            this.labelTherm.AutoSize = true;
            this.labelTherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTherm.ForeColor = System.Drawing.Color.White;
            this.labelTherm.Location = new System.Drawing.Point(15, 459);
            this.labelTherm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTherm.Name = "labelTherm";
            this.labelTherm.Size = new System.Drawing.Size(0, 20);
            this.labelTherm.TabIndex = 436;
            // 
            // buttonMinusTherm
            // 
            this.buttonMinusTherm.Location = new System.Drawing.Point(11, 402);
            this.buttonMinusTherm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinusTherm.Name = "buttonMinusTherm";
            this.buttonMinusTherm.Size = new System.Drawing.Size(37, 27);
            this.buttonMinusTherm.TabIndex = 437;
            this.buttonMinusTherm.Text = "-";
            this.buttonMinusTherm.UseVisualStyleBackColor = true;
            this.buttonMinusTherm.Visible = false;
            this.buttonMinusTherm.Click += new System.EventHandler(this.buttonMinusTherm_Click);
            // 
            // buttonPlusTherm
            // 
            this.buttonPlusTherm.Location = new System.Drawing.Point(56, 402);
            this.buttonPlusTherm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlusTherm.Name = "buttonPlusTherm";
            this.buttonPlusTherm.Size = new System.Drawing.Size(37, 27);
            this.buttonPlusTherm.TabIndex = 438;
            this.buttonPlusTherm.Text = "+";
            this.buttonPlusTherm.UseVisualStyleBackColor = true;
            this.buttonPlusTherm.Visible = false;
            this.buttonPlusTherm.Click += new System.EventHandler(this.buttonPlusTherm_Click);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.Transparent;
            this.panelControls.Controls.Add(this.buttonCopy);
            this.panelControls.Controls.Add(this.buttonColor);
            this.panelControls.Controls.Add(this.buttonLights);
            this.panelControls.Controls.Add(this.buttonPlusTherm);
            this.panelControls.Controls.Add(this.buttonTherm);
            this.panelControls.Controls.Add(this.buttonMinusTherm);
            this.panelControls.Controls.Add(this.labelLights);
            this.panelControls.Controls.Add(this.labelTherm);
            this.panelControls.Location = new System.Drawing.Point(79, 123);
            this.panelControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(168, 665);
            this.panelControls.TabIndex = 439;
            this.panelControls.Visible = false;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.White;
            this.buttonCopy.Location = new System.Drawing.Point(4, 617);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(141, 44);
            this.buttonCopy.TabIndex = 441;
            this.buttonCopy.Text = "Λήψη αντιγράφου Λίστας μουσικής";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonColor.FlatAppearance.BorderSize = 0;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor.ForeColor = System.Drawing.Color.White;
            this.buttonColor.Location = new System.Drawing.Point(4, 193);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(104, 59);
            this.buttonColor.TabIndex = 440;
            this.buttonColor.Text = "Επιλογή Χρώματος Φωτισμού";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(103, 14);
            this.pictureBoxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(75, 66);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettings.TabIndex = 440;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Visible = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // richTextBoxPlaylist
            // 
            this.richTextBoxPlaylist.Location = new System.Drawing.Point(1160, 758);
            this.richTextBoxPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxPlaylist.Name = "richTextBoxPlaylist";
            this.richTextBoxPlaylist.Size = new System.Drawing.Size(132, 64);
            this.richTextBoxPlaylist.TabIndex = 442;
            this.richTextBoxPlaylist.Text = resources.GetString("richTextBoxPlaylist.Text");
            this.richTextBoxPlaylist.Visible = false;
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
            this.Sidebar.MaximumSize = new System.Drawing.Size(189, 838);
            this.Sidebar.MinimumSize = new System.Drawing.Size(79, 838);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(79, 838);
            this.Sidebar.TabIndex = 443;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 190);
            this.panel1.TabIndex = 2;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(0, 12);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(189, 135);
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
            this.buttonHome.Location = new System.Drawing.Point(4, 194);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(189, 82);
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
            this.buttonArtists.Location = new System.Drawing.Point(4, 284);
            this.buttonArtists.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArtists.Name = "buttonArtists";
            this.buttonArtists.Size = new System.Drawing.Size(223, 82);
            this.buttonArtists.TabIndex = 5;
            this.buttonArtists.Text = "            Αίθουσες                 Καλλιτεχνών";
            this.buttonArtists.UseVisualStyleBackColor = false;
            this.buttonArtists.Click += new System.EventHandler(this.buttonArtists_Click);
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
            this.buttonEvents.Location = new System.Drawing.Point(4, 374);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(223, 82);
            this.buttonEvents.TabIndex = 7;
            this.buttonEvents.Text = "            Αίθουσες                  Εκδηλώσεων";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
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
            this.buttonShows.Location = new System.Drawing.Point(4, 464);
            this.buttonShows.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShows.Name = "buttonShows";
            this.buttonShows.Size = new System.Drawing.Size(223, 82);
            this.buttonShows.TabIndex = 8;
            this.buttonShows.Text = "             Χώροι                Προβολής";
            this.buttonShows.UseVisualStyleBackColor = false;
            this.buttonShows.Click += new System.EventHandler(this.buttonShows_Click);
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
            this.buttonConcert.Location = new System.Drawing.Point(4, 554);
            this.buttonConcert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConcert.Name = "buttonConcert";
            this.buttonConcert.Size = new System.Drawing.Size(189, 82);
            this.buttonConcert.TabIndex = 7;
            this.buttonConcert.Text = "            Αίθουσα                Συναυλιών";
            this.buttonConcert.UseVisualStyleBackColor = false;
            this.buttonConcert.Click += new System.EventHandler(this.buttonConcert_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Enabled = true;
            this.sidebarTimer.Interval = 25;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // FormPrivateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1899, 838);
            this.ControlBox = false;
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.richTextBoxPlaylist);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.panelConsole);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.pictureBoxConsole);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.panelOnlineOrder);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.panelHello);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrivateSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panelHello.ResumeLayout(false);
            this.panelHello.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelHello;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.ComboBox comboBoxHello;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel panelOnlineOrder;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.PictureBox pictureBoxConsole;
        private System.Windows.Forms.Panel panelConsole;
        private System.Windows.Forms.Button buttonLights;
        private System.Windows.Forms.Button buttonTherm;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.Label labelTherm;
        private System.Windows.Forms.Button buttonMinusTherm;
        private System.Windows.Forms.Button buttonPlusTherm;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.RichTextBox richTextBoxPlaylist;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPlaylist;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonArtists;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonShows;
        private System.Windows.Forms.Button buttonConcert;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}