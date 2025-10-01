# 📌 Lập trình mạng căn bản  
**Bài tập: Viết ứng dụng quản lý người dùng với tính năng đăng nhập, đăng ký**

---

## 👥 Thành viên nhóm
| MSSV      | Họ và tên              | Tài khoản GitHub            |
|-----------|------------------------|-----------------------------|
| 24520949  | Khương Thành Lên       | [ThanhLen-Hoc-IT](https://github.com/ThanhLen-Hoc-IT) |
| 24521977  | Huỳnh Hoàng Tứ Văn     | [huynhhoangtuvan-ops](https://github.com/huynhhoangtuvan-ops) |
| 24521135  | Trần Kim Ngân          | [Kylna-ops](https://github.com/Kylna-ops) |
| 24521831  | Huỳnh Minh Trí         | [trihuynhminh](https://github.com/trihuynhminh) |
| 24522056  | Lê Nguyễn Phương Vy    | [PVL-cyber](https://github.com/PVL-cyber) |

---

## 🎯 Mục tiêu
- Tạo ứng dụng **Windows Forms (C#)** với tính năng **đăng nhập** và **đăng ký người dùng**.  
- Lưu trữ thông tin người dùng vào **SQL Server**.  

---

## 📖 Yêu cầu chi tiết
### 1. Giao diện người dùng (2.5đ)
- Form **Đăng nhập** và **Đăng ký** (theo phân tích ở bài tập 2.1).  
- Form chính hiển thị thông tin sau khi đăng nhập thành công.  

### 2. Chức năng Đăng ký (2.5đ)
- Kiểm tra dữ liệu hợp lệ:
  - Mật khẩu = Xác nhận mật khẩu.  
  - Email đúng định dạng.  
  - Username chưa tồn tại trong CSDL.  
- Mã hóa mật khẩu trước khi lưu (SHA-256).  
- Lưu dữ liệu vào bảng **Users** trong SQL Server.  

### 3. Chức năng Đăng nhập (2.5đ)
- Kiểm tra thông tin với dữ liệu trong CSDL.  
- Hiển thị lỗi nếu đăng nhập thất bại.  
- Vào form chính nếu thành công.  

### 4. Cơ sở dữ liệu (1đ)
- Bảng `Users` ví dụ:  
  ```sql
  UserId (int, primary key),  
  Username (nvarchar),  
  Password (nvarchar),  
  Email (nvarchar)
### 5. Mã hóa mật khẩu (0.5đ)
- Sử dụng **SHA-256** (hoặc thuật toán mã hóa khác) để bảo mật mật khẩu trước khi lưu vào cơ sở dữ liệu.  
- Khi đăng nhập, mật khẩu người dùng nhập vào sẽ được **mã hóa lại** rồi so sánh với mật khẩu đã lưu trong CSDL.  

### 6. Yêu cầu bổ sung (1đ)
- Thiết kế giao diện **thân thiện, dễ sử dụng**.  
- Đặt **tên biến, tên file** rõ ràng, có ý nghĩa.  
- Xử lý tốt **Exception** và hiển thị thông báo lỗi thân thiện với người dùng.  

## III. Hướng dẫn thực hiện cơ bản

### 🔹 Bước 1: Tạo dự án
- Sử dụng **Visual Studio** để tạo dự án **Windows Forms App (C#)**.

### 🔹 Bước 2: Tạo cơ sở dữ liệu
- Tạo cơ sở dữ liệu **UserDB** và bảng **Users** trong SQL Server.

### 🔹 Bước 3: Viết mã C#
- Xử lý các chức năng **Đăng nhập** và **Đăng ký** người dùng.

### 🔹 Bước 4: Kiểm tra
- Đảm bảo ứng dụng hoạt động đúng yêu cầu đề bài.


