namespace FastShop_IMS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_DescriptionLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label tax_CodeLabel;
            System.Windows.Forms.Label in_StockLabel;
            System.Windows.Forms.Label on_OrderLabel;
            System.Windows.Forms.Label last_Order_DateLabel;
            System.Windows.Forms.Label last_Order_QuantityLabel;
            System.Windows.Forms.Label purchase_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fastShopDBDataSet = new FastShop_IMS.FastShopDBDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new FastShop_IMS.FastShopDBDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new FastShop_IMS.FastShopDBDataSetTableAdapters.TableAdapterManager();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tax_CodeTextBox = new System.Windows.Forms.TextBox();
            this.in_StockTextBox = new System.Windows.Forms.TextBox();
            this.on_OrderTextBox = new System.Windows.Forms.TextBox();
            this.last_Order_DateTextBox = new System.Windows.Forms.TextBox();
            this.last_Order_QuantityTextBox = new System.Windows.Forms.TextBox();
            this.purchase_PriceTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOrderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            product_IDLabel = new System.Windows.Forms.Label();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            tax_CodeLabel = new System.Windows.Forms.Label();
            in_StockLabel = new System.Windows.Forms.Label();
            on_OrderLabel = new System.Windows.Forms.Label();
            last_Order_DateLabel = new System.Windows.Forms.Label();
            last_Order_QuantityLabel = new System.Windows.Forms.Label();
            purchase_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fastShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(18, 52);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(78, 17);
            product_IDLabel.TabIndex = 0;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(18, 80);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(136, 17);
            product_DescriptionLabel.TabIndex = 2;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(365, 49);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 4;
            categoryLabel.Text = "Category:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(365, 77);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            // 
            // tax_CodeLabel
            // 
            tax_CodeLabel.AutoSize = true;
            tax_CodeLabel.Location = new System.Drawing.Point(365, 105);
            tax_CodeLabel.Name = "tax_CodeLabel";
            tax_CodeLabel.Size = new System.Drawing.Size(72, 17);
            tax_CodeLabel.TabIndex = 8;
            tax_CodeLabel.Text = "Tax Code:";
            // 
            // in_StockLabel
            // 
            in_StockLabel.AutoSize = true;
            in_StockLabel.Location = new System.Drawing.Point(721, 49);
            in_StockLabel.Name = "in_StockLabel";
            in_StockLabel.Size = new System.Drawing.Size(62, 17);
            in_StockLabel.TabIndex = 10;
            in_StockLabel.Text = "In Stock:";
            // 
            // on_OrderLabel
            // 
            on_OrderLabel.AutoSize = true;
            on_OrderLabel.Location = new System.Drawing.Point(721, 77);
            on_OrderLabel.Name = "on_OrderLabel";
            on_OrderLabel.Size = new System.Drawing.Size(72, 17);
            on_OrderLabel.TabIndex = 12;
            on_OrderLabel.Text = "On Order:";
            // 
            // last_Order_DateLabel
            // 
            last_Order_DateLabel.AutoSize = true;
            last_Order_DateLabel.Location = new System.Drawing.Point(721, 105);
            last_Order_DateLabel.Name = "last_Order_DateLabel";
            last_Order_DateLabel.Size = new System.Drawing.Size(114, 17);
            last_Order_DateLabel.TabIndex = 14;
            last_Order_DateLabel.Text = "Last Order Date:";
            // 
            // last_Order_QuantityLabel
            // 
            last_Order_QuantityLabel.AutoSize = true;
            last_Order_QuantityLabel.Location = new System.Drawing.Point(721, 133);
            last_Order_QuantityLabel.Name = "last_Order_QuantityLabel";
            last_Order_QuantityLabel.Size = new System.Drawing.Size(137, 17);
            last_Order_QuantityLabel.TabIndex = 16;
            last_Order_QuantityLabel.Text = "Last Order Quantity:";
            // 
            // purchase_PriceLabel
            // 
            purchase_PriceLabel.AutoSize = true;
            purchase_PriceLabel.Location = new System.Drawing.Point(721, 161);
            purchase_PriceLabel.Name = "purchase_PriceLabel";
            purchase_PriceLabel.Size = new System.Drawing.Size(108, 17);
            purchase_PriceLabel.TabIndex = 18;
            purchase_PriceLabel.Text = "Purchase Price:";
            // 
            // fastShopDBDataSet
            // 
            this.fastShopDBDataSet.DataSetName = "FastShopDBDataSet";
            this.fastShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.fastShopDBDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = FastShop_IMS.FastShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Product ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(161, 49);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.product_IDTextBox.TabIndex = 1;
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Product Description", true));
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(161, 77);
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(133, 22);
            this.product_DescriptionTextBox.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(508, 46);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(135, 22);
            this.categoryTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(508, 74);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 7;
            // 
            // tax_CodeTextBox
            // 
            this.tax_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Tax Code", true));
            this.tax_CodeTextBox.Location = new System.Drawing.Point(508, 102);
            this.tax_CodeTextBox.Name = "tax_CodeTextBox";
            this.tax_CodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.tax_CodeTextBox.TabIndex = 9;
            // 
            // in_StockTextBox
            // 
            this.in_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "In Stock", true));
            this.in_StockTextBox.Location = new System.Drawing.Point(864, 46);
            this.in_StockTextBox.Name = "in_StockTextBox";
            this.in_StockTextBox.Size = new System.Drawing.Size(100, 22);
            this.in_StockTextBox.TabIndex = 11;
            // 
            // on_OrderTextBox
            // 
            this.on_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "On Order", true));
            this.on_OrderTextBox.Location = new System.Drawing.Point(864, 74);
            this.on_OrderTextBox.Name = "on_OrderTextBox";
            this.on_OrderTextBox.Size = new System.Drawing.Size(100, 22);
            this.on_OrderTextBox.TabIndex = 13;
            // 
            // last_Order_DateTextBox
            // 
            this.last_Order_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Last Order Date", true));
            this.last_Order_DateTextBox.Location = new System.Drawing.Point(864, 102);
            this.last_Order_DateTextBox.Name = "last_Order_DateTextBox";
            this.last_Order_DateTextBox.Size = new System.Drawing.Size(122, 22);
            this.last_Order_DateTextBox.TabIndex = 15;
            // 
            // last_Order_QuantityTextBox
            // 
            this.last_Order_QuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Last Order Quantity", true));
            this.last_Order_QuantityTextBox.Location = new System.Drawing.Point(864, 130);
            this.last_Order_QuantityTextBox.Name = "last_Order_QuantityTextBox";
            this.last_Order_QuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.last_Order_QuantityTextBox.TabIndex = 17;
            // 
            // purchase_PriceTextBox
            // 
            this.purchase_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "Purchase Price", true));
            this.purchase_PriceTextBox.Location = new System.Drawing.Point(864, 158);
            this.purchase_PriceTextBox.Name = "purchase_PriceTextBox";
            this.purchase_PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.purchase_PriceTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(1085, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 626);
            this.panel1.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 574);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(253, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(18, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 438);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.taxCodeDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.onOrderDataGridViewTextBoxColumn,
            this.lastOrderDateDataGridViewTextBoxColumn,
            this.lastOrderQuantityDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 387);
            this.dataGridView1.TabIndex = 7;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // taxCodeDataGridViewTextBoxColumn
            // 
            this.taxCodeDataGridViewTextBoxColumn.DataPropertyName = "Tax Code";
            this.taxCodeDataGridViewTextBoxColumn.HeaderText = "Tax Code";
            this.taxCodeDataGridViewTextBoxColumn.Name = "taxCodeDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "In Stock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "In Stock";
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // onOrderDataGridViewTextBoxColumn
            // 
            this.onOrderDataGridViewTextBoxColumn.DataPropertyName = "On Order";
            this.onOrderDataGridViewTextBoxColumn.HeaderText = "On Order";
            this.onOrderDataGridViewTextBoxColumn.Name = "onOrderDataGridViewTextBoxColumn";
            // 
            // lastOrderDateDataGridViewTextBoxColumn
            // 
            this.lastOrderDateDataGridViewTextBoxColumn.DataPropertyName = "Last Order Date";
            this.lastOrderDateDataGridViewTextBoxColumn.HeaderText = "Last Order Date";
            this.lastOrderDateDataGridViewTextBoxColumn.Name = "lastOrderDateDataGridViewTextBoxColumn";
            // 
            // lastOrderQuantityDataGridViewTextBoxColumn
            // 
            this.lastOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Last Order Quantity";
            this.lastOrderQuantityDataGridViewTextBoxColumn.HeaderText = "Last Order Quantity";
            this.lastOrderQuantityDataGridViewTextBoxColumn.Name = "lastOrderQuantityDataGridViewTextBoxColumn";
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(971, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(419, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "E-mail";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search";
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(77, 12);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(184, 24);
            this.cmbSearch.TabIndex = 23;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(267, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 22);
            this.txtSearch.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 653);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.product_DescriptionTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(tax_CodeLabel);
            this.Controls.Add(this.tax_CodeTextBox);
            this.Controls.Add(in_StockLabel);
            this.Controls.Add(this.in_StockTextBox);
            this.Controls.Add(on_OrderLabel);
            this.Controls.Add(this.on_OrderTextBox);
            this.Controls.Add(last_Order_DateLabel);
            this.Controls.Add(this.last_Order_DateTextBox);
            this.Controls.Add(last_Order_QuantityLabel);
            this.Controls.Add(this.last_Order_QuantityTextBox);
            this.Controls.Add(purchase_PriceLabel);
            this.Controls.Add(this.purchase_PriceTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastShopDBDataSet fastShopDBDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private FastShopDBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private FastShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox tax_CodeTextBox;
        private System.Windows.Forms.TextBox in_StockTextBox;
        private System.Windows.Forms.TextBox on_OrderTextBox;
        private System.Windows.Forms.TextBox last_Order_DateTextBox;
        private System.Windows.Forms.TextBox last_Order_QuantityTextBox;
        private System.Windows.Forms.TextBox purchase_PriceTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOrderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

