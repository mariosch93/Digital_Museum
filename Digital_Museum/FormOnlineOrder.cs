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
        LoginInfo loginInfo;
        int totalCost = 0;
        int counterValue = 0;
        int counterValueS = 0;
        int counterValueSa = 0;
        int counterValueF = 0;
        int counterValueCap = 0;
        int counterValueFr = 0;
        int counterValueJ = 0;
        int counterValueCola = 0;

        public FormOnlineOrder(LoginInfo loginInfo)
        {
            InitializeComponent();
            this.loginInfo = loginInfo;
            if (loginInfo != null)
            {
                labelHello.Text = $"Γεια σας ονομάζομαι {loginInfo.UserName}!\nΠως θα μπορούσα \nνα σας εξυπηρετήσω?";
            }
            else {
                labelHello.Text = $"Γεια σας! Πως θα μπορούσα \nνα σας εξυπηρετήσω?";
            }
        }

        void calculatecost() 
        {
            totalCost = (counterValue * 15) + (counterValueS * 10) + (counterValueSa * 8) + (counterValueF * 6) +
                        (counterValueCap * 3) + (counterValueJ * 4) + (counterValueCola * 3) + (counterValueFr * 3);
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
                calculatecost();
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
                calculatecost();
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
                calculatecost();
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
                calculatecost();
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

        private void comboBoxFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFoods.SelectedIndex == 0)
            {
                panelDrinks.Visible = false;
                panelFoods.Visible = true;
            }
            if(comboBoxFoods.SelectedIndex == 1)
            {
                panelFoods.Visible = false;
                panelDrinks.Visible = true; 
            }
        }

        private void checkBoxCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCappuccino.Checked == true)
            {
                buttonMinusCap.Enabled = true;
                buttonPlusCap.Enabled = true;
            }
            else
            {
                labelValueCap.Text = "";
                buttonMinusCap.Enabled = false;
                buttonPlusCap.Enabled = false;
                counterValueCap = 0;
                calculatecost();
            }
        }

        private void checkBoxJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJ.Checked == true)
            {
                buttonMinusJ.Enabled = true;
                buttonPlusJ.Enabled = true;
            }
            else
            {
                labelValueJ.Text = "";
                buttonMinusJ.Enabled = false;
                buttonPlusJ.Enabled = false;
                counterValueJ = 0;
                calculatecost();
            }
        }

        private void checkBoxFreddo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFreddo.Checked == true)
            {
                buttonMinusFr.Enabled = true;
                buttonPlusFr.Enabled = true;
            }
            else
            {
                labelValueFr.Text = "";
                buttonMinusFr.Enabled = false;
                buttonPlusFr.Enabled = false;
                counterValueFr = 0;
                calculatecost();
            }
        }

        private void checkBoxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCola.Checked == true)
            {
                buttonMinusCola.Enabled = true;
                buttonPlusCola.Enabled = true;
            }
            else
            {
                labelValueCola.Text = "";
                buttonMinusCola.Enabled = false;
                buttonPlusCola.Enabled = false;
                counterValueCola = 0;
                calculatecost();
            }
        }

        private void buttonMinusCola_Click(object sender, EventArgs e)
        {
            if (counterValueCola <= 0)
            {
                counterValueCola = 0;
            }
            else
            {
                counterValueCola -= 1;
            }
            labelValueCola.Text = counterValueCola.ToString();
            calculatecost();
        }

        private void buttonMinusJ_Click(object sender, EventArgs e)
        {
            if (counterValueJ <= 0)
            {
                counterValueJ = 0;
            }
            else
            {
                counterValueJ -= 1;
            }
            labelValueJ.Text = counterValueJ.ToString();
            calculatecost();
        }

        private void buttonMinusFr_Click(object sender, EventArgs e)
        {
            if (counterValueFr <= 0)
            {
                counterValueFr = 0;
            }
            else
            {
                counterValueFr -= 1;
            }
            labelValueFr.Text = counterValueFr.ToString();
            calculatecost();
        }

        private void buttonMinusCap_Click(object sender, EventArgs e)
        {
            if (counterValueCap <= 0)
            {
                counterValueCap = 0;
            }
            else
            {
                counterValueCap -= 1;
            }
            labelValueCap.Text = counterValueCap.ToString();
            calculatecost();
        }

        private void buttonPlusCola_Click(object sender, EventArgs e)
        {
            counterValueCola += 1;
            labelValueCola.Text = counterValueCola.ToString();
            calculatecost();
        }

        private void buttonPlusJ_Click(object sender, EventArgs e)
        {
            counterValueJ += 1;
            labelValueJ.Text = counterValueJ.ToString();
            calculatecost();
        }

        private void buttonPlusFr_Click(object sender, EventArgs e)
        {
            counterValueFr += 1;
            labelValueFr.Text = counterValueFr.ToString();
            calculatecost();
        }

        private void buttonPlusCap_Click(object sender, EventArgs e)
        {
            counterValueCap += 1;
            labelValueCap.Text = counterValueCap.ToString();
            calculatecost();
        }
    }
}
