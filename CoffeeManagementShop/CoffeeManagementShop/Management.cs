using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CoffeeManagementShop
{
    public partial class CoffeeManagement : Form
    {
        String connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        SqlConnection sqlConn = null;

        public CoffeeManagement()
        {
            InitializeComponent();
        }

        private void CoffeeManagement_Load(object sender, EventArgs e)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                sqlConn = new SqlConnection(connString);
                sqlConn.Open();

                // Tạo truy vấn SQL để lấy dữ liệu từ bảng Product
                string query = "SELECT ProductID, ProductName, Price, CategoryID FROM Product";
                string queryOrder = "SELECT * FROM [Order]";
                string queryCustomer = "SELECT * FROM Customer";

                // Tạo đối tượng SqlDataAdapter và DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                SqlDataAdapter adapterOrder = new SqlDataAdapter(queryOrder, sqlConn);
                SqlDataAdapter adapterCustomer = new SqlDataAdapter(queryCustomer, sqlConn);
                DataTable dt = new DataTable();
                DataTable dtOrder = new DataTable();
                DataTable dtCustomer = new DataTable();

                // Đổ dữ liệu từ truy vấn vào DataTable
                adapter.Fill(dt);
                adapterOrder.Fill(dtOrder);
                adapterCustomer.Fill(dtCustomer);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                grdMenu.DataSource = dt;
                grdOrder.DataSource = dtOrder;
                grdCustomer.DataSource = dtCustomer;

                // Đóng kết nối sau khi sử dụng
                sqlConn.Close();

                LoadDataToComboBox();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                sqlConn = new SqlConnection(connString);
                sqlConn.Open();

                // Tạo truy vấn SQL để lấy dữ liệu từ bảng Product
                string query = "SELECT ProductID, ProductName, Price, CategoryID FROM Product";

                // Tạo đối tượng SqlDataAdapter và DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataTable dt = new DataTable();

                // Đổ dữ liệu từ truy vấn vào DataTable
                adapter.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                grdMenu.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        private void grdMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ các trường nhập liệu trên form
            string productName = txtProductName.Text;
            string priceText = txtPrice.Text;
            string categoryName = cbCategory.Text; // Lấy tên danh mục sản phẩm từ ComboBox

            // Kiểm tra xem có bất kỳ trường nào bị bỏ trống hay không
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tiếp tục xử lý khi dữ liệu đã được nhập đầy đủ
            try
            {
                // Chuyển đổi giá trị giá thành số thực
                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra xem sản phẩm có tồn tại trong cơ sở dữ liệu hay không
                if (IsProductExist(productName))
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Truy vấn SQL để lấy CategoryID tương ứng với CategoryName đã chọn
                    string query = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);

                    // Thực thi truy vấn và lấy CategoryID
                    int categoryID = Convert.ToInt32(command.ExecuteScalar());

                    // Tiếp tục thêm sản phẩm vào bảng Product với CategoryID đã lấy được
                    query = "INSERT INTO Product (ProductName, Price, CategoryID) VALUES (@ProductName, @Price, @CategoryID)";
                    command = new SqlCommand(query, connection);

                    // Thêm các tham số vào truy vấn SQL để tránh lỗ hổng bảo mật và xử lý dữ liệu an toàn
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Thực thi truy vấn SQL
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo khi thêm sản phẩm thành công
                    MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại dữ liệu trong DataGridView
                    LoadData();

                    // Đóng kết nối
                    // connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm được chọn
            string productName = txtProductName.Text;
            string priceText = txtPrice.Text;
            string categoryName = cbCategory.Text;
            int productId = Convert.ToInt32(grdMenu.CurrentRow.Cells["ProductID"].Value);

            // Kiểm tra xem có bất kỳ trường nào bị bỏ trống hay không
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tiếp tục xử lý khi dữ liệu đã được nhập đầy đủ
            try
            {
                // Chuyển đổi giá trị giá thành số thực
                if (!decimal.TryParse(priceText, out decimal price))
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Lấy CategoryID tương ứng với CategoryName đã chọn
                    string query = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    int categoryID = Convert.ToInt32(command.ExecuteScalar());

                    // Kiểm tra xem tên sản phẩm mới đã nhập có trùng với bất kỳ sản phẩm nào khác trong cơ sở dữ liệu hay không
                    if (IsProductNameExist(productName, productId))
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật thông tin sản phẩm
                    query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, CategoryID = @CategoryID WHERE ProductID = @ProductID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.ExecuteNonQuery();

                    // Hiển thị thông báo khi chỉnh sửa sản phẩm thành công
                    MessageBox.Show("Sản phẩm đã được chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại dữ liệu trong DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không và giá trị không phải là DBNull
            if (e.RowIndex >= 0 && grdMenu.Rows[e.RowIndex].Cells["CategoryID"].Value != DBNull.Value)
            {
                DataGridViewRow row = this.grdMenu.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                // Lấy CategoryID từ hàng được chọn
                int categoryID = Convert.ToInt32(row.Cells["CategoryID"].Value);

                // Tìm tên danh mục sản phẩm tương ứng với CategoryID và hiển thị nó trong cbCategory
                string categoryName = GetCategoryName(categoryID);
                cbCategory.Text = categoryName;
            }
            else
            {
                // Hiển thị thông báo lỗi khi chọn vào hàng rỗng hoặc giá trị DBNull
                MessageBox.Show("Vui lòng chọn một hàng có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCategoryName(int categoryID)
        {
            string categoryName = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = "SELECT CategoryName FROM Category WHERE CategoryID = @CategoryID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    categoryName = command.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lấy tên danh mục sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return categoryName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn sản phẩm để xóa chưa
            if (grdMenu.SelectedRows.Count > 0)
            {
                // Lấy ProductID của sản phẩm được chọn từ DataGridView
                int productId = Convert.ToInt32(grdMenu.SelectedRows[0].Cells["ProductID"].Value);

                try
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();

                        // Tạo truy vấn SQL để xóa sản phẩm
                        string query = "DELETE FROM Product WHERE ProductID = @ProductID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ProductID", productId);

                        // Thực thi truy vấn SQL để xóa sản phẩm
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi xóa sản phẩm thành công
                            MessageBox.Show("Sản phẩm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật lại dữ liệu trong DataGridView
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchProductByName(string productName)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để tìm kiếm sản phẩm dựa vào ProductName
                    string query = "SELECT ProductID, ProductName, Price, CategoryID FROM Product WHERE ProductName LIKE '%' + @ProductName + '%'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ truy vấn vào DataTable
                    adapter.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    grdMenu.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm với ProductName từ TextBox txtSearchProductName
            SearchProductByName(txtSearchProductName.Text);
        }

        private void cbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên danh mục đã chọn từ ComboBox
            string selectedCategory = cbCategoryList.SelectedItem.ToString();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Truy vấn SQL để lấy CategoryID tương ứng với CategoryName đã chọn
                    string query = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryName", selectedCategory);

                    // Lấy CategoryID
                    int categoryID = Convert.ToInt32(command.ExecuteScalar());

                    // Truy vấn SQL để lấy các sản phẩm có CategoryID tương ứng
                    query = "SELECT ProductID, ProductName, Price FROM Product WHERE CategoryID = @CategoryID";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Tạo đối tượng SqlDataAdapter và DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ truy vấn vào DataTable
                    adapter.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    grdMenu.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi lấy dữ liệu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsProductNameExist(string productName, int currentProductId)
        {
            bool isExist = false;
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để kiểm tra xem sản phẩm có tồn tại không
                    // và không trùng với sản phẩm đang được chỉnh sửa (dựa vào ProductID)
                    string query = "SELECT COUNT(*) FROM Product WHERE ProductName = @ProductName AND ProductID <> @ProductID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ProductID", currentProductId);

                    // Thực thi truy vấn và kiểm tra kết quả
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        isExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi kiểm tra sự tồn tại của tên sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isExist;
        }

        private bool IsProductExist(string productName)
        {
            bool isExist = false;
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để kiểm tra xem sản phẩm có tồn tại không
                    string query = "SELECT COUNT(*) FROM Product WHERE ProductName = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    // Thực thi truy vấn và kiểm tra kết quả
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        isExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi kiểm tra sự tồn tại của sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isExist;
        }

        // check input
        private bool ValidateInputs()
        {
            // Kiểm tra các trường nhập liệu và hiển thị cảnh báo nếu thiếu thông tin
            if (string.IsNullOrWhiteSpace(txtCustomerForCheckID.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập tổng số tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem có chọn hàng nào trong DataGridView không
            if (grdOrder.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem đã chọn tableId nào hay chưa
            if (string.IsNullOrWhiteSpace(txtTableIdOrder.Text))
            {
                MessageBox.Show("Vui lòng chọn một Table ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem đã nhập đúng định dạng số tiền hay chưa
            if (!decimal.TryParse(txtTotalAmount.Text, out _))
            {
                MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập số tiền dưới dạng số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường nhập liệu đã hợp lệ chưa trước khi cập nhật đơn hàng
            if (!ValidateInputs())
            {
                return;
            }

            // Lấy thông tin từ các control
            DateTime orderDate = dtpOrder.Value;
            string customerName = txtCustomerForCheckID.Text;
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            int tableId = Convert.ToInt32(txtTableIdOrder.Text);

            // Kiểm tra xem khách hàng có tồn tại trong bảng Customer hay không
            int customerId = FindCustomerIdByName(customerName);

            if (customerId == -1)
            {
                // Thêm khách hàng mới nếu không tồn tại
                customerId = AddNewCustomer(customerName);
            }

            // Thêm đơn hàng vào cơ sở dữ liệu
            AddOrder(orderDate, customerId, totalAmount, tableId);
            LoadDataOrder();

            // Cập nhật giao diện hoặc thông báo thành công
            MessageBox.Show("Đã thêm đơn hàng thành công!");
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường nhập liệu đã hợp lệ chưa trước khi cập nhật đơn hàng
            if (!ValidateInputs())
            {
                return;
            }

            // Lấy thông tin từ các control
            DateTime orderDate = dtpOrder.Value;
            string customerName = txtCustomerForCheckID.Text;
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            int orderId = Convert.ToInt32(grdOrder.CurrentRow.Cells["OrderID"].Value);
            int tableId = Convert.ToInt32(txtTableIdOrder.Text);

            // Kiểm tra xem khách hàng có tồn tại trong bảng Customer hay không
            int customerId = FindCustomerIdByName(customerName);

            if (customerId == -1)
            {
                // Thêm khách hàng mới nếu không tồn tại
                customerId = AddNewCustomer(customerName);
            }

            // Cập nhật thông tin của đơn hàng trong cơ sở dữ liệu
            UpdateOrder(orderId, orderDate, customerId, totalAmount, tableId);
            LoadDataOrder();

            // Cập nhật giao diện hoặc thông báo thành công
            MessageBox.Show("Đã cập nhật đơn hàng thành công!");
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Lấy orderId từ TextBox
            int orderId = int.Parse(txtOrderID.Text);

            // Xóa đơn hàng khỏi cơ sở dữ liệu
            DeleteOrder(orderId);
            LoadDataOrder();

            // Cập nhật giao diện hoặc thông báo thành công
            MessageBox.Show("Đã xóa đơn hàng thành công!");
        }

        // Hàm tìm ID của khách hàng dựa trên tên
        private int FindCustomerIdByName(string customerName)
        {
            // Thực hiện truy vấn trong cơ sở dữ liệu để tìm ID của khách hàng
            // Trả về -1 nếu không tìm thấy

            int customerId = -1; // Khởi tạo customerId với giá trị mặc định -1

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để lấy ID của khách hàng dựa trên tên
                    string query = "SELECT CustomerID FROM Customer WHERE CustomerName = @CustomerName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerName", customerName);

                    // Thực thi truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem kết quả có null hay không
                    if (result != null)
                    {
                        customerId = Convert.ToInt32(result); // Gán customerId bằng giá trị ID của khách hàng
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm ID của khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return customerId;
        }

        // Hàm thêm khách hàng mới vào cơ sở dữ liệu
        private int AddNewCustomer(string customerName)
        {
            // Thực hiện thêm khách hàng mới vào cơ sở dữ liệu
            // Trả về ID của khách hàng vừa được thêm vào

            int customerId = -1; // Khởi tạo customerId với giá trị mặc định -1

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để thêm khách hàng mới
                    string query = "INSERT INTO Customer (CustomerName) VALUES (@CustomerName); SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerName", customerName);

                    // Thực thi truy vấn và lấy ID của khách hàng mới được thêm vào
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerId = Convert.ToInt32(result); // Gán customerId bằng giá trị ID của khách hàng mới
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return customerId;
        }

        // Hàm thêm đơn hàng vào cơ sở dữ liệu
        private void AddOrder(DateTime orderDate, int customerId, decimal totalAmount, int tableId)
        {
            // Thực hiện thêm đơn hàng vào cơ sở dữ liệu

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = "INSERT INTO [Order] (OrderDate, CustomerID, TotalAmount, TableID) VALUES (@OrderDate, @CustomerID, @TotalAmount, @TableID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@TableID", tableId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm cập nhật thông tin đơn hàng trong cơ sở dữ liệu
        private void UpdateOrder(int orderId, DateTime orderDate, int customerId, decimal totalAmount, int tableId)
        {
            // Thực hiện cập nhật thông tin của đơn hàng trong cơ sở dữ liệu

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string query = "UPDATE [Order] SET OrderDate = @OrderDate, CustomerID = @CustomerID, TotalAmount = @TotalAmount, TableID = @TableID WHERE OrderID = @OrderID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@TableID", tableId);
                    command.Parameters.AddWithValue("@OrderID", orderId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xóa đơn hàng khỏi cơ sở dữ liệu
        private void DeleteOrder(int orderId)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này? Thao tác này sẽ ảnh hưởng tới các bản ghi liên quan trong bảng OrderDetail, Payment và Customer.", "Xác nhận xóa đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Kiểm tra lựa chọn của người dùng
                    if (result == DialogResult.Yes)
                    {
                        // Xóa các bản ghi liên quan trong bảng OrderDetail
                        string deleteOrderDetailQuery = "DELETE FROM OrderDetail WHERE OrderID = @OrderID";
                        SqlCommand deleteOrderDetailCommand = new SqlCommand(deleteOrderDetailQuery, connection);
                        deleteOrderDetailCommand.Parameters.AddWithValue("@OrderID", orderId);
                        deleteOrderDetailCommand.ExecuteNonQuery();

                        // Xóa các bản ghi liên quan trong bảng Payment
                        string deletePaymentQuery = "DELETE FROM Payment WHERE OrderID = @OrderID";
                        SqlCommand deletePaymentCommand = new SqlCommand(deletePaymentQuery, connection);
                        deletePaymentCommand.Parameters.AddWithValue("@OrderID", orderId);
                        deletePaymentCommand.ExecuteNonQuery();

                        // Xóa đơn hàng từ bảng Order
                        string deleteOrderQuery = "DELETE FROM [Order] WHERE OrderID = @OrderID";
                        SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection);
                        deleteOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                        deleteOrderCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        // Người dùng không đồng ý, không thực hiện việc xóa
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataOrder()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                sqlConn = new SqlConnection(connString);
                sqlConn.Open();

                // Tạo truy vấn SQL để lấy dữ liệu từ bảng Product
                string query = "SELECT * FROM [Order]";

                // Tạo đối tượng SqlDataAdapter và DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn);
                DataTable dt = new DataTable();

                // Đổ dữ liệu từ truy vấn vào DataTable
                adapter.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                grdOrder.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        private void grdOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào dòng (row) không
            if (e.RowIndex >= 0)
            {
                // Lấy ra dòng (row) được chọn
                DataGridViewRow row = grdOrder.Rows[e.RowIndex];

                // Khai báo biến để lưu trữ giá trị từ cell
                int orderId = 0;
                DateTime orderDate = DateTime.MinValue;
                int customerId = 0;
                decimal totalAmount = 0;
                int tableId = 0;

                // Kiểm tra và chuyển đổi giá trị từ DBNull sang kiểu dữ liệu mong muốn
                if (row.Cells["OrderID"].Value != DBNull.Value)
                    orderId = Convert.ToInt32(row.Cells["OrderID"].Value);

                if (row.Cells["OrderDate"].Value != DBNull.Value)
                    DateTime.TryParse(row.Cells["OrderDate"].Value.ToString(), out orderDate);

                if (row.Cells["CustomerID"].Value != DBNull.Value)
                    customerId = Convert.ToInt32(row.Cells["CustomerID"].Value);

                if (row.Cells["TotalAmount"].Value != DBNull.Value)
                    totalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value);

                if (row.Cells["TableID"].Value != DBNull.Value)
                    tableId = Convert.ToInt32(row.Cells["TableID"].Value);

                // Truy vấn SQL để lấy CustomerName từ CustomerID
                string customerName = GetCustomerName(customerId);

                // Hiển thị thông tin trong các control tương ứng
                txtOrderID.Text = orderId.ToString();
                if (orderDate != DateTime.MinValue)
                    dtpOrder.Value = orderDate;
                txtCustomerForCheckID.Text = customerName; // Hiển thị CustomerName thay vì CustomerID
                txtTotalAmount.Text = totalAmount.ToString();
                txtTableIdOrder.Text = tableId.ToString();
            }
        }

        // Hàm truy vấn SQL để lấy CustomerName từ CustomerID
        private string GetCustomerName(int customerId)
        {
            string customerName = string.Empty;

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để lấy CustomerName từ CustomerID
                    string query = "SELECT CustomerName FROM Customer WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    // Thực thi truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        customerName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Đã xảy ra lỗi khi truy xuất CustomerName: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return customerName;
        }

        private void txtSearchOrderID_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ ô txtSearchOrderID
            string searchValue = txtSearchOrderID.Text.Trim();

            // Kiểm tra xem ô nhập liệu có rỗng không
            if (string.IsNullOrEmpty(searchValue))
            {
                // Nếu rỗng, hiển thị lại toàn bộ dữ liệu
                LoadDataOrder();
            }
            else
            {
                try
                {
                    // Kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();

                        // Tạo truy vấn SQL để tìm kiếm OrderID trong bảng [Order]
                        string query = "SELECT * FROM [Order] WHERE OrderID = @OrderID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@OrderID", searchValue);

                        // Tạo đối tượng SqlDataAdapter và DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();

                        // Đổ dữ liệu từ truy vấn vào DataTable
                        adapter.Fill(dt);

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        grdOrder.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các textbox có được nhập đầy đủ hay không
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin từ các textbox
            string customerName = txtCustomerName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để thêm khách hàng vào cơ sở dữ liệu
                    string query = "INSERT INTO Customer (CustomerName, Phone, Address) VALUES (@CustomerName, @Phone, @Address)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);

                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có thêm thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại dữ liệu trong DataGridView
                        LoadCustomerData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để lấy dữ liệu khách hàng từ cơ sở dữ liệu
                    string query = "SELECT * FROM Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();

                    // Đổ dữ liệu từ truy vấn vào DataTable
                    adapter.Fill(dt);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    grdCustomer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các textbox có được nhập đầy đủ hay không
            if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin từ các textbox
            string customerID = txtCustomerID.Text;
            string customerName = txtCustomerName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để cập nhật thông tin khách hàng trong cơ sở dữ liệu
                    string query = "UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone, Address = @Address WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);

                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có cập nhật thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại dữ liệu trong DataGridView
                        LoadCustomerData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng để cập nhật hoặc thông tin không thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCustomerOrders(string customerID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Tạo truy vấn SQL để kiểm tra xem có đơn hàng nào tham chiếu đến khách hàng không
                string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Lấy ID của khách hàng từ textbox
            string customerID = txtCustomerID.Text;

            try
            {
                // Kiểm tra xem có đơn hàng nào tham chiếu đến khách hàng đó hay không
                bool hasOrders = CheckCustomerOrders(customerID);

                if (hasOrders)
                {
                    MessageBox.Show("Không thể xóa khách hàng vì còn đơn hàng liên quan đến khách hàng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu không có đơn hàng tham chiếu đến khách hàng, tiến hành xóa khách hàng
                DeleteCustomer(customerID);

                MessageBox.Show("Xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomerData();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCustomer(string customerID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Tạo truy vấn SQL để xóa khách hàng từ cơ sở dữ liệu
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                // Thực thi truy vấn
                command.ExecuteNonQuery();
            }
        }

        private void btnBackToTable_Click(object sender, EventArgs e)
        {
            TableForOrder table = new TableForOrder();
            table.Show();
            this.Hide();
        }

        private void grdOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có chọn hàng nào trong DataGridView không
            if (e.RowIndex >= 0)
            {
                // Lấy id của order từ hàng được chọn
                int orderId = Convert.ToInt32(grdOrder.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Mở form chi tiết và truyền id của order đó vào form
                OrderDetail orderDetailForm = new OrderDetail(orderId);
                orderDetailForm.Show();
                this.Hide();
            }
        }

        private void btnBackToTableFromOrderManagement_Click(object sender, EventArgs e)
        {
            TableForOrder table = new TableForOrder();
            table.Show();
            this.Hide();
        }

        private void btnCloseFromMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseFromOrder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToTableFromCustomerManagement_Click(object sender, EventArgs e)
        {
            TableForOrder table = new TableForOrder();
            table.Show();
            this.Hide();
        }

        private void btnCloseFromCustomer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDate.SelectedItem != null)
                {
                    // Lấy ngày được chọn từ ComboBox
                    DateTime selectedDate = Convert.ToDateTime(cbDate.SelectedItem);

                    // Kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();

                        // Tạo truy vấn SQL để lấy các thông tin từ bảng Order tương ứng với order date được chọn
                        string query = "SELECT * FROM [Order] WHERE CONVERT(date, OrderDate) = @SelectedDate";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                        // Tạo đối tượng SqlDataAdapter và DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dtOrder = new DataTable();

                        // Đổ dữ liệu từ truy vấn vào DataTable
                        adapter.Fill(dtOrder);

                        // Gán DataTable làm nguồn dữ liệu cho DataGridView
                        grdOrder.DataSource = dtOrder;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Tạo truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
                    string query = "SELECT DISTINCT CONVERT(date, OrderDate) AS OrderDate FROM [Order]";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thực thi truy vấn và lấy dữ liệu từ kết quả
                    SqlDataReader reader = command.ExecuteReader();

                    // Xóa các mục cũ trong ComboBox trước khi thêm mới
                    cbDate.Items.Clear();

                    // Duyệt qua các dòng dữ liệu và thêm vào ComboBox
                    while (reader.Read())
                    {
                        // Lấy giá trị từ cột "OrderDate"
                        DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);

                        // Thêm vào ComboBox
                        cbDate.Items.Add(orderDate);
                    }

                    // Đóng kết nối sau khi sử dụng
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện KeyPress của textbox txtCustomerID để chỉ cho phép nhập số
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Sự kiện TextChanged của textbox txtCustomerName để giới hạn độ dài của tên khách hàng
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length > 100)
            {
                MessageBox.Show("Tên khách hàng không được quá 100 ký tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Text = txtCustomerName.Text.Substring(0, 100);
            }
        }

        // Sự kiện KeyPress của textbox txtPhone để chỉ cho phép nhập số và giới hạn độ dài là 13 số
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPhone.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Sự kiện TextChanged của textbox txtPhone để giới hạn độ dài của số điện thoại
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 13)
            {
                MessageBox.Show("Số điện thoại không được quá 13 số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = txtPhone.Text.Substring(0, 13);
            }
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hợp lệ hay không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = grdCustomer.Rows[e.RowIndex];

                // Hiển thị thông tin từ hàng được chọn lên các TextBox tương ứng
                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void SearchCustomerByName(string customerName)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection sqlConn = new SqlConnection(connString))
                {
                    sqlConn.Open();

                    // Tạo câu truy vấn SQL để tìm kiếm khách hàng theo tên
                    string query = "SELECT * FROM Customer WHERE CustomerName LIKE @CustomerName";

                    // Tạo đối tượng SqlCommand và thêm tham số
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");

                        // Tạo đối tượng SqlDataAdapter và DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            // Đổ dữ liệu từ truy vấn vào DataTable
                            adapter.Fill(dt);

                            // Gán DataTable làm nguồn dữ liệu cho grdCustomer
                            grdCustomer.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bằng cách hiển thị thông báo lỗi
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            // Gọi phương thức tìm kiếm khách hàng khi người dùng thay đổi nội dung của textbox
            SearchCustomerByName(txtSearchCustomerName.Text);
        }
    }
}
