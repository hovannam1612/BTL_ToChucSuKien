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
    public partial class WebForm5 : System.Web.UI.Page
    {
        DataTaiKhoan data = new DataTaiKhoan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                loadCB();
            }
        }
        public void loadCB()
        {

            drQuyenTruyCap.Items.Add("admin");
            drQuyenTruyCap.Items.Add("user");
            drTrangThai.Items.Add("1");
            drTrangThai.Items.Add("0");



        }
        public void LoadData()
        {
            dgvTaiKhoan.DataSource = data.DSTaiKhoan();
            dgvTaiKhoan.DataBind();

        }
        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int idtaikhoan = int.Parse(e.CommandArgument.ToString());
                data.deleteTK(idtaikhoan);
                LoadData();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int idtaikhoan = int.Parse(e.CommandArgument.ToString());
                TaiKhoan tk = data.findOne(idtaikhoan);
                Session["tk"] = tk;
                Response.Redirect("SuaTaiKhoan.aspx");
            }
        }

        protected void dgvTaiKhoan_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvTaiKhoan.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void btTim_Click(object sender, EventArgs e)
        {

            TaiKhoan tk = new TaiKhoan();
            if (txtSDT.Text == "")
            {
                tk.quyentruycap = drQuyenTruyCap.SelectedValue;
                tk.trangthai = int.Parse(drTrangThai.SelectedValue);
                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = data.find(tk);
                DataBind();
                txtSDT.Visible = false;
                lblSoDienThoai.Visible = false;

            }
            else
            {
                tk.sodienthoai = txtSDT.Text;
                dgvTaiKhoan.DataSource = null;
                dgvTaiKhoan.DataSource = data.findsdt(tk);
                dgvTaiKhoan.DataBind();
                drQuyenTruyCap.Visible = false;
                drTrangThai.Visible = false;
                lblQuyenTruyCap.Visible = false;
                lblTrangthai.Visible = false;
            }
            if (dgvTaiKhoan.Rows.Count == 0)
                lblMsg.Text = "Không có dữ liệu";

        }
    }
}