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
            this.buttonPayment = new System.Windows.Forms.Button();
            this.richTextBoxTotal = new System.Windows.Forms.RichTextBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxFries = new System.Windows.Forms.CheckBox();
            this.checkBoxSandwitch = new System.Windows.Forms.CheckBox();
            this.buttonMinusBur = new System.Windows.Forms.Button();
            this.buttonPlusBur = new System.Windows.Forms.Button();
            this.labelValueBurger = new System.Windows.Forms.Label();
            this.buttonMinusS = new System.Windows.Forms.Button();
            this.buttonPlusS = new System.Windows.Forms.Button();
            this.buttonMinusF = new System.Windows.Forms.Button();
            this.buttonPlusF = new System.Windows.Forms.Button();
            this.buttonMinusSa = new System.Windows.Forms.Button();
            this.buttonPlusSa = new System.Windows.Forms.Button();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFoods = new System.Windows.Forms.Panel();
            this.checkBoxSalad = new System.Windows.Forms.CheckBox();
            this.labelValueF = new System.Windows.Forms.Label();
            this.labelValueS = new System.Windows.Forms.Label();
            this.labelValueSa = new System.Windows.Forms.Label();
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
            this.comboBoxFoods.Items.AddRange(new object[] {
            "Φαγητό ",
            "Ροφήματα"});
            this.comboBoxFoods.Location = new System.Drawing.Point(12, 53);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(137, 23);
            this.comboBoxFoods.TabIndex = 2;
            this.comboBoxFoods.Text = "Επέλεξε κατηγορία";
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
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // richTextBoxTotal
            // 
            this.richTextBoxTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotal.Location = new System.Drawing.Point(12, 390);
            this.richTextBoxTotal.Name = "richTextBoxTotal";
            this.richTextBoxTotal.Size = new System.Drawing.Size(158, 83);
            this.richTextBoxTotal.TabIndex = 5;
            this.richTextBoxTotal.Text = " ";
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBurger.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxBurger.Image")));
            this.checkBoxBurger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxBurger.Location = new System.Drawing.Point(12, 51);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(158, 32);
            this.checkBoxBurger.TabIndex = 0;
            this.checkBoxBurger.Text = "           HamBurger: 15€";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.checkBoxBurger_CheckedChanged);
            // 
            // checkBoxFries
            // 
            this.checkBoxFries.AutoSize = true;
            this.checkBoxFries.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFries.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFries.Image")));
            this.checkBoxFries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxFries.Location = new System.Drawing.Point(12, 156);
            this.checkBoxFries.Name = "checkBoxFries";
            this.checkBoxFries.Size = new System.Drawing.Size(120, 32);
            this.checkBoxFries.TabIndex = 2;
            this.checkBoxFries.Text = "           Fries: 15€";
            this.checkBoxFries.UseVisualStyleBackColor = true;
            this.checkBoxFries.CheckedChanged += new System.EventHandler(this.checkBoxFries_CheckedChanged);
            // 
            // checkBoxSandwitch
            // 
            this.checkBoxSandwitch.AutoSize = true;
            this.checkBoxSandwitch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSandwitch.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxSandwitch.Image")));
            this.checkBoxSandwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxSandwitch.Location = new System.Drawing.Point(12, 203);
            this.checkBoxSandwitch.Name = "checkBoxSandwitch";
            this.checkBoxSandwitch.Size = new System.Drawing.Size(152, 32);
            this.checkBoxSandwitch.TabIndex = 3;
            this.checkBoxSandwitch.Text = "           Sandwitch: 15€";
            this.checkBoxSandwitch.UseVisualStyleBackColor = true;
            this.checkBoxSandwitch.CheckedChanged += new System.EventHandler(this.checkBoxSandwitch_CheckedChanged);
            // 
            // buttonMinusBur
            // 
            this.buttonMinusBur.Enabled = false;
            this.buttonMinusBur.Location = new System.Drawing.Point(169, 56);
            this.buttonMinusBur.Name = "buttonMinusBur";
            this.buttonMinusBur.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusBur.TabIndex = 4;
            this.buttonMinusBur.Text = "-";
            this.buttonMinusBur.UseVisualStyleBackColor = true;
            this.buttonMinusBur.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlusBur
            // 
            this.buttonPlusBur.Enabled = false;
            this.buttonPlusBur.Location = new System.Drawing.Point(228, 56);
            this.buttonPlusBur.Name = "buttonPlusBur";
            this.buttonPlusBur.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusBur.TabIndex = 5;
            this.buttonPlusBur.Text = "+";
            this.buttonPlusBur.UseVisualStyleBackColor = true;
            this.buttonPlusBur.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // labelValueBurger
            // 
            this.labelValueBurger.AutoSize = true;
            this.labelValueBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueBurger.Location = new System.Drawing.Point(206, 58);
            this.labelValueBurger.Name = "labelValueBurger";
            this.labelValueBurger.Size = new System.Drawing.Size(0, 16);
            this.labelValueBurger.TabIndex = 6;
            // 
            // buttonMinusS
            // 
            this.buttonMinusS.Enabled = false;
            this.buttonMinusS.Location = new System.Drawing.Point(169, 110);
            this.buttonMinusS.Name = "buttonMinusS";
            this.buttonMinusS.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusS.TabIndex = 7;
            this.buttonMinusS.Text = "-";
            this.buttonMinusS.UseVisualStyleBackColor = true;
            this.buttonMinusS.Click += new System.EventHandler(this.buttonMinusS_Click);
            // 
            // buttonPlusS
            // 
            this.buttonPlusS.Enabled = false;
            this.buttonPlusS.Location = new System.Drawing.Point(228, 110);
            this.buttonPlusS.Name = "buttonPlusS";
            this.buttonPlusS.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusS.TabIndex = 8;
            this.buttonPlusS.Text = "+";
            this.buttonPlusS.UseVisualStyleBackColor = true;
            this.buttonPlusS.Click += new System.EventHandler(this.buttonPlusS_Click);
            // 
            // buttonMinusF
            // 
            this.buttonMinusF.Enabled = false;
            this.buttonMinusF.Location = new System.Drawing.Point(169, 161);
            this.buttonMinusF.Name = "buttonMinusF";
            this.buttonMinusF.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusF.TabIndex = 10;
            this.buttonMinusF.Text = "-";
            this.buttonMinusF.UseVisualStyleBackColor = true;
            this.buttonMinusF.Click += new System.EventHandler(this.buttonMinusF_Click);
            // 
            // buttonPlusF
            // 
            this.buttonPlusF.Enabled = false;
            this.buttonPlusF.Location = new System.Drawing.Point(228, 161);
            this.buttonPlusF.Name = "buttonPlusF";
            this.buttonPlusF.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusF.TabIndex = 11;
            this.buttonPlusF.Text = "+";
            this.buttonPlusF.UseVisualStyleBackColor = true;
            this.buttonPlusF.Click += new System.EventHandler(this.buttonPlusF_Click);
            // 
            // buttonMinusSa
            // 
            this.buttonMinusSa.Enabled = false;
            this.buttonMinusSa.Location = new System.Drawing.Point(169, 208);
            this.buttonMinusSa.Name = "buttonMinusSa";
            this.buttonMinusSa.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusSa.TabIndex = 13;
            this.buttonMinusSa.Text = "-";
            this.buttonMinusSa.UseVisualStyleBackColor = true;
            this.buttonMinusSa.Click += new System.EventHandler(this.buttonMinusSa_Click);
            // 
            // buttonPlusSa
            // 
            this.buttonPlusSa.Enabled = false;
            this.buttonPlusSa.Location = new System.Drawing.Point(228, 208);
            this.buttonPlusSa.Name = "buttonPlusSa";
            this.buttonPlusSa.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusSa.TabIndex = 14;
            this.buttonPlusSa.Text = "+";
            this.buttonPlusSa.UseVisualStyleBackColor = true;
            this.buttonPlusSa.Click += new System.EventHandler(this.buttonPlusSa_Click);
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo3.Location = new System.Drawing.Point(27, 22);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(130, 16);
            this.labelInfo3.TabIndex = 16;
            this.labelInfo3.Text = "Επιλογή Προϊόντος";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ποσότητα";
            // 
            // panelFoods
            // 
            this.panelFoods.Controls.Add(this.labelValueSa);
            this.panelFoods.Controls.Add(this.labelValueS);
            this.panelFoods.Controls.Add(this.labelValueF);
            this.panelFoods.Controls.Add(this.label4);
            this.panelFoods.Controls.Add(this.labelInfo3);
            this.panelFoods.Controls.Add(this.buttonPlusSa);
            this.panelFoods.Controls.Add(this.buttonMinusSa);
            this.panelFoods.Controls.Add(this.buttonPlusF);
            this.panelFoods.Controls.Add(this.buttonMinusF);
            this.panelFoods.Controls.Add(this.buttonPlusS);
            this.panelFoods.Controls.Add(this.buttonMinusS);
            this.panelFoods.Controls.Add(this.labelValueBurger);
            this.panelFoods.Controls.Add(this.buttonPlusBur);
            this.panelFoods.Controls.Add(this.buttonMinusBur);
            this.panelFoods.Controls.Add(this.checkBoxSandwitch);
            this.panelFoods.Controls.Add(this.checkBoxFries);
            this.panelFoods.Controls.Add(this.checkBoxSalad);
            this.panelFoods.Controls.Add(this.checkBoxBurger);
            this.panelFoods.Location = new System.Drawing.Point(3, 82);
            this.panelFoods.Name = "panelFoods";
            this.panelFoods.Size = new System.Drawing.Size(270, 302);
            this.panelFoods.TabIndex = 3;
            // 
            // checkBoxSalad
            // 
            this.checkBoxSalad.AutoSize = true;
            this.checkBoxSalad.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSalad.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxSalad.Image")));
            this.checkBoxSalad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxSalad.Location = new System.Drawing.Point(12, 105);
            this.checkBoxSalad.Name = "checkBoxSalad";
            this.checkBoxSalad.Size = new System.Drawing.Size(123, 32);
            this.checkBoxSalad.TabIndex = 1;
            this.checkBoxSalad.Text = "           Salad: 15$";
            this.checkBoxSalad.UseVisualStyleBackColor = true;
            this.checkBoxSalad.CheckedChanged += new System.EventHandler(this.checkBoxSalad_CheckedChanged);
            // 
            // labelValueF
            // 
            this.labelValueF.AutoSize = true;
            this.labelValueF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueF.Location = new System.Drawing.Point(206, 161);
            this.labelValueF.Name = "labelValueF";
            this.labelValueF.Size = new System.Drawing.Size(0, 16);
            this.labelValueF.TabIndex = 23;
            // 
            // labelValueS
            // 
            this.labelValueS.AutoSize = true;
            this.labelValueS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueS.Location = new System.Drawing.Point(206, 110);
            this.labelValueS.Name = "labelValueS";
            this.labelValueS.Size = new System.Drawing.Size(0, 16);
            this.labelValueS.TabIndex = 24;
            // 
            // labelValueSa
            // 
            this.labelValueSa.AutoSize = true;
            this.labelValueSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueSa.Location = new System.Drawing.Point(206, 208);
            this.labelValueSa.Name = "labelValueSa";
            this.labelValueSa.Size = new System.Drawing.Size(0, 16);
            this.labelValueSa.TabIndex = 25;
            // 
            // FormOnlineOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 485);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBoxTotal);
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
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.RichTextBox richTextBoxTotal;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxFries;
        private System.Windows.Forms.CheckBox checkBoxSandwitch;
        private System.Windows.Forms.Button buttonMinusBur;
        private System.Windows.Forms.Button buttonPlusBur;
        private System.Windows.Forms.Label labelValueBurger;
        private System.Windows.Forms.Button buttonMinusS;
        private System.Windows.Forms.Button buttonPlusS;
        private System.Windows.Forms.Button buttonMinusF;
        private System.Windows.Forms.Button buttonPlusF;
        private System.Windows.Forms.Button buttonMinusSa;
        private System.Windows.Forms.Button buttonPlusSa;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFoods;
        private System.Windows.Forms.CheckBox checkBoxSalad;
        private System.Windows.Forms.Label labelValueS;
        private System.Windows.Forms.Label labelValueF;
        private System.Windows.Forms.Label labelValueSa;
    }
}