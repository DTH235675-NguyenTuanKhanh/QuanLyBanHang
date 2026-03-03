namespace QuanLyBanHang.Forms
{
    partial class frmSanPham
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            sanPhamBindingSource1 = new BindingSource(components);
            sanPhamBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnTimKiem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            cboHangSanXuat = new ComboBox();
            label1 = new Label();
            cboLoaiSanPham = new ComboBox();
            label6 = new Label();
            txtMoTa = new TextBox();
            label5 = new Label();
            txtTenSanPham = new TextBox();
            label4 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            IDcol = new DataGridViewTextBoxColumn();
            LoaiSanPham = new DataGridViewTextBoxColumn();
            HangSanXuat = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(4, 263);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1273, 377);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDcol, LoaiSanPham, HangSanXuat, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, HinhAnh });
            dataGridView.DataSource = sanPhamBindingSource1;
            dataGridView.Location = new Point(6, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 20;
            dataGridView.Size = new Size(1261, 343);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // sanPhamBindingSource1
            // 
            sanPhamBindingSource1.DataSource = typeof(Data.SanPham);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1270, 249);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1050, 199);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 31);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(969, 38);
            btnDoiAnh.Margin = new Padding(3, 4, 3, 4);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(101, 31);
            btnDoiAnh.TabIndex = 26;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(794, 38);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(156, 141);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 25;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(535, 83);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(216, 27);
            numDonGia.TabIndex = 24;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(535, 36);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(216, 27);
            numSoLuong.TabIndex = 23;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(416, 77);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 22;
            label3.Text = "Đơn giá(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(405, 35);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 21;
            label2.Text = "Số lượng(*):";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(166, 77);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(216, 28);
            cboHangSanXuat.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(6, 73);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 19;
            label1.Text = "Hãng sản xuất(*):";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(166, 35);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(216, 28);
            cboLoaiSanPham.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(34, 36);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 17;
            label6.Text = "Phân loại(*):";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(166, 155);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(585, 27);
            txtMoTa.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(7, 151);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 15;
            label5.Text = "Mô tả sản phẩm:";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(166, 117);
            txtTenSanPham.Margin = new Padding(3, 4, 3, 4);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(585, 27);
            txtTenSanPham.TabIndex = 14;
            txtTenSanPham.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(11, 113);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 13;
            label4.Text = "Tên sản phẩm(*):";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(930, 199);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(101, 31);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(809, 199);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(101, 31);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(688, 199);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.RightToLeft = RightToLeft.Yes;
            btnThoat.Size = new Size(102, 31);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(568, 199);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(102, 31);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(451, 199);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(102, 31);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(333, 199);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(216, 199);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(98, 199);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // IDcol
            // 
            IDcol.DataPropertyName = "ID";
            IDcol.FillWeight = 42.78075F;
            IDcol.HeaderText = "ID";
            IDcol.MinimumWidth = 6;
            IDcol.Name = "IDcol";
            // 
            // LoaiSanPham
            // 
            LoaiSanPham.DataPropertyName = "TenLoai";
            LoaiSanPham.HeaderText = "LoaiSanPham";
            LoaiSanPham.MinimumWidth = 6;
            LoaiSanPham.Name = "LoaiSanPham";
            // 
            // HangSanXuat
            // 
            HangSanXuat.DataPropertyName = "TenHangSanXuat";
            HangSanXuat.HeaderText = "HangSanXuat";
            HangSanXuat.MinimumWidth = 6;
            HangSanXuat.Name = "HangSanXuat";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TenSanPham";
            dataGridViewTextBoxColumn2.FillWeight = 108.174171F;
            dataGridViewTextBoxColumn2.HeaderText = "TenSanPham";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            dataGridViewTextBoxColumn3.FillWeight = 108.174171F;
            dataGridViewTextBoxColumn3.HeaderText = "DonGia";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn4.FillWeight = 108.174171F;
            dataGridViewTextBoxColumn4.HeaderText = "SoLuong";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "HinhAnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSanPham";
            Text = "SanPham";
            Load += frmSanPham_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanPhamBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox cboLoaiSanPham;
        private Label label6;
        private TextBox txtMoTa;
        private Label label5;
        private TextBox txtTenSanPham;
        private Label label4;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboHangSanXuat;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox picHinhAnh;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private Button btnDoiAnh;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hangSanXuatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private BindingSource sanPhamBindingSource;
        private DataGridView dataGridView;
        private BindingSource sanPhamBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button btnTimKiem;
        private DataGridViewTextBoxColumn IDcol;
        private DataGridViewTextBoxColumn LoaiSanPham;
        private DataGridViewTextBoxColumn HangSanXuat;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn HinhAnh;
    }
}