namespace QuanLyBanHang.Forms
{
    partial class frmHoaDonChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            soLuongBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            donGiaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            hoaDonChiTietBindingSource = new BindingSource(components);
            button1 = new Button();
            btnXoa = new Button();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            btnLuuHoaDon = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1024, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtGhiChuHoaDon.Location = new Point(172, 85);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(846, 34);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(160, 28);
            label3.TabIndex = 4;
            label3.Text = "Ghi chú hóa đơn:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(664, 20);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(354, 36);
            cboKhachHang.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(168, 20);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(354, 36);
            cboNhanVien.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhân viên lập(*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(528, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Khách Hàng(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1024, 446);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn chi tiết";
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, TenSanPham, soLuongBanDataGridViewTextBoxColumn, donGiaBanDataGridViewTextBoxColumn, ThanhTien });
            dataGridView.DataSource = hoaDonChiTietBindingSource;
            dataGridView.Location = new Point(6, 137);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1012, 297);
            dataGridView.TabIndex = 13;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên Sản Phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // soLuongBanDataGridViewTextBoxColumn
            // 
            soLuongBanDataGridViewTextBoxColumn.DataPropertyName = "SoLuongBan";
            soLuongBanDataGridViewTextBoxColumn.HeaderText = "Số Lượng Bán";
            soLuongBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            soLuongBanDataGridViewTextBoxColumn.Name = "soLuongBanDataGridViewTextBoxColumn";
            // 
            // donGiaBanDataGridViewTextBoxColumn
            // 
            donGiaBanDataGridViewTextBoxColumn.DataPropertyName = "DonGiaBan";
            donGiaBanDataGridViewTextBoxColumn.HeaderText = "Đơn Giá Bán";
            donGiaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            donGiaBanDataGridViewTextBoxColumn.Name = "donGiaBanDataGridViewTextBoxColumn";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle1;
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // hoaDonChiTietBindingSource
            // 
            hoaDonChiTietBindingSource.DataSource = typeof(Data.HoaDonChiTiet);
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(775, 77);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 12;
            button1.Text = "Xác nhận bán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(920, 78);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 38);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            numDonGiaBan.Location = new Point(581, 81);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(178, 34);
            numDonGiaBan.TabIndex = 10;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            numSoLuongBan.Location = new Point(352, 81);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(178, 34);
            numSoLuongBan.TabIndex = 9;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(581, 41);
            label6.Name = "label6";
            label6.Size = new Size(154, 28);
            label6.TabIndex = 8;
            label6.Text = "Số lượng bán(*):";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(352, 41);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 7;
            label5.Text = "Đơn giá bán(*):";
            // 
            // cboSanPham
            // 
            cboSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(43, 81);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(256, 36);
            cboSanPham.TabIndex = 6;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(43, 41);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 2;
            label4.Text = "Sản phẩm(*):";
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.AutoSize = true;
            btnInHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnInHoaDon.ForeColor = Color.Black;
            btnInHoaDon.Location = new Point(430, 644);
            btnInHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(182, 38);
            btnInHoaDon.TabIndex = 17;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.AutoSize = true;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(634, 644);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 38);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.AutoSize = true;
            btnLuuHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(232, 644);
            btnLuuHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(182, 38);
            btnLuuHoaDon.TabIndex = 15;
            btnLuuHoaDon.Text = "Lưu hóa đơn...";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // frmHoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 717);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnThoat);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDonChiTiet";
            Text = "Hóa Đơn Chi TIết";
            Load += frmHoaDonChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonChiTietBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cboNhanVien;
        private Label label2;
        private ComboBox cboKhachHang;
        private TextBox txtGhiChuHoaDon;
        private Label label3;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private ComboBox cboSanPham;
        private Label label4;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private DataGridView dataGridView;
        private Button button1;
        private Button btnXoa;
        private BindingSource hoaDonChiTietBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn soLuongBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn donGiaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnInHoaDon;
        private Button btnThoat;
        private Button btnLuuHoaDon;
    }
}