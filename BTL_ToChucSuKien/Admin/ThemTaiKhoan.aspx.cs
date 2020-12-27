using BTL_ToChucSuKien.Admin.Model;
using BTL_ToChucSuKien.DataUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Admin
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        DataTaiKhoan dataTK = new DataTaiKhoan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCb();
            }
        }
        public void loadCb()
        {
            /* drQuyenTruyCap.DataSource = dataTK.DSTaiKhoan();
             drQuyenTruyCap.DataTextField = "quyentruycap";
             drQuyenTruyCap.DataValueField = "quyentruycap";
             drTrangThai.DataSource = dataTK.DSTaiKhoan();
             drTrangThai.DataTextField = "trangthai";
             drTrangThai.DataValueField = "trangthai";
             DataBind();*/
            drQuyenTruyCap.Items.Add("admin");
            drQuyenTruyCap.Items.Add("user");
            drTrangThai.Items.Add("0");
            drTrangThai.Items.Add("1");
        }
        public Boolean checkError()
        {
            if (txtTenDangNhap.Text == "")
            {
                throw new Exception("Vui lòng nhập tên đăng nhập!");

            }
            if (txtMatKhau.Text == "")
            {
                throw new Exception("Vui lòng nhập mật khẩu!");
            }
            if (txtDiaChi.Text == "")
            {
                throw new Exception("Vui lòng nhập địa chỉ!");
            }
            if (txtSoDienThoai.Text == "")
            {
                throw new Exception("Vui lòng nhập số điện thoại!");
            }
            if (txtHoTen.Text == "")
            {
                throw new Exception("Vui lòng nhập họ tên!");
            }
            return true;

        }
        protected void themTk_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkError())
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.tendangnhap = txtTenDangNhap.Text;
                    tk.matkhau = txtMatKhau.Text;
                    tk.diachi = txtDiaChi.Text;
                    tk.sodienthoai = txtSoDienThoai.Text;
                    tk.hoten = txtHoTen.Text;
                    tk.quyentruycap = drQuyenTruyCap.SelectedItem.Text.ToString();
                    tk.trangthai = int.Parse(drTrangThai.SelectedItem.Text.ToString());
                    dataTK.insertTK(tk);
                    lblMsg.Text = "Thêm thành công";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Thêm thất bại, lỗi: " + ex.Message;
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}