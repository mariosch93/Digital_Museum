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
        int costA11;

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
            totalCost = costA10 + costA11;
            richTextBoxTotal.Text = $"Το τελικό σας ποσό είναι: {totalCost} ";
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
    }
}
