namespace CoffeeManagementShop
{
    partial class TableForOrder
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
            btnA1Table = new Button();
            btnA2Table = new Button();
            btnB1Table = new Button();
            btnB2Table = new Button();
            btnC1Table = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnC2Table = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdminManagement = new Button();
            label1 = new Label();
            btnThoat = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnA1Table
            // 
            btnA1Table.BackColor = Color.FromArgb(192, 255, 192);
            btnA1Table.ForeColor = Color.Black;
            btnA1Table.Location = new Point(3, 3);
            btnA1Table.Name = "btnA1Table";
            btnA1Table.Size = new Size(578, 204);
            btnA1Table.TabIndex = 0;
            btnA1Table.Text = "Bàn A1";
            btnA1Table.UseVisualStyleBackColor = false;
            btnA1Table.Click += btnA1Table_Click;
            // 
            // btnA2Table
            // 
            btnA2Table.BackColor = Color.FromArgb(192, 255, 192);
            btnA2Table.ForeColor = Color.Black;
            btnA2Table.Location = new Point(587, 3);
            btnA2Table.Name = "btnA2Table";
            btnA2Table.Size = new Size(579, 204);
            btnA2Table.TabIndex = 1;
            btnA2Table.Text = "Bàn A2";
            btnA2Table.UseVisualStyleBackColor = false;
            btnA2Table.Click += btnA2Table_Click;
            // 
            // btnB1Table
            // 
            btnB1Table.BackColor = Color.FromArgb(192, 255, 255);
            btnB1Table.Location = new Point(3, 213);
            btnB1Table.Name = "btnB1Table";
            btnB1Table.Size = new Size(578, 216);
            btnB1Table.TabIndex = 2;
            btnB1Table.Text = "Bàn B1";
            btnB1Table.UseVisualStyleBackColor = false;
            btnB1Table.Click += btnB1Table_Click;
            // 
            // btnB2Table
            // 
            btnB2Table.BackColor = Color.FromArgb(192, 255, 255);
            btnB2Table.Location = new Point(587, 213);
            btnB2Table.Name = "btnB2Table";
            btnB2Table.Size = new Size(579, 216);
            btnB2Table.TabIndex = 3;
            btnB2Table.Text = "Bàn B2";
            btnB2Table.UseVisualStyleBackColor = false;
            btnB2Table.Click += btnB2Table_Click;
            // 
            // btnC1Table
            // 
            btnC1Table.BackColor = Color.FromArgb(192, 192, 255);
            btnC1Table.Location = new Point(3, 435);
            btnC1Table.Name = "btnC1Table";
            btnC1Table.Size = new Size(578, 189);
            btnC1Table.TabIndex = 4;
            btnC1Table.Text = "Bàn C1";
            btnC1Table.UseVisualStyleBackColor = false;
            btnC1Table.Click += btnC1Table_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnA1Table, 0, 0);
            tableLayoutPanel1.Controls.Add(btnA2Table, 1, 0);
            tableLayoutPanel1.Controls.Add(btnB2Table, 1, 1);
            tableLayoutPanel1.Controls.Add(btnB1Table, 0, 1);
            tableLayoutPanel1.Controls.Add(btnC2Table, 1, 2);
            tableLayoutPanel1.Controls.Add(btnC1Table, 0, 2);
            tableLayoutPanel1.Font = new Font("Cambria", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(12, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.6486473F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 194F));
            tableLayoutPanel1.Size = new Size(1169, 627);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnC2Table
            // 
            btnC2Table.BackColor = Color.FromArgb(192, 192, 255);
            btnC2Table.Location = new Point(587, 435);
            btnC2Table.Name = "btnC2Table";
            btnC2Table.Size = new Size(579, 189);
            btnC2Table.TabIndex = 5;
            btnC2Table.Text = "Bàn C2";
            btnC2Table.UseVisualStyleBackColor = false;
            btnC2Table.Click += btnC2Table_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 461F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 362F));
            tableLayoutPanel2.Controls.Add(btnAdminManagement, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(btnThoat, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1169, 85);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnAdminManagement
            // 
            btnAdminManagement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdminManagement.BackColor = Color.FromArgb(64, 64, 64);
            btnAdminManagement.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminManagement.ForeColor = Color.White;
            btnAdminManagement.Location = new Point(925, 3);
            btnAdminManagement.Name = "btnAdminManagement";
            btnAdminManagement.Size = new Size(241, 52);
            btnAdminManagement.TabIndex = 7;
            btnAdminManagement.Text = "Quản lý dữ liệu";
            btnAdminManagement.UseVisualStyleBackColor = false;
            btnAdminManagement.Click += btnAdminManagement_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSalmon;
            label1.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(392, 21);
            label1.Name = "label1";
            label1.Size = new Size(368, 42);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC BÀN";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Silver;
            btnThoat.Location = new Point(3, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(136, 52);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // TableToOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 742);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "TableToOrder";
            Text = "Table";
            Load += Table_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnA1Table;
        private Button btnA2Table;
        private Button btnB1Table;
        private Button btnB2Table;
        private Button btnC1Table;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnC2Table;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button btnAdminManagement;
        private Button btnThoat;
    }
}