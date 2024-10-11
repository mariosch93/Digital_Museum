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
            this.labelHello = new System.Windows.Forms.Label();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.richTextBoxTotal = new System.Windows.Forms.RichTextBox();
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
            this.labelValueSa = new System.Windows.Forms.Label();
            this.labelValueS = new System.Windows.Forms.Label();
            this.labelValueF = new System.Windows.Forms.Label();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.labelValueCola = new System.Windows.Forms.Label();
            this.labelValueFr = new System.Windows.Forms.Label();
            this.labelValueJ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPlusCola = new System.Windows.Forms.Button();
            this.buttonMinusCola = new System.Windows.Forms.Button();
            this.buttonPlusJ = new System.Windows.Forms.Button();
            this.buttonMinusJ = new System.Windows.Forms.Button();
            this.buttonPlusFr = new System.Windows.Forms.Button();
            this.buttonMinusFr = new System.Windows.Forms.Button();
            this.labelValueCap = new System.Windows.Forms.Label();
            this.buttonPlusCap = new System.Windows.Forms.Button();
            this.buttonMinusCap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.checkBoxJ = new System.Windows.Forms.CheckBox();
            this.checkBoxFreddo = new System.Windows.Forms.CheckBox();
            this.checkBoxCappuccino = new System.Windows.Forms.CheckBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.checkBoxSandwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxFries = new System.Windows.Forms.CheckBox();
            this.checkBoxSalad = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFoods.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(5, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 16);
            this.labelHello.TabIndex = 1;
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.AutoCompleteCustomSource.AddRange(new string[] {
            "Φαγητό",
            "Ροφήματα"});
            this.comboBoxFoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFoods.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Items.AddRange(new object[] {
            "Φαγητό ",
            "Ροφήματα"});
            this.comboBoxFoods.Location = new System.Drawing.Point(3, 69);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(137, 23);
            this.comboBoxFoods.TabIndex = 2;
            this.comboBoxFoods.Text = "Επέλεξε κατηγορία";
            this.comboBoxFoods.SelectedIndexChanged += new System.EventHandler(this.comboBoxFoods_SelectedIndexChanged);
            // 
            // richTextBoxTotal
            // 
            this.richTextBoxTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTotal.Location = new System.Drawing.Point(3, 390);
            this.richTextBoxTotal.Name = "richTextBoxTotal";
            this.richTextBoxTotal.Size = new System.Drawing.Size(160, 83);
            this.richTextBoxTotal.TabIndex = 5;
            this.richTextBoxTotal.Text = " ";
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
            this.panelFoods.Location = new System.Drawing.Point(3, 98);
            this.panelFoods.Name = "panelFoods";
            this.panelFoods.Size = new System.Drawing.Size(270, 286);
            this.panelFoods.TabIndex = 3;
            this.panelFoods.Visible = false;
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
            // labelValueS
            // 
            this.labelValueS.AutoSize = true;
            this.labelValueS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueS.Location = new System.Drawing.Point(206, 110);
            this.labelValueS.Name = "labelValueS";
            this.labelValueS.Size = new System.Drawing.Size(0, 16);
            this.labelValueS.TabIndex = 24;
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
            // panelDrinks
            // 
            this.panelDrinks.Controls.Add(this.labelValueCola);
            this.panelDrinks.Controls.Add(this.labelValueFr);
            this.panelDrinks.Controls.Add(this.labelValueJ);
            this.panelDrinks.Controls.Add(this.label5);
            this.panelDrinks.Controls.Add(this.label6);
            this.panelDrinks.Controls.Add(this.buttonPlusCola);
            this.panelDrinks.Controls.Add(this.buttonMinusCola);
            this.panelDrinks.Controls.Add(this.buttonPlusJ);
            this.panelDrinks.Controls.Add(this.buttonMinusJ);
            this.panelDrinks.Controls.Add(this.buttonPlusFr);
            this.panelDrinks.Controls.Add(this.buttonMinusFr);
            this.panelDrinks.Controls.Add(this.labelValueCap);
            this.panelDrinks.Controls.Add(this.buttonPlusCap);
            this.panelDrinks.Controls.Add(this.buttonMinusCap);
            this.panelDrinks.Controls.Add(this.checkBoxCola);
            this.panelDrinks.Controls.Add(this.checkBoxJ);
            this.panelDrinks.Controls.Add(this.checkBoxFreddo);
            this.panelDrinks.Controls.Add(this.checkBoxCappuccino);
            this.panelDrinks.Location = new System.Drawing.Point(3, 98);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(270, 286);
            this.panelDrinks.TabIndex = 6;
            this.panelDrinks.Visible = false;
            // 
            // labelValueCola
            // 
            this.labelValueCola.AutoSize = true;
            this.labelValueCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueCola.Location = new System.Drawing.Point(221, 208);
            this.labelValueCola.Name = "labelValueCola";
            this.labelValueCola.Size = new System.Drawing.Size(0, 16);
            this.labelValueCola.TabIndex = 25;
            // 
            // labelValueFr
            // 
            this.labelValueFr.AutoSize = true;
            this.labelValueFr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueFr.Location = new System.Drawing.Point(221, 110);
            this.labelValueFr.Name = "labelValueFr";
            this.labelValueFr.Size = new System.Drawing.Size(0, 16);
            this.labelValueFr.TabIndex = 24;
            // 
            // labelValueJ
            // 
            this.labelValueJ.AutoSize = true;
            this.labelValueJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueJ.Location = new System.Drawing.Point(221, 161);
            this.labelValueJ.Name = "labelValueJ";
            this.labelValueJ.Size = new System.Drawing.Size(0, 16);
            this.labelValueJ.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ποσότητα";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Επιλογή Προϊόντος";
            // 
            // buttonPlusCola
            // 
            this.buttonPlusCola.Enabled = false;
            this.buttonPlusCola.Location = new System.Drawing.Point(239, 208);
            this.buttonPlusCola.Name = "buttonPlusCola";
            this.buttonPlusCola.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusCola.TabIndex = 14;
            this.buttonPlusCola.Text = "+";
            this.buttonPlusCola.UseVisualStyleBackColor = true;
            this.buttonPlusCola.Click += new System.EventHandler(this.buttonPlusCola_Click);
            // 
            // buttonMinusCola
            // 
            this.buttonMinusCola.Enabled = false;
            this.buttonMinusCola.Location = new System.Drawing.Point(184, 208);
            this.buttonMinusCola.Name = "buttonMinusCola";
            this.buttonMinusCola.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusCola.TabIndex = 13;
            this.buttonMinusCola.Text = "-";
            this.buttonMinusCola.UseVisualStyleBackColor = true;
            this.buttonMinusCola.Click += new System.EventHandler(this.buttonMinusCola_Click);
            // 
            // buttonPlusJ
            // 
            this.buttonPlusJ.Enabled = false;
            this.buttonPlusJ.Location = new System.Drawing.Point(239, 161);
            this.buttonPlusJ.Name = "buttonPlusJ";
            this.buttonPlusJ.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusJ.TabIndex = 11;
            this.buttonPlusJ.Text = "+";
            this.buttonPlusJ.UseVisualStyleBackColor = true;
            this.buttonPlusJ.Click += new System.EventHandler(this.buttonPlusJ_Click);
            // 
            // buttonMinusJ
            // 
            this.buttonMinusJ.Enabled = false;
            this.buttonMinusJ.Location = new System.Drawing.Point(184, 161);
            this.buttonMinusJ.Name = "buttonMinusJ";
            this.buttonMinusJ.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusJ.TabIndex = 10;
            this.buttonMinusJ.Text = "-";
            this.buttonMinusJ.UseVisualStyleBackColor = true;
            this.buttonMinusJ.Click += new System.EventHandler(this.buttonMinusJ_Click);
            // 
            // buttonPlusFr
            // 
            this.buttonPlusFr.Enabled = false;
            this.buttonPlusFr.Location = new System.Drawing.Point(239, 110);
            this.buttonPlusFr.Name = "buttonPlusFr";
            this.buttonPlusFr.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusFr.TabIndex = 8;
            this.buttonPlusFr.Text = "+";
            this.buttonPlusFr.UseVisualStyleBackColor = true;
            this.buttonPlusFr.Click += new System.EventHandler(this.buttonPlusFr_Click);
            // 
            // buttonMinusFr
            // 
            this.buttonMinusFr.Enabled = false;
            this.buttonMinusFr.Location = new System.Drawing.Point(184, 110);
            this.buttonMinusFr.Name = "buttonMinusFr";
            this.buttonMinusFr.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusFr.TabIndex = 7;
            this.buttonMinusFr.Text = "-";
            this.buttonMinusFr.UseVisualStyleBackColor = true;
            this.buttonMinusFr.Click += new System.EventHandler(this.buttonMinusFr_Click);
            // 
            // labelValueCap
            // 
            this.labelValueCap.AutoSize = true;
            this.labelValueCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueCap.Location = new System.Drawing.Point(221, 58);
            this.labelValueCap.Name = "labelValueCap";
            this.labelValueCap.Size = new System.Drawing.Size(0, 16);
            this.labelValueCap.TabIndex = 6;
            // 
            // buttonPlusCap
            // 
            this.buttonPlusCap.Enabled = false;
            this.buttonPlusCap.Location = new System.Drawing.Point(239, 56);
            this.buttonPlusCap.Name = "buttonPlusCap";
            this.buttonPlusCap.Size = new System.Drawing.Size(28, 22);
            this.buttonPlusCap.TabIndex = 5;
            this.buttonPlusCap.Text = "+";
            this.buttonPlusCap.UseVisualStyleBackColor = true;
            this.buttonPlusCap.Click += new System.EventHandler(this.buttonPlusCap_Click);
            // 
            // buttonMinusCap
            // 
            this.buttonMinusCap.Enabled = false;
            this.buttonMinusCap.Location = new System.Drawing.Point(184, 56);
            this.buttonMinusCap.Name = "buttonMinusCap";
            this.buttonMinusCap.Size = new System.Drawing.Size(28, 22);
            this.buttonMinusCap.TabIndex = 4;
            this.buttonMinusCap.Text = "-";
            this.buttonMinusCap.UseVisualStyleBackColor = true;
            this.buttonMinusCap.Click += new System.EventHandler(this.buttonMinusCap_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 432;
            this.button1.Text = "HELP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCola.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxCola.Image")));
            this.checkBoxCola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxCola.Location = new System.Drawing.Point(12, 203);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(142, 32);
            this.checkBoxCola.TabIndex = 3;
            this.checkBoxCola.Text = "           Coca cola: 3€";
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.CheckedChanged += new System.EventHandler(this.checkBoxCola_CheckedChanged);
            // 
            // checkBoxJ
            // 
            this.checkBoxJ.AutoSize = true;
            this.checkBoxJ.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJ.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxJ.Image")));
            this.checkBoxJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxJ.Location = new System.Drawing.Point(12, 156);
            this.checkBoxJ.Name = "checkBoxJ";
            this.checkBoxJ.Size = new System.Drawing.Size(157, 32);
            this.checkBoxJ.TabIndex = 2;
            this.checkBoxJ.Text = "         Orange Juice: 4€";
            this.checkBoxJ.UseVisualStyleBackColor = true;
            this.checkBoxJ.CheckedChanged += new System.EventHandler(this.checkBoxJuice_CheckedChanged);
            // 
            // checkBoxFreddo
            // 
            this.checkBoxFreddo.AutoSize = true;
            this.checkBoxFreddo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFreddo.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFreddo.Image")));
            this.checkBoxFreddo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxFreddo.Location = new System.Drawing.Point(12, 105);
            this.checkBoxFreddo.Name = "checkBoxFreddo";
            this.checkBoxFreddo.Size = new System.Drawing.Size(167, 32);
            this.checkBoxFreddo.TabIndex = 1;
            this.checkBoxFreddo.Text = "          Cold espresso: 3€";
            this.checkBoxFreddo.UseVisualStyleBackColor = true;
            this.checkBoxFreddo.CheckedChanged += new System.EventHandler(this.checkBoxFreddo_CheckedChanged);
            // 
            // checkBoxCappuccino
            // 
            this.checkBoxCappuccino.AutoSize = true;
            this.checkBoxCappuccino.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCappuccino.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxCappuccino.Image")));
            this.checkBoxCappuccino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxCappuccino.Location = new System.Drawing.Point(12, 51);
            this.checkBoxCappuccino.Name = "checkBoxCappuccino";
            this.checkBoxCappuccino.Size = new System.Drawing.Size(156, 32);
            this.checkBoxCappuccino.TabIndex = 0;
            this.checkBoxCappuccino.Text = "           Cappuccino: 3€";
            this.checkBoxCappuccino.UseVisualStyleBackColor = true;
            this.checkBoxCappuccino.CheckedChanged += new System.EventHandler(this.checkBoxCappuccino_CheckedChanged);
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
            this.buttonPayment.Location = new System.Drawing.Point(169, 390);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(101, 83);
            this.buttonPayment.TabIndex = 4;
            this.buttonPayment.Text = "Ολοκληρώστε την πληρωμή σας";
            this.buttonPayment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // checkBoxSandwitch
            // 
            this.checkBoxSandwitch.AutoSize = true;
            this.checkBoxSandwitch.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSandwitch.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxSandwitch.Image")));
            this.checkBoxSandwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxSandwitch.Location = new System.Drawing.Point(12, 203);
            this.checkBoxSandwitch.Name = "checkBoxSandwitch";
            this.checkBoxSandwitch.Size = new System.Drawing.Size(145, 32);
            this.checkBoxSandwitch.TabIndex = 3;
            this.checkBoxSandwitch.Text = "           Sandwitch: 8€";
            this.checkBoxSandwitch.UseVisualStyleBackColor = true;
            this.checkBoxSandwitch.CheckedChanged += new System.EventHandler(this.checkBoxSandwitch_CheckedChanged);
            // 
            // checkBoxFries
            // 
            this.checkBoxFries.AutoSize = true;
            this.checkBoxFries.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFries.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFries.Image")));
            this.checkBoxFries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxFries.Location = new System.Drawing.Point(12, 156);
            this.checkBoxFries.Name = "checkBoxFries";
            this.checkBoxFries.Size = new System.Drawing.Size(113, 32);
            this.checkBoxFries.TabIndex = 2;
            this.checkBoxFries.Text = "           Fries: 6€";
            this.checkBoxFries.UseVisualStyleBackColor = true;
            this.checkBoxFries.CheckedChanged += new System.EventHandler(this.checkBoxFries_CheckedChanged);
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
            this.checkBoxSalad.Text = "           Salad: 10€";
            this.checkBoxSalad.UseVisualStyleBackColor = true;
            this.checkBoxSalad.CheckedChanged += new System.EventHandler(this.checkBoxSalad_CheckedChanged);
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
            // FormOnlineOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 485);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.richTextBoxTotal);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.panelFoods);
            this.Controls.Add(this.comboBoxFoods);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormOnlineOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineOrder";
            this.panelFoods.ResumeLayout(false);
            this.panelFoods.PerformLayout();
            this.panelDrinks.ResumeLayout(false);
            this.panelDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Label labelValueCola;
        private System.Windows.Forms.Label labelValueFr;
        private System.Windows.Forms.Label labelValueJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPlusCola;
        private System.Windows.Forms.Button buttonMinusCola;
        private System.Windows.Forms.Button buttonPlusJ;
        private System.Windows.Forms.Button buttonMinusJ;
        private System.Windows.Forms.Button buttonPlusFr;
        private System.Windows.Forms.Button buttonMinusFr;
        private System.Windows.Forms.Label labelValueCap;
        private System.Windows.Forms.Button buttonPlusCap;
        private System.Windows.Forms.Button buttonMinusCap;
        private System.Windows.Forms.CheckBox checkBoxCola;
        private System.Windows.Forms.CheckBox checkBoxJ;
        private System.Windows.Forms.CheckBox checkBoxFreddo;
        private System.Windows.Forms.CheckBox checkBoxCappuccino;
        private System.Windows.Forms.Button button1;
    }
}