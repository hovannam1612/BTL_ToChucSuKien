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
    public partial class WebForm7 : System.Web.UI.Page
    {
        DataTaiKhoan data = new DataTaiKhoan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCb();
                TaiKhoan tk = (TaiKhoan)Session["tk"];
                txtIDTaiKhoan.Text = tk.idtaikhoan.ToString();
                txtTenDangNhap.Text = tk.tendangnhap.ToString();
                txtMatKhau.Text = tk.matkhau.ToString();

                txtDiaChi.Text = tk.diachi.ToString();
                txtSoDienThoai.Text = tk.sodienthoai.ToString();
                txtHoTen.Text = tk.hoten.ToString();
                drQuyenTruyCap.Text = tk.quyentruycap.ToString();
                drTrangThai.Text = tk.trangthai.ToString();
            }
        }
        public void loadCb()
        {

            drQuyenTruyCap.Items.Add("admin");
            drQuyenTruyCap.Items.Add("user");
            drTrangThai.Items.Add("0");
            drTrangThai.Items.Add("1");
        }
        protected void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.idtaikhoan = int.Parse(txtIDTaiKhoan.Text);
                tk.tendangnhap = txtTenDangNhap.Text;
                tk.matkhau = txtMatKhau.Text;
                tk.diachi = txtDiaChi.Text;
                tk.sodienthoai = txtSoDienThoai.Text;
                tk.hoten = txtHoTen.Text;
                tk.quyentruycap = drQuyenTruyCap.SelectedItem.Text;
                tk.trangthai = int.Parse(drTrangThai.SelectedItem.Text);
                data.updateTK(tk);
                lblMsg.Text = "Sửa thành công";
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Sửa thất bại, lỗi: " + ex.Message;
                lblMsg.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}