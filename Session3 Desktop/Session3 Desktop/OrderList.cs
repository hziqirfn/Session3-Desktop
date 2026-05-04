using Session3_Desktop.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session3_Desktop
{
    public partial class OrderList : Form
    {
        public static List<Order> list = new List<Order>();
        public OrderList()
        {
            InitializeComponent();
            _ = getdata();
        }

        public async Task getdata()
        {
            list = await Helper.get<List<Order>>("OrdersCus") ?? new();
            loadtable();
        }

        public void loadtable()
        {
            var key = textBox1.Text.ToLower().Trim();
            var content = list.Where(x =>
                x.TransactionId.ToString().Contains(key) ||
                x.CustomerName.ToLower().Contains(key) ||
                x.OrderDate.ToString().Contains(key)).ToList();
            dataGridView1.DataSource = content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductList pro = new ProductList();
            pro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadtable();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = "Detail View";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Order;

                this.Hide();
                var add = new OrderDetail(item);
                add.save += async () =>
                {
                    await getdata();
                };
                add.ShowDialog();
                this.Show();
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
