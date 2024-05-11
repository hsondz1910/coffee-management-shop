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
    public partial class Register : Form
    {
        String connString = @"Data Source=DESKTOP-L43D2I1\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True";
        SqlConnection sqlConn = null;

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã hóa mật khẩu bằng bcrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            // Kiểm tra xem username đã tồn tại trong cơ sở dữ liệu chưa
            if (IsUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo câu lệnh SQL INSERT
            string insertQuery = "INSERT INTO [User] (Username, Password, PhoneNumber, Email) VALUES (@Username, @Password, @PhoneNumber, @Email)";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                try
                {
                    sqlConn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, sqlConn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        // Thực thi câu lệnh SQL INSERT
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsUsernameExists(string username)
        {
            // Tạo câu lệnh SQL SELECT để kiểm tra xem username đã tồn tại trong cơ sở dữ liệu chưa
            string selectQuery = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";

            // Mở kết nối đến cơ sở dữ liệu
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(selectQuery, sqlConn))
                {
                    // Thêm tham số cho câu lệnh SQL SELECT
                    cmd.Parameters.AddWithValue("@Username", username);

                    sqlConn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    // Nếu count > 0, tức là username đã tồn tại
                    return count > 0;
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
