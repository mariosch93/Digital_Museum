using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Museum
{
    public partial class FormOnlineOrder : Form
    {
        
        int totalCost = 0;
        int[] foods2 = { 15, 15, 15, 3, 4 };
        int[] drinks = { 0, 1, 2, 3, 4 };
        int counterValue = 0;
        int counterValueS = 0;
        int counterValueSa = 0;
        int counterValueF = 0;

        public FormOnlineOrder()
        {
            InitializeComponent();
        }


        void calculatecost() 
        {
            totalCost = (counterValue * 20) + (counterValueS * 15) + (counterValueSa * 10) + (counterValueF * 6);
            richTextBoxTotal.Text = $"Το τελικό ποσό πληρωμής είναι: {totalCost}€ ";
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment(totalCost);
            formPayment.ShowDialog();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            counterValue += 1;
            labelValueBurger.Text = counterValue.ToString();
            calculatecost();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (counterValue <= 0)
            {
                counterValue = 0;
            }
            else {
                counterValue -= 1;
            }
            labelValueBurger.Text = counterValue.ToString();
            calculatecost();
        }

        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBurger.Checked == true)
            {
                buttonMinusBur.Enabled = true;
                buttonPlusBur.Enabled = true;
            }
            else
            {
                labelValueBurger.Text = "";
                buttonMinusBur.Enabled = false;
                buttonPlusBur.Enabled = false;
                counterValue = 0;
            }
        }

        private void checkBoxSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSalad.Checked == true)
            {
                buttonMinusS.Enabled = true;
                buttonPlusS.Enabled = true;
            }
            else
            {
                labelValueS.Text = "";
                buttonMinusS.Enabled = false;
                buttonPlusS.Enabled = false;
                counterValueS = 0;
            }
        }

        private void checkBoxFries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFries.Checked == true)
            {
                buttonMinusF.Enabled = true;
                buttonPlusF.Enabled = true;
            }
            else
            {
                labelValueF.Text = "";
                buttonMinusF.Enabled = false;
                buttonPlusF.Enabled = false;
                counterValueF = 0;
            }
        }

        private void checkBoxSandwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSandwitch.Checked == true)
            {
                buttonMinusSa.Enabled = true;
                buttonPlusSa.Enabled = true;
            }
            else
            {
                labelValueSa.Text = "";
                buttonMinusSa.Enabled = false;
                buttonPlusSa.Enabled = false;
                counterValueSa = 0;
            }
        }

        private void buttonMinusS_Click(object sender, EventArgs e)
        {
            if (counterValueS <= 0)
            {
                counterValueS = 0;
            }
            else
            {
                counterValueS -= 1;
            }
            labelValueS.Text = counterValueS.ToString();
            calculatecost();
        }

        private void buttonPlusS_Click(object sender, EventArgs e)
        {
            counterValueS += 1;
            labelValueS.Text = counterValueS.ToString();
            calculatecost();
        }

        private void buttonMinusF_Click(object sender, EventArgs e)
        {
            if (counterValueF <= 0)
            {
                counterValueF = 0;
            }
            else
            {
                counterValueF -= 1;
            }
            labelValueF.Text = counterValueF.ToString();
            calculatecost();
        }

        private void buttonPlusF_Click(object sender, EventArgs e)
        {
            counterValueF += 1;
            labelValueF.Text = counterValueF.ToString();
            calculatecost();
        }

        private void buttonMinusSa_Click(object sender, EventArgs e)
        {
            if (counterValueSa <= 0)
            {
                counterValueSa = 0;
            }
            else
            {
                counterValueSa -= 1;
            }
            labelValueSa.Text = counterValueSa.ToString();
            calculatecost();
        }

        private void buttonPlusSa_Click(object sender, EventArgs e)
        {
            counterValueSa += 1;
            labelValueSa.Text = counterValueSa.ToString();
            calculatecost();
        }
    }
}
