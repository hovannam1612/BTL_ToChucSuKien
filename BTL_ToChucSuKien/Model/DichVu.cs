using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class DichVu
    {
        public int iddichvu { get; set; }
        public String tieude { get; set; }
        public String anh { get; set; }
        public String motangan { get; set; }
        public String noidung { get; set; }
        public float gia { get; set; }
        public int iddanhmuc { get; set; }
        public int idphuongtien { get; set; }

        public DichVu()
        {

        }
        public DichVu(int idDichVu, string tieude, string anh, string moTaNgan, string noiDung, float gia, int idDanhMuc, int idPhuongTien)
        {
            this.iddichvu = idDichVu;
            this.tieude = tieude;
            this.anh = anh;
            this.motangan = moTaNgan;
            this.noidung = noiDung;
            this.gia = gia;
            this.iddanhmuc = idDanhMuc;
            this.idphuongtien = idPhuongTien;
        }
    }
}