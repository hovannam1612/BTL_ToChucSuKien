using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using BTL_ToChucSuKien.DataUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_ToChucSuKien.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataDichVu dataDichVu = new DataDichVu();
        DataDanhMuc dataDanhMuc = new DataDanhMuc();
        DataPhuongTien dataPhuongTien = new DataPhuongTien();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCombo();
                DichVu dv = (DichVu)Session["dv"];
                txtIDDichVu.Text = dv.iddichvu.ToString();
                img.ImageUrl = "~/Images/" + dv.anh;
                txtMoTaNgan.Text = dv.motangan;
                txtNoiDung.Text = dv.noidung;
                txtTieuDe.Text = dv.tieude;
                ddlDanhMuc.Text = dv.iddanhmuc.ToString();
                ddlPhuongTien.Text = dv.idphuongtien.ToString();
                txtGia.Text = dv.gia.ToString();
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
        protected void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                FileUpload f = fileUpload;
                String path = Server.MapPath("~/Images/");
                f.PostedFile.SaveAs(path + f.FileName);
                if (checkData())
                {
                    DichVu dv = new DichVu();
                    dv.iddichvu = int.Parse(txtIDDichVu.Text);
                    dv.motangan = txtMoTaNgan.Text;
                    dv.noidung = txtNoiDung.Text;
                    dv.tieude = txtTieuDe.Text;
                    dv.iddanhmuc = int.Parse(ddlDanhMuc.Text);
                    dv.idphuongtien = int.Parse(ddlPhuongTien.Text);
                    dv.gia = float.Parse(txtGia.Text);
                    dv.anh = f.FileName;

                    dataDichVu.update(dv);
                    lblMsg.Text = "Sửa thành công";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (FormatException exx)
            {
                lblMsg.Text = "Giá phải là số";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Sửa thất bại, lỗi: " + ex.Message;
                if (ex.Message.Contains("Could not find a part of the path"))
                {
                    lblMsg.Text = "Không tìm thấy đường dẫn ảnh";
                }
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}