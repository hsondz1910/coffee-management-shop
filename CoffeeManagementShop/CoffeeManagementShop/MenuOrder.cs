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
    public partial class MenuOrder : Form
    {
        string connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        private string tableName;
        private int orderID; // Biến để lưu trữ OrderID

        public MenuOrder(string tableName)
        {
            InitializeComponent();

            // Lưu tên của bàn vào biến tableName
            this.tableName = tableName;
        }

        private void createNewOrder()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn SQL để lấy TableID từ bảng Table dựa vào TableName
                    string tableQuery = "SELECT TableID FROM [Table] WHERE TableName = @TableName;";
                    SqlCommand tableCommand = new SqlCommand(tableQuery, connection);
                    tableCommand.Parameters.AddWithValue("@TableName", tableName);
                    int tableID = (int)tableCommand.ExecuteScalar();

                    // Thực thi truy vấn SQL để chèn một bản ghi mới vào bảng Order
                    string query = "INSERT INTO [Order] (OrderDate, CustomerID, TotalAmount, TableID) VALUES (@OrderDate, @CustomerID, @TotalAmount, @TableID); SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderDate", DateTime.Now); // Giả sử bạn muốn sử dụng ngày hiện tại cho OrderDate
                    command.Parameters.AddWithValue("@CustomerID", DBNull.Value); // Chưa xác định khách hàng nên để null
                    command.Parameters.AddWithValue("@TotalAmount", 0); // Khởi tạo TotalAmount là 0
                    command.Parameters.AddWithValue("@TableID", tableID); // Sử dụng TableID đã lấy được từ bảng Table

                    // Thực thi truy vấn và lấy ra OrderID của bản ghi mới được chèn
                    orderID = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating new order: " + ex.Message);
                }
            }
        }

        private void btnGoDownMenu_Click(object sender, EventArgs e)
        {
            int change = flpMenu.VerticalScroll.Value + flpMenu.VerticalScroll.SmallChange * 30;
            flpMenu.AutoScrollPosition = new Point(0, change);
        }

        private void btnGoUpMenu_Click(object sender, EventArgs e)
        {
            int change = flpMenu.VerticalScroll.Value - flpMenu.VerticalScroll.SmallChange * 30;
            flpMenu.AutoScrollPosition = new Point(0, change);
        }

        // Hàm thêm sản phẩm vào đơn hàng
        private void AddFoodToOrder(string productName, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Lấy ProductID từ bảng Product dựa vào ProductName
                    string getProductIDQuery = "SELECT ProductID FROM Product WHERE ProductName = @ProductName;";
                    SqlCommand getProductIDCommand = new SqlCommand(getProductIDQuery, connection);
                    getProductIDCommand.Parameters.AddWithValue("@ProductName", productName);
                    int productID = (int)getProductIDCommand.ExecuteScalar();

                    // Thực thi truy vấn SQL để chèn một bản ghi mới vào bảng OrderDetail
                    string insertOrderDetailQuery = "INSERT INTO OrderDetail (OrderID, ProductID, Quantity, Price) VALUES (@OrderID, @ProductID, @Quantity, @Price);";
                    SqlCommand insertOrderDetailCommand = new SqlCommand(insertOrderDetailQuery, connection);
                    insertOrderDetailCommand.Parameters.AddWithValue("@OrderID", orderID); // Sử dụng orderID đã lưu từ trước
                    insertOrderDetailCommand.Parameters.AddWithValue("@ProductID", productID);
                    insertOrderDetailCommand.Parameters.AddWithValue("@Quantity", quantity);

                    // Lấy giá của sản phẩm từ bảng Product
                    string getProductPriceQuery = "SELECT Price FROM Product WHERE ProductID = @ProductID;";
                    SqlCommand getProductPriceCommand = new SqlCommand(getProductPriceQuery, connection);
                    getProductPriceCommand.Parameters.AddWithValue("@ProductID", productID);
                    decimal price = (decimal)getProductPriceCommand.ExecuteScalar();
                    insertOrderDetailCommand.Parameters.AddWithValue("@Price", price * quantity); // Giá của sản phẩm được tính bằng giá của sản phẩm nhân với số lượng

                    // Thực thi truy vấn chèn dữ liệu vào bảng OrderDetail
                    insertOrderDetailCommand.ExecuteNonQuery();

                    // Cập nhật dữ liệu trong listBoxPurchased
                    listBoxPurchased_SelectedIndexChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding food to order: " + ex.Message);
                }
            }
        }

        private void btnAddCafeMuoi_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Cafe Muối", 1); // Thêm sản phẩm "Cafe Muoi" với số lượng 1 vào đơn hàng
        }

        private void btnAddTraChanh_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Trà Chanh", 1); // Thêm sản phẩm "Tra Chanh" với số lượng 1 vào đơn hàng
        }

        private void listBoxPurchased_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPurchased.Items.Clear(); // Xóa danh sách sản phẩm hiện có trong listBox

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn SQL để lấy danh sách chi tiết các sản phẩm từ bảng OrderDetail
                    string query = "SELECT Product.ProductName, OrderDetail.Quantity, OrderDetail.Price FROM OrderDetail INNER JOIN Product ON OrderDetail.ProductID = Product.ProductID WHERE OrderDetail.OrderID = @OrderID;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderID", orderID);

                    // Đọc dữ liệu từ SqlDataReader và thêm vào listBox
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader["ProductName"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            listBoxPurchased.Items.Add(productName + " - Quantity: " + quantity + " - Price: $" + price);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving order details: " + ex.Message);
                }
            }
        }

        private void btnBackToTable_Click(object sender, EventArgs e)
        {
            TableForOrder table = new TableForOrder();
            table.Show();
            this.Close();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnPayOrder_Click(object sender, EventArgs e)
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

                    // Cập nhật tổng giá vào bảng Order
                    string updateQuery = "UPDATE [Order] SET TotalAmount = @TotalAmount WHERE OrderID = @OrderID;";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    updateCommand.Parameters.AddWithValue("@OrderID", orderID);
                    updateCommand.ExecuteNonQuery();

                    // MessageBox.Show("Tổng số tiền đã được cập nhật thành công: $" + totalAmount);
                    Payment paymentForm = new Payment(orderID, tableName);
                    paymentForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error paying order: " + ex.Message);
                }
            }
        }

        private void btnAddTraDen_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Black Tea", 1);
        }

        private void MenuOrder_Load(object sender, EventArgs e)
        {
            createNewOrder();
        }

        private void btnAddBanhMiXiuMai_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Bánh mì xíu mại", 1);
        }

        private void btnAddCappuccino_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Cappuccino", 1);
        }

        private void btnAddBacXiu_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Bạc Xỉu", 1);
        }

        private void btnAddEspresso_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Espresso", 1);
        }

        private void btnAddLatte_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Latte", 1);
        }

        private void btnAddGreenTea_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Green Tea", 1);
        }

        private void btnAddMatchaLatte_Click(object sender, EventArgs e)
        {
            AddFoodToOrder("Matcha Latte", 1);
        }
    }
}
