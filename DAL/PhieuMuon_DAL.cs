using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PhieuMuon_DAL : DBConnect
    {
        public DataTable getPhieuMuon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachPhieuMuon";
                cmd.Connection = _conn;
                DataTable dtPhieuMuon = new DataTable();
                dtPhieuMuon.Load(cmd.ExecuteReader());
                return dtPhieuMuon;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InseartPhieuMuon(PhieuMuon_DTO pm)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERTPHIEUMUON";
                cmd.Parameters.AddWithValue("MaPhieu", pm.MaPhieu);
                cmd.Parameters.AddWithValue("MaDocGia", pm.MaDocGia);
                cmd.Parameters.AddWithValue("MaNhanVien", pm.MaNhanVien);
                cmd.Parameters.AddWithValue("NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("NgayPhaiTra", pm.NgayPhaiTra);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool UpdatePhieuMuon(PhieuMuon_DTO pm)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATEPHIEUMUON";
                cmd.Parameters.AddWithValue("MaPhieu", pm.MaPhieu);
                cmd.Parameters.AddWithValue("MaDocGia", pm.MaDocGia);
                cmd.Parameters.AddWithValue("MaNhanVien", pm.MaNhanVien);
                cmd.Parameters.AddWithValue("NgayMuon", pm.NgayMuon);
                cmd.Parameters.AddWithValue("NgayPhaiTra", pm.NgayPhaiTra);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool DeletePhieuMuon(string maPhieu)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletePhieuMuon";
                cmd.Parameters.AddWithValue("maphieu", maPhieu);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable SearchPhieuMuon(string maPhieu)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchPhieuMuon";
                cmd.Parameters.AddWithValue("maphieu", maPhieu);
                cmd.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
