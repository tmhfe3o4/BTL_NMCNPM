using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace main
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            model.Login.GetInstant.strConnection = @"C:\USERS\BEART\DESKTOP\CNPM\APP_DATA\DATABASE.MDF";
            fGetView();
        }

        private void fGetView()
        {
            model.Login.GetInstant.email = login_email.Value;
            model.Login.GetInstant.password = login_passowrd.Value;
        }

        private void login(object sender, EventArgs e)
        {
            if (checkUI(model.Login.GetInstant.email, model.Login.GetInstant.password))
            {
                using (SqlConnection cn = new SqlConnection(model.Login.GetInstant.strConnection))
                {
                    cn.Open();
                    SqlCommand com;
                    SqlDataReader reader;
                    String sql;
                    Boolean result = false;

                    sql = "SELECT * from tbl_tai_khoan where tbl_tai_khoan.emal = " + model.Login.GetInstant.email + "and tbl_tai_khoan.matkhau = " + model.Login.GetInstant.password;
                    com = new SqlCommand(sql, cn);

                    reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetValue.ToString.Equals(""))
                        {

                        }
                    }
                    cn.Close();
                }
            }
        }
        private Boolean checkUI(String email, String password)
        {
            if (!checkEmail(email).Equals("") && !checkPassword(password).Equals(""))
            {
                return true;
            }
            return false;
        }

        private Boolean checkEmail(String email)
        {
            return false;
        }
        private Boolean checkPassword(String password)
        {
            return false;
        }
    }
}