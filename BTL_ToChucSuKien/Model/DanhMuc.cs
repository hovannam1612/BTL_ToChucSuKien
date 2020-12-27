using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class DanhMuc
    {
        public int iddanhmuc { get; set; }
        public String ten { get; set; }
        public String madanhmuc { get; set; }

        public DanhMuc()
        {

        }

        public DanhMuc(int idDanhMuc, string ten, string maDanhMuc)
        {
            this.iddanhmuc = idDanhMuc;
            this.ten = ten;
            this.madanhmuc = maDanhMuc;
        }
    }
}