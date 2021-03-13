using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTLHSK
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            check();
        }

        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void loginBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                check();
            }
        }

        public void check()
        {
            SqlConnection connect = openSQL();
            string query = "select * from tblTaiKhoan where taikhoan = '" + taiKhoan.Text + "'and matkhau = '" + matKhau.Text + "';";

            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                ViewTaiKhoan view = new ViewTaiKhoan();
                view.Show();
                this.Hide();
            }
            else
            {
                const string message = "Tài khoản hoặc mật khẩu sai!";
                const string caption = "Đăng nhập";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                taiKhoan.Focus();
            }
            connect.Close();
        }

        private void hienckb_CheckedChanged(object sender, EventArgs e)
        {
            matKhau.PasswordChar = hienckb.Checked ? '\0' : '*';
        }
    }
}
