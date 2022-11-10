using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_E4_ProjectWinform_G6.GUI
{
    public partial class BillingGUI : Form
    {
        public BillingGUI()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckOutGUI checkOutGUI = new CheckOutGUI();                     
            checkOutGUI.Show();           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
