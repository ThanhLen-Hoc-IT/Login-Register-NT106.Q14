using System;
using System.Text.RegularExpressions;

namespace Login_Register.Utils
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Kiểm tra chuỗi có bị rỗng hoặc chỉ chứa khoảng trắng hay không
        /// </summary>
        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Kiểm tra định dạng email có hợp lệ hay không
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Kiểm tra mật khẩu có đáp ứng độ dài tối thiểu hay không (ví dụ: >= 6 ký tự)
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 6;
        }

        /// <summary>
        /// Kiểm tra mật khẩu và xác nhận mật khẩu có trùng nhau không
        /// </summary>
        public static bool IsPasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        /// <summary>
        /// Kiểm tra tên đăng nhập có hợp lệ (chỉ cho phép chữ, số, dấu gạch dưới)
        /// </summary>
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            string pattern = @"^[a-zA-Z0-9_]{3,20}$";
            return Regex.IsMatch(username, pattern);
        }
    }
}


/*if (ValidationHelper.IsEmpty(txtUsername.Text))
{
    MessageBox.Show("Tên đăng nhập không được để trống!");
    return;
}

if (!ValidationHelper.IsValidEmail(txtEmail.Text))
{
    MessageBox.Show("Email không hợp lệ!");
    return;
}

if (!ValidationHelper.IsPasswordMatch(txtPassword.Text, txtConfirm.Text))
{
    MessageBox.Show("Mật khẩu xác nhận không khớp!");
    return;
}
*/