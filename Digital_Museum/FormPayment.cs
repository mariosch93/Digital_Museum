using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Linq.Enumerable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Digital_Museum
{
    public partial class FormPayment : Form
    {
        int totalCost;
        Regex regexCard = new Regex("^[0-9]{16}");
        Regex regexName = new Regex("^[α-ω Α-Ω Ά-ώ a-z A-Z]+$");
        Regex regexCVV = new Regex("^[0-9]{4}");
        Regex regexEmail = new Regex("[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$");
        String compare;
        bool cardAccepted = false;
        bool nameAccepted = false;
        bool cardCVV_Accepted = false;
        bool emailAccepted = false;
        String errorName;
        String errorCard;
        String errorCVV;
        String errorCType;
        String errorEmail;
        

        public FormPayment(int totalCost)
        {
            InitializeComponent();
            this.totalCost = totalCost;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            textBoxCost.Text = $"{totalCost}";
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxNumCard_TextChanged(object sender, EventArgs e)
        {
            String compare = textBoxNumCard.Text;
            if (regexCard.IsMatch(compare))
            {
                cardAccepted = true;
                textBoxNumCard.BackColor = Color.LightGreen;
            }
            else
            {
                cardAccepted = false;
                textBoxNumCard.BackColor = Color.White;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            String compare = textBoxName.Text;
            if (regexName.IsMatch(compare))
            {
                nameAccepted = true;
                textBoxName.BackColor = Color.LightGreen;
            }
            else
            {
                nameAccepted = false;
                textBoxName.BackColor = Color.White;
            }
        }

        private void comboBoxTypePay_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTypePay.BackColor = Color.LightGreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String compare = textBox1.Text;
            if (regexCVV.IsMatch(compare))
            {
                cardCVV_Accepted = true;
                textBox1.BackColor = Color.LightGreen;
            }
            else
            {
                cardCVV_Accepted = false;
                textBox1.BackColor = Color.White;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            String compare = textBoxEmail.Text;
            if (regexEmail.IsMatch(compare))
            {
                emailAccepted = true;
                textBoxEmail.BackColor = Color.LightGreen;
            }
            else
            {
                emailAccepted = false;
                textBoxEmail.BackColor = Color.White;
            }
        }

        void allaccepted()
        {
            textBoxErrors.Clear();
            errorName = string.Empty;
            errorCard = string.Empty;
            errorCVV = string.Empty;
            errorCType = string.Empty;
            errorEmail = string.Empty;

            if (nameAccepted == false || cardAccepted == false || cardCVV_Accepted == false || comboBoxTypePay.SelectedIndex == -1 || emailAccepted == false)
            {
                textBoxErrors.Visible = true;
                
                if (nameAccepted == false)
                {
                    errorName = "•Το όνομα σας μπορεί να περιέχει μόνο γράμματα";
                }
                if (cardAccepted == false)
                {
                    errorCard = "•Ελέξτε τα στοιχεία της κάρτας σας";
                }
                if (cardCVV_Accepted == false)
                {
                    errorCVV = "•Ο CVV είναι τα τελευταία 4 ψηφία πίσω απο τη κάρτα σας";
                }
                if (emailAccepted == false) 
                {
                    errorEmail = "•Το email πρέπει να είναι της μορφής example@mail.com";
                }
                if (comboBoxTypePay.SelectedIndex == -1)
                {
                    errorCType = "•Υποχρεωτική επιλογή τύπου κάρτας";
                }
                textBoxErrors.Text= $"{errorName}{Environment.NewLine}{errorCard}{Environment.NewLine}{errorCVV}{Environment.NewLine}{errorCType}{Environment.NewLine}{errorEmail}";
            }
            else
            {
                textBoxErrors.Visible = false;
                buttonPayment.FlatAppearance.BorderColor = Color.Green;
                progressBarPayment.Visible = true;
                progressBarPayment.Value = 100;
            
                timerProgressbar = new Timer();
                timerProgressbar.Tick += new EventHandler(timerProgressbar_Tick);
                timerProgressbar.Start();
            }
        }

        private void timerProgressbar_Tick(object sender, EventArgs e)
        {
            if (progressBarPayment.Value < 100)
            {
                progressBarPayment.Value += 1;
            }
            else
            {
                timerProgressbar.Stop();
                MessageBox.Show("Επιτυχής πληρωμή, Θα λάβετε τα στοιχεία παραγγελίας στο email σας, Σας ευχαριστούμε για τη προτίμηση!❤️❤️❤️");
                this.Close();
            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            allaccepted();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
