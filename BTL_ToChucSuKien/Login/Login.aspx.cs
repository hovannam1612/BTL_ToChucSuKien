using BTL_ToChucSuKien.Admin.Model;
using BTL_ToChucSuKien.DataUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Login
{
    public partial class Login : System.Web.UI.Page
    {
        DataTaiKhoan data = new DataTaiKhoan();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            TaiKhoan tk = null;
            if (username != null && password != null)
            {
                tk = data.findOneUser(username, password, 1);
                
                if(tk != null)
                {
                    if(Session["TaiKhoan"] == null)
                    {
                        Session["TaiKhoan"] = tk;
                    }

                    String quyentruycap = tk.quyentruycap.ToString().Trim();
                    lblMsg.Text = quyentruycap;
                    if (quyentruycap.Equals("admin")){
                        Response.Redirect("~/Admin/AdminHome.aspx");
                    }
                    else if(quyentruycap.Equals("user"))
                    {
                        Response.Redirect("~/Web/Home.aspx");
                    }
                }
                else
                {
                    lblMsg.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
        }
    }
}