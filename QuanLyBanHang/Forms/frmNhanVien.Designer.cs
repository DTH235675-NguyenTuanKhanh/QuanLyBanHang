namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            nhanVienBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            txtMatKhau = new TextBox();
            label5 = new Label();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoVaTenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dienThoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDangNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matKhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quyenHanDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1135, 419);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, hoVaTenDataGridViewTextBoxColumn, dienThoaiDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn, tenDangNhapDataGridViewTextBoxColumn, matKhauDataGridViewTextBoxColumn, quyenHanDataGridViewCheckBoxColumn });
            dataGridView.DataSource = nhanVienBindingSource;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 24);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1129, 391);
            dataGridView.TabIndex = 0;
            // 
            // nhanVienBindingSource
            // 
            nhanVienBindingSource.DataSource = typeof(Data.NhanVien);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1126, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Location = new Point(512, 109);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(216, 28);
            cboQuyenHan.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(380, 109);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 17;
            label6.Text = "Quyền Hạn";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(512, 68);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(216, 27);
            txtMatKhau.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(393, 68);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 15;
            label5.Text = "Mật Khẩu";
            label5.Click += label5_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(512, 31);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(216, 27);
            txtTenDangNhap.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(366, 30);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 13;
            label4.Text = "Tên Đăng Nhập";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(993, 109);
            btnXuat.Margin = new Padding(3, 4, 3, 4);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(101, 31);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(993, 70);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(101, 31);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(993, 32);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 31);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm..";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(876, 108);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.RightToLeft = RightToLeft.Yes;
            btnThoat.Size = new Size(102, 31);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(876, 70);
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
            btnLuu.Location = new Point(876, 31);
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
            btnXoa.Location = new Point(757, 108);
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
            btnSua.Location = new Point(757, 70);
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
            btnThem.Location = new Point(757, 31);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(120, 105);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(240, 27);
            txtDienThoai.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Điện thoại";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(120, 67);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(240, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(24, 67);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(120, 30);
            txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(240, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            hoVaTenDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            hoVaTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            dienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.HeaderText = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // quyenHanDataGridViewCheckBoxColumn
            // 
            quyenHanDataGridViewCheckBoxColumn.DataPropertyName = "QuyenHan";
            quyenHanDataGridViewCheckBoxColumn.HeaderText = "QuyenHan";
            quyenHanDataGridViewCheckBoxColumn.MinimumWidth = 6;
            quyenHanDataGridViewCheckBoxColumn.Name = "quyenHanDataGridViewCheckBoxColumn";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 592);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private Label label6;
        private TextBox txtMatKhau;
        private Label label5;
        private TextBox txtTenDangNhap;
        private Label label4;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtHoVaTen;
        private Label label1;
        private BindingSource nhanVienBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn quyenHanDataGridViewCheckBoxColumn;
    }
}