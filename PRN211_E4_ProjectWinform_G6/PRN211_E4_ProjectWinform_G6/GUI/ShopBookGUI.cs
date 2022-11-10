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
    public partial class ShopBookGUI : Form
    {
        PageList<Product> pagelist;
        BookStoreContext context;
        Cart cart;
        public ShopBookGUI()
        {
            InitializeComponent();
            context = new BookStoreContext();
            cart = new Cart();
            cbCategory.DataSource = context.Categories.ToList();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "id";
            bindPanel(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
        void bindPanel(int pageIndex)
        {
            IQueryable<Product> pros = context.Products.Where(t => t.CidNavigation.Name.Contains(cbCategory.Text));

            pagelist = PageList<Product>.Create(pros, pageIndex, 3);
            btnPrevious.Enabled = pagelist.HasPreviousPage;
            btnNext.Enabled = pagelist.HasNextPage;

            panel1.Controls.Clear();
            int height = panel1.Height;
            int width = (panel1.Width - 50) / 3;
            int i = 0;
            foreach (Product pro in pagelist)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = pro.Title;
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image.FromFile(Directory.GetParent(s)
                        .Parent.Parent.FullName + "/Images/" + pro.ProductUrl);

                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(150, 100);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(60, 80);
                groupBox.Controls.Add(pictureBox);

                Label lblPrice = new Label();
                lblPrice.AutoSize = true;
                lblPrice.Text = $"${pro.Price.ToString()}";
                lblPrice.Location = new Point(100, 230);
                groupBox.Controls.Add(lblPrice);

                Label lblUuthor = new Label();
                lblUuthor.AutoSize = true;
                lblUuthor.Text = $"Author:{pro.Author.ToString()}";
                lblUuthor.Location = new Point(90, 280);
                groupBox.Controls.Add(lblUuthor);

                Button btnAdd = new Button();
                btnAdd.Name = $"btn{pro.Id}";
                btnAdd.Text = "Add to cart";
                btnAdd.BackColor = Color.Blue;
                btnAdd.ForeColor = Color.White;
                btnAdd.AutoSize = true;
                btnAdd.Location = new Point(80, 300);
                groupBox.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;

                i++;
                panel1.Controls.Add(groupBox);
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            int proid = int.Parse(((Button)sender).Name.Substring(3));
            MessageBox.Show("Add to cart successfully!");
            Product album = context.Products.Find(proid);
            ShoppingCart shoppingCart = ShoppingCart.GetCart();
            shoppingCart.AddToCart(album);
        }

        public void bindPanelSearch(int pageIndex)
        {
            IQueryable<Product> pros = context.Products.Where(r => r.Title
            .Contains(tbTitle.Text.Trim()));

            pagelist = PageList<Product>.Create(pros, pageIndex, 3);
            btnPrevious.Enabled = pagelist.HasPreviousPage;
            btnNext.Enabled = pagelist.HasNextPage;

            panel1.Controls.Clear();
            int height = panel1.Height;
            int width = (panel1.Width - 50) / 3;
            int i = 0;
            foreach (Product pro in pagelist)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = pro.Title;
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BorderStyle = BorderStyle.None;
                string s = Directory.GetCurrentDirectory();
                try
                {
                    pictureBox.Image = Image
                        .FromFile(Directory.GetParent(s).Parent.Parent.FullName + "/Images/" + pro.ProductUrl);
                }
                catch
                {
                    pictureBox.Image = null;
                }
                pictureBox.Size = new Size(50, 30);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(40, 20);
                groupBox.Controls.Add(pictureBox);

                Label lblPrice = new Label();
                lblPrice.AutoSize = true;
                lblPrice.Text = $"${pro.Price.ToString()}";
                lblPrice.Location = new Point(100, 110);
                groupBox.Controls.Add(lblPrice);

                Label lblArtis = new Label();
                lblArtis.AutoSize = true;
                lblArtis.Text = $"Author:{pro.Author.ToString()}";
                lblArtis.Location = new Point(100, 130);
                groupBox.Controls.Add(lblArtis);

                Button btnAdd = new Button();
                btnAdd.Name = $"btn{pro.Author}";
                btnAdd.Text = "Add to cart";
                btnAdd.BackColor = Color.Blue;
                btnAdd.ForeColor = Color.White;
                btnAdd.AutoSize = true;
                btnAdd.Location = new Point(80, 150);
                groupBox.Controls.Add(btnAdd);
                btnAdd.Click += BtnAdd_Click;
                i++;
                panel1.Controls.Add(groupBox);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindPanel(pagelist.PageIndex - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindPanel(pagelist.PageIndex + 1);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindPanelSearch(1);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPanel(1);
        }
    }
}
