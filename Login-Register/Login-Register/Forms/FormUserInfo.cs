using Login_Register.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing; // thêm dòng này để làm việc với hình ảnh

namespace Login_Register
{
    public partial class FormUserInfo : Form
    {
        private string _username;

        // Nhận username từ form đăng nhập
        public FormUserInfo(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin người dùng";
            LoadUserInfo();

            
        }

        private void LoadUserInfo()
        {
            try
            {
                string connString = "Server=localhost;Database=UserManagementDB;User Id=sa;Password=1234;";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT Username, Email FROM Users WHERE Username = @username";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", _username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblDisplayUsername.Text = reader["Username"].ToString();
                        lblDisplayEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng trong cơ sở dữ liệu!",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new s(); // class đăng nhập của bạn
            loginForm.Show();
            this.Close();
        }

        private void picSticker_Click(object sender, EventArgs e)
        {

        }

        // 🌟 HÀM MỚI — hiển thị sticker khi form mở
       

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
