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
    public partial class AddEdit : Form
    {
        Product product { get; set; }
        public event Action Save;
        public AddEdit(Product pro)
        {
            InitializeComponent();
            product = pro;
            _ = getdata();
        }

        public async Task getdata()
        {
            var list = await Helper.get<List<Product>>("products") ?? new();

            var cat = list.Select(x => x.Category).Distinct().ToList();
            cat.Insert(0, "Select Category");
            comboBox1.DataSource = cat;

            if (product != null)
            {
                comboBox1.SelectedItem = product.Category;
                textBox1.Text = product.ProductName;
                numericUpDown1.Value = product.Price;
                numericUpDown2.Value = product.Cost;
                dateTimePicker1.Value = product.IntroducedDate.ToDateTime(TimeOnly.MinValue);
                checkBox1.Checked = product.Active;
                checkBox2.Checked = product.Seasonal;
                textBox2.Text = product.Description;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                    MessageBox.Show("Please select category.", "Error");
                return;
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter product name.", "Error");
                return;
            }
            else if (numericUpDown2.Value > numericUpDown1.Value || numericUpDown1.Value == numericUpDown2.Value)
            {
                MessageBox.Show("Your cost is same or higher than price.", "Error");
                return;
            }

            if (product == null)
            {
                var data = new Product()
                {
                    Category = comboBox1.Text,
                    ProductName = textBox1.Text,
                    Price = numericUpDown1.Value,
                    Cost = numericUpDown2.Value,
                    IntroducedDate = DateOnly.FromDateTime(dateTimePicker1.Value),
                    Seasonal = checkBox2.Checked,
                    Active = checkBox1.Checked,
                    Description = textBox2.Text
                };

                var keep = await Helper.post<Product>("products", data) ?? new();
                MessageBox.Show("Product successfully added.", "Success", MessageBoxButtons.OK);
            }
            else
            {
                product.Category = comboBox1.Text;
                product.ProductName = textBox1.Text;
                product.Price = numericUpDown1.Value;
                product.Cost = numericUpDown2.Value;
                product.IntroducedDate = DateOnly.FromDateTime(dateTimePicker1.Value);
                product.Active = checkBox1.Checked;
                product.Seasonal = checkBox2.Checked;
                product.Description = textBox2.Text;

                var edit = await Helper.put<Product>($"products/{product.ProductId}", product) ?? new();
                MessageBox.Show("Product successfully updated.", "Success", MessageBoxButtons.OK);
            }
            Save?.Invoke();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to discard.", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
