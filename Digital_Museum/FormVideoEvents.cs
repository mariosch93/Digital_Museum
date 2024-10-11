using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Digital_Museum
{
    public partial class FormVideoEvents : Form
    {   LoginInfo loginInfo;
        bool sidebarExpand;
        bool buttonClicked = false;
        private int currentIndex = 0;

        String[] linkSRC = new string[]
        { "https://www.youtube.com/embed/fIPfPJWg3gA?si=lcLRm7VGTvIHGNTV",
          "https://www.youtube.com/embed/EmnjB5gayMU?si=pMaEe8zkCBQCCM6h",
          "https://www.youtube.com/embed/-1_tSgrWmpU?si=J-JElahD3W3Yhbbs",
          "https://www.youtube.com/embed/6b7vEhueyMk?si=QeAzr-KJP1PVq4xY",
          "https://www.youtube.com/embed/W3jPSQC-zE0?si=ZVOTELpwXMda4n0K"
        };
        String[] linkURL = new string[] 
        { "https://www.youtube.com/watch?v=fIPfPJWg3gA&list=PLx3jx6kZ_h4Fc-kjEV_MlOb2V9iefXj02&index=18",
          "https://www.youtube.com/watch?v=EmnjB5gayMU&list=PLx3jx6kZ_h4Fc-kjEV_MlOb2V9iefXj02&index=21",
          "https://www.youtube.com/watch?v=-1_tSgrWmpU&list=PLx3jx6kZ_h4Fc-kjEV_MlOb2V9iefXj02&index=24",
          "https://www.youtube.com/watch?v=6b7vEhueyMk&list=PLx3jx6kZ_h4Fc-kjEV_MlOb2V9iefXj02&index=26",
          "https://www.youtube.com/watch?v=W3jPSQC-zE0&list=PLx3jx6kZ_h4Fc-kjEV_MlOb2V9iefXj02&index=78"
        };

        public FormVideoEvents(LoginInfo logininfo)
        {
            InitializeComponent();
            this.loginInfo = logininfo;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
       protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadVideo(currentIndex);
        }
        private void LoadVideo(int index)
        {
            string selectedSrc = linkSRC[index]; /* + "&autoplay=1"; για autoplay αυτόματα! */
            string selectedUrl = linkURL[index];
            var embed = $@"
            <html>
                <head>
                    <meta http-equiv=""X-UA-Compatible"" content=""IE=Edge""/>
                </head>
                <body>
                    <iframe width=""680"" height=""240"" src=""{selectedSrc}""
                        frameborder=""0"" allow=""autoplay; encrypted-media"" allowfullscreen></iframe>
                </body>
            </html>";
            var url = $"{selectedUrl}";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex >= linkSRC.Length)
            {
                currentIndex = 0;
            }
            LoadVideo(currentIndex);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex <= 0)
            {
                currentIndex = 0;
            }
            LoadVideo(currentIndex);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false) {
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
                panelOnlineOrder.Visible=false;
                buttonClicked = false;
            } 
        }

        private void FormVideoEvents_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string helping = @"helper\help_musee.chm";
            Help.ShowHelp(this, helping, HelpNavigator.TopicId, "75");
        }
    }
}
