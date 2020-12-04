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
    public class PhieuMuon_BUS
    {
        PhieuMuon_DAL dalPhieuMuon = new PhieuMuon_DAL();
        public DataTable getPhieuMuon()
        {
            return dalPhieuMuon.getPhieuMuon();
        }
        public bool InseartPhieuMuon(PhieuMuon_DTO pm)
        {
            return dalPhieuMuon.InseartPhieuMuon(pm);
        }
        public bool UpdatePhieuMuon(PhieuMuon_DTO pm)
        {
            return dalPhieuMuon.UpdatePhieuMuon(pm);
        }
        public bool DeletePhieuMuon(string maPhieu)
        {
            return dalPhieuMuon.DeletePhieuMuon(maPhieu);
        }
        public DataTable SearchPhieuMuon(string maPhieu)
        {
            return dalPhieuMuon.SearchPhieuMuon(maPhieu);
        }
    }
}
