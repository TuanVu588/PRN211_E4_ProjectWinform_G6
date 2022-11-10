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
            cbCategory.DataSource = context.Categories.ToList();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "id";

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
            UsersGUI usersGUI = new UsersGUI();
            usersGUI.Show();
            this.Hide();
        }

        private void BookGUI_Activated(object sender, EventArgs e)
        {
            if(Settings.UserName != null && Settings.UserName != " ")
            {
                lbLogout.Text = $"Logout({Settings.UserName})";
            }
            else
            {
                lbLogin.Text = $"Login";
            }
            if (Settings.Role == 2||Settings.Role == 3 && Settings.UserName != null && Settings.UserName != " ")
            {
                pnDashBoard.Visible = false;
                pnUser.Visible = false;

            }else if(Settings.Role == 1 && Settings.UserName != null && Settings.UserName != " ")
            {
                pnDashBoard.Visible = true;
                pnUser.Visible = true;
            }
        }
    }
}
