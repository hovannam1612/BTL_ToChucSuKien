using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.DataUtil
{
    public class DataBinhLuan
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public DataBinhLuan()
        {
            conn = Connect.connect();
        }
        public List<BinhLuan> dsBinhLuan()
        {
            conn.Open();
            List<BinhLuan> ds = new List<BinhLuan>();
            String sql = "select * from BinhLuan";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BinhLuan bl = new BinhLuan();
                bl.idbinhluan = int.Parse(dr["idbinhluan"].ToString());
                bl.noidung = dr["noidung"].ToString();
                bl.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                bl.iddichvu = int.Parse(dr["iddichvu"].ToString());
                ds.Add(bl);
            }
            conn.Close();
            return ds;
        }
        public void insertBL(BinhLuan bl)
        {
            conn.Open();
            String sql = "insert into BinhLuan values(@idbinhluan, @noidung, @idtaikhoan, @iddichvu)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idbinhluan", bl.idbinhluan);
            cmd.Parameters.AddWithValue("noidung", bl.noidung);
            cmd.Parameters.AddWithValue("idtaikhoan", bl.idtaikhoan);
            cmd.Parameters.AddWithValue("iddichvu", bl.iddichvu);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(int idbinhluan)
        {
            conn.Open();
            String sql = "delete from BinhLuan where idbinhluan=@idbinhluan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idbinhluan", idbinhluan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void update(BinhLuan bl)
        {
            conn.Open();
            String sql = "update BinhLuan set noidung=@noidung, idtaikhoan=@idtaikhoan, iddichvu=@iddichvu where idbinhluan=@idbinhluan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("noidung", bl.noidung);
            cmd.Parameters.AddWithValue("idtaikhoan", bl.idtaikhoan);
            cmd.Parameters.AddWithValue("iddichvu", bl.iddichvu);
            cmd.Parameters.AddWithValue("idbinhluan", bl.idbinhluan);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public BinhLuan findOne(int idbinhluan)
        {
            conn.Open();
            String sql = "select * from BinhLuan where idbinhluan=@idbinhluan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idbinhluan", idbinhluan);
            dr = cmd.ExecuteReader();
            BinhLuan ds = null;
            while (dr.Read())
            {
                BinhLuan bl = new BinhLuan();
                bl.idbinhluan = int.Parse(dr["idbinhluan"].ToString());
                bl.noidung = dr["noidung"].ToString();
                bl.idtaikhoan = int.Parse(dr["idtaikhoan"].ToString());
                bl.iddichvu = int.Parse(dr["iddichvu"].ToString());

            }
            conn.Close();
            return ds;
        }
    }
}