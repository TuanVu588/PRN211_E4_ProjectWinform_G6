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
    public partial class RegisterGUI : Form
    {
        BookStoreContext context;
        public RegisterGUI()
        {
            InitializeComponent();
            context = new BookStoreContext();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUsername != null && tbPassword != null)
            {
                if (tbPassword.Text.Equals(tbRePassword.Text))
                {
                    User user = new User
                    {
                        UserName = tbUsername.Text,
                        Password = tbPassword.Text,
                        Role = 2
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Register sucessfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password and re-password must be equals");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blank field");
            }

        }
    }
}
