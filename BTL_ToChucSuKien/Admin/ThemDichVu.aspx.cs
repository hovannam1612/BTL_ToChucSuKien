using BTL_ToChucSuKien.Admin.DataUtil;
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
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataDanhMuc dataDanhMuc = new DataDanhMuc();
        DataDichVu dataDichVu = new DataDichVu();
        DataPhuongTien dataPhuongTien = new DataPhuongTien();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCombo();
            }

        }

        public void loadCombo()
        {
            ddlDanhMuc.DataSource = dataDanhMuc.DSDanhMuc();
            ddlDanhMuc.DataTextField = "ten";
            ddlDanhMuc.DataValueField = "iddanhmuc";

            ddlPhuongTien.DataSource = dataPhuongTien.DSPhuongTien();
            ddlPhuongTien.DataTextField = "dungcu";
            ddlPhuongTien.DataValueField = "idphuongtien";
            DataBind();
           
        }

        public Boolean checkData()
        {
            if (txtTieuDe.Text == "")
                throw new Exception("Tiêu đề không để trống");
            if (txtNoiDung.Text == "")
                throw new Exception("Nội dung không để trống");
            if (txtMoTaNgan.Text == "")
                throw new Exception("Mô tả ngắn không để trống");
            if (txtGia.Text == "")
                throw new Exception("Giá không để trống");
            return true;
        }
        protected void btnThem_Click1(object sender, EventArgs e)
        {
            try
            {
                FileUpload f = (FileUpload)fileUpload;
                String path = Server.MapPath("~/Images/");
                f.PostedFile.SaveAs(path + f.FileName);
                if (checkData()) { 
                    DichVu dv = new DichVu();
                    dv.tieude = txtTieuDe.Text;
                    dv.noidung = txtNoiDung.Text;
                    dv.motangan = txtMoTaNgan.Text;
                    dv.idphuongtien = int.Parse(ddlPhuongTien.SelectedValue.ToString());
                    dv.iddanhmuc = int.Parse(ddlDanhMuc.SelectedValue.ToString());
                    dv.gia = float.Parse(txtGia.Text);
                    dv.anh = f.FileName;
                    dataDichVu.insert(dv);
                    lblMsg.Text = "Thêm thành công";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
            }catch(FormatException exx)
            {
                lblMsg.Text = "Giá phải là số";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Thêm thất bại, lỗi: " + ex.Message;
                if(ex.Message.Contains("Could not find a part of the path"))
                {
                    lblMsg.Text = "Không tìm thấy đường dẫn ảnh";
                }
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}