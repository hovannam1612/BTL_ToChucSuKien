using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class PhuongTien
    {
        public int idphuongtien { get; set; }
        public String nhansu { get; set; }
        public String dungcu { get; set; }
        public String vatlieuthietke { get; set; }

        public PhuongTien()
        {

        }
        public PhuongTien(int idPhuongTien, string nhanSu, string dungCu, string vatLieuThietKe)
        {
            this.idphuongtien = idPhuongTien;
            this.nhansu = nhanSu;
            this.dungcu = dungCu;
            this.vatlieuthietke = vatLieuThietKe;
        }
    }
}