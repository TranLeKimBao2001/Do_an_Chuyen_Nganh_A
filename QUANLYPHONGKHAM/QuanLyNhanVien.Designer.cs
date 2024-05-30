namespace QUANLYPHONGKHAM
{
    partial class QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVien));
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txthinhanh = new TextBox();
            label12 = new Label();
            txtmatKhau = new TextBox();
            label11 = new Label();
            txttaiKhoan = new TextBox();
            dtpNgayvaolam = new DateTimePicker();
            label10 = new Label();
            cbbchucVu = new ComboBox();
            label9 = new Label();
            cbbgioiTinh = new ComboBox();
            dtpngaySinh = new DateTimePicker();
            btnchonHinh = new Button();
            btnLammoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            pbhinhAnhNV = new PictureBox();
            label7 = new Label();
            txtdiaChi = new TextBox();
            label6 = new Label();
            txtCCCD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txthoten = new TextBox();
            label3 = new Label();
            txtMaNV = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dgvDSNhanVien = new DataGridView();
            errorPCCCD = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhAnhNV).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPCCCD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(508, 20);
            label1.Name = "label1";
            label1.Size = new Size(399, 50);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txthinhanh);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtmatKhau);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txttaiKhoan);
            groupBox2.Controls.Add(dtpNgayvaolam);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cbbchucVu);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbbgioiTinh);
            groupBox2.Controls.Add(dtpngaySinh);
            groupBox2.Controls.Add(btnchonHinh);
            groupBox2.Controls.Add(btnLammoi);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(pbhinhAnhNV);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtdiaChi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCCCD);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txthoten);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(24, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1670, 388);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN NHÂN VIÊN";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label8.Location = new Point(551, 262);
            label8.Name = "label8";
            label8.Size = new Size(105, 24);
            label8.TabIndex = 33;
            label8.Text = "Ten hinh:";
            // 
            // txthinhanh
            // 
            txthinhanh.Location = new Point(739, 262);
            txthinhanh.Name = "txthinhanh";
            txthinhanh.Size = new Size(352, 34);
            txthinhanh.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label12.Location = new Point(551, 209);
            label12.Name = "label12";
            label12.Size = new Size(111, 24);
            label12.TabIndex = 31;
            label12.Text = "Mật khẩu:";
            // 
            // txtmatKhau
            // 
            txtmatKhau.Location = new Point(739, 206);
            txtmatKhau.Name = "txtmatKhau";
            txtmatKhau.Size = new Size(352, 34);
            txtmatKhau.TabIndex = 10;
            txtmatKhau.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label11.Location = new Point(551, 158);
            label11.Name = "label11";
            label11.Size = new Size(115, 24);
            label11.TabIndex = 29;
            label11.Text = "Tài khoản:";
            // 
            // txttaiKhoan
            // 
            txttaiKhoan.Location = new Point(739, 149);
            txttaiKhoan.Name = "txttaiKhoan";
            txttaiKhoan.Size = new Size(352, 34);
            txttaiKhoan.TabIndex = 9;
            // 
            // dtpNgayvaolam
            // 
            dtpNgayvaolam.CustomFormat = "dd/MM/yyyy";
            dtpNgayvaolam.Format = DateTimePickerFormat.Custom;
            dtpNgayvaolam.Location = new Point(176, 153);
            dtpNgayvaolam.Name = "dtpNgayvaolam";
            dtpNgayvaolam.Size = new Size(352, 34);
            dtpNgayvaolam.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label10.Location = new Point(551, 111);
            label10.Name = "label10";
            label10.Size = new Size(154, 24);
            label10.TabIndex = 25;
            label10.Text = "Ngày vào làm:";
            // 
            // cbbchucVu
            // 
            cbbchucVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbchucVu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbchucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbchucVu.FormattingEnabled = true;
            cbbchucVu.Items.AddRange(new object[] { "Y tá", "Bác sỹ", "Dược sỹ", "Admin" });
            cbbchucVu.Location = new Point(739, 51);
            cbbchucVu.Name = "cbbchucVu";
            cbbchucVu.Size = new Size(352, 36);
            cbbchucVu.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label9.Location = new Point(551, 57);
            label9.Name = "label9";
            label9.Size = new Size(99, 24);
            label9.TabIndex = 23;
            label9.Text = "Chức vụ:";
            // 
            // cbbgioiTinh
            // 
            cbbgioiTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbgioiTinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbgioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbgioiTinh.FormattingEnabled = true;
            cbbgioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbgioiTinh.Location = new Point(176, 256);
            cbbgioiTinh.Name = "cbbgioiTinh";
            cbbgioiTinh.Size = new Size(83, 36);
            cbbgioiTinh.TabIndex = 5;
            // 
            // dtpngaySinh
            // 
            dtpngaySinh.CustomFormat = "dd/MM/yyyy";
            dtpngaySinh.Format = DateTimePickerFormat.Custom;
            dtpngaySinh.Location = new Point(739, 102);
            dtpngaySinh.Name = "dtpngaySinh";
            dtpngaySinh.Size = new Size(352, 34);
            dtpngaySinh.TabIndex = 8;
            dtpngaySinh.ValueChanged += dtpngaySinh_ValueChanged;
            // 
            // btnchonHinh
            // 
            btnchonHinh.Location = new Point(1179, 320);
            btnchonHinh.Name = "btnchonHinh";
            btnchonHinh.Size = new Size(156, 37);
            btnchonHinh.TabIndex = 12;
            btnchonHinh.Text = "Chọn hình...";
            btnchonHinh.UseVisualStyleBackColor = true;
            btnchonHinh.Click += button5_Click_1;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(1484, 246);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(156, 37);
            btnLammoi.TabIndex = 16;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1484, 175);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(156, 37);
            btnSua.TabIndex = 15;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1484, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(156, 37);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1484, 104);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(156, 37);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // pbhinhAnhNV
            // 
            pbhinhAnhNV.BorderStyle = BorderStyle.FixedSingle;
            pbhinhAnhNV.Image = (Image)resources.GetObject("pbhinhAnhNV.Image");
            pbhinhAnhNV.Location = new Point(1110, 30);
            pbhinhAnhNV.Name = "pbhinhAnhNV";
            pbhinhAnhNV.Size = new Size(322, 268);
            pbhinhAnhNV.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhinhAnhNV.TabIndex = 12;
            pbhinhAnhNV.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label7.Location = new Point(16, 317);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 10;
            label7.Text = "Địa chỉ:";
            // 
            // txtdiaChi
            // 
            txtdiaChi.Location = new Point(176, 311);
            txtdiaChi.Name = "txtdiaChi";
            txtdiaChi.Size = new Size(352, 34);
            txtdiaChi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label6.Location = new Point(15, 262);
            label6.Name = "label6";
            label6.Size = new Size(102, 24);
            label6.TabIndex = 8;
            label6.Text = "Giới tính:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(176, 203);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(352, 34);
            txtCCCD.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.Location = new Point(15, 209);
            label5.Name = "label5";
            label5.Size = new Size(71, 24);
            label5.TabIndex = 6;
            label5.Text = "CCCD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 158);
            label4.Name = "label4";
            label4.Size = new Size(117, 24);
            label4.TabIndex = 4;
            label4.Text = "Ngày sinh:";
            // 
            // txthoten
            // 
            txthoten.Location = new Point(176, 105);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(352, 34);
            txthoten.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 111);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Enabled = false;
            txtMaNV.Location = new Point(176, 47);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(83, 34);
            txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.Location = new Point(16, 57);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 0;
            label2.Text = "Mã NV:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDSNhanVien);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 192);
            groupBox1.Location = new Point(3, 504);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1690, 339);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvDSNhanVien
            // 
            dgvDSNhanVien.BackgroundColor = Color.RosyBrown;
            dgvDSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSNhanVien.Location = new Point(20, 38);
            dgvDSNhanVien.Name = "dgvDSNhanVien";
            dgvDSNhanVien.RowHeadersWidth = 51;
            dgvDSNhanVien.ScrollBars = ScrollBars.Vertical;
            dgvDSNhanVien.Size = new Size(1649, 280);
            dgvDSNhanVien.TabIndex = 0;
            dgvDSNhanVien.CellClick += dgvDSNhanVien_CellClick;
            dgvDSNhanVien.CellContentClick += dgvDSNhanVien_CellContentClick;
            // 
            // errorPCCCD
            // 
            errorPCCCD.ContainerControl = this;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1720, 834);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuanLyNhanVien";
            Text = "DANH MỤC";
            Load += QuanLyNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhAnhNV).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPCCCD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnSua;
        private Button btnThem;
        private Button btnXoa;
        private PictureBox pbhinhAnhNV;
        private Label label7;
        private TextBox txtdiaChi;
        private Label label6;
        private TextBox txtCCCD;
        private Label label5;
        private Label label4;
        private TextBox txthoten;
        private Label label3;
        private TextBox txtMaNV;
        private Label label2;
        private Button btnchonHinh;
        private Button btnLammoi;
        private GroupBox groupBox1;
        private DataGridView dgvDSNhanVien;
        private ComboBox cbbgioiTinh;
        private DateTimePicker dtpngaySinh;
        private DateTimePicker dtpNgayvaolam;
        private Label label10;
        private ComboBox cbbchucVu;
        private Label label9;
        private Label label12;
        private TextBox txtmatKhau;
        private Label label11;
        private TextBox txttaiKhoan;
        private Label label8;
        private TextBox txthinhanh;
        private ErrorProvider errorPCCCD;
    }
}