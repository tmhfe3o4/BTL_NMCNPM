using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace main.ui.manage
{
    public partial class addorder : System.Web.UI.Page
    {
        public static string strCon = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
        public static SqlConnection connectDatabase()
        {
            SqlConnection myCnn = new SqlConnection(strCon);
            myCnn.Open();
            return myCnn;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string ma = "";
            if (Request.QueryString.Count > 0)
            {
                ma = Request.QueryString["manl"];
            }

            if (!IsPostBack)
            {
                if (!ma.Equals(""))
                {
                    using (SqlConnection myCnn = connectDatabase())
                    {
                        //SqlCommand cmd = new SqlCommand("get_nguyenlieu_theoid", myCnn);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@id", ma);
                        //SqlDataReader rd = cmd.ExecuteReader();
                        //if (rd.HasRows)
                        //{
                        //    while (rd.Read())
                        //    {
                        //        txtSoban.Text = rd["ten"].ToString();
                        //        txtSoluong.Text = rd["so_luong"].ToString();
                        //        txtSoluong.Text = rd["don_gia"].ToString();
                        //        txtTenmon.Text = rd["don_vi"].ToString();
                        //    }
                        //}
                    }
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //try { 
                string soban = txtSoban.Text.Trim();
                string ngay = txtNgay.Text.Trim();
                int id_nhan_vien = Convert.ToInt32(listNhanvien.Text.Trim());
                int id_khach_hang = Convert.ToInt32(listKhachhang.Text.Trim());
                string ten_mon = txtTenmon.Text.Trim();
                int soluong = Convert.ToInt32(txtSoluong.Text);
                int id_hoadon = Convert.ToInt32(txtHoadon.Text.Trim());
                String query = "INSERT INTO [dbo].[tbl_phieu_order] ([soban],[ngay],[id_nhan_vien],[id_khach_hang],[ten_mon],[so_luong],[id_hoadon]) VALUES (@soban,@ngay,@id_nhan_vien,@id_khach_hang,@ten_mon,@so_luong,@id_hoadon)";

                using (SqlConnection connection = connectDatabase())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    //command.Parameters.AddWithValue("@id", "abc");
                    // @soban,@ngay,@id_nhan_vien,@id_khach_hang,@ten_mon,@so_luong,@id_hoadon)
                    command.Parameters.AddWithValue("@soban", soban);
                    command.Parameters.AddWithValue("@ngay", ngay);
                    command.Parameters.AddWithValue("@id_nhan_vien", id_nhan_vien);
                    command.Parameters.AddWithValue("@id_khach_hang", id_khach_hang);
                    command.Parameters.AddWithValue("@ten_mon", ten_mon);
                    command.Parameters.AddWithValue("@so_luong", soluong);
                    command.Parameters.AddWithValue("@id_hoadon", id_hoadon);

                    //connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblNoti.Text = "Thêm nguyên liệu thành công";
                        lblNoti.CssClass = "text-success";
                    }
                    else
                    {
                        lblNoti.Text = "Thêm nguyên liệu không thành công";
                        lblNoti.CssClass = "text-error";
                    }
                }
            //}
            //catch
            //{
            //    lblNoti.Text = "Thêm nguyên liệu không thành công, lỗi thông tin nhập vào.";
            //    return;
            //}

          
       
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //string tennguyenlieu = txtTenMon.Text.Trim();
            //int soluong = Convert.ToInt32(txtSoLuong.Text);
            //int dongia = Convert.ToInt32(txtDonGia.Text.Trim());
            //string donvitinh = txtDVTinh.Text.Trim();
            //string ma = Request.QueryString["manl"]; ;

            //using (SqlConnection myCnn = connectDatabase())
            //{
            //    SqlCommand cmd = new SqlCommand("update_nguyenlieu", myCnn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@ma", Convert.ToInt32(ma));
            //    cmd.Parameters.AddWithValue("@ten", tennguyenlieu);
            //    cmd.Parameters.AddWithValue("@soluong", soluong);
            //    cmd.Parameters.AddWithValue("@dongia", dongia);
            //    cmd.Parameters.AddWithValue("@donvi", donvitinh);

            //    int check = cmd.ExecuteNonQuery();

            //    if (check > 0)
            //    {
            //        lblNoti.Text = "Cập nhật nguyên liệu thành công !";
            //        lblNoti.CssClass = "text-success";
            //    }
            //    else
            //    {
            //        lblNoti.Text = "Cập nhật nguyên liệu không thành công !";
            //        lblNoti.CssClass = "text-error";
            //    }
            //}
        }

    }
}