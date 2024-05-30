namespace QUANLYPHONGKHAM
{
    partial class DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVu));
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbbdonViDo = new ComboBox();
            nbrGia = new NumericUpDown();
            cbbTenDichVu = new ComboBox();
            btnLamMoi = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtGhichu = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTenDichVu = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtMaDV = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvDichVu = new DataGridView();
            groupBox3 = new GroupBox();
            label9 = new Label();
            btnTimKiem = new Button();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbrGia).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(510, 23);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC DỊCH VỤ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbdonViDo);
            groupBox1.Controls.Add(nbrGia);
            groupBox1.Controls.Add(cbbTenDichVu);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtGhichu);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTenDichVu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaDV);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 371);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // cbbdonViDo
            // 
            cbbdonViDo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbdonViDo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbdonViDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbdonViDo.FormattingEnabled = true;
            cbbdonViDo.Items.AddRange(new object[] { "ống", "ml", "không" });
            cbbdonViDo.Location = new Point(539, 231);
            cbbdonViDo.Name = "cbbdonViDo";
            cbbdonViDo.Size = new Size(182, 31);
            cbbdonViDo.TabIndex = 6;
            // 
            // nbrGia
            // 
            nbrGia.Location = new Point(539, 165);
            nbrGia.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nbrGia.Name = "nbrGia";
            nbrGia.Size = new Size(182, 30);
            nbrGia.TabIndex = 5;
            // 
            // cbbTenDichVu
            // 
            cbbTenDichVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenDichVu.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbTenDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenDichVu.FormattingEnabled = true;
            cbbTenDichVu.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbbTenDichVu.Location = new Point(152, 108);
            cbbTenDichVu.Name = "cbbTenDichVu";
            cbbTenDichVu.Size = new Size(204, 31);
            cbbTenDichVu.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(808, 221);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 48);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(808, 305);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(110, 48);
            btnCapNhat.TabIndex = 10;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(808, 136);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 48);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(808, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 48);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtGhichu
            // 
            txtGhichu.BorderStyle = BorderStyle.FixedSingle;
            txtGhichu.Font = new Font("Tahoma", 12F);
            txtGhichu.Location = new Point(539, 48);
            txtGhichu.Multiline = true;
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(182, 81);
            txtGhichu.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 48);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 12;
            label8.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 231);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 8;
            label6.Text = "Đơn vị đo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 161);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 6;
            label5.Text = "Giá:";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(152, 170);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(204, 30);
            txtTenDichVu.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 170);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 4;
            label4.Text = "Tên Dịch vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên Loại DV:";
            // 
            // txtMaDV
            // 
            txtMaDV.Enabled = false;
            txtMaDV.Location = new Point(152, 48);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(76, 30);
            txtMaDV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 48);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã DV:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDichVu);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 469);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1294, 330);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SACH DỊCH VỤ";
            // 
            // dgvDichVu
            // 
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDichVu.Location = new Point(6, 46);
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.RowHeadersWidth = 51;
            dgvDichVu.Size = new Size(1231, 256);
            dgvDichVu.TabIndex = 13;
            dgvDichVu.CellClick += dgvDichVu_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(983, 77);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(323, 362);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "TÌM KIẾM DỊCH VỤ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 85);
            label9.Name = "label9";
            label9.Size = new Size(281, 23);
            label9.TabIndex = 97;
            label9.Text = "*Lưu ý: Tìm kiếm theo tên Dịch vụ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(80, 143);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 48);
            btnTimKiem.TabIndex = 12;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(35, 39);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(203, 30);
            textBox6.TabIndex = 11;
            // 
            // DichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DichVu";
            Text = "DichVu";
            Load += DichVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbrGia).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenDichVu;
        private Label label4;
        private Label label3;
        private TextBox txtMaDV;
        private Label label2;
        private TextBox txtGhichu;
        private Label label8;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnLamMoi;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox3;
        private Label label9;
        private Button btnTimKiem;
        private TextBox textBox6;
        private DataGridView dgvDichVu;
        private ComboBox cbbTenDichVu;
        private NumericUpDown nbrGia;
        private ComboBox cbbdonViDo;
    }
}