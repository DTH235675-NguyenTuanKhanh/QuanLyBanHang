using QuanLyBanHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlsp_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham f1 = new frmLoaiSanPham();
            f1.ShowDialog();
        }

        private void btnHangSX_Click(object sender, EventArgs e)
        {
            frmHangSanXuat f2 = new frmHangSanXuat();
            f2.ShowDialog();
        }
    }
}
