namespace Session3_Desktop
{
    partial class OrderList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            order = new DataGridViewLinkColumn();
            transactionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            channelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            storeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            promotionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(897, 72);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 2;
            button1.Text = "Add New Product";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order, transactionIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, paymentMethodDataGridViewTextBoxColumn, channelDataGridViewTextBoxColumn, storeIdDataGridViewTextBoxColumn, promotionIdDataGridViewTextBoxColumn, discountAmountDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Location = new Point(12, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1073, 372);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // order
            // 
            order.DataPropertyName = "TransactionId";
            order.HeaderText = "OrderDetail";
            order.MinimumWidth = 8;
            order.Name = "order";
            order.ReadOnly = true;
            order.Width = 150;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            transactionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            transactionIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            customerIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            paymentMethodDataGridViewTextBoxColumn.MinimumWidth = 8;
            paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            paymentMethodDataGridViewTextBoxColumn.Width = 150;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            channelDataGridViewTextBoxColumn.MinimumWidth = 8;
            channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            channelDataGridViewTextBoxColumn.ReadOnly = true;
            channelDataGridViewTextBoxColumn.Width = 150;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            storeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            storeIdDataGridViewTextBoxColumn.ReadOnly = true;
            storeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // promotionIdDataGridViewTextBoxColumn
            // 
            promotionIdDataGridViewTextBoxColumn.DataPropertyName = "PromotionId";
            promotionIdDataGridViewTextBoxColumn.HeaderText = "PromotionId";
            promotionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            promotionIdDataGridViewTextBoxColumn.Name = "promotionIdDataGridViewTextBoxColumn";
            promotionIdDataGridViewTextBoxColumn.ReadOnly = true;
            promotionIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.HeaderText = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            discountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            discountAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.ReadOnly = true;
            customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderItemsDataGridViewTextBoxColumn
            // 
            orderItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.HeaderText = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderItemsDataGridViewTextBoxColumn.Name = "orderItemsDataGridViewTextBoxColumn";
            orderItemsDataGridViewTextBoxColumn.ReadOnly = true;
            orderItemsDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(models.Order);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 4;
            label1.Text = "Search on ID/Customer Name/Date";
            // 
            // button2
            // 
            button2.Location = new Point(942, 524);
            button2.Name = "button2";
            button2.Size = new Size(143, 34);
            button2.TabIndex = 5;
            button2.Text = "Product List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // OrderList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 580);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "OrderList";
            Text = "Order Listing";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private BindingSource orderBindingSource;
        private Button button2;
        private TextBox textBox1;
        private DataGridViewLinkColumn order;
        private DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn promotionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
    }
}