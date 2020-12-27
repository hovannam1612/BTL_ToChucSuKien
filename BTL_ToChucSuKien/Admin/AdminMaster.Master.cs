using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["TaiKhoan"] != null)
                {
                    TaiKhoan tk = (TaiKhoan)Session["TaiKhoan"];
                    lblUserName.Text = tk.hoten;
                    lblUserName2.Text = tk.hoten;
                }
            }
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Web/Home.aspx");
        }
    }
}