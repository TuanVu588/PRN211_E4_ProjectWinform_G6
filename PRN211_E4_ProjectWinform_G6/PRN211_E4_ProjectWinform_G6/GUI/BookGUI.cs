using PRN211_E4_ProjectWinform_G6.Models;
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
    public partial class BookGUI : Form
    {
        BookStoreContext context;
        public BookGUI()
        {
            InitializeComponent();
            context = new BookStoreContext();
            

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();           
        }

        private void lbUser_Click(object sender, EventArgs e)
        {
            RegisterGUI usersGUI = new RegisterGUI();
            usersGUI.Show();
            this.Hide();
        }

        private void BookGUI_Activated(object sender, EventArgs e)
        {
            if(Settings.UserName != null && Settings.UserName != " ")
            {
                lbLogin.Text = $"Logout({Settings.UserName})";
            }
            else
            {
                lbLogin.Text = $"Login";
            }
            if (Settings.Role == 2||Settings.Role == 3 && Settings.UserName != null && Settings.UserName != " ")
            {
                pnDashBoard.Visible = false;
                

            }else if(Settings.Role == 1 && Settings.UserName != null && Settings.UserName != " ")
            {
                pnDashBoard.Visible = true;
                
            }
        }

        private void lbDashBoard_Click(object sender, EventArgs e)
        {
            DashboardGUI dashboardGUI = new DashboardGUI();
            dashboardGUI.TopLevel=false;
            dashboardGUI.FormBorderStyle = FormBorderStyle.None;
            dashboardGUI.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(dashboardGUI);

        }

        private void lbBooks_Click(object sender, EventArgs e)
        {
            ShopBookGUI shopBookGUI = new ShopBookGUI();
            shopBookGUI.TopLevel=false;
            shopBookGUI.FormBorderStyle = FormBorderStyle.None;
            shopBookGUI.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(shopBookGUI);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BillingGUI billingGUI = new BillingGUI();
            billingGUI.TopLevel=false;
            billingGUI.FormBorderStyle = FormBorderStyle.None;
            billingGUI.Show();
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(billingGUI);
        }
    }
}
