using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {

        private string taiKhoan;
        private string matKhau;
        private int quyen;
        public string TaiKhoan { get { return taiKhoan; } set { taiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public int Quyen { get { return quyen; } set { quyen = value; } }

        public TaiKhoan_DTO(string _taiKhoan, string _matKhau, int _quyen)
        {
            this.taiKhoan = _taiKhoan;
            this.matKhau = _matKhau;
            this.quyen = _quyen;
        }
        public TaiKhoan_DTO(string _taiKhoan, int _quyen)
        {
            this.taiKhoan = _taiKhoan;
            this.quyen = _quyen;
        }
        public TaiKhoan_DTO() { }
    }       
}
