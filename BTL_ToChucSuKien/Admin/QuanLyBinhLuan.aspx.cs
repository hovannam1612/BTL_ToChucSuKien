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
    public partial class WebForm8 : System.Web.UI.Page
    {
        DataBinhLuan dataBl = new DataBinhLuan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();

            }

        }
        public void LoadData()
        {
            dgvBinhLuan.DataSource = dataBl.dsBinhLuan();
            dgvBinhLuan.DataBind();

        }
        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int idbinhluan = int.Parse(e.CommandArgument.ToString());
                dataBl.delete(idbinhluan);
                LoadData();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sua")
            {
                int idbinhluan = int.Parse(e.CommandArgument.ToString());
                BinhLuan bl = dataBl.findOne(idbinhluan);
                Session["bl"] = bl;
                Response.Redirect("SuaBinhLuan.aspx");
            }
        }
    }
}