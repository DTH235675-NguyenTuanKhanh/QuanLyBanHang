namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            khachHangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            hoaDonBindingSource = new BindingSource(components);
            hoaDonChiTietBindingSource = new BindingSource(components);
            hoaDonChiTietBindingSource1 = new BindingSource(components);
            btnThoat = new Button();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLapHoaDon = new Button();
            btnInHoaDon = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1284, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, ngayLapDataGridViewTextBoxColumn, khachHangDataGridViewTextBoxColumn, nhanVienDataGridViewTextBoxColumn, TongTien, XemChiTiet });
            dataGridView.DataSource = hoaDonBindingSource;
            dataGridView.Location = new Point(6, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1272, 295);
            dataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            ngayLapDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // khachHangDataGridViewTextBoxColumn
            // 
            khachHangDataGridViewTextBoxColumn.DataPropertyName = "KhachHang";
            khachHangDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            khachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            khachHangDataGridViewTextBoxColumn.Name = "khachHangDataGridViewTextBoxColumn";
            // 
            // nhanVienDataGridViewTextBoxColumn
            // 
            nhanVienDataGridViewTextBoxColumn.DataPropertyName = "NhanVien";
            nhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            nhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            nhanVienDataGridViewTextBoxColumn.Name = "nhanVienDataGridViewTextBoxColumn";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.HeaderText = "Xem Chi Tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            // 
            // hoaDonBindingSource
            // 
            hoaDonBindingSource.DataSource = typeof(Data.HoaDon);
            // 
            // hoaDonChiTietBindingSource
            // 
            hoaDonChiTietBindingSource.DataMember = "HoaDonChiTiet";
            hoaDonChiTietBindingSource.DataSource = hoaDonBindingSource;
            // 
            // hoaDonChiTietBindingSource1
            // 
            hoaDonChiTietBindingSource1.DataMember = "HoaDonChiTiet";
            hoaDonChiTietBindingSource1.DataSource = hoaDonBindingSource;
            // 
            // btnThoat
            // 
            btnThoat.AutoSize = true;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(901, 372);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 38);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.AutoSize = true;
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXuat.Location = new Point(1012, 372);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(118, 38);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất Excel..";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = true;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(763, 372);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(111, 38);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm Kiếm..";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(657, 372);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 38);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSua.Location = new Point(552, 372);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 38);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.AutoSize = true;
            btnLapHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Location = new Point(148, 372);
            btnLapHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(182, 38);
            btnLapHoaDon.TabIndex = 8;
            btnLapHoaDon.Text = "Lập hóa đơn mới...";
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.AutoSize = true;
            btnInHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnInHoaDon.ForeColor = Color.Black;
            btnInHoaDon.Location = new Point(346, 372);
            btnInHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(182, 38);
            btnInHoaDon.TabIndex = 14;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 450);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnThoat);
            Controls.Add(btnXuat);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLapHoaDon);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            Text = "Hóa Đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private BindingSource hoaDonBindingSource;
        private BindingSource hoaDonChiTietBindingSource;
        private BindingSource hoaDonChiTietBindingSource1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn khachHangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLapHoaDon;
        private Button btnInHoaDon;
    }
}