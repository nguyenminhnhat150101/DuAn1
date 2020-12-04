using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai_DTO
    {
        private string maTheLoai;
        private string tenTheLoai;
        public string MaTheLoai { get { return maTheLoai; } set { maTheLoai = value; } }
        public string TenTheLoai { get { return tenTheLoai; } set { tenTheLoai = value; } }

        public TheLoai_DTO(string _maTheLoai, string _tenTheLoai) 
        {
            this.maTheLoai = _maTheLoai;
            this.tenTheLoai = _tenTheLoai;
        }
    }
}
