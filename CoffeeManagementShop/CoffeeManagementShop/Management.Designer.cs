namespace CoffeeManagementShop
{
    partial class CoffeeManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            menu = new TabPage();
            btnCloseFromMenu = new Button();
            btnBackToTableFromMenuManagement = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            cbCategoryList = new ComboBox();
            lblCategoryList = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtSearchProductName = new TextBox();
            lblSearchMenu = new Label();
            grdMenu = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddProduct = new Button();
            btnDelete = new Button();
            btnEditProduct = new Button();
            grbMenu = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbCategory = new ComboBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblProductID = new Label();
            txtProductID = new TextBox();
            lblCategory = new Label();
            order = new TabPage();
            btnCloseFromOrder = new Button();
            btnBackToTableFromOrderManagement = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            cbDate = new ComboBox();
            lblDTPOrder = new Label();
            grdOrder = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnAddOrder = new Button();
            btnDeleteOrder = new Button();
            btnEditOrder = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtSearchOrderID = new TextBox();
            label1 = new Label();
            grbOrder = new GroupBox();
            tlpOrder = new TableLayoutPanel();
            dtpOrder = new DateTimePicker();
            lblCustomerForCheckID = new Label();
            lblOrderDate = new Label();
            lblOrderID = new Label();
            txtOrderID = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            txtCustomerForCheckID = new TextBox();
            label6 = new Label();
            txtTableIdOrder = new TextBox();
            customer = new TabPage();
            btnCloseFromCustomer = new Button();
            btnBackToTableFromCustomerManagement = new Button();
            grdCustomer = new DataGridView();
            tableLayoutPanel9 = new TableLayoutPanel();
            txtSearchCustomerName = new TextBox();
            label3 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            btnAddCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnEditCustomer = new Button();
            grbCustomer = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label2 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCustomerName = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            txtCustomerID = new TextBox();
            revenueReport = new TabPage();
            fileSystemWatcher1 = new FileSystemWatcher();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl.SuspendLayout();
            menu.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdMenu).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            grbMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            order.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrder).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            grbOrder.SuspendLayout();
            tlpOrder.SuspendLayout();
            customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCustomer).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            grbCustomer.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(menu);
            tabControl.Controls.Add(order);
            tabControl.Controls.Add(customer);
            tabControl.Controls.Add(revenueReport);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1366, 1122);
            tabControl.TabIndex = 0;
            // 
            // menu
            // 
            menu.Controls.Add(btnCloseFromMenu);
            menu.Controls.Add(btnBackToTableFromMenuManagement);
            menu.Controls.Add(tableLayoutPanel4);
            menu.Controls.Add(tableLayoutPanel3);
            menu.Controls.Add(grdMenu);
            menu.Controls.Add(tableLayoutPanel2);
            menu.Controls.Add(grbMenu);
            menu.Location = new Point(4, 34);
            menu.Name = "menu";
            menu.Padding = new Padding(3);
            menu.Size = new Size(1358, 1084);
            menu.TabIndex = 0;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = true;
            // 
            // btnCloseFromMenu
            // 
            btnCloseFromMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseFromMenu.BackColor = SystemColors.GrayText;
            btnCloseFromMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseFromMenu.ForeColor = SystemColors.Control;
            btnCloseFromMenu.Location = new Point(1166, 19);
            btnCloseFromMenu.Name = "btnCloseFromMenu";
            btnCloseFromMenu.Size = new Size(181, 48);
            btnCloseFromMenu.TabIndex = 19;
            btnCloseFromMenu.Text = "Close";
            btnCloseFromMenu.UseVisualStyleBackColor = false;
            btnCloseFromMenu.Click += btnCloseFromMenu_Click;
            // 
            // btnBackToTableFromMenuManagement
            // 
            btnBackToTableFromMenuManagement.BackColor = SystemColors.ActiveBorder;
            btnBackToTableFromMenuManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToTableFromMenuManagement.ForeColor = SystemColors.Control;
            btnBackToTableFromMenuManagement.Location = new Point(23, 19);
            btnBackToTableFromMenuManagement.Name = "btnBackToTableFromMenuManagement";
            btnBackToTableFromMenuManagement.Size = new Size(181, 48);
            btnBackToTableFromMenuManagement.TabIndex = 18;
            btnBackToTableFromMenuManagement.Text = "<- Back to table";
            btnBackToTableFromMenuManagement.UseVisualStyleBackColor = false;
            btnBackToTableFromMenuManagement.Click += btnBackToTable_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(cbCategoryList, 1, 0);
            tableLayoutPanel4.Controls.Add(lblCategoryList, 0, 0);
            tableLayoutPanel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel4.Location = new Point(495, 664);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(428, 63);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // cbCategoryList
            // 
            cbCategoryList.Anchor = AnchorStyles.Left;
            cbCategoryList.FormattingEnabled = true;
            cbCategoryList.Items.AddRange(new object[] { "Coffee", "Tea", "Pastries", "Sandwiches", "Smoothies", "Desserts", "Salads", "Breakfast", "Lunch", "Dinner" });
            cbCategoryList.Location = new Point(217, 15);
            cbCategoryList.Name = "cbCategoryList";
            cbCategoryList.Size = new Size(208, 40);
            cbCategoryList.TabIndex = 16;
            cbCategoryList.SelectedIndexChanged += cbCategoryList_SelectedIndexChanged;
            // 
            // lblCategoryList
            // 
            lblCategoryList.Anchor = AnchorStyles.Right;
            lblCategoryList.AutoSize = true;
            lblCategoryList.ForeColor = Color.FromArgb(0, 0, 64);
            lblCategoryList.Location = new Point(86, 15);
            lblCategoryList.Name = "lblCategoryList";
            lblCategoryList.Size = new Size(125, 32);
            lblCategoryList.TabIndex = 17;
            lblCategoryList.Text = "Category:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.5679741F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.4320259F));
            tableLayoutPanel3.Controls.Add(txtSearchProductName, 3, 0);
            tableLayoutPanel3.Controls.Add(lblSearchMenu, 0, 0);
            tableLayoutPanel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel3.Location = new Point(17, 93);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1330, 124);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // txtSearchProductName
            // 
            txtSearchProductName.Anchor = AnchorStyles.Left;
            txtSearchProductName.Location = new Point(702, 42);
            txtSearchProductName.Name = "txtSearchProductName";
            txtSearchProductName.Size = new Size(204, 39);
            txtSearchProductName.TabIndex = 8;
            txtSearchProductName.TextChanged += txtSearchProductName_TextChanged;
            // 
            // lblSearchMenu
            // 
            lblSearchMenu.Anchor = AnchorStyles.Right;
            lblSearchMenu.AutoSize = true;
            lblSearchMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchMenu.ForeColor = Color.Navy;
            lblSearchMenu.Location = new Point(428, 46);
            lblSearchMenu.Name = "lblSearchMenu";
            lblSearchMenu.Size = new Size(268, 32);
            lblSearchMenu.TabIndex = 7;
            lblSearchMenu.Text = "Search Product Name:";
            // 
            // grdMenu
            // 
            grdMenu.Anchor = AnchorStyles.Bottom;
            grdMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdMenu.DefaultCellStyle = dataGridViewCellStyle2;
            grdMenu.Location = new Point(17, 770);
            grdMenu.Name = "grdMenu";
            grdMenu.RowHeadersWidth = 62;
            grdMenu.Size = new Size(1330, 306);
            grdMenu.TabIndex = 6;
            grdMenu.CellClick += grdMenu_CellClick;
            grdMenu.CellContentClick += grdMenu_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel2.Controls.Add(btnAddProduct, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEditProduct, 1, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(495, 513);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(428, 74);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.None;
            btnAddProduct.BackColor = Color.Green;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(15, 10);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(122, 54);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(307, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.None;
            btnEditProduct.BackColor = Color.RosyBrown;
            btnEditProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(167, 10);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(122, 54);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // grbMenu
            // 
            grbMenu.Anchor = AnchorStyles.Top;
            grbMenu.Controls.Add(tableLayoutPanel1);
            grbMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMenu.ForeColor = Color.Navy;
            grbMenu.Location = new Point(17, 223);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(1330, 242);
            grbMenu.TabIndex = 0;
            grbMenu.TabStop = false;
            grbMenu.Text = "Menu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.941906F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.0581F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 462F));
            tableLayoutPanel1.Controls.Add(cbCategory, 3, 1);
            tableLayoutPanel1.Controls.Add(txtPrice, 3, 0);
            tableLayoutPanel1.Controls.Add(lblPrice, 2, 0);
            tableLayoutPanel1.Controls.Add(lblProductName, 0, 1);
            tableLayoutPanel1.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblProductID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtProductID, 1, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 2, 1);
            tableLayoutPanel1.Location = new Point(6, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1324, 195);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Left;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Coffee", "Tea", "Pastries", "Sandwiches", "Smoothies", "Desserts", "Salads", "Breakfast", "Lunch", "Dinner" });
            cbCategory.Location = new Point(864, 123);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(208, 46);
            cbCategory.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(864, 26);
            txtPrice.MaxLength = 10;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(204, 45);
            txtPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(0, 0, 192);
            lblPrice.Location = new Point(739, 32);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 32);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price:";
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.None;
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(0, 0, 192);
            lblProductName.Location = new Point(30, 114);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(112, 64);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Left;
            txtProductName.Location = new Point(176, 123);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(204, 45);
            txtProductName.TabIndex = 0;
            // 
            // lblProductID
            // 
            lblProductID.Anchor = AnchorStyles.None;
            lblProductID.AutoSize = true;
            lblProductID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductID.ForeColor = Color.FromArgb(0, 0, 192);
            lblProductID.Location = new Point(14, 32);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(145, 32);
            lblProductID.TabIndex = 6;
            lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Anchor = AnchorStyles.Left;
            txtProductID.Location = new Point(176, 26);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(204, 45);
            txtProductID.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.Anchor = AnchorStyles.None;
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(0, 0, 192);
            lblCategory.Location = new Point(716, 130);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(125, 32);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // order
            // 
            order.Controls.Add(btnCloseFromOrder);
            order.Controls.Add(btnBackToTableFromOrderManagement);
            order.Controls.Add(tableLayoutPanel6);
            order.Controls.Add(grdOrder);
            order.Controls.Add(tableLayoutPanel7);
            order.Controls.Add(tableLayoutPanel5);
            order.Controls.Add(grbOrder);
            order.ForeColor = SystemColors.ControlText;
            order.Location = new Point(4, 34);
            order.Name = "order";
            order.Padding = new Padding(3);
            order.Size = new Size(1358, 1084);
            order.TabIndex = 1;
            order.Text = "Order";
            order.UseVisualStyleBackColor = true;
            // 
            // btnCloseFromOrder
            // 
            btnCloseFromOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseFromOrder.BackColor = SystemColors.GrayText;
            btnCloseFromOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseFromOrder.ForeColor = SystemColors.Control;
            btnCloseFromOrder.Location = new Point(1167, 15);
            btnCloseFromOrder.Name = "btnCloseFromOrder";
            btnCloseFromOrder.Size = new Size(181, 48);
            btnCloseFromOrder.TabIndex = 25;
            btnCloseFromOrder.Text = "Close";
            btnCloseFromOrder.UseVisualStyleBackColor = false;
            btnCloseFromOrder.Click += btnCloseFromOrder_Click;
            // 
            // btnBackToTableFromOrderManagement
            // 
            btnBackToTableFromOrderManagement.BackColor = SystemColors.ActiveBorder;
            btnBackToTableFromOrderManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToTableFromOrderManagement.ForeColor = SystemColors.Control;
            btnBackToTableFromOrderManagement.Location = new Point(23, 15);
            btnBackToTableFromOrderManagement.Name = "btnBackToTableFromOrderManagement";
            btnBackToTableFromOrderManagement.Size = new Size(181, 48);
            btnBackToTableFromOrderManagement.TabIndex = 24;
            btnBackToTableFromOrderManagement.Text = "<- Back to table";
            btnBackToTableFromOrderManagement.UseVisualStyleBackColor = false;
            btnBackToTableFromOrderManagement.Click += btnBackToTableFromOrderManagement_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.None;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(cbDate, 1, 0);
            tableLayoutPanel6.Controls.Add(lblDTPOrder, 0, 0);
            tableLayoutPanel6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel6.Location = new Point(486, 597);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(428, 63);
            tableLayoutPanel6.TabIndex = 20;
            // 
            // cbDate
            // 
            cbDate.Anchor = AnchorStyles.Left;
            cbDate.FormattingEnabled = true;
            cbDate.Items.AddRange(new object[] { "asd/3" });
            cbDate.Location = new Point(217, 11);
            cbDate.Name = "cbDate";
            cbDate.Size = new Size(208, 40);
            cbDate.TabIndex = 16;
            cbDate.SelectedIndexChanged += cbDate_SelectedIndexChanged;
            // 
            // lblDTPOrder
            // 
            lblDTPOrder.Anchor = AnchorStyles.Right;
            lblDTPOrder.AutoSize = true;
            lblDTPOrder.ForeColor = Color.FromArgb(0, 0, 64);
            lblDTPOrder.Location = new Point(137, 15);
            lblDTPOrder.Name = "lblDTPOrder";
            lblDTPOrder.Size = new Size(74, 32);
            lblDTPOrder.TabIndex = 17;
            lblDTPOrder.Text = "Date:";
            // 
            // grdOrder
            // 
            grdOrder.Anchor = AnchorStyles.Bottom;
            grdOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            grdOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            grdOrder.DefaultCellStyle = dataGridViewCellStyle4;
            grdOrder.Location = new Point(8, 770);
            grdOrder.Name = "grdOrder";
            grdOrder.RowHeadersWidth = 62;
            grdOrder.Size = new Size(1340, 306);
            grdOrder.TabIndex = 19;
            grdOrder.CellClick += grdOrder_CellClick;
            grdOrder.CellContentClick += grdOrder_CellContentClick;
            grdOrder.CellDoubleClick += grdOrder_CellDoubleClick;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top;
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel7.Controls.Add(btnAddOrder, 0, 0);
            tableLayoutPanel7.Controls.Add(btnDeleteOrder, 2, 0);
            tableLayoutPanel7.Controls.Add(btnEditOrder, 1, 0);
            tableLayoutPanel7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel7.Location = new Point(503, 508);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(428, 74);
            tableLayoutPanel7.TabIndex = 18;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.None;
            btnAddOrder.BackColor = Color.Green;
            btnAddOrder.ForeColor = Color.White;
            btnAddOrder.Location = new Point(15, 10);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(122, 54);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "Add";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Anchor = AnchorStyles.None;
            btnDeleteOrder.BackColor = Color.Red;
            btnDeleteOrder.ForeColor = Color.White;
            btnDeleteOrder.Location = new Point(307, 10);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(118, 54);
            btnDeleteOrder.TabIndex = 3;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Anchor = AnchorStyles.None;
            btnEditOrder.BackColor = Color.RosyBrown;
            btnEditOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditOrder.ForeColor = Color.White;
            btnEditOrder.Location = new Point(167, 10);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(122, 54);
            btnEditOrder.TabIndex = 2;
            btnEditOrder.Text = "Edit";
            btnEditOrder.UseVisualStyleBackColor = false;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1946526F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8053474F));
            tableLayoutPanel5.Controls.Add(txtSearchOrderID, 3, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel5.Location = new Point(8, 99);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1346, 124);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // txtSearchOrderID
            // 
            txtSearchOrderID.Anchor = AnchorStyles.Left;
            txtSearchOrderID.Location = new Point(719, 42);
            txtSearchOrderID.Name = "txtSearchOrderID";
            txtSearchOrderID.Size = new Size(204, 39);
            txtSearchOrderID.TabIndex = 8;
            txtSearchOrderID.TextChanged += txtSearchOrderID_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(511, 46);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 7;
            label1.Text = "Search Order ID:";
            // 
            // grbOrder
            // 
            grbOrder.Anchor = AnchorStyles.Top;
            grbOrder.Controls.Add(tlpOrder);
            grbOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbOrder.ForeColor = Color.Navy;
            grbOrder.Location = new Point(8, 216);
            grbOrder.Name = "grbOrder";
            grbOrder.Size = new Size(1346, 253);
            grbOrder.TabIndex = 10;
            grbOrder.TabStop = false;
            grbOrder.Text = "Order";
            // 
            // tlpOrder
            // 
            tlpOrder.CausesValidation = false;
            tlpOrder.ColumnCount = 4;
            tlpOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.941906F));
            tlpOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.0581F));
            tlpOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tlpOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 462F));
            tlpOrder.Controls.Add(dtpOrder, 1, 1);
            tlpOrder.Controls.Add(lblCustomerForCheckID, 2, 0);
            tlpOrder.Controls.Add(lblOrderDate, 0, 1);
            tlpOrder.Controls.Add(lblOrderID, 0, 0);
            tlpOrder.Controls.Add(txtOrderID, 1, 0);
            tlpOrder.Controls.Add(lblTotalAmount, 2, 1);
            tlpOrder.Controls.Add(txtTotalAmount, 3, 1);
            tlpOrder.Controls.Add(txtCustomerForCheckID, 3, 0);
            tlpOrder.Controls.Add(label6, 2, 2);
            tlpOrder.Controls.Add(txtTableIdOrder, 3, 2);
            tlpOrder.Location = new Point(15, 44);
            tlpOrder.Name = "tlpOrder";
            tlpOrder.RowCount = 3;
            tlpOrder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOrder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpOrder.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpOrder.Size = new Size(1325, 203);
            tlpOrder.TabIndex = 4;
            // 
            // dtpOrder
            // 
            dtpOrder.Anchor = AnchorStyles.Left;
            dtpOrder.Location = new Point(177, 90);
            dtpOrder.Name = "dtpOrder";
            dtpOrder.Size = new Size(408, 45);
            dtpOrder.TabIndex = 12;
            // 
            // lblCustomerForCheckID
            // 
            lblCustomerForCheckID.Anchor = AnchorStyles.None;
            lblCustomerForCheckID.AutoSize = true;
            lblCustomerForCheckID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerForCheckID.ForeColor = Color.FromArgb(0, 0, 192);
            lblCustomerForCheckID.Location = new Point(714, 5);
            lblCustomerForCheckID.Name = "lblCustomerForCheckID";
            lblCustomerForCheckID.Size = new Size(131, 64);
            lblCustomerForCheckID.TabIndex = 5;
            lblCustomerForCheckID.Text = "Customer Name:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.Anchor = AnchorStyles.None;
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.FromArgb(0, 0, 192);
            lblOrderDate.Location = new Point(13, 96);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(147, 32);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            lblOrderID.Anchor = AnchorStyles.None;
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderID.ForeColor = Color.FromArgb(0, 0, 192);
            lblOrderID.Location = new Point(27, 21);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(120, 32);
            lblOrderID.TabIndex = 6;
            lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            txtOrderID.Anchor = AnchorStyles.Left;
            txtOrderID.Location = new Point(177, 15);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(204, 45);
            txtOrderID.TabIndex = 7;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.None;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotalAmount.Location = new Point(722, 80);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(114, 64);
            lblTotalAmount.TabIndex = 8;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Anchor = AnchorStyles.Left;
            txtTotalAmount.Location = new Point(865, 90);
            txtTotalAmount.MaxLength = 10;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(204, 45);
            txtTotalAmount.TabIndex = 9;
            // 
            // txtCustomerForCheckID
            // 
            txtCustomerForCheckID.Anchor = AnchorStyles.Left;
            txtCustomerForCheckID.Location = new Point(865, 15);
            txtCustomerForCheckID.Name = "txtCustomerForCheckID";
            txtCustomerForCheckID.Size = new Size(204, 45);
            txtCustomerForCheckID.TabIndex = 13;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(722, 160);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 14;
            label6.Text = "Table ID:";
            // 
            // txtTableIdOrder
            // 
            txtTableIdOrder.Location = new Point(865, 153);
            txtTableIdOrder.Name = "txtTableIdOrder";
            txtTableIdOrder.Size = new Size(204, 45);
            txtTableIdOrder.TabIndex = 15;
            // 
            // customer
            // 
            customer.Controls.Add(btnCloseFromCustomer);
            customer.Controls.Add(btnBackToTableFromCustomerManagement);
            customer.Controls.Add(grdCustomer);
            customer.Controls.Add(tableLayoutPanel9);
            customer.Controls.Add(tableLayoutPanel10);
            customer.Controls.Add(grbCustomer);
            customer.ForeColor = SystemColors.ControlText;
            customer.Location = new Point(4, 34);
            customer.Name = "customer";
            customer.Size = new Size(1358, 1084);
            customer.TabIndex = 2;
            customer.Text = "Customer";
            customer.UseVisualStyleBackColor = true;
            // 
            // btnCloseFromCustomer
            // 
            btnCloseFromCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseFromCustomer.BackColor = SystemColors.GrayText;
            btnCloseFromCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseFromCustomer.ForeColor = SystemColors.Control;
            btnCloseFromCustomer.Location = new Point(1157, 19);
            btnCloseFromCustomer.Name = "btnCloseFromCustomer";
            btnCloseFromCustomer.Size = new Size(181, 48);
            btnCloseFromCustomer.TabIndex = 24;
            btnCloseFromCustomer.Text = "Close";
            btnCloseFromCustomer.UseVisualStyleBackColor = false;
            btnCloseFromCustomer.Click += btnCloseFromCustomer_Click;
            // 
            // btnBackToTableFromCustomerManagement
            // 
            btnBackToTableFromCustomerManagement.BackColor = SystemColors.ActiveBorder;
            btnBackToTableFromCustomerManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToTableFromCustomerManagement.ForeColor = SystemColors.Control;
            btnBackToTableFromCustomerManagement.Location = new Point(18, 19);
            btnBackToTableFromCustomerManagement.Name = "btnBackToTableFromCustomerManagement";
            btnBackToTableFromCustomerManagement.Size = new Size(181, 48);
            btnBackToTableFromCustomerManagement.TabIndex = 23;
            btnBackToTableFromCustomerManagement.Text = "<- Back to table";
            btnBackToTableFromCustomerManagement.UseVisualStyleBackColor = false;
            btnBackToTableFromCustomerManagement.Click += btnBackToTableFromCustomerManagement_Click;
            // 
            // grdCustomer
            // 
            grdCustomer.Anchor = AnchorStyles.Bottom;
            grdCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            grdCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            grdCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            grdCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            grdCustomer.Location = new Point(4, 770);
            grdCustomer.Name = "grdCustomer";
            grdCustomer.RowHeadersWidth = 62;
            grdCustomer.Size = new Size(1340, 306);
            grdCustomer.TabIndex = 22;
            grdCustomer.CellClick += grdCustomer_CellClick;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Top;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.5679741F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.4320259F));
            tableLayoutPanel9.Controls.Add(txtSearchCustomerName, 3, 0);
            tableLayoutPanel9.Controls.Add(label3, 0, 0);
            tableLayoutPanel9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel9.Location = new Point(8, 124);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(1336, 124);
            tableLayoutPanel9.TabIndex = 21;
            // 
            // txtSearchCustomerName
            // 
            txtSearchCustomerName.Anchor = AnchorStyles.Left;
            txtSearchCustomerName.Location = new Point(705, 42);
            txtSearchCustomerName.Name = "txtSearchCustomerName";
            txtSearchCustomerName.Size = new Size(204, 39);
            txtSearchCustomerName.TabIndex = 8;
            txtSearchCustomerName.TextChanged += txtSearchCustomerName_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(412, 46);
            label3.Name = "label3";
            label3.Size = new Size(287, 32);
            label3.TabIndex = 7;
            label3.Text = "Search Customer Name:";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = AnchorStyles.Top;
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel10.Controls.Add(btnAddCustomer, 0, 0);
            tableLayoutPanel10.Controls.Add(btnDeleteCustomer, 2, 0);
            tableLayoutPanel10.Controls.Add(btnEditCustomer, 1, 0);
            tableLayoutPanel10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel10.Location = new Point(498, 552);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(428, 74);
            tableLayoutPanel10.TabIndex = 19;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.None;
            btnAddCustomer.BackColor = Color.Green;
            btnAddCustomer.ForeColor = Color.White;
            btnAddCustomer.Location = new Point(15, 10);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(122, 54);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.None;
            btnDeleteCustomer.BackColor = Color.Red;
            btnDeleteCustomer.ForeColor = Color.White;
            btnDeleteCustomer.Location = new Point(307, 10);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(118, 54);
            btnDeleteCustomer.TabIndex = 3;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Anchor = AnchorStyles.None;
            btnEditCustomer.BackColor = Color.RosyBrown;
            btnEditCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditCustomer.ForeColor = Color.White;
            btnEditCustomer.Location = new Point(167, 10);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(122, 54);
            btnEditCustomer.TabIndex = 2;
            btnEditCustomer.Text = "Edit";
            btnEditCustomer.UseVisualStyleBackColor = false;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // grbCustomer
            // 
            grbCustomer.Anchor = AnchorStyles.Top;
            grbCustomer.Controls.Add(tableLayoutPanel11);
            grbCustomer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCustomer.ForeColor = Color.Navy;
            grbCustomer.Location = new Point(8, 254);
            grbCustomer.Name = "grbCustomer";
            grbCustomer.Size = new Size(1336, 242);
            grbCustomer.TabIndex = 18;
            grbCustomer.TabStop = false;
            grbCustomer.Text = "Customer";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 4;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.941906F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.0581F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 462F));
            tableLayoutPanel11.Controls.Add(label2, 0, 0);
            tableLayoutPanel11.Controls.Add(txtPhone, 3, 0);
            tableLayoutPanel11.Controls.Add(label4, 2, 0);
            tableLayoutPanel11.Controls.Add(label5, 0, 1);
            tableLayoutPanel11.Controls.Add(txtCustomerName, 1, 1);
            tableLayoutPanel11.Controls.Add(label7, 2, 1);
            tableLayoutPanel11.Controls.Add(txtAddress, 3, 1);
            tableLayoutPanel11.Controls.Add(txtCustomerID, 1, 0);
            tableLayoutPanel11.Location = new Point(10, 41);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(1320, 195);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(4, 32);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 22;
            label2.Text = "Customer ID:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left;
            txtPhone.Location = new Point(860, 26);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 45);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(728, 32);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 5;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(20, 114);
            label5.Name = "label5";
            label5.Size = new Size(131, 64);
            label5.TabIndex = 3;
            label5.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Left;
            txtCustomerName.Location = new Point(175, 123);
            txtCustomerName.MaxLength = 50;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(204, 45);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(718, 130);
            label7.Name = "label7";
            label7.Size = new Size(113, 32);
            label7.TabIndex = 8;
            label7.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left;
            txtAddress.Location = new Point(860, 123);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 45);
            txtAddress.TabIndex = 9;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Anchor = AnchorStyles.Left;
            txtCustomerID.Location = new Point(175, 26);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(204, 45);
            txtCustomerID.TabIndex = 10;
            txtCustomerID.KeyPress += txtCustomerID_KeyPress;
            // 
            // revenueReport
            // 
            revenueReport.Location = new Point(4, 34);
            revenueReport.Name = "revenueReport";
            revenueReport.Size = new Size(1358, 1084);
            revenueReport.TabIndex = 3;
            revenueReport.Text = "RevenueReport";
            revenueReport.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CoffeeManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 1122);
            Controls.Add(tabControl);
            Name = "CoffeeManagement";
            Text = "Coffee Management Shop";
            Load += CoffeeManagement_Load;
            tabControl.ResumeLayout(false);
            menu.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdMenu).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            grbMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            order.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrder).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            grbOrder.ResumeLayout(false);
            tlpOrder.ResumeLayout(false);
            tlpOrder.PerformLayout();
            customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCustomer).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            grbCustomer.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage menu;
        private TabPage order;
        private GroupBox grbMenu;
        private TextBox txtPrice;
        private TextBox txtProductName;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPrice;
        private Label lblProductName;
        private DataGridView grdMenu;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddProduct;
        private Button btnDelete;
        private Button btnEditProduct;
        private Label lblProductID;
        private TextBox txtProductID;
        private Label lblCategory;
        private TextBox txtCategoryID;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtSearchProductName;
        private Label lblSearchMenu;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox cbCategoryList;
        private Label lblCategoryList;
        private ComboBox cbCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage customer;
        private TabPage revenueReport;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtSearchOrderID;
        private Label label1;
        private GroupBox grbOrder;
        private TableLayoutPanel tlpOrder;
        private Label lblCustomerForCheckID;
        private Label lblOrderDate;
        private Label lblOrderID;
        private TextBox txtOrderID;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private DateTimePicker dtpOrder;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox cbDate;
        private Label lblDTPOrder;
        private DataGridView grdOrder;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnAddOrder;
        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private TextBox txtCustomer;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox txtSearchCustomerName;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnAddCustomer;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private GroupBox grbCustomer;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerName;
        private Label label6;
        private TextBox txtCustomerID;
        private Label label7;
        private TextBox txtAddress;
        private TextBox txtCustomerForCheckID;
        private Label label2;
        private DataGridView grdCustomer;
        private Button btnBackToTableFromMenuManagement;
        private TextBox txtTableIdOrder;
        private Button btnBackToTableFromCustomerManagement;
        private Button btnBackToTableFromOrderManagement;
        private Button btnCloseFromMenu;
        private Button btnCloseFromOrder;
        private Button btnCloseFromCustomer;
    }
}
