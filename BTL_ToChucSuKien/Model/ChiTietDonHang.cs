using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class ChiTietDonHang
    {
        public int iddonhang { get; set; }
        public String ngaydat { get; set; }
        public int iddichvu { get; set; }
        public int idtaikhoan { get; set; }

        public ChiTietDonHang()
        {

        }

        public ChiTietDonHang(int iddonhang, string ngaydat, int iddichvu, int idtaikhoan)
        {
            this.iddonhang = iddonhang;
            this.ngaydat = ngaydat;
            this.iddichvu = iddichvu;
            this.idtaikhoan = idtaikhoan;
        }
    }
}