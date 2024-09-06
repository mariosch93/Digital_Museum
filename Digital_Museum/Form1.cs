using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        string connectionString = "Data source=digital_museum.db;Version=3;";
        SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
        }

        public Form1(LoginInfo loginInfo)
        {
            InitializeComponent();
            this.loginInfo = loginInfo;
            if (loginInfo != null)
            {
                usernameLabel.Visible = true;
                usernameLabel.Text = "Καλωσήρθες " + loginInfo.UserName;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = username.Text;
            var pass = password.Text;

            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT id FROM users WHERE username = @username AND password = @password", connection);
            command.Parameters.AddWithValue("username", user);
            command.Parameters.AddWithValue("password", pass);
            var reader = command.ExecuteReader();

            if (reader.Read()){
                var loginInfo = new LoginInfo()
                {
                    UserName = user,
                    IsLoggedIn = true,
                    UserId = reader.GetInt32(0),
                };
                command.Dispose();
                reader.Close();
                connection.Close();

                var form1 = new Form1(loginInfo);
                form1.ShowDialog();
            }
            else {
                labelerror.Text = "Ανεπιτυχής σύνδεση, Ελέγξτε τα στοιχεία σας";
                command.Dispose();
                reader.Close();
                connection.Close();
            }   
        }

        private void buttonArtists_Click(object sender, EventArgs e)
        {
            FormArtists formArtists = new FormArtists();
            formArtists.ShowDialog();
        }

        private void buttonConcert_Click(object sender, EventArgs e)
        {
            FormConcert formConcert = new FormConcert();
            formConcert.ShowDialog();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            FormVideoEvents formVideoEvents = new FormVideoEvents(loginInfo);
            formVideoEvents.ShowDialog();
        }
    }
}
