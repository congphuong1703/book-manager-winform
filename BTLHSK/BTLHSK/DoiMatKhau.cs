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

namespace BTLHSK
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void quaylaibtn_Click(object sender, EventArgs e)
        {
            ViewTaiKhoan viewTaiKhoan = new ViewTaiKhoan();
            viewTaiKhoan.Show();
            this.Hide();
        }

        private void doimatkhaubtn_Click(object sender, EventArgs e)
        {

        }

        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;             
        }

        public void check()
        {
            if (!matkhaumoi.Equals(xacnhan))
            {
                const string message = "Mật khẩu sai!";
                const string caption = "Đăng nhập";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
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
            }
            connect.Close();
        }

        private void doimatkhaubtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            check();
        }
    }
}
