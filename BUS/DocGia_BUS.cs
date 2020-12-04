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
    public class DocGia_BUS
    {
        DocGia_DAL dalDocGia = new DocGia_DAL();
        public DataTable getDocGia()
        {
            return dalDocGia.getDocGia();
        }
        public bool InsertDocGia(DocGia_DTO pm)
        {
            return dalDocGia.InsertDocGia(pm);
        }
        public bool UpdateDocGia(DocGia_DTO pm)
        {
            return dalDocGia.UpdateDocGia(pm);
        }
        public bool DeleteDocGia(string MaDocGia)
        {
            return dalDocGia.DeleteDocGia(MaDocGia);
        }
        public DataTable SearchDocGia(string HoTen)
        {
            return dalDocGia.SearchDocGia(HoTen);
        }
}
