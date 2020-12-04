using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia_DTO
    {
        private string MaDocGia;
        private string HoTen;
        private int GioiTinh;
        private DateTime NamSinh;
        private string DiaChi;
        private string SoDienThoai;
        private string Email;

        public string MADOCGIA
        {
            get
            {
                return MaDocGia;
            }
            set
            {
                MaDocGia = value;
            }
        }
        public string HOTEN
        {
            get
            {
                return HoTen;
            }
            set
            {
                HoTen = value;
            }
        }
        public int GIOITINH
        {
            get
            {
                return GioiTinh;
            }
            set
            {
                GioiTinh = value;
            }
        }
        public DateTime NAMSINH
        {
            get
            {
                return NamSinh;
            }
            set
            {
                NamSinh = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string SODIENTHOAI
        {
            get
            {
                return SoDienThoai;
            }
            set
            {
                SoDienThoai = value;
            }
        }
        public string EMAIL
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public DocGia_DTO(string MaDocGia, string HoTen, int GioiTinh, DateTime NamSinh, string DiaChi, string SoDienThoai, string Email)
        {
            this.MaDocGia = MaDocGia;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NamSinh = NamSinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.Email = Email;
        }

    }
}
