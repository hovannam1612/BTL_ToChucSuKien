using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Web
{
    public partial class WebMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TaiKhoan tk = null;
                if(Session["TaiKhoan"] != null)
                {
                    tk = (TaiKhoan)Session["TaiKhoan"];
                    lbLogin.Visible = false;
                    ltrUserName.Text = "<span style='color:white;'>" + "Chào," + tk.hoten  + "</span>";
                }
                else
                {
                    lbLogin.Visible = true;
                    lbLogout.Visible = false;
                }
                
            }
        }

        protected void hlLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }

        protected void lbLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login/Login.aspx");
        }
    }
}