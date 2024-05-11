namespace CoffeeManagementShop
{
    partial class OrderDetail
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
            btnBackToOrderAdmin = new Button();
            flowLayoutPanelOrder = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBackToOrderAdmin, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanelOrder, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.06877F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 630F));
            tableLayoutPanel1.Size = new Size(1079, 698);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBackToOrderAdmin
            // 
            btnBackToOrderAdmin.BackColor = SystemColors.ActiveBorder;
            btnBackToOrderAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToOrderAdmin.Location = new Point(3, 3);
            btnBackToOrderAdmin.Name = "btnBackToOrderAdmin";
            btnBackToOrderAdmin.Size = new Size(136, 42);
            btnBackToOrderAdmin.TabIndex = 1;
            btnBackToOrderAdmin.Text = "Back";
            btnBackToOrderAdmin.UseVisualStyleBackColor = false;
            btnBackToOrderAdmin.Click += btnBackToOrderAdmin_Click;
            // 
            // flowLayoutPanelOrder
            // 
            flowLayoutPanelOrder.Location = new Point(3, 71);
            flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            flowLayoutPanelOrder.Size = new Size(1073, 624);
            flowLayoutPanelOrder.TabIndex = 2;
            // 
            // OrderDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 722);
            Controls.Add(tableLayoutPanel1);
            Name = "OrderDetail";
            Text = "DetailOrder";
            Load += OrderDetail_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBackToOrderAdmin;
        private FlowLayoutPanel flowLayoutPanelOrder;
    }
}