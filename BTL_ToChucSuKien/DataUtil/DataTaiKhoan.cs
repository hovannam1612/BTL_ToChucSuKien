using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.DataUtil
{
    public class DataTaiKhoan
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public DataTaiKhoan()
        {
            conn = Connect.connect();
        }

        public TaiKhoan findOneUser(String username, String password, int stt)
        {
            try
            {
                conn.Open();
                String sql = "select * from TaiKhoan where tendangnhap=@tendangnhap and matkhau=@matkhau and trangthai=@trangthai";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tendangnhap", username);
                cmd.Parameters.AddWithValue("matkhau", password);
                cmd.Parameters.AddWithValue("trangthai", stt);
                dr = cmd.ExecuteReader();
                TaiKhoan tk = null;
                while (dr.Read())
                {
                    tk = new TaiKhoan();
                    tk.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                    tk.tendangnhap = dr["tendangnhap"].ToString();
                    tk.matkhau = dr["matkhau"].ToString();
                    tk.diachi =dr["diachi"].ToString();
                    tk.sodienthoai = dr["sodienthoai"].ToString();
                    tk.hoten = dr["hoten"].ToString();
                    tk.quyentruycap = dr["quyentruycap"].ToString();
                    tk.trangthai = int.Parse(dr["trangthai"].ToString());
                }
                return tk;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }
        public List<TaiKhoan> DSTaiKhoan()
        {
            conn.Open();
            List<TaiKhoan> dsTaiKhoan = new List<TaiKhoan>();
            String sql = "select * from TaiKhoan";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                tk.tendangnhap = dr["tendangnhap"].ToString();
                tk.matkhau = dr["matkhau"].ToString();
                tk.diachi = dr["diachi"].ToString();
                tk.sodienthoai = dr["sodienthoai"].ToString();
                tk.hoten = dr["hoten"].ToString();
                tk.quyentruycap = dr["quyentruycap"].ToString();
                tk.trangthai = int.Parse(dr["trangthai"].ToString());
                dsTaiKhoan.Add(tk);
            }
            conn.Close();
            return dsTaiKhoan;
        }


        public void insertTK(TaiKhoan tk)
        {
            conn.Open();
            String sql = "insert into TaiKhoan values(@tendangnhap, @matkhau, @diachi, @sodienthoai, @hoten, @quyentruycap, @trangthai)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tendangnhap", tk.tendangnhap);
            cmd.Parameters.AddWithValue("matkhau", tk.matkhau);
            cmd.Parameters.AddWithValue("diachi", tk.diachi);
            cmd.Parameters.AddWithValue("sodienthoai", tk.sodienthoai);
            cmd.Parameters.AddWithValue("hoten", tk.hoten);
            cmd.Parameters.AddWithValue("quyentruycap", tk.quyentruycap);
            cmd.Parameters.AddWithValue("trangthai", tk.trangthai);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteTK(int idtaikhoan)
        {
            conn.Open();
            String sql = "delete from TaiKhoan where idtaikhoan=@idtaikhoan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idtaikhoan", idtaikhoan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public TaiKhoan findOne(int idtaikhoan)
        {
            conn.Open();
            String sql = "select * from TaiKhoan where idtaikhoan=@idtaikhoan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idtaikhoan", idtaikhoan);
            dr = cmd.ExecuteReader();
            TaiKhoan tk = null;
            while (dr.Read())
            {
                tk = new TaiKhoan();
                tk.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                tk.tendangnhap = dr["tendangnhap"].ToString();
                tk.matkhau = dr["matkhau"].ToString();
                tk.diachi = dr["diachi"].ToString();
                tk.sodienthoai = dr["sodienthoai"].ToString();
                tk.hoten = dr["hoten"].ToString();
                tk.quyentruycap = dr["quyentruycap"].ToString();
                tk.trangthai = int.Parse(dr["trangthai"].ToString());
            }
            conn.Close();
            return tk;
        }
        public void updateTK(TaiKhoan tk)
        {
            conn.Open();
            string sql = " update TaiKhoan set tendangnhap=@tendangnhap,matkhau=@matkhau,diachi=@diachi,sodienthoai=@sodienthoai,hoten=@hoten," +
                "quyentruycap=@quyentruycap,trangthai=@trangthai where idtaikhoan=@idtaikhoan ";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tendangnhap", tk.tendangnhap);
            cmd.Parameters.AddWithValue("matkhau", tk.matkhau);
            cmd.Parameters.AddWithValue("diachi", tk.diachi);
            cmd.Parameters.AddWithValue("sodienthoai", tk.sodienthoai);
            cmd.Parameters.AddWithValue("hoten", tk.hoten);
            cmd.Parameters.AddWithValue("quyentruycap", tk.quyentruycap);
            cmd.Parameters.AddWithValue("trangthai", tk.trangthai);
            cmd.Parameters.AddWithValue("idtaikhoan", tk.idtaikhoan);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public List<TaiKhoan> find(TaiKhoan taikhoan)
        {
            conn.Open();
            List<TaiKhoan> listTK = new List<TaiKhoan>();
            String sql = "SELECT * FROM TaiKhoan WHERE quyentruycap=@quyentruycap and trangthai=@trangthai";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("quyentruycap", taikhoan.quyentruycap);
            cmd.Parameters.AddWithValue("trangthai", taikhoan.trangthai);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                TaiKhoan tk = new TaiKhoan();
                tk.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                tk.tendangnhap = dr["tendangnhap"].ToString();
                tk.matkhau = dr["matkhau"].ToString();
                tk.diachi = dr["diachi"].ToString();
                tk.sodienthoai = dr["sodienthoai"].ToString();
                tk.hoten = dr["hoten"].ToString();
                tk.quyentruycap = dr["quyentruycap"].ToString();
                tk.trangthai = int.Parse(dr["trangthai"].ToString());
                listTK.Add(tk);
            }
            conn.Close();
            return listTK;
        }
        public List<TaiKhoan> findsdt(TaiKhoan taikhoan)
        {
            conn.Open();
            List<TaiKhoan> listTK = new List<TaiKhoan>();
            String sql = "SELECT * FROM TaiKhoan WHERE sodienthoai=@sodienthoai";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("sodienthoai", taikhoan.sodienthoai);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                TaiKhoan tk = new TaiKhoan();
                tk.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                tk.tendangnhap = dr["tendangnhap"].ToString();
                tk.matkhau = dr["matkhau"].ToString();
                tk.diachi = dr["diachi"].ToString();
                tk.sodienthoai = dr["sodienthoai"].ToString();
                tk.hoten = dr["hoten"].ToString();
                tk.quyentruycap = dr["quyentruycap"].ToString();
                tk.trangthai = int.Parse(dr["trangthai"].ToString());
                listTK.Add(tk);
            }
            conn.Close();
            return listTK;
        }
    }
}