using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoai_BUS
    {
        TheLoai_DAL dalTheLoai = new TheLoai_DAL();
        public DataTable getTheLoai()
        {
            return dalTheLoai.getTheLoai();
        }
        public bool InseartTheLoai(TheLoai_DTO tl)
        {
            return dalTheLoai.InseartTheLoai(tl);
        }
        public bool UpdateTheLoai(TheLoai_DTO tl)
        {
            return dalTheLoai.UpdateTheLoai(tl);
        }
        public bool DeleteTheLoai(string maTheLoai)
        {
            return dalTheLoai.DeleteTheLoai(maTheLoai);
        }
        public DataTable SearchTheLoai(string maTheLoai)
        {
            return dalTheLoai.SearchTheLoai(maTheLoai);
        }
    }
}
