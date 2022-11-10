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
    public partial class DashboardGUI : Form
    {
        BookStoreContext context;
        public DashboardGUI()
        {
            InitializeComponent();
            context = new BookStoreContext();
            var bookStockCount = context.Products.Count();
            bookStock.Text = bookStockCount.ToString();
            var moneyTotalStock = context.Orders.Select(a => a.Total).ToList();
            decimal countMoney = 0;
            foreach (var money in moneyTotalStock)
            {
                countMoney += money;
            }
            MoneyTotalStock.Text = "$"+countMoney.ToString();
            var userCount = context.Users.Count();
            UserTotalStock.Text = userCount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
