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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRN211_E4_ProjectWinform_G6.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            BookStoreContext context = new BookStoreContext();
            if(username != String.Empty && password != String.Empty)
            {
                IQueryable<User> admins = context.Users.Where(a => a.Role == 1);
                IQueryable<User> users = context.Users.Where(a => a.Role == 2);
                foreach (User user in admins)
                {
                    if (username.Equals(user.UserName) && password.Equals(user.Password))
                    {
                        Settings.UserName = user.UserName;
                        Settings.Role = user.Role;
                        this.Close();
                        isUser = true;
                    }

                }
                foreach (User user in users)
                {
                    if (username.Equals(user.UserName) && password.Equals(user.Password))
                    {
                        Settings.UserName = user.UserName;
                        Settings.Role = user.Role;
                        this.Close();
                        isUser = true;
                    }
                }
                if (isUser == false)
                {
                    MessageBox.Show("That member does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Please fill into blank!");
            }
        }
        }
    }

