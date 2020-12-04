using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=LAPTOP-GD5M7TGB;Initial Catalog=QLThuVien;Integrated Security=True");
    }
}
