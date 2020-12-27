using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.DataUtil
{
    public class DataDanhMuc
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public DataDanhMuc()
        {
            conn = Connect.connect();
        }

        public List<DanhMuc> DSDanhMuc()
        {
            conn.Open();
            List<DanhMuc> listDM = new List<DanhMuc>();
            String sql = "select * from DanhMuc";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DanhMuc dm = new DanhMuc();
                dm.iddanhmuc = int.Parse(dr["iddanhmuc"].ToString());
                dm.madanhmuc = dr["madanhmuc"].ToString();
                dm.ten = dr["ten"].ToString();
                listDM.Add(dm);
            }
            conn.Close();
            return listDM;
        }
    }
}