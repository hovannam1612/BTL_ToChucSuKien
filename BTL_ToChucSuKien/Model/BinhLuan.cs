using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class BinhLuan
    {
        public int idbinhluan { get; set; }
        public String noidung { get; set; }
        public int idtaikhoan { get; set; }
        public int iddichvu { get; set; }

        public BinhLuan()
        {

        }

        public BinhLuan(int idbinhluan, string noidung, int idtaikhoan, int iddichvu)
        {
            this.idbinhluan = idbinhluan;
            this.noidung = noidung;
            this.idtaikhoan = idtaikhoan;
            this.iddichvu = iddichvu;
        }
    }
}