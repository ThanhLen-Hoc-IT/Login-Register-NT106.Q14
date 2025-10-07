/*Loại file: C# Class (Data Model)

Chức năng: Đại diện cho đối tượng dữ liệu (User) — thường ánh xạ 1:1 với bảng trong database.

Thuộc tầng: Models

Đặc điểm:

Không chứa logic xử lý, chỉ có các thuộc tính (properties).

Mỗi thuộc tính tương ứng với một cột trong bảng SQL.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string Email { get; set; }
    }
}
