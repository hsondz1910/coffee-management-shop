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
using BCrypt.Net;

namespace CoffeeManagementShop
{
    public partial class Login : Form
    {
        String connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        SqlConnection sqlConn = null;

        public Login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo câu lệnh SQL để kiểm tra tên người dùng có tồn tại trong cơ sở dữ liệu không
            string selectUserQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand userCmd = new SqlCommand(selectUserQuery, sqlConn))
                {
                    // Thêm tham số cho câu lệnh SQL SELECT
                    userCmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                    sqlConn.Open();
                    int userCount = (int)userCmd.ExecuteScalar();

                    // Kiểm tra xem tên người dùng có tồn tại trong cơ sở dữ liệu không
                    if (userCount > 0)
                    {
                        // Nếu tên người dùng tồn tại, tiếp tục kiểm tra mật khẩu
                        string selectPasswordQuery = "SELECT Password FROM [User] WHERE Username = @Username";
                        using (SqlCommand passwordCmd = new SqlCommand(selectPasswordQuery, sqlConn))
                        {
                            // Thêm tham số cho câu lệnh SQL SELECT
                            passwordCmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                            // Lấy mật khẩu từ cơ sở dữ liệu
                            string hashedPassword = (string)passwordCmd.ExecuteScalar();

                            // Kiểm tra xem mật khẩu nhập vào có khớp với mật khẩu đã lấy từ cơ sở dữ liệu không
                            if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword))
                            {
                                // Đăng nhập thành công, mở form CoffeeManagement và đóng form Login
                                TableForOrder tableForm = new TableForOrder();
                                tableForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Hide();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được bấm có phải là phím "Enter" không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi phương thức xử lý của nút "Login"
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được bấm có phải là phím "Enter" không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi phương thức xử lý của nút "Login"
                btnLogin_Click(sender, e);
            }
        }
    }
}
