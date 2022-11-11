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
    public partial class CRUDBookGUI : Form
    {
        public CRUDBookGUI()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dataGridView1.Rows.Clear();
            using (var context = new BookStoreContext())
            {
                List<Product> list = context.Products.ToList();

                foreach (var item in list)
                {
                    Category c = context.Categories.Where(x => x.Id == item.Cid).FirstOrDefault();
                    dataGridView1.Rows.Add(item.Id, c.Name, item.Title, item.Price, item.ProductUrl, item.Author);
                }
                List<Category> categories = context.Categories.ToList();
                var group = categories.GroupBy(x => x.Name);
                cbCategory.DisplayMember = "Key";
                cbCategory.ValueMember = "Key";
                cbCategory.DataSource = group.ToList();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookID.Text = dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
            tbTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
            tbImage.Text = dataGridView1.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
            numericUpDown1.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
            string category = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            cbCategory.SelectedIndex = cbCategory.FindString(category);
            tbAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
        }

        BookStoreContext context = new BookStoreContext();
        int id ;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            try
            {
                int cid = context.Categories.Where(x => x.Name == cbCategory.Text).Select(x => x.Id).FirstOrDefault();
                string title = tbTitle.Text;
                decimal price = decimal.Parse(numericUpDown1.Value.ToString());
                string image = tbImage.Text;
                string author = tbAuthor.Text;


                p.Cid = cid;
                p.Title = title;
                p.Price = price;
                p.ProductUrl = image;
                p.Author = author;
                context.Products.Add(p);
                context.SaveChanges();
                MessageBox.Show("Add successfull!!!!");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            openFileDialog1.InitialDirectory = path + "\\Images";
            openFileDialog1.ShowDialog();
            tbImage.Text = "/Images/" + openFileDialog1.SafeFileName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            try
            {
                int id = Int32.Parse(tbBookID.Text);
                Product p = context.Products.Find(id);
                p.Cid = context.Categories.Where(x => x.Name == cbCategory.Text).Select(x => x.Id).FirstOrDefault(); 
                p.Title = tbTitle.Text;
                p.Price = numericUpDown1.Value;
                p.ProductUrl = tbImage.Text;
                p.Author = tbAuthor.Text;
                context.Products.Update(p);
                context.SaveChanges();
                MessageBox.Show("Update successfull!!!!");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(tbBookID.Text);
                Product p = context.Products.Find(id);               
                context.Products.Remove(p);
                context.SaveChanges();
                MessageBox.Show("Remove successfull!!!!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);

            }
        }
    }
}
