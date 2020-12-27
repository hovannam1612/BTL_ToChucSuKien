using BTL_ToChucSuKien.Admin.DataUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Admin
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        DataDichVu dataDV = new DataDichVu();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadData();
            }
        }
        public void loadData()
        {
            dgvDoanhSo.DataSource = dataDV.DSDichVu();
            dgvDoanhSo.DataBind();
        }

        protected void dgvDoanhSo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvDoanhSo.PageIndex = e.NewPageIndex;
            loadData();
        }
        int sum = 0;
        protected void dgvDoanhSo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label salary = (Label)e.Row.FindControl("lblgia"); //take lable id
                sum += int.Parse(salary.Text);
                lblDoanhthu.Text = sum.ToString();
            }
        }
    }
}