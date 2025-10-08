using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Register.Utils;

namespace Login_Register.Forms
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.IsEmpty(TenDangNhap.Text))
            {
                MessageBox.Show("Ten dang nhap khong duoc de trong");
            }
            if (ValidationHelper.IsEmpty(EmailDangNhap.Text))
            {
                MessageBox.Show("Email khong duoc de trong");
            }
            if (ValidationHelper.IsEmpty(MatKhau.Text))
            {
                MessageBox.Show("Mat khau khong duoc de trong");
            }
            if (ValidationHelper.IsEmpty(XacNhanMatkhau.Text))
            {
                MessageBox.Show("Xac nhan mat khau khong duoc de trong");
            }
            if (!ValidationHelper.IsValidEmail(EmailDangNhap.Text))
            {
                MessageBox.Show("Email khong hop le");
            }
            if (!ValidationHelper.IsValidPassword(MatKhau.Text))
            {
                MessageBox.Show("Mat khau phai co it nhat 6 ky tu");
            }
            if (!ValidationHelper.IsPasswordMatch(MatKhau.Text, XacNhanMatkhau.Text))
            {
                MessageBox.Show("Mat khau va xac nhan mat khau khong trung khop");
            }

            // --- Sau khi kiểm tra hợp lệ ---
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    string Ten = TenDangNhap.Text;
                    string Email = EmailDangNhap.Text;
                    string MatKhauStr = MatKhau.Text;
                    cmd.Parameters.AddWithValue("@Username", Ten);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", MatKhauStr); // sau này sẽ hash

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi lưu vào database!");
                    }
                }
            }
        }
}
