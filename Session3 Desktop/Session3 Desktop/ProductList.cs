using Microsoft.EntityFrameworkCore;
using Session3_Desktop.models;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session3_Desktop
{
    public partial class ProductList : Form
    {
        public static List<Product> list = new List<Product>();
        public ProductList()
        {
            InitializeComponent();
            _ = getdata();
        }

        public async Task getdata()
        {
            list = await Helper.get<List<Product>>("products") ?? new();
            loadtable();
        }

        public void loadtable()
        {
            var key = textBox1.Text.ToLower().Trim();
            var temp = list.Where(x =>
                x.ProductName.ToLower().Contains(key) ||
                x.Category.ToLower().Contains(key)).ToList();
            dataGridView1.DataSource = temp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadtable();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

                this.Hide();
                new AddEdit(item).ShowDialog();
                this.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

                if (MessageBox.Show("Are you confirm to delete this item?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var req = await Helper.client.DeleteAsync($"products/{item.ProductId}");
                    MessageBox.Show(req.IsSuccessStatusCode ? "Success" : "Failed.This product exists in other orders.");
                    await getdata();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderList ordList = new OrderList();
            ordList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var add = new AddEdit(null);
            add.Save += async () =>
            {
                await getdata();
            };
            add.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = "Edit";
            }
            else if (e.ColumnIndex == 1)
            {
                e.Value = "Delete";
            }
        }
        
        bool isAscending = true;

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            isAscending = !isAscending;
            if (isAscending)
            {
                list = list.OrderBy(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
            }
            else
            {
                list = list.OrderByDescending(x => x.GetType().GetProperty(column).GetValue(x)).ToList();
            }
            loadtable();

        }
    }
}
