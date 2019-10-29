using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace main.ui.login
{
    public partial class Register : System.Web.UI.Page
    {
        String constr = @"Data Source=DESKTOP-5IV9CDJ\SQLEXPRESS;Initial Catalog=BTLLogin;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            String sql = "select count(*) from tbl_tai_khoan where email='" + txtEmail.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            int i = (int)cmd.ExecuteScalar();
            if (i > 0)
            {
                lblThongbao.Text = "Tài khoản đã có người sử dụng, vui lòng đặt lại tên!";

            }
            else
            {
                string insert = "insert into tbl_tai_khoan(email, mat_khau) values('" + txtEmail.Text + "','" + txtPassword.Text + "')";
                SqlCommand cmd1 = new SqlCommand(insert, cnn);
                int j = (int)cmd1.ExecuteNonQuery();
                if (j > 0)
                {
                    lblThongbao.Text = "Bạn đã đăng kí thành công!";
                    txtEmail.Text = "";
                }
                else
                {
                    lblThongbao.Text = " Đăng kí thất bại, vui lòng kiểm tra lại!";
                }
            }

        }

    }
}