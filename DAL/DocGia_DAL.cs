using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGia_DAL : DBConnect
    {
        public DataTable getDocGia()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachDocGia";
                cmd.Connection = _conn;
                DataTable dtDocGia = new DataTable();
                dtDocGia.Load(cmd.ExecuteReader());
                return dtDocGia;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool InsertDocGia(DocGia_DTO pm)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERTPHIEUMUON";
                cmd.Parameters.AddWithValue("MaDocGia", pm.MADOCGIA);
                cmd.Parameters.AddWithValue("HoTen", pm.HOTEN);
                cmd.Parameters.AddWithValue("GioiTinh", pm.GIOITINH);
                cmd.Parameters.AddWithValue("NamSinh", pm.NAMSINH);
                cmd.Parameters.AddWithValue("DiaChi", pm.DIACHI);
                cmd.Parameters.AddWithValue("SoDienThoai", pm.SODIENTHOAI);
                cmd.Parameters.AddWithValue("Email", pm.EMAIL);
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

        }
        public bool UpdateDocGia(DocGia_DTO pm)
        {
            try
            {
                _conn.Open();
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERTPHIEUMUON";
                cmd.Parameters.AddWithValue("MaDocGia", pm.MADOCGIA);
                cmd.Parameters.AddWithValue("HoTen", pm.HOTEN);
                cmd.Parameters.AddWithValue("GioiTinh", pm.GIOITINH);
                cmd.Parameters.AddWithValue("NamSinh", pm.NAMSINH);
                cmd.Parameters.AddWithValue("DiaChi", pm.DIACHI);
                cmd.Parameters.AddWithValue("SoDienThoai", pm.SODIENTHOAI);
                cmd.Parameters.AddWithValue("Email", pm.EMAIL);

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
        public bool DeleteDocGia(string MaDocGia)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDocGia";
                cmd.Parameters.AddWithValue("MADOCGIA", MaDocGia);
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
        public DataTable SearchDocGia(string HoTen)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchDocGia";
                cmd.Parameters.AddWithValue("HOTEN", HoTen);
                cmd.Connection = _conn;
                DataTable dtDocGia = new DataTable();
                dtDocGia.Load(cmd.ExecuteReader());
                return dtDocGia;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
