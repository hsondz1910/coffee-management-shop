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
    public partial class Payment : Form
    {
        String connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        string tableName;
        int orderID;

        public Payment(int orderID, string tableName)
        {
            InitializeComponent();

            this.orderID = orderID;
            this.tableName = tableName;
        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            MenuOrder order = new MenuOrder(tableName);
            order.Show();
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            tongTienThanhToan_Click(sender, e);
        }

        private void tongTienThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn SQL để tính tổng giá của tất cả sản phẩm trong đơn hàng
                    string query = "SELECT SUM(Price) AS TotalAmount FROM OrderDetail WHERE OrderID = @OrderID;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    decimal totalAmount = Convert.ToDecimal(command.ExecuteScalar());

                    // Hiển thị tổng số tiền trong label tongTienThanhToan
                    tongTienThanhToan.Text = "Tổng số tiền cần thanh toán: $" + totalAmount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy tổng số tiền: " + ex.Message);
                }
            }
        }

        private void btnChuyenKhoan_Click(object sender, EventArgs e)
        {
            TransferPayment transferPayment = new TransferPayment();
            transferPayment.ShowDialog();
        }
    }
}
