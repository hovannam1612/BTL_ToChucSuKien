using BTL_ToChucSuKien.Admin.DataUtil;
using BTL_ToChucSuKien.Admin.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BTL_ToChucSuKien.DataUtil
{
    public class DataPhuongTien
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        public DataPhuongTien()
        {
            conn = Connect.connect();
        }

        public List<PhuongTien> DSPhuongTien()
        {
            conn.Open();
            List<PhuongTien> listPT = new List<PhuongTien>();
            String sql = "select * from PhuongTien";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PhuongTien dm = new PhuongTien();
                dm.idphuongtien = int.Parse(dr["idphuongtien"].ToString());
                dm.nhansu = dr["nhansu"].ToString();
                dm.dungcu = dr["dungcu"].ToString();
                dm.vatlieuthietke = dr["vatlieuthietke"].ToString();
                listPT.Add(dm);
            }
            conn.Close();
            return listPT;
        }
    }
}