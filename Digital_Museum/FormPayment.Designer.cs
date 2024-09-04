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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTypePay = new System.Windows.Forms.Label();
            this.comboBoxTypePay = new System.Windows.Forms.ComboBox();
            this.labelNumCard = new System.Windows.Forms.Label();
            this.textBoxNumCard = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(460, 473);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(190, 22);
            this.textBoxCost.TabIndex = 0;
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelPay.Location = new System.Drawing.Point(209, 51);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(858, 25);
            this.labelPay.TabIndex = 1;
            this.labelPay.Text = "Συμπληρώστε τα στοιχεία σας παρακάτω προκειμένου να πραγματοποιηθεί η πληρωμή";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelName.Location = new System.Drawing.Point(220, 167);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Όνομα:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(460, 167);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 230);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(220, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Επώνυμο:";
            // 
            // labelTypePay
            // 
            this.labelTypePay.AutoSize = true;
            this.labelTypePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTypePay.Location = new System.Drawing.Point(220, 305);
            this.labelTypePay.Name = "labelTypePay";
            this.labelTypePay.Size = new System.Drawing.Size(150, 25);
            this.labelTypePay.TabIndex = 6;
            this.labelTypePay.Text = "Τύπος Κάρτας:";
            // 
            // comboBoxTypePay
            // 
            this.comboBoxTypePay.FormattingEnabled = true;
            this.comboBoxTypePay.Location = new System.Drawing.Point(460, 309);
            this.comboBoxTypePay.Name = "comboBoxTypePay";
            this.comboBoxTypePay.Size = new System.Drawing.Size(190, 24);
            this.comboBoxTypePay.TabIndex = 7;
            // 
            // labelNumCard
            // 
            this.labelNumCard.AutoSize = true;
            this.labelNumCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelNumCard.Location = new System.Drawing.Point(220, 387);
            this.labelNumCard.Name = "labelNumCard";
            this.labelNumCard.Size = new System.Drawing.Size(166, 25);
            this.labelNumCard.TabIndex = 8;
            this.labelNumCard.Text = "Αριθμός Κάρτας:";
            // 
            // textBoxNumCard
            // 
            this.textBoxNumCard.Location = new System.Drawing.Point(460, 391);
            this.textBoxNumCard.Multiline = true;
            this.textBoxNumCard.Name = "textBoxNumCard";
            this.textBoxNumCard.PasswordChar = '*';
            this.textBoxNumCard.Size = new System.Drawing.Size(190, 22);
            this.textBoxNumCard.TabIndex = 9;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTotalCost.Location = new System.Drawing.Point(220, 473);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(172, 25);
            this.labelTotalCost.TabIndex = 10;
            this.labelTotalCost.Text = "Συνολικό Κόστος:";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1188, 557);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(89, 65);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 415;
            this.pictureBoxExit.TabStop = false;
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUnipi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnipi.Image")));
            this.pictureBoxUnipi.Location = new System.Drawing.Point(1188, 32);
            this.pictureBoxUnipi.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(89, 73);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnipi.TabIndex = 414;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(717, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 416;
            this.pictureBox1.TabStop = false;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.textBoxNumCard);
            this.Controls.Add(this.labelNumCard);
            this.Controls.Add(this.comboBoxTypePay);
            this.Controls.Add(this.labelTypePay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPay);
            this.Controls.Add(this.textBoxCost);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTypePay;
        private System.Windows.Forms.ComboBox comboBoxTypePay;
        private System.Windows.Forms.Label labelNumCard;
        private System.Windows.Forms.TextBox textBoxNumCard;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}