using Microsoft.EntityFrameworkCore;
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
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string hinhAnhTam = "";
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);
            // Tương tự đối với cboHangSanXuat
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtMoTa
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);
            // Tương tự đối với numDonGia
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dataGridView.DataSource = bindingSource;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*private void dataGridView_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang ở đúng cột Hình Ảnh (thay "HinhAnh" bằng Name của cột đó trong Design)
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                // Lấy dữ liệu của dòng hiện tại
                var sp = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;

                if (sp != null && !string.IsNullOrEmpty(sp.HinhAnh))
                {
                    try
                    {
                        // Đường dẫn đến file ảnh: bin/Debug/images/tên_file.jpg
                        string fullPath = Path.Combine(imagesFolder, sp.HinhAnh);
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            if (File.Exists(fullPath))
                            {
                                // Nạp ảnh từ file vào ô
                                e.Value = Image.FromStream(fs);
                            }
                    }
                    catch
                    {
                        e.Value = null;
                    }
                }
            }
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDcol"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                    sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                    // Tương tự với các form đã thực hiện
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.DonGia = (int)numDonGia.Value;
                    sp.SoLuong = (int)numSoLuong.Value;
                    sp.HinhAnh = xuLyThem ? hinhAnhTam : sp.HinhAnh;
                    sp.MoTa = txtMoTa.Text;

                    context.SanPham.Add(sp);
                    context.SaveChanges();
                    frmSanPham_Load(sender, e);
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.HangSanXuatID = (int)cboHangSanXuat.SelectedValue;
                        sp.LoaiSanPhamID = (int)cboLoaiSanPham.SelectedValue;
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.DonGia = (int)numDonGia.Value;
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.HinhAnh = picHinhAnh.ImageLocation;
                        sp.MoTa = txtMoTa.Text;

                        context.SaveChanges();
                        frmSanPham_Load(sender, e);
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDcol"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string fileSavePath = Path.Combine(imagesFolder, fileName + ext);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDcol"].Value.ToString());
                SanPham sp = context.SanPham.Find(id); sp.HinhAnh = fileName + ext;
                context.SanPham.Update(sp);
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã ID sản phẩm:", "Tìm kiếm sản phẩm", "");

            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int id))
                {
                    // Thay 'dgvSanPham' bằng tên DataGridView của bạn
                    DataTable dt = (DataTable)dataGridView.DataSource;
                    if (dt != null)
                    {
                        dt.DefaultView.RowFilter = string.Format("ID = {0}", id);

                        if (dataGridView.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo");
                            dt.DefaultView.RowFilter = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID là con số!", "Thông báo");
                }
            }
            else
            {
                if (dataGridView.DataSource is BindingSource bs)
                {
                    bs.RemoveFilter();
                }
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang ở đúng cột Hình Ảnh (thay "HinhAnh" bằng Name của cột đó trong Design)
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                // Lấy dữ liệu của dòng hiện tại
                var sp = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;

                if (sp != null && !string.IsNullOrEmpty(sp.HinhAnh))
                {
                    try
                    {
                        // Đường dẫn đến file ảnh: bin/Debug/images/tên_file.jpg
                        string fullPath = Path.Combine(imagesFolder, sp.HinhAnh);
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            if (File.Exists(fullPath))
                            {
                                // Nạp ảnh từ file vào ô
                                e.Value = Image.FromStream(fs);
                            }
                    }
                    catch
                    {
                        e.Value = null;
                    }
                }
            }
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
