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
    public partial class OrderDetail : Form
    {
        String connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        SqlConnection sqlConn = null;
        int orderId;

        public OrderDetail(int orderId)
        {
            InitializeComponent();

            this.orderId = orderId;
        }

        private void btnBackToOrderAdmin_Click(object sender, EventArgs e)
        {
            CoffeeManagement adminManagement = new CoffeeManagement();
            adminManagement.Show();
            this.Close();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            // Gọi phương thức để hiển thị dữ liệu đơn hàng trong flowLayoutPanelOrder
            DisplayOrderDetails();
        }

        private void flowLayoutPanelOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayOrderDetails()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connString))
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    sqlConn.Open();

                    // Tạo câu truy vấn SQL để lấy thông tin từ bảng orderdetail dựa trên orderId
                    string query = "SELECT * FROM OrderDetail WHERE OrderID = @OrderID";

                    // Tạo đối tượng SqlCommand và thiết lập tham số
                    using (SqlCommand command = new SqlCommand(query, sqlConn))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        // Thực hiện truy vấn SQL và đọc dữ liệu từ bảng orderdetail
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Xóa tất cả các controls hiện có trong flowLayoutPanelOrder
                            flowLayoutPanelOrder.Controls.Clear();

                            // Kiểm tra xem có dữ liệu nào được trả về không
                            if (reader.HasRows)
                            {
                                // Đọc từng dòng dữ liệu và tạo controls tương ứng trong flowLayoutPanelOrder
                                while (reader.Read())
                                {
                                    // Lấy các giá trị từ cột trong dòng hiện tại
                                    int orderDetailId = reader.GetInt32(reader.GetOrdinal("OrderDetailID"));
                                    int productId = reader.GetInt32(reader.GetOrdinal("ProductID"));
                                    int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                    decimal price = reader.GetDecimal(reader.GetOrdinal("Price"));

                                    // Tạo các controls để hiển thị thông tin chi tiết đơn hàng
                                    Label lblOrderDetailId = new Label();
                                    lblOrderDetailId.Text = "OrderDetailID: " + orderDetailId.ToString();
                                    Label lblProductId = new Label();
                                    lblProductId.Text = "ProductID: " + productId.ToString();
                                    Label lblQuantity = new Label();
                                    lblQuantity.Text = "Quantity: " + quantity.ToString();
                                    Label lblPrice = new Label();
                                    lblPrice.Text = "Price: " + price.ToString();

                                    // Thêm các controls vào flowLayoutPanelOrder
                                    flowLayoutPanelOrder.Controls.Add(lblOrderDetailId);
                                    flowLayoutPanelOrder.Controls.Add(lblProductId);
                                    flowLayoutPanelOrder.Controls.Add(lblQuantity);
                                    flowLayoutPanelOrder.Controls.Add(lblPrice);
                                }
                            }
                            else
                            {
                                // Nếu không có dữ liệu, thông báo rằng không tìm thấy thông tin
                                MessageBox.Show("Không tìm thấy thông tin chi tiết đơn hàng.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
