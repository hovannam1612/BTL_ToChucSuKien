using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.Model
{
    public class TaiKhoan
    {
        public int idtaikhoan { get; set; }
        public String tendangnhap { get; set; }
        public String matkhau { get; set; }
        public String diachi { get; set; }
        public String sodienthoai { get; set; }
        public String hoten { get; set; }
        public String quyentruycap { get; set; }
        public int trangthai { get; set; }

        public TaiKhoan()
        {

        }
        public TaiKhoan(int idtaikhoan, string tendangnhap, string matkhau, string diachi, string sodienthoai, string hoten, string quyentruycap, int trangthai)
        {
            this.idtaikhoan = idtaikhoan;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;
            this.hoten = hoten;
            this.quyentruycap = quyentruycap;
            this.trangthai = trangthai;
        }
    }
}