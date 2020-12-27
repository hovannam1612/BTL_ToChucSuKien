using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataDichVu data = new DataDichVu();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                LoadCombo();
            }

        }
        public void LoadCombo()
        {
            ddlTimKiem.Items.Add("Tiêu đề");
            ddlTimKiem.Items.Add("Giá dưới 3000");
            ddlTimKiem.Items.Add("Giá trên 3000");
        }
        public void LoadData()
        {
            dgvDichVu.DataSource = data.DSDichVu();
            dgvDichVu.DataBind();

        }
        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "xoa")
            {
                int iddichvu = int.Parse(e.CommandArgument.ToString());
                data.delete(iddichvu);
                LoadData();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "sua")
            {
                int iddichvu = int.Parse(e.CommandArgument.ToString());
                DichVu dv = data.findOne(iddichvu);
                Session["dv"] = dv;
                Response.Redirect("SuaDichVu.aspx");
            }
        }

        protected void dgvDichVu_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvDichVu.PageIndex = e.NewPageIndex;   
            LoadData();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(ddlTimKiem.SelectedIndex == 0)
            {
                String timkiem = txtTimKiem.Text;
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data.findByTieuDe(timkiem);
                dgvDichVu.DataBind();
                if (dgvDichVu.Rows.Count == 0)
                    lblMsg.Text = "Không có dữ liệu";
            }
            if (ddlTimKiem.SelectedIndex == 1)
            {
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data.findByLowPrice();
                dgvDichVu.DataBind();
                if (dgvDichVu.Rows.Count == 0)
                    lblMsg.Text = "Không có dữ liệu";
            }
            if(ddlTimKiem.SelectedIndex == 2)
            {
                dgvDichVu.DataSource = null;
                dgvDichVu.DataSource = data.findByHighPrice();
                dgvDichVu.DataBind();
                if (dgvDichVu.Rows.Count == 0)
                    lblMsg.Text = "Không có dữ liệu";
            }
        }

        protected void ddlTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}