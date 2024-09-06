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
        bool lightsClicked = true;
        bool panelControlsCl = false;
        int airconditioning = 29;
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
                pictureBoxSettings.Visible = true;

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
                panelConsole.BackColor = Color.White;
                panelConsole.Visible = true;
                panelConsole.Controls.Add(console);
                console.BringToFront();
                console.Show();
                consoleClicked = true;
                panelControls.Visible = false;
                labelConsole.Visible= false;
            }
            else { 
                panelConsole.Visible = false;
                consoleClicked = false;
                labelConsole.Visible = true;
            }
        }
        private void buttonLights_Click(object sender, EventArgs e)
        {
            if (lightsClicked == true)
            {
                lightsClicked = false;
                if (comboBoxHello.SelectedIndex == 1) { this.BackgroundImage = Properties.Resources.FormPrivateBG2night; }
                if (comboBoxHello.SelectedIndex == 0) { this.BackgroundImage = Properties.Resources.FormPrivateBGnight; }
                labelLights.Text = "Τα φώτα είναι:\nΣβηστά";

            }
            else
            {
                lightsClicked = true;
                if (comboBoxHello.SelectedIndex == 1) { this.BackgroundImage = Properties.Resources.FormPrivateBG2; }
                if (comboBoxHello.SelectedIndex == 0) { this.BackgroundImage = Properties.Resources.FormPrivateBG; }
                labelLights.Text = "Τα φώτα είναι:\nΑνοιχτά";
            }
            //richTextBoxStatus
        }

        private void buttonTherm_Click(object sender, EventArgs e)
        {
            labelTherm.Text = $"Η θερμοκρασία\nέχει ρυθμιστεί\nστους: {airconditioning}°C";
            buttonMinusTherm.Visible = true;
            buttonPlusTherm.Visible = true;
        }

        private void buttonMinusTherm_Click(object sender, EventArgs e)
        {
            airconditioning -= 1;
            labelTherm.Text = $"Η θερμοκρασία\nέχει ρυθμιστεί\nστους: {airconditioning}°C";
        }

        private void buttonPlusTherm_Click(object sender, EventArgs e)
        {
            airconditioning += 1;
            labelTherm.Text = $"Η θερμοκρασία\nέχει ρυθμιστεί\nστους: {airconditioning}°C";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            if (panelControlsCl == false) 
            {  
                panelControls.Visible = true; 
                panelControlsCl = true;
            }
            else 
            {
                panelControls.Visible = false; 
                panelControlsCl = false;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (saveFileDialogPlaylist.ShowDialog() == DialogResult.OK)
            {
                richTextBoxPlaylist.SaveFile(saveFileDialogPlaylist.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Αποθήκευση λίστας επιτυχώς");
            }
        }
    }
}
