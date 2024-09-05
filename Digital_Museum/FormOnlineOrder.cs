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
    public partial class FormOnlineOrder : Form
    {
        int totalCost;
        int[] foods = { 0, 1, 2, 3, 4 };
        int[] drinks = { 0, 1, 2, 3, 4 };


        public FormOnlineOrder()
        {
            InitializeComponent();
        }
    }
}
