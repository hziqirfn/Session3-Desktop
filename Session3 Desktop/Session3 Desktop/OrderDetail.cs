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
    public partial class OrderDetail : Form
    {
        public event Action save;
        Order order { get; set; }
        public OrderDetail(Order ord)
        {
            InitializeComponent();
            order = ord;
            _ = getdata();
        }

        public async Task getdata()
        {
            var list = await Helper.get<List<OrderItem>>($"orderItem/{order.TransactionId}") ?? new();
            dataGridView1.DataSource = list;

            comboBox1.DataSource = new List<string>
            {
                "Pending",
                "Processing",
                "Completed",
                "Cancelled"
            };

            label7.Text = order.TransactionId.ToString();
            label8.Text = order.CustomerName;
            dateTimePicker1.Value = order.OrderDate;
            label9.Text = order.TotalAmount.ToString();
            comboBox1.Text = order.Status;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to discard.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Order()
            {
                Status = comboBox1.Text
            };

            if (comboBox1.Text == "Processing")
            {
                var stat = await Helper.put<Order>($"orders/{order.TransactionId}/process", data) ?? new();
            }
            else if (comboBox1.Text == "Completed")
            {
                var stat = await Helper.put<Order>($"orders/{order.TransactionId}/complete", data) ?? new();
            }
            else if (comboBox1.Text == "Cancelled")
            {
                var stat = await Helper.put<Order>($"orders/{order.TransactionId}/cancel", data) ?? new();
            }
            else
            {
                var stat = await Helper.put<Order>($"orders/{order.TransactionId}/pend", data) ?? new();
            }
            MessageBox.Show("Successfully updated.", "Success");
            save?.Invoke();
            this.Close();
            _ = getdata();
        }
    }
}

