using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagementShop
{
    public partial class TableForOrder : Form
    {
        private bool isNewOrder = true;

        public TableForOrder()
        {
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminManagement_Click(object sender, EventArgs e)
        {
            CoffeeManagement management = new CoffeeManagement();
            management.Show();
            this.Close();
        }

        private void btnA1Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn A1
            string tableName = "A1";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnA2Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn A2
            string tableName = "A2";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnB1Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn B1
            string tableName = "B1";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnB2Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn B2
            string tableName = "B2";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnC1Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn C1
            string tableName = "C1";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnC2Table_Click(object sender, EventArgs e)
        {
            // Lấy tên của bàn C2
            string tableName = "C2";

            MenuOrder orderForm = new MenuOrder(tableName);
            orderForm.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
