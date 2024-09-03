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

        private void richTextBoxInfo_MouseHover(object sender, EventArgs e)
        {
            richTextBoxInfo.BackColor = Color.LightBlue;
        }

        private void richTextBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            richTextBoxInfo.BackColor = Color.White;
        }

        private void buttonMpithikotsis_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ο Γρηγόρης Μπιθικώτσης (1922-2005) ένας από τους κορυφαίους Έλληνες τραγουδιστές και συνθέτες.Γνωστός ως \"ο Σερ,\" του ελληνικού τραγουδιού", buttonMpithikotsis);
        }

        private void buttonTheodorakis_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Ο Μίκης Θεοδωράκης (1925-2021) ήταν ένας από τους μεγαλύτερους Έλληνες συνθέτες και παγκόσμια αναγνωρισμένη προσωπικότητα της μουσικής ", buttonTheodorakis);
        }
    }
    
}
