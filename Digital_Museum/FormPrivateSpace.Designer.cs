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
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.richTextBoxPlaylist = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.Color.Transparent;
            this.panelHello.Controls.Add(this.comboBoxHello);
            this.panelHello.Controls.Add(this.label1);
            this.panelHello.Controls.Add(this.labelHello);
            this.panelHello.Controls.Add(this.buttonRent);
            this.panelHello.Location = new System.Drawing.Point(371, 43);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(688, 233);
            this.panelHello.TabIndex = 421;
            // 
            // comboBoxHello
            // 
            this.comboBoxHello.FormattingEnabled = true;
            this.comboBoxHello.Items.AddRange(new object[] {
            "Αίθουσα Α ",
            "Αίθουσα Β"});
            this.comboBoxHello.Location = new System.Drawing.Point(271, 76);
            this.comboBoxHello.Name = "comboBoxHello";
            this.comboBoxHello.Size = new System.Drawing.Size(179, 21);
            this.comboBoxHello.TabIndex = 419;
            this.comboBoxHello.SelectedIndexChanged += new System.EventHandler(this.comboBoxHello_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 19);
            this.label1.TabIndex = 420;
            this.label1.Text = "Πατήστε για να ολοκληρώσετε την ενοικίαση σας\r\n";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(3, 16);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(678, 171);
            this.labelHello.TabIndex = 418;
            this.labelHello.Text = resources.GetString("labelHello.Text");
            // 
            // buttonRent
            // 
            this.buttonRent.BackColor = System.Drawing.Color.Transparent;
            this.buttonRent.Enabled = false;
            this.buttonRent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRent.Location = new System.Drawing.Point(391, 190);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(106, 34);
            this.buttonRent.TabIndex = 417;
            this.buttonRent.Text = "Ενοικίαση";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // panelConsole
            // 
            this.panelConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelConsole.Location = new System.Drawing.Point(188, 199);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(670, 411);
            this.panelConsole.TabIndex = 432;
            this.panelConsole.Visible = false;
            // 
            // panelOnlineOrder
            // 
            this.panelOnlineOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOnlineOrder.Location = new System.Drawing.Point(1122, 77);
            this.panelOnlineOrder.Name = "panelOnlineOrder";
            this.panelOnlineOrder.Size = new System.Drawing.Size(290, 524);
            this.panelOnlineOrder.TabIndex = 428;
            this.panelOnlineOrder.Visible = false;
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.BackColor = System.Drawing.Color.Transparent;
            this.labelConsole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsole.ForeColor = System.Drawing.Color.White;
            this.labelConsole.Location = new System.Drawing.Point(145, 640);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(647, 19);
            this.labelConsole.TabIndex = 430;
            this.labelConsole.Text = "Πατήστε το κουμπί της κονσόλας ώστε να σας εμφανιστούν οι επιλογές της αίθουσας";
            this.labelConsole.Visible = false;
            // 
            // buttonLights
            // 
            this.buttonLights.BackColor = System.Drawing.Color.Transparent;
            this.buttonLights.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLights.BackgroundImage")));
            this.buttonLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLights.Location = new System.Drawing.Point(0, 22);
            this.buttonLights.Name = "buttonLights";
            this.buttonLights.Size = new System.Drawing.Size(77, 70);
            this.buttonLights.TabIndex = 433;
            this.buttonLights.UseVisualStyleBackColor = false;
            this.buttonLights.Click += new System.EventHandler(this.buttonLights_Click);
            // 
            // pictureBoxConsole
            // 
            this.pictureBoxConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConsole.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConsole.Image")));
            this.pictureBoxConsole.Location = new System.Drawing.Point(798, 616);
            this.pictureBoxConsole.Name = "pictureBoxConsole";
            this.pictureBoxConsole.Size = new System.Drawing.Size(57, 53);
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
            this.buttonOrder.Location = new System.Drawing.Point(1292, 11);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(60, 59);
            this.buttonOrder.TabIndex = 422;
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Visible = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1345, 616);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(67, 53);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 5;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(1357, 12);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(67, 59);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 4;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // buttonTherm
            // 
            this.buttonTherm.BackColor = System.Drawing.Color.Transparent;
            this.buttonTherm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTherm.BackgroundImage")));
            this.buttonTherm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTherm.Location = new System.Drawing.Point(3, 251);
            this.buttonTherm.Name = "buttonTherm";
            this.buttonTherm.Size = new System.Drawing.Size(77, 70);
            this.buttonTherm.TabIndex = 434;
            this.buttonTherm.UseVisualStyleBackColor = false;
            this.buttonTherm.Click += new System.EventHandler(this.buttonTherm_Click);
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLights.ForeColor = System.Drawing.Color.White;
            this.labelLights.Location = new System.Drawing.Point(15, 105);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(0, 16);
            this.labelLights.TabIndex = 435;
            // 
            // labelTherm
            // 
            this.labelTherm.AutoSize = true;
            this.labelTherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTherm.ForeColor = System.Drawing.Color.White;
            this.labelTherm.Location = new System.Drawing.Point(11, 373);
            this.labelTherm.Name = "labelTherm";
            this.labelTherm.Size = new System.Drawing.Size(0, 16);
            this.labelTherm.TabIndex = 436;
            // 
            // buttonMinusTherm
            // 
            this.buttonMinusTherm.Location = new System.Drawing.Point(8, 327);
            this.buttonMinusTherm.Name = "buttonMinusTherm";
            this.buttonMinusTherm.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusTherm.TabIndex = 437;
            this.buttonMinusTherm.Text = "-";
            this.buttonMinusTherm.UseVisualStyleBackColor = true;
            this.buttonMinusTherm.Visible = false;
            this.buttonMinusTherm.Click += new System.EventHandler(this.buttonMinusTherm_Click);
            // 
            // buttonPlusTherm
            // 
            this.buttonPlusTherm.Location = new System.Drawing.Point(42, 327);
            this.buttonPlusTherm.Name = "buttonPlusTherm";
            this.buttonPlusTherm.Size = new System.Drawing.Size(28, 22);
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
            this.panelControls.Location = new System.Drawing.Point(59, 100);
            this.panelControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(126, 540);
            this.panelControls.TabIndex = 439;
            this.panelControls.Visible = false;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonColor.FlatAppearance.BorderSize = 0;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColor.ForeColor = System.Drawing.Color.White;
            this.buttonColor.Location = new System.Drawing.Point(3, 157);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(78, 48);
            this.buttonColor.TabIndex = 440;
            this.buttonColor.Text = "Επιλογή Χρώματος Φωτισμού";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(77, 11);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(56, 54);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettings.TabIndex = 440;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Visible = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.White;
            this.buttonCopy.Location = new System.Drawing.Point(3, 501);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(106, 36);
            this.buttonCopy.TabIndex = 441;
            this.buttonCopy.Text = "Λήψη αντιγράφου Λίστας μουσικής";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // richTextBoxPlaylist
            // 
            this.richTextBoxPlaylist.Location = new System.Drawing.Point(870, 616);
            this.richTextBoxPlaylist.Name = "richTextBoxPlaylist";
            this.richTextBoxPlaylist.Size = new System.Drawing.Size(100, 53);
            this.richTextBoxPlaylist.TabIndex = 442;
            this.richTextBoxPlaylist.Text = resources.GetString("richTextBoxPlaylist.Text");
            this.richTextBoxPlaylist.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(142, 681);
            this.panel1.MinimumSize = new System.Drawing.Size(59, 681);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(59, 681);
            this.panel1.TabIndex = 416;
            // 
            // FormPrivateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.richTextBoxPlaylist);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.panelConsole);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.pictureBoxConsole);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.panelOnlineOrder);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.panelHello);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxUnipi);
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
        private System.Windows.Forms.Panel panel1;
    }
}