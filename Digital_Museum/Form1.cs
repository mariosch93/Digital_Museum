using Digital_Museum.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Museum
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        LoginInfo loginInfo;
        bool buttonClicked = false;
        bool buttonDeveloped = false;

        bool calendarClicked = false;
        string connectionString = "Data source=digital_museum.db;Version=3;";
        SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
        }

        Dictionary<DateTime, string> CalendarDates = new Dictionary<DateTime, string>()
        {
            { new DateTime(2024, 11, 1), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 4), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 5), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 6), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 7), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 8), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 11), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 12), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 13), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 14), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 15), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 18), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 19), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 20), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 21), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 22), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 25), "Ωράριο Εργασίας: 15:00 - 23:00 "},
            { new DateTime(2024, 11, 26), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 11, 27), "Ωράριο Εργασίας: 9:00 - 17:00 "},
            { new DateTime(2024, 12, 25), "25 Δεκεμβρίου, Χριστούγεννα" },
        };

        public Form1(LoginInfo loginInfo)
        {
            InitializeComponent();
            this.loginInfo = loginInfo;
            if (loginInfo != null)
            {
                usernameLabel.Visible = true;
                usernameLabel.Text = "Καλωσήρθες " + loginInfo.UserName;
                buttonCalendar.Visible = true;
                monthCalendarWork.BoldedDates = CalendarDates.Keys.ToArray();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // MenuBar ---------------------------------------------------------------------------

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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
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

        private void buttonShows_Click(object sender, EventArgs e)
        {
            FormPrivateSpace formPrivateSpace = new FormPrivateSpace(loginInfo);
            formPrivateSpace.ShowDialog();
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


        // ------------------------------------------------------------------------------------------ 

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (calendarClicked == false)
            {
                monthCalendarWork.Visible = true;
                richTextBoxCalendar.Visible = true;
                calendarClicked = true;
            }
            else
            {
                monthCalendarWork.Visible = false;
                richTextBoxCalendar.Visible = false;
                calendarClicked = false;
            }
        }
        private void monthCalendarWork_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (CalendarDates.TryGetValue(e.Start, out var description))
            {
                richTextBoxCalendar.Text = description;
            }
            else
            {
                richTextBoxCalendar.Text = "";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string helping = @"./helper/help_musee.chm";
            Help.ShowHelp(this, helping);

        }

        private void buttonDevelopedby_Click(object sender, EventArgs e)
        {
            if (!buttonDeveloped) {
                buttonDeveloped = true;
                labelDevelopedBy.Visible = true;
                labelDevelopedBy.Text = "-Παναγου Παναγιώτης ΑΜ:mppl2321\n-Θωμαΐδης Ιωάννης ΑΜ:mppl:2308\n-Χαρίδης Μάριος-Χρήστος ΑΜ:mppl:2336\n";
            }
            else
            {
                buttonDeveloped = false;
                labelDevelopedBy.Visible = false;
            }
        }
    }
}
