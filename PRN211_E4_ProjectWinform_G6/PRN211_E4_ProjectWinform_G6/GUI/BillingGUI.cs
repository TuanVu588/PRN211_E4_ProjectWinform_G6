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
    public partial class BillingGUI : Form
    {
        ShoppingCart cart;
        BookStoreContext context;
        public BillingGUI()
        {
            InitializeComponent();
            context = new BookStoreContext();
            usernamelb.Text = Settings.UserName;
            bindGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckOutGUI checkOutGUI = new CheckOutGUI();
            DialogResult dr = checkOutGUI.ShowDialog();
            if(dr == DialogResult.OK)
            {
                cart.EmptyCart();
                bindGrid();
            }

        }
        void bindGrid()
        {
            cart = ShoppingCart.GetCart();
            tbTotal.Text = cart.GetTotal().ToString();
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = cart.GetCartItems().ToList();
            dataGridView3.Columns["CartId"].Visible = false;
            dataGridView3.Columns["id"].Visible = false;
            dataGridView3.Columns["Product"].Visible = false;
            if (dataGridView3.Rows.Count > 0 && Settings.UserName != null)
            {
                btnCheckOut.Enabled = true;
            }
            else if (dataGridView3.Rows.Count == 0)
            {
                btnCheckOut.Enabled = false;
            }
            int count = dataGridView3.Columns.Count;
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn
            {
                Text = "Add to cart",
                Name = "Add",
                UseColumnTextForButtonValue = true,
            };
            dataGridView3.Columns.Insert(0, btnAdd);

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn
            {
                Text = "Remove from cart",
                Name = "Remove",
                UseColumnTextForButtonValue = true,
            };
            dataGridView3.Columns.Insert(count + 1, btnRemove);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView3.Columns["Add"].Index)
            {
                int productId = (int)dataGridView3.Rows[e.RowIndex].Cells["ProductId"].Value;
                Product product = context.Products.Find(productId);
                cart.AddToCart(product);
                bindGrid();
            }
            else if (e.ColumnIndex == dataGridView3.Columns["Remove"].Index)
            {
                int recordId = (int)dataGridView3.Rows[e.RowIndex].Cells["id"].Value;
                cart.RemoveFromCart(recordId);
                bindGrid();
            }
        }
    }
}
