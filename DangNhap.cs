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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            UngDungQuanLiKS.Menu mh = new UngDungQuanLiKS.Menu();
            mh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UngDungQuanLiKS.NhanVien mh = new UngDungQuanLiKS.NhanVien();
            mh.Show();
        }

       
    }
}
