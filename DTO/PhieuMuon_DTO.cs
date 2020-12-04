using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuon_DTO
    {
        private string maPhieu;
        private string maDocGia;
        private string maNhanVien;
        private DateTime ngayMuon;
        private DateTime ngayPhaiTra;
        public string MaPhieu { get { return maPhieu; } set { maPhieu = value; } }
        public string MaDocGia { get { return maDocGia; } set { maDocGia = value; } }
        public string MaNhanVien { get { return maNhanVien; } set { maNhanVien = value; } }
        public DateTime NgayMuon { get { return ngayMuon; } set { ngayMuon = value; } }
        public DateTime NgayPhaiTra { get { return ngayPhaiTra; } set { ngayPhaiTra = value; } }
        public PhieuMuon_DTO(string _maPhieu, string _maDocGia, string _maNhanVien, DateTime _ngayMuon, DateTime _ngayPhaiTra)
        {
            this.maPhieu = _maPhieu;
            this.maDocGia = _maDocGia;
            this.maNhanVien = _maNhanVien;
            this.ngayMuon = _ngayMuon;
            this.ngayPhaiTra = _ngayPhaiTra;
        }

    }
}
