using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLiKS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void chuyểnNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DoiMatKhau mh = new DoiMatKhau();
            mh.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap mh = new DangNhap();
            mh.Show();
        }

        private void danhMụcNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNguoiDung mh = new DanhMucNguoiDung();
            mh.Show();
        }

        private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongTrong mh = new PhongTrong();
            mh.Show();
        }

        private void phòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongThue mh = new PhongThue();
            mh.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu mh = new DichVu();
            mh.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien mh = new NhanVien();
            mh.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang mh = new KhachHang();
            mh.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu mh = new ChucVu();
            mh.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon mh = new HoaDon();
            mh.Show();
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuChi mh = new PhieuChi();
            mh.Show();
        }

      

      
    }
}
