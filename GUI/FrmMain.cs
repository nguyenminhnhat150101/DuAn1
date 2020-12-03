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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static int session = 0;
        public static int profile = 0;
        public static string taikhoan;
        FrmDangNhap dn = new FrmDangNhap();
        private bool CheckExistsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void QuyenNV()
        {
            MS_QLDM.Visible = true;
            MS_LoaiSach.Visible = true;
            MS_Sach.Visible = true;
            MS_TacGia.Visible = true;
            MS_DocGia.Visible = true;
            MS_BaoCaoThongKe.Visible = true;
            MS_BCSach.Visible = true;
            MS_TKDocGia.Visible = true;
            MS_LapPhieu.Visible = true;
            MS_NhanVien.Visible = true;
            MS_DSNhanVien.Visible = true;

            MS_QLMuonTraSach.Visible = false;
            MS_MuonSach.Visible = false;
            MS_TraSach.Visible = false;
        }
        private void QuyenDG()
        {
            MS_QLDM.Visible = false;
            MS_LoaiSach.Visible = false;
            MS_Sach.Visible = false;
            MS_TacGia.Visible = false;
            MS_DocGia.Visible = false;
            MS_BaoCaoThongKe.Visible = false;
            MS_BCSach.Visible = false;
            MS_TKDocGia.Visible = false;
            MS_LapPhieu.Visible = false;
            MS_NhanVien.Visible = false;
            MS_DSNhanVien.Visible = false;

            MS_QLMuonTraSach.Visible = true;
            MS_MuonSach.Visible = true;
            MS_TraSach.Visible = true;
        }
        private void ResetValue()
        {
            if (session == 1)
            {
                txtChao.Text = "Chào " + FrmMain.taikhoan;

                MS_HeThong.Visible = true;
                MS_DangNhap.Enabled = false;
                MS_DangXuat.Visible = true;
                MS_Thoat.Visible = true;
                if (int.Parse(dn.Quyen) == 0)
                {
                    QuyenDG();
                }
                else
                {
                    QuyenNV();
                }
            }
            else
            {
                MS_QLDM.Visible = false;
                MS_LoaiSach.Visible = false;
                MS_Sach.Visible = false;
                MS_TacGia.Visible = false;
                MS_DocGia.Visible = false;
                MS_BaoCaoThongKe.Visible = false;
                MS_BCSach.Visible = false;
                MS_TKDocGia.Visible = false;
                MS_LapPhieu.Visible = false;
                MS_NhanVien.Visible = false;
                MS_DSNhanVien.Visible = false;
                MS_HeThong.Visible = true;
                MS_DangNhap.Enabled = true;
                MS_DangXuat.Visible = false;
                MS_Thoat.Visible = true;
                MS_QLMuonTraSach.Visible = false;
                MS_MuonSach.Visible = false;
                MS_TraSach.Visible = false;
                txtChao.Text = null;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1)
            {
                txtChao.Text = null;
                profile = 0;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MS_DangNhap_Click(object sender, EventArgs e)
        {
            dn = new FrmDangNhap();
            if (!CheckExistsForm("FrmDangNhap"))
            {
                dn.IsMdiContainer = true;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("FrmDangNhap");
            }
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
        }
    }
}
