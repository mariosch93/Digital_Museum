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
    public partial class FormConcert : Form
    {
        int totalCost;
        int costA10 = 0;
        int costA11 = 0;
        int costL6 = 0;
        int costL7 = 0;
        int costL8 = 0;

        public FormConcert()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSeatA10_MouseEnter(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "Θέση A10 Κόστος: 25€";
        }

        private void buttonSeatA10_MouseLeave(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "";
        }

        private void buttonSeatA11_MouseEnter(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "Θέση A11 Κόστος: 25€";
        }

        private void buttonSeatA11_MouseLeave(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "";
        }

        private void buttonSeatL6_MouseEnter(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "Θέση L6 Κόστος: 15€";
        }

        private void buttonSeatL6_MouseLeave(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "";
        }

        private void buttonSeatL7_MouseEnter(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "Θέση L7 Κόστος: 15€";
        }

        private void buttonSeatL7_MouseLeave(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "";
        }

        private void buttonSeatL8_MouseEnter(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "Θέση L8 Κόστος: 15€";
        }

        private void buttonSeatL8_MouseLeave(object sender, EventArgs e)
        {
            textBoxSeatInfo.Text = "";
        }

        void calculateCost()
        {
            totalCost = costA10 + costA11 + costL6 + costL7 + costL8;
            richTextBoxTotal.Text = $"Το τελικό ποσό πληρωμής είναι: {totalCost}€ ";
        }

        private void buttonSeatA10_MouseClick(object sender, MouseEventArgs e)
        {
            if (costA10 == 0)
            {
                buttonSeatA10.BackColor = Color.Green;
                costA10 = 25;
            }
            else
            {
                buttonSeatA10.BackColor = Color.White;
                costA10 = 0;
            }
            calculateCost();
        }

        private void buttonSeatA11_Click(object sender, EventArgs e)
        {
            if (costA11 == 0)
            {

                buttonSeatA11.BackColor = Color.Green;
                costA11 = 25;
            }
            else
            {
                buttonSeatA11.BackColor = Color.White;
                costA11 = 0;
            }
            calculateCost();
        }

        private void buttonSeatL6_Click(object sender, EventArgs e)
        {
            if (costL6 == 0)
            {

                buttonSeatL6.BackColor = Color.Green;
                costL6 = 15;
            }
            else
            {
                buttonSeatL6.BackColor = Color.White;
                costL6 = 0;
            }
            calculateCost();
        }

        private void buttonSeatL7_Click(object sender, EventArgs e)
        {
            if (costL7 == 0)
            {

                buttonSeatL7.BackColor = Color.Green;
                costL7 = 15;
            }
            else
            {
                buttonSeatL7.BackColor = Color.White;
                costL7 = 0;
            }
            calculateCost();
        }

        private void buttonSeatL8_Click(object sender, EventArgs e)
        {
            if (costL8 == 0)
            {

                buttonSeatL8.BackColor = Color.Green;
                costL8 = 15;
            }
            else
            {
                buttonSeatL8.BackColor = Color.White;
                costL8 = 0;
            }
            calculateCost();
        }

        private void buttonBuyTickets_MouseEnter(object sender, EventArgs e)
        {
            buttonBuyTickets.BackColor = Color.LightBlue;
        }

        private void buttonBuyTickets_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyTickets.BackColor = Color.White;
        }
    }
}
