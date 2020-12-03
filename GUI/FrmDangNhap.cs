using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        TaiKhoan_BUS busTaiKhoan = new TaiKhoan_BUS();
        public string Quyen { get; set; }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.TaiKhoan = txtTaiKhoan.Text;
            tk.MatKhau = busTaiKhoan.encryption(txtMatKhau.Text);
            if (busTaiKhoan.DangNhap(tk))
            {
                FrmMain.taikhoan = tk.TaiKhoan;
                DataTable dt = busTaiKhoan.KiemTraQuyen(tk.TaiKhoan);
                Quyen = dt.Rows[0][0].ToString();
                MessageBox.Show("Đăng nhập thành công");
                FrmMain.session = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                txtTaiKhoan.Text = null;
                txtMatKhau = null;
                txtTaiKhoan.Focus();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            FrmMain.session = 0;
        }
    }
}
