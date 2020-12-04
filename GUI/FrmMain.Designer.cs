namespace GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.MS_QLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_LoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Sach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_TacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_QLMuonTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_MuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_TraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BCSach = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_TKDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_QLPhieuMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtChao = new System.Windows.Forms.ToolStripTextBox();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_QLDM,
            this.MS_QLMuonTraSach,
            this.MS_BaoCaoThongKe,
            this.MS_NhanVien,
            this.MS_HeThong,
            this.txtChao});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(800, 24);
            this.MS_Main.TabIndex = 4;
            this.MS_Main.Text = "menuStrip1";
            // 
            // MS_QLDM
            // 
            this.MS_QLDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_LoaiSach,
            this.MS_Sach,
            this.MS_TacGia,
            this.MS_DocGia});
            this.MS_QLDM.Name = "MS_QLDM";
            this.MS_QLDM.Size = new System.Drawing.Size(120, 20);
            this.MS_QLDM.Text = "Quản Lý Danh Mục";
            // 
            // MS_LoaiSach
            // 
            this.MS_LoaiSach.Name = "MS_LoaiSach";
            this.MS_LoaiSach.Size = new System.Drawing.Size(124, 22);
            this.MS_LoaiSach.Text = "Loại Sách";
            // 
            // MS_Sach
            // 
            this.MS_Sach.Name = "MS_Sach";
            this.MS_Sach.Size = new System.Drawing.Size(124, 22);
            this.MS_Sach.Text = "Sách";
            // 
            // MS_TacGia
            // 
            this.MS_TacGia.Name = "MS_TacGia";
            this.MS_TacGia.Size = new System.Drawing.Size(124, 22);
            this.MS_TacGia.Text = "Tác Giả";
            // 
            // MS_DocGia
            // 
            this.MS_DocGia.Name = "MS_DocGia";
            this.MS_DocGia.Size = new System.Drawing.Size(124, 22);
            this.MS_DocGia.Text = "Độc Giả";
            // 
            // MS_QLMuonTraSach
            // 
            this.MS_QLMuonTraSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_MuonSach,
            this.MS_TraSach});
            this.MS_QLMuonTraSach.Name = "MS_QLMuonTraSach";
            this.MS_QLMuonTraSach.Size = new System.Drawing.Size(151, 20);
            this.MS_QLMuonTraSach.Text = "Quản Lý Mượn - Trả Sách";
            // 
            // MS_MuonSach
            // 
            this.MS_MuonSach.Name = "MS_MuonSach";
            this.MS_MuonSach.Size = new System.Drawing.Size(156, 22);
            this.MS_MuonSach.Text = "Mượn Sách";
            // 
            // MS_TraSach
            // 
            this.MS_TraSach.Name = "MS_TraSach";
            this.MS_TraSach.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.MS_TraSach.Size = new System.Drawing.Size(156, 22);
            this.MS_TraSach.Text = "Trả Sách";
            // 
            // MS_BaoCaoThongKe
            // 
            this.MS_BaoCaoThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_BCSach,
            this.MS_TKDocGia,
            this.MS_QLPhieuMuon});
            this.MS_BaoCaoThongKe.Name = "MS_BaoCaoThongKe";
            this.MS_BaoCaoThongKe.Size = new System.Drawing.Size(124, 20);
            this.MS_BaoCaoThongKe.Text = "Báo Cáo - Thống Kê";
            // 
            // MS_BCSach
            // 
            this.MS_BCSach.Name = "MS_BCSach";
            this.MS_BCSach.Size = new System.Drawing.Size(185, 22);
            this.MS_BCSach.Text = "Báo Cáo Sách";
            // 
            // MS_TKDocGia
            // 
            this.MS_TKDocGia.Name = "MS_TKDocGia";
            this.MS_TKDocGia.Size = new System.Drawing.Size(185, 22);
            this.MS_TKDocGia.Text = "Thống Kê Độc Giả";
            // 
            // MS_QLPhieuMuon
            // 
            this.MS_QLPhieuMuon.Name = "MS_QLPhieuMuon";
            this.MS_QLPhieuMuon.Size = new System.Drawing.Size(185, 22);
            this.MS_QLPhieuMuon.Text = "Quản Lý Phiếu Mượn";
            // 
            // MS_NhanVien
            // 
            this.MS_NhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_DSNhanVien});
            this.MS_NhanVien.Name = "MS_NhanVien";
            this.MS_NhanVien.Size = new System.Drawing.Size(74, 20);
            this.MS_NhanVien.Text = "Nhân Viên";
            // 
            // MS_DSNhanVien
            // 
            this.MS_DSNhanVien.Name = "MS_DSNhanVien";
            this.MS_DSNhanVien.Size = new System.Drawing.Size(146, 22);
            this.MS_DSNhanVien.Text = "DS Nhân Viên";
            // 
            // MS_HeThong
            // 
            this.MS_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_DangNhap,
            this.MS_DangXuat,
            this.MS_Thoat});
            this.MS_HeThong.Name = "MS_HeThong";
            this.MS_HeThong.Size = new System.Drawing.Size(71, 20);
            this.MS_HeThong.Text = "Hệ Thống";
            // 
            // MS_DangNhap
            // 
            this.MS_DangNhap.Name = "MS_DangNhap";
            this.MS_DangNhap.Size = new System.Drawing.Size(134, 22);
            this.MS_DangNhap.Text = "Đăng Nhập";
            this.MS_DangNhap.Click += new System.EventHandler(this.MS_DangNhap_Click);
            // 
            // MS_DangXuat
            // 
            this.MS_DangXuat.Name = "MS_DangXuat";
            this.MS_DangXuat.Size = new System.Drawing.Size(134, 22);
            this.MS_DangXuat.Text = "Đăng Xuất";
            this.MS_DangXuat.Click += new System.EventHandler(this.MS_DangXuat_Click);
            // 
            // MS_Thoat
            // 
            this.MS_Thoat.Name = "MS_Thoat";
            this.MS_Thoat.Size = new System.Drawing.Size(134, 22);
            this.MS_Thoat.Text = "Thoát";
            // 
            // txtChao
            // 
            this.txtChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtChao.BackColor = System.Drawing.SystemColors.Window;
            this.txtChao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChao.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChao.ForeColor = System.Drawing.Color.Black;
            this.txtChao.Name = "txtChao";
            this.txtChao.ReadOnly = true;
            this.txtChao.Size = new System.Drawing.Size(220, 20);
            this.txtChao.Text = "nhatnmps13276@fpt.edu.vn";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MS_Main);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_QLDM;
        private System.Windows.Forms.ToolStripMenuItem MS_LoaiSach;
        private System.Windows.Forms.ToolStripMenuItem MS_Sach;
        private System.Windows.Forms.ToolStripMenuItem MS_TacGia;
        private System.Windows.Forms.ToolStripMenuItem MS_DocGia;
        private System.Windows.Forms.ToolStripMenuItem MS_QLMuonTraSach;
        private System.Windows.Forms.ToolStripMenuItem MS_MuonSach;
        private System.Windows.Forms.ToolStripMenuItem MS_TraSach;
        private System.Windows.Forms.ToolStripMenuItem MS_BaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem MS_BCSach;
        private System.Windows.Forms.ToolStripMenuItem MS_TKDocGia;
        private System.Windows.Forms.ToolStripMenuItem MS_QLPhieuMuon;
        private System.Windows.Forms.ToolStripMenuItem MS_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem MS_DSNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MS_HeThong;
        private System.Windows.Forms.ToolStripMenuItem MS_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem MS_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem MS_Thoat;
        private System.Windows.Forms.ToolStripTextBox txtChao;
    }
}