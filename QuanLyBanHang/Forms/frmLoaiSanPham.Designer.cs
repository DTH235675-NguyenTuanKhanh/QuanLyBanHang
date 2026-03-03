namespace QuanLyBanHang.Forms
{
    partial class frmLoaiSanPham
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLoai = new TextBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            grbSp = new GroupBox();
            khoiTaoCSDLBindingSource = new BindingSource(components);
            loaiSanPhamBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLoaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            grbSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khoiTaoCSDLBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(778, 109);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(666, 109);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(86, 31);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huy bo";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(557, 109);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(86, 31);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(451, 109);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(345, 109);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(241, 109);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 2;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTenLoai.Location = new Point(241, 36);
            txtTenLoai.Margin = new Padding(3, 4, 3, 4);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(623, 39);
            txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Ten loai san pham(*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, tenLoaiDataGridViewTextBoxColumn });
            dataGridView.DataSource = loaiSanPhamBindingSource;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 24);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(875, 353);
            dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(17, 203);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(881, 381);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin san pham";
            // 
            // grbSp
            // 
            grbSp.Controls.Add(btnThoat);
            grbSp.Controls.Add(btnHuyBo);
            grbSp.Controls.Add(btnLuu);
            grbSp.Controls.Add(btnXoa);
            grbSp.Controls.Add(btnSua);
            grbSp.Controls.Add(btnThem);
            grbSp.Controls.Add(txtTenLoai);
            grbSp.Controls.Add(label1);
            grbSp.Location = new Point(17, 16);
            grbSp.Margin = new Padding(3, 4, 3, 4);
            grbSp.Name = "grbSp";
            grbSp.Padding = new Padding(3, 4, 3, 4);
            grbSp.Size = new Size(881, 179);
            grbSp.TabIndex = 2;
            grbSp.TabStop = false;
            grbSp.Text = "Thong tin san pham";
            // 
            // khoiTaoCSDLBindingSource
            // 
            khoiTaoCSDLBindingSource.DataSource = typeof(Migrations.KhoiTaoCSDL);
            // 
            // loaiSanPhamBindingSource
            // 
            loaiSanPhamBindingSource.DataSource = typeof(Data.LoaiSanPham);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Controls.Add(grbSp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLoaiSanPham";
            Text = "frmLoaiSanPham";
            Load += frmLoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            grbSp.ResumeLayout(false);
            grbSp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)khoiTaoCSDLBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLoai;
        private Label label1;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private GroupBox grbSp;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private BindingSource loaiSanPhamBindingSource;
        private BindingSource khoiTaoCSDLBindingSource;
    }
}