namespace Digital_Museum
{
    partial class FormOnlineOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOnlineOrder));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.panelFoods = new System.Windows.Forms.Panel();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxSalad = new System.Windows.Forms.CheckBox();
            this.checkBoxFries = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(12, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(175, 32);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Γεια σας! Πως θα μπορούσα \r\nνα σας εξυπηρετήσω?";
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.AutoCompleteCustomSource.AddRange(new string[] {
            "Φαγητό",
            "Ροφήματα"});
            this.comboBoxFoods.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(12, 53);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(137, 23);
            this.comboBoxFoods.TabIndex = 2;
            this.comboBoxFoods.Text = "Επέλεξε κατηγορία";
            // 
            // panelFoods
            // 
            this.panelFoods.Controls.Add(this.checkBox2);
            this.panelFoods.Controls.Add(this.checkBoxFries);
            this.panelFoods.Controls.Add(this.checkBoxSalad);
            this.panelFoods.Controls.Add(this.checkBoxBurger);
            this.panelFoods.Location = new System.Drawing.Point(12, 82);
            this.panelFoods.Name = "panelFoods";
            this.panelFoods.Size = new System.Drawing.Size(250, 258);
            this.panelFoods.TabIndex = 3;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.Image = ((System.Drawing.Image)(resources.GetObject("buttonPayment.Image")));
            this.buttonPayment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPayment.Location = new System.Drawing.Point(172, 390);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(101, 83);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Ολοκληρώστε την πληρωμή σας";
            this.buttonPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 346);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(158, 127);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBurger.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxBurger.Image")));
            this.checkBoxBurger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxBurger.Location = new System.Drawing.Point(6, 31);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(158, 32);
            this.checkBoxBurger.TabIndex = 0;
            this.checkBoxBurger.Text = "           HamBurger: 15€";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalad
            // 
            this.checkBoxSalad.AutoSize = true;
            this.checkBoxSalad.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSalad.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxSalad.Image")));
            this.checkBoxSalad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxSalad.Location = new System.Drawing.Point(6, 83);
            this.checkBoxSalad.Name = "checkBoxSalad";
            this.checkBoxSalad.Size = new System.Drawing.Size(123, 32);
            this.checkBoxSalad.TabIndex = 1;
            this.checkBoxSalad.Text = "           Salad: 15$";
            this.checkBoxSalad.UseVisualStyleBackColor = true;
            // 
            // checkBoxFries
            // 
            this.checkBoxFries.AutoSize = true;
            this.checkBoxFries.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFries.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFries.Image")));
            this.checkBoxFries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxFries.Location = new System.Drawing.Point(6, 137);
            this.checkBoxFries.Name = "checkBoxFries";
            this.checkBoxFries.Size = new System.Drawing.Size(120, 32);
            this.checkBoxFries.TabIndex = 2;
            this.checkBoxFries.Text = "           Fries: 15€";
            this.checkBoxFries.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox2.Location = new System.Drawing.Point(6, 190);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 32);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "           Sandwitch: 15€";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FormOnlineOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 485);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.panelFoods);
            this.Controls.Add(this.comboBoxFoods);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormOnlineOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFoods.ResumeLayout(false);
            this.panelFoods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.Panel panelFoods;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxSalad;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxFries;
    }
}