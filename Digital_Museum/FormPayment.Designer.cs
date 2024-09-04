namespace Digital_Museum
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelPay = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTypePay = new System.Windows.Forms.Label();
            this.comboBoxTypePay = new System.Windows.Forms.ComboBox();
            this.labelNumCard = new System.Windows.Forms.Label();
            this.textBoxNumCard = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxErrors = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBarPayment = new System.Windows.Forms.ProgressBar();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(217, 310);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(144, 20);
            this.textBoxCost.TabIndex = 0;
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Font = new System.Drawing.Font("Arial", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPay.Location = new System.Drawing.Point(55, 52);
            this.labelPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(698, 19);
            this.labelPay.TabIndex = 1;
            this.labelPay.Text = "Συμπληρώστε τα στοιχεία σας παρακάτω προκειμένου να πραγματοποιηθεί η πληρωμή";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelName.Location = new System.Drawing.Point(34, 97);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Όνοματεπωνυμο:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(217, 99);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 19);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelTypePay
            // 
            this.labelTypePay.AutoSize = true;
            this.labelTypePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTypePay.Location = new System.Drawing.Point(34, 188);
            this.labelTypePay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypePay.Name = "labelTypePay";
            this.labelTypePay.Size = new System.Drawing.Size(117, 20);
            this.labelTypePay.TabIndex = 6;
            this.labelTypePay.Text = "Τύπος Κάρτας:";
            // 
            // comboBoxTypePay
            // 
            this.comboBoxTypePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypePay.FormattingEnabled = true;
            this.comboBoxTypePay.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "AmericanExpress"});
            this.comboBoxTypePay.Location = new System.Drawing.Point(215, 188);
            this.comboBoxTypePay.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTypePay.Name = "comboBoxTypePay";
            this.comboBoxTypePay.Size = new System.Drawing.Size(144, 23);
            this.comboBoxTypePay.TabIndex = 7;
            this.comboBoxTypePay.Text = "Choose card type";
            this.comboBoxTypePay.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypePay_SelectedIndexChanged);
            // 
            // labelNumCard
            // 
            this.labelNumCard.AutoSize = true;
            this.labelNumCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelNumCard.Location = new System.Drawing.Point(34, 229);
            this.labelNumCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumCard.Name = "labelNumCard";
            this.labelNumCard.Size = new System.Drawing.Size(132, 20);
            this.labelNumCard.TabIndex = 8;
            this.labelNumCard.Text = "Αριθμός Κάρτας:";
            // 
            // textBoxNumCard
            // 
            this.textBoxNumCard.Location = new System.Drawing.Point(217, 231);
            this.textBoxNumCard.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumCard.MaxLength = 16;
            this.textBoxNumCard.Multiline = true;
            this.textBoxNumCard.Name = "textBoxNumCard";
            this.textBoxNumCard.PasswordChar = '*';
            this.textBoxNumCard.Size = new System.Drawing.Size(144, 19);
            this.textBoxNumCard.TabIndex = 9;
            this.textBoxNumCard.TextChanged += new System.EventHandler(this.textBoxNumCard_TextChanged);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTotalCost.Location = new System.Drawing.Point(31, 310);
            this.labelTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(138, 20);
            this.labelTotalCost.TabIndex = 10;
            this.labelTotalCost.Text = "Συνολικό Κόστος:";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(776, 455);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(67, 53);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 415;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(776, 12);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(67, 59);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 414;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 416;
            this.pictureBox1.TabStop = false;
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.ForeColor = System.Drawing.Color.Red;
            this.labelCard.Location = new System.Drawing.Point(212, 274);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(0, 16);
            this.labelCard.TabIndex = 417;
            this.labelCard.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 270);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 4;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(144, 19);
            this.textBox1.TabIndex = 420;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCVV.Location = new System.Drawing.Point(32, 269);
            this.labelCVV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(176, 18);
            this.labelCVV.TabIndex = 419;
            this.labelCVV.Text = "Κωδικός αφάλειας (CVV)";
            // 
            // buttonPayment
            // 
            this.buttonPayment.FlatAppearance.BorderSize = 2;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.Location = new System.Drawing.Point(217, 336);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(146, 48);
            this.buttonPayment.TabIndex = 421;
            this.buttonPayment.Text = "Ολοκλήρωση \r\nπληρωμής";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErrors.Location = new System.Drawing.Point(21, 390);
            this.textBoxErrors.Multiline = true;
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.Size = new System.Drawing.Size(471, 129);
            this.textBoxErrors.TabIndex = 422;
            this.textBoxErrors.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 423;
            this.button1.Text = "Ακύρωση\r\nπληρωμής";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // progressBarPayment
            // 
            this.progressBarPayment.Location = new System.Drawing.Point(25, 436);
            this.progressBarPayment.MarqueeAnimationSpeed = 5;
            this.progressBarPayment.Name = "progressBarPayment";
            this.progressBarPayment.Size = new System.Drawing.Size(467, 31);
            this.progressBarPayment.Step = 5;
            this.progressBarPayment.TabIndex = 424;
            this.progressBarPayment.Visible = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(217, 144);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(144, 19);
            this.textBoxEmail.TabIndex = 426;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelEmail.Location = new System.Drawing.Point(34, 144);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(146, 20);
            this.labelEmail.TabIndex = 425;
            this.labelEmail.Text = "Συμπλήρωση email:";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 520);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.progressBarPayment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxErrors);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.textBoxNumCard);
            this.Controls.Add(this.labelNumCard);
            this.Controls.Add(this.comboBoxTypePay);
            this.Controls.Add(this.labelTypePay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPay);
            this.Controls.Add(this.textBoxCost);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTypePay;
        private System.Windows.Forms.ComboBox comboBoxTypePay;
        private System.Windows.Forms.Label labelNumCard;
        private System.Windows.Forms.TextBox textBoxNumCard;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxErrors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarPayment;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}