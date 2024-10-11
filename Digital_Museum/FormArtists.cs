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
    public partial class FormArtists : Form
     
    {
        ToolTip t1 = new ToolTip();
        bool sidebarExpand;
        LoginInfo loginInfo;

        public FormArtists()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonKazatzidis_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ο Στέλιος Καζαντζίδης (1931-2001) υπήρξε ένας από τους σημαντικότερους Έλληνες λαϊκούς τραγουδιστές.", buttonKazatzidis);
        }
        private void buttonMpithikotsis_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ο Γρηγόρης Μπιθικώτσης (1922-2005) ένας από τους κορυφαίους Έλληνες τραγουδιστές και συνθέτες.Γνωστός ως \"ο Σερ,\" του ελληνικού τραγουδιού", buttonMpithikotsis);
        }

        private void buttonTheodorakis_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ο Μίκης Θεοδωράκης (1925-2021) ήταν ένας από τους μεγαλύτερους Έλληνες συνθέτες και παγκόσμια αναγνωρισμένη προσωπικότητα της μουσικής ", buttonTheodorakis);
        }
        private void richTextBoxInfo_MouseHover(object sender, EventArgs e)
        {
            richTextBoxInfo.BackColor = Color.LightBlue;
        }

        private void richTextBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxInfo.BackColor = Color.White;
        }

        private void buttonKazatzidis_Click(object sender, EventArgs e)
        {
            FormKazatzidis formKazatzidis = new FormKazatzidis();
            formKazatzidis.ShowDialog();
        }

        private void buttonMpithikotsis_Click(object sender, EventArgs e)
        {
            FormMpithikotsis formMpithikotsis=new FormMpithikotsis();
            formMpithikotsis.ShowDialog();
        }

        private void buttonTheodorakis_Click(object sender, EventArgs e)
        {
            FormTheodorakis formTheodorakis=new FormTheodorakis();  
            formTheodorakis.ShowDialog();
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
            Help.ShowHelp(this, helping, HelpNavigator.TopicId, "30");
        }
    }
    
}
