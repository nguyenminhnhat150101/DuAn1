using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAL dalTaiKhoan = new TaiKhoan_DAL();
        public bool DangNhap(TaiKhoan_DTO tk)
        {
            return dalTaiKhoan.DangNhap(tk);
        }
        public DataTable KiemTraQuyen(string taikhoan)
        {
            return dalTaiKhoan.KiemTraQuyen(taikhoan);
        }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();

            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
       
    }
}
