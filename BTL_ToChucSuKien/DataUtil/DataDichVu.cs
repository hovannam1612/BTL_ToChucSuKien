using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.Admin.DataUtil
{
    public class DataDichVu
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public DataDichVu()
        {
            conn = Connect.connect();
        }

        public List<DichVu> DSDichVu()
        {
            conn.Open();
            List<DichVu> dsDichVu = new List<DichVu>();
            String sql = "select * from DichVu";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DichVu dv = new DichVu();
                dv.iddichvu = int.Parse(dr["iddichvu"].ToString());
                dv.tieude = dr["tieude"].ToString();
                dv.anh = dr["anh"].ToString();
                dv.motangan = dr["motangan"].ToString();
                dv.noidung = dr["noidung"].ToString();
                dv.gia = float.Parse(dr["gia"].ToString());
                dv.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dv.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
                dsDichVu.Add(dv);
            }
            conn.Close();
            return dsDichVu;
        }
        public void insert(DichVu dv)
        {
            conn.Open();
            String sql = "insert into DichVu values(@tieude, @anh, @motangan, @noidung, @gia, @iddanhmuc, @idphuongtien);";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tieude", dv.tieude);
            cmd.Parameters.AddWithValue("anh", dv.anh);
            cmd.Parameters.AddWithValue("motangan", dv.motangan);
            cmd.Parameters.AddWithValue("noidung", dv.noidung);
            cmd.Parameters.AddWithValue("gia", dv.gia);
            cmd.Parameters.AddWithValue("iddanhmuc", dv.iddanhmuc);
            cmd.Parameters.AddWithValue("idphuongtien", dv.idphuongtien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete(int iddichvu)
        {
            conn.Open();
            String sql = "delete from DichVu where iddichvu=@iddichvu";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("iddichvu", iddichvu);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void update(DichVu dv)
        {
            conn.Open();
            String sql = "update DichVu set tieude=@tieude, anh=@anh, motangan=@motangan, noidung=@noidung, gia=@gia, iddanhmuc=@iddanhmuc, idphuongtien=@idphuongtien where iddichvu=@iddichvu";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tieude", dv.tieude);
            cmd.Parameters.AddWithValue("anh", dv.anh);
            cmd.Parameters.AddWithValue("motangan", dv.motangan);
            cmd.Parameters.AddWithValue("noidung", dv.noidung);
            cmd.Parameters.AddWithValue("gia", dv.gia);
            cmd.Parameters.AddWithValue("iddanhmuc", dv.iddanhmuc);
            cmd.Parameters.AddWithValue("idphuongtien", dv.idphuongtien);
            cmd.Parameters.AddWithValue("iddichvu", dv.iddichvu);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DichVu findOne(int iddichvu)
        {
            conn.Open();
            String sql = "select * from DichVu where iddichvu=@iddichvu";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("iddichvu", iddichvu);
            dr = cmd.ExecuteReader();
            DichVu dv = null;
            while (dr.Read())
            {
                dv = new DichVu();
                dv.iddichvu = int.Parse(dr["iddichvu"].ToString());
                dv.tieude = dr["tieude"].ToString();
                dv.anh = dr["anh"].ToString();
                dv.motangan = dr["motangan"].ToString();
                dv.noidung = dr["noidung"].ToString();
                dv.gia = float.Parse(dr["gia"].ToString());
                dv.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dv.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
            }
            conn.Close();
            return dv;
        }

        public List<DichVu> findByTieuDe(String tieude)
        {
            conn.Open();
            List<DichVu> dichVuList = new List<DichVu>();
            String sql = "select * from DichVu where tieude like N'%' + @tieude + '%'";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("tieude", tieude);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DichVu dv = new DichVu();
                dv.iddichvu = int.Parse(dr["iddichvu"].ToString());
                dv.tieude = dr["tieude"].ToString();
                dv.anh = dr["anh"].ToString();
                dv.motangan = dr["motangan"].ToString();
                dv.noidung = dr["noidung"].ToString();
                dv.gia = float.Parse(dr["gia"].ToString());
                dv.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dv.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
                dichVuList.Add(dv);
            }
            conn.Close();
            return dichVuList;
        }
        public List<DichVu> findByLowPrice()
        {
            conn.Open();
            List<DichVu> dichVuList = new List<DichVu>();
            String sql = "SELECT * FROM DichVu WHERE gia <= 3000";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DichVu dv = new DichVu();
                dv.iddichvu = int.Parse(dr["iddichvu"].ToString());
                dv.tieude = dr["tieude"].ToString();
                dv.anh = dr["anh"].ToString();
                dv.motangan = dr["motangan"].ToString();
                dv.noidung = dr["noidung"].ToString();
                dv.gia = float.Parse(dr["gia"].ToString());
                dv.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dv.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
                dichVuList.Add(dv);
            }
            conn.Close();
            return dichVuList;
        }
        public List<DichVu> findByHighPrice()
        {
            conn.Open();
            List<DichVu> dichVuList = new List<DichVu>();
            String sql = "SELECT * FROM DichVu WHERE gia >= 3000";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DichVu dv = new DichVu();
                dv.iddichvu = int.Parse(dr["iddichvu"].ToString());
                dv.tieude = dr["tieude"].ToString();
                dv.anh = dr["anh"].ToString();
                dv.motangan = dr["motangan"].ToString();
                dv.noidung = dr["noidung"].ToString();
                dv.gia = float.Parse(dr["gia"].ToString());
                dv.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dv.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
                dichVuList.Add(dv);
            }
            conn.Close();
            return dichVuList;
        }
    }
}