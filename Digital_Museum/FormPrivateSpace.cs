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
    public partial class FormPrivateSpace : Form
    {
        LoginInfo loginInfo;
        bool buttonClicked = false;
        bool consoleClicked = false;
        public FormPrivateSpace(LoginInfo loginInfo)
        {
            InitializeComponent();
            this.loginInfo = loginInfo;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBoxHello_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHello.SelectedIndex == 0) { this.BackgroundImage = Properties.Resources.FormPrivateBG; }
            if (comboBoxHello.SelectedIndex == 1) { this.BackgroundImage = Properties.Resources.FormPrivateBG2; }
            buttonRent.Enabled = true;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (comboBoxHello.SelectedIndex != -1)
            {
                MessageBox.Show("Η ενοικίαση σας ολοκληρώθηκε!\n\nΑπολαύστε με τη παρέα σας μια υπέροχη βραδιά!");
                panelHello.Visible = false;
                buttonOrder.Visible = true;
                labelConsole.Visible = true;
                pictureBoxConsole.Visible = true;



            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                FormOnlineOrder onlineOrder = new FormOnlineOrder(loginInfo);
                onlineOrder.TopLevel = false;
                panelOnlineOrder.Visible = true;
                panelOnlineOrder.Controls.Add(onlineOrder);
                onlineOrder.BringToFront();
                onlineOrder.Show();
                buttonClicked = true;
            }
            else
            {
                panelOnlineOrder.Visible = false;
                buttonClicked = false;
            }
        }

        private void pictureBoxConsole_Click(object sender, EventArgs e)
        {
            if (consoleClicked == false)
            {
                FormConsole console = new FormConsole(loginInfo);
                console.TopLevel = false;
                panelConsole.Visible = true;
                panelConsole.Controls.Add(console);
                console.BringToFront();
                console.Show();
                consoleClicked = true;
            }
            else { 
                panelConsole.Visible = false;
                consoleClicked = false;
            }
        }
    }
}
