using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = (int)r.ID, 
                NhanVienID = (int)r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = (int)r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                // Tính tổng tiền an toàn hơn
                TongTienHoaDon = r.HoaDonChiTiet.Sum(ct => (double?)ct.SoLuongBan * (double?)ct.DonGiaBan) ?? 0,
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập ID
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã ID hóa đơn cần tìm:", "Tìm kiếm theo ID", "");

            if (!string.IsNullOrEmpty(input))
            {
                // Kiểm tra xem người dùng có nhập đúng định dạng số không
                if (int.TryParse(input, out int id))
                {
                    DataTable dt = (DataTable)dataGridView.DataSource;
                    if (dt != null)
                    {
                        // Lọc chính xác theo cột ID
                        dt.DefaultView.RowFilter = string.Format("ID = {0}", id);

                        // Thông báo nếu không thấy
                        if (dataGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn có ID: " + id, "Thông báo");
                            dt.DefaultView.RowFilter = ""; // Hiển thị lại toàn bộ danh sách
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chỉ nhập số (ID là số nguyên)!", "Lỗi nhập liệu");
                }
            }
            else
            {
                // Nếu nhấn Cancel hoặc để trống thì hiện lại tất cả
                if (dataGridView.DataSource is BindingSource bs)
                {
                    bs.RemoveFilter();
                }
            }
        }
    }
}
