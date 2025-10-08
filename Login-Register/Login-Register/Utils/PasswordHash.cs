using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Login_Register.Utils
{
    // SHA-256 Lưu dạng hex 64 ký tự.
    internal static class PasswordHash
    {
        // Trả về chuỗi hex (64 ký tự) của SHA-256(password)
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));

            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                    sb.Append(b.ToString("X2")); // 2 ký tự HEX/byte

                return sb.ToString(); // ví dụ: 64 ký tự HEX
            }
        }

        // So khớp password người dùng nhập với hash đã lưu (so sánh không phân biệt hoa/thường)
        public static bool VerifyPassword(string password, string storedHexHash)
        {
            if (string.IsNullOrWhiteSpace(storedHexHash) || password == null) return false;

            string inputHex = HashPassword(password);
            // Dùng so sánh hằng thời gian để tránh timing attack
            return FixedTimeEqualsHex(inputHex, storedHexHash);
        }

        private static bool FixedTimeEqualsHex(string a, string b)
        {
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
                diff |= char.ToUpperInvariant(a[i]) ^ char.ToUpperInvariant(b[i]);
            return diff == 0;
        }
    }
}