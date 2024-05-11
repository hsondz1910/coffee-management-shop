namespace CoffeeManagementShop
{
    partial class Payment
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBackToOrder = new Button();
            label1 = new Label();
            btnChuyenKhoan = new Button();
            btnTienMat = new Button();
            tongTienThanhToan = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.2852058F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.7147942F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            tableLayoutPanel1.Controls.Add(btnBackToOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnChuyenKhoan, 1, 2);
            tableLayoutPanel1.Controls.Add(btnTienMat, 2, 2);
            tableLayoutPanel1.Controls.Add(tongTienThanhToan, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.2676048F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.7323952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBackToOrder
            // 
            btnBackToOrder.BackColor = SystemColors.ActiveBorder;
            btnBackToOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToOrder.Location = new Point(3, 3);
            btnBackToOrder.Name = "btnBackToOrder";
            btnBackToOrder.Size = new Size(123, 39);
            btnBackToOrder.TabIndex = 0;
            btnBackToOrder.Text = "Back";
            btnBackToOrder.UseVisualStyleBackColor = false;
            btnBackToOrder.Click += btnBackToOrder_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(248, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 65);
            label1.TabIndex = 3;
            label1.Text = "Thanh Toán";
            // 
            // btnChuyenKhoan
            // 
            btnChuyenKhoan.Anchor = AnchorStyles.None;
            btnChuyenKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenKhoan.Location = new Point(299, 332);
            btnChuyenKhoan.Name = "btnChuyenKhoan";
            btnChuyenKhoan.Size = new Size(189, 45);
            btnChuyenKhoan.TabIndex = 2;
            btnChuyenKhoan.Text = "Chuyển khoản";
            btnChuyenKhoan.UseVisualStyleBackColor = true;
            btnChuyenKhoan.Click += btnChuyenKhoan_Click;
            // 
            // btnTienMat
            // 
            btnTienMat.Anchor = AnchorStyles.None;
            btnTienMat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTienMat.Location = new Point(574, 332);
            btnTienMat.Name = "btnTienMat";
            btnTienMat.Size = new Size(189, 45);
            btnTienMat.TabIndex = 1;
            btnTienMat.Text = "Tiền mặt";
            btnTienMat.UseVisualStyleBackColor = true;
            // 
            // tongTienThanhToan
            // 
            tongTienThanhToan.Anchor = AnchorStyles.None;
            tongTienThanhToan.AutoSize = true;
            tongTienThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tongTienThanhToan.Location = new Point(237, 161);
            tongTienThanhToan.Name = "tongTienThanhToan";
            tongTienThanhToan.Size = new Size(312, 64);
            tongTienThanhToan.TabIndex = 4;
            tongTienThanhToan.Text = "Tổng số tiền mà bạn phải thanh toán là: ";
            tongTienThanhToan.Click += tongTienThanhToan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 284);
            label2.Name = "label2";
            label2.Size = new Size(169, 64);
            label2.TabIndex = 5;
            label2.Text = "Phương thức thanh toán:";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBackToOrder;
        private Button btnTienMat;
        private Button btnChuyenKhoan;
        private Label label1;
        private Label tongTienThanhToan;
        private Label label2;
    }
}