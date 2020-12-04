using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoai_DAL : DBConnect
    {
        public DataTable getTheLoai()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachTheLoai";
                cmd.Connection = _conn;
                DataTable dttheloai = new DataTable();
                dttheloai.Load(cmd.ExecuteReader());
                return dttheloai;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool InseartTheLoai(TheLoai_DTO tl)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERTTheLoai";
                cmd.Parameters.AddWithValue("MaTheLoai", tl.MaTheLoai);
                cmd.Parameters.AddWithValue("TenTheLoai", tl.TenTheLoai);
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
        public bool UpdateTheLoai(TheLoai_DTO tl)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UPDATETheLoai";
                cmd.Parameters.AddWithValue("MaTheLoai", tl.MaTheLoai);
                cmd.Parameters.AddWithValue("TenTheLoai", tl.TenTheLoai);

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
        public bool DeleteTheLoai(string maTheLoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteTheLoai";
                cmd.Parameters.AddWithValue("MaTheLoai", maTheLoai);
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
        public DataTable SearchTheLoai(string maTheLoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchTheLoai";
                cmd.Parameters.AddWithValue("matheloai", maTheLoai);
                cmd.Connection = _conn;
                DataTable dtTheLoai = new DataTable();
                dtTheLoai.Load(cmd.ExecuteReader());
                return dtTheLoai;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
