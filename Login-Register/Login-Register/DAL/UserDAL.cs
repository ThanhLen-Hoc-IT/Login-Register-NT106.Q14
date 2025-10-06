/* 
Loại file: C# Class (Business/Data Layer)

Chức năng: Thực hiện các truy vấn CRUD (Create, Read, Update, Delete) tới cơ sở dữ liệu SQL Server.

Thuộc tầng: DAL (Data Access Layer)

Đặc điểm:
- Gọi các hàm từ DatabaseHelper để kết nối và chạy SQL.
- Trả về các đối tượng User hoặc DataTable cho tầng giao diện (UI).
*/

using System;
using System.Data;
using System.Data.SqlClient;
using Login_Register.Models;
using Login_Register.Utils;
using Login_Register.Utlis;

namespace Login_Register.DAL
{
    public static class UserDAL
    {
        // ✅ Kiểm tra username đã tồn tại hay chưa
        public static bool IsUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username=@u";
            SqlParameter[] parameters = { new SqlParameter("@u", username) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        // ✅ Thêm người dùng mới (đăng ký)
        public static void RegisterUser(User user)
        {
            // Hash mật khẩu trước khi lưu
            string hashedPassword = PasswordHash.HashPassword(user.Password);

            string query = "INSERT INTO Users (Username, HashedPassword, Email) VALUES (@u, @p, @e)";
            SqlParameter[] parameters = {
                new SqlParameter("@u", user.Username),
                new SqlParameter("@p", hashedPassword),
                new SqlParameter("@e", user.Email)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // ✅ Đăng nhập người dùng
        public static User Login(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username=@u";
            SqlParameter[] parameters = { new SqlParameter("@u", username) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            // Không có user nào khớp tên đăng nhập
            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            string storedHash = row["HashedPassword"].ToString();

            // So sánh mật khẩu nhập với mật khẩu đã hash trong DB
            if (!PasswordHash.VerifyPassword(password, storedHash))
                return null;

            // Đăng nhập thành công -> trả về đối tượng User
            return new User
            {
                UserId = (int)row["UserId"],
                Username = row["Username"].ToString(),
                Email = row["Email"].ToString()
            };
        }
    }
}


//CACH DU DUNG
//Vi du:  UserDAL.IsUsernameExist(username)