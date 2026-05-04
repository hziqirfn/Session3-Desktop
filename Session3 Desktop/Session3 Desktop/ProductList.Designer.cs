namespace Session3_Desktop
{
    partial class ProductList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewLinkColumn();
            Delete = new DataGridViewLinkColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            seasonalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            activeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            introducedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customOrdersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(953, 65);
            button1.Name = "button1";
            button1.Size = new Size(188, 34);
            button1.TabIndex = 1;
            button1.Text = "Add New Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1001, 488);
            button2.Name = "button2";
            button2.Size = new Size(140, 34);
            button2.TabIndex = 3;
            button2.Text = "Order List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 4;
            label1.Text = "Search On Products/Categories";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete, productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, seasonalDataGridViewCheckBoxColumn, activeDataGridViewCheckBoxColumn, introducedDateDataGridViewTextBoxColumn, ingredientsDataGridViewTextBoxColumn, customOrdersDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(26, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1115, 340);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Edit
            // 
            Edit.DataPropertyName = "ProductId";
            Edit.HeaderText = "Action";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 150;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "ProductId";
            Delete.HeaderText = "";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 150;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.MinimumWidth = 8;
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.ReadOnly = true;
            costDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // seasonalDataGridViewCheckBoxColumn
            // 
            seasonalDataGridViewCheckBoxColumn.DataPropertyName = "Seasonal";
            seasonalDataGridViewCheckBoxColumn.HeaderText = "Seasonal";
            seasonalDataGridViewCheckBoxColumn.MinimumWidth = 8;
            seasonalDataGridViewCheckBoxColumn.Name = "seasonalDataGridViewCheckBoxColumn";
            seasonalDataGridViewCheckBoxColumn.ReadOnly = true;
            seasonalDataGridViewCheckBoxColumn.Width = 150;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            activeDataGridViewCheckBoxColumn.MinimumWidth = 8;
            activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            activeDataGridViewCheckBoxColumn.ReadOnly = true;
            activeDataGridViewCheckBoxColumn.Width = 150;
            // 
            // introducedDateDataGridViewTextBoxColumn
            // 
            introducedDateDataGridViewTextBoxColumn.DataPropertyName = "IntroducedDate";
            introducedDateDataGridViewTextBoxColumn.HeaderText = "IntroducedDate";
            introducedDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            introducedDateDataGridViewTextBoxColumn.Name = "introducedDateDataGridViewTextBoxColumn";
            introducedDateDataGridViewTextBoxColumn.ReadOnly = true;
            introducedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // ingredientsDataGridViewTextBoxColumn
            // 
            ingredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients";
            ingredientsDataGridViewTextBoxColumn.HeaderText = "Ingredients";
            ingredientsDataGridViewTextBoxColumn.MinimumWidth = 8;
            ingredientsDataGridViewTextBoxColumn.Name = "ingredientsDataGridViewTextBoxColumn";
            ingredientsDataGridViewTextBoxColumn.ReadOnly = true;
            ingredientsDataGridViewTextBoxColumn.Width = 150;
            // 
            // customOrdersDataGridViewTextBoxColumn
            // 
            customOrdersDataGridViewTextBoxColumn.DataPropertyName = "CustomOrders";
            customOrdersDataGridViewTextBoxColumn.HeaderText = "CustomOrders";
            customOrdersDataGridViewTextBoxColumn.MinimumWidth = 8;
            customOrdersDataGridViewTextBoxColumn.Name = "customOrdersDataGridViewTextBoxColumn";
            customOrdersDataGridViewTextBoxColumn.ReadOnly = true;
            customOrdersDataGridViewTextBoxColumn.Width = 150;
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(models.Product);
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 562);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "ProductList";
            Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private DataGridViewLinkColumn Edit;
        private DataGridViewLinkColumn Delete;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn seasonalDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn introducedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customOrdersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
    }
}
