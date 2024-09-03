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
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        LoginInfo loginInfo;


        public Form1()
        {
            InitializeComponent();
        }

        public Form1(LoginInfo loginInfo)
        {
            InitializeComponent();
            this.loginInfo = loginInfo;
            if (loginInfo != null)
            {
                usernameLabel.Visible = true;
                usernameLabel.Text = "Καλώσήρθες " + loginInfo.UserName;
            }
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor= Color.LightBlue;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.White;
        }

        private void buttonNewLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonNewLogin.BackColor= Color.LightBlue;
        }

        private void buttonNewLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonNewLogin.BackColor = Color.White;
        }

        private void buttonNewLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible= true;
        }

        private void buttonCancelLogin_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
        }

        private void buttonCancelLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonCancelLogin.BackColor= Color.Red;
        }

        private void buttonCancelLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonCancelLogin.BackColor = Color.White;
        }
    }
}
