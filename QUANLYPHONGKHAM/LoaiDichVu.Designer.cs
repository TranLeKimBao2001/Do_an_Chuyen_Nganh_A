namespace QUANLYPHONGKHAM
{
    partial class LoaiDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiDichVu));
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnCapnhat = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtghiChu = new TextBox();
            label4 = new Label();
            txtTenLoaiDichVu = new TextBox();
            label3 = new Label();
            txtMaLoaiDichVu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvLoaiDichVu = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDichVu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnCapnhat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtghiChu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenLoaiDichVu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLoaiDichVu);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(955, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN LOẠI DỊCH VỤ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(679, 146);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 48);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Location = new Point(534, 146);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(110, 48);
            btnCapnhat.TabIndex = 6;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(679, 61);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 48);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(534, 61);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 48);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtghiChu
            // 
            txtghiChu.BorderStyle = BorderStyle.FixedSingle;
            txtghiChu.Font = new Font("Tahoma", 12F);
            txtghiChu.Location = new Point(190, 180);
            txtghiChu.Multiline = true;
            txtghiChu.Name = "txtghiChu";
            txtghiChu.Size = new Size(265, 81);
            txtghiChu.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 171);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 4;
            label4.Text = "Ghi chú:";
            // 
            // txtTenLoaiDichVu
            // 
            txtTenLoaiDichVu.Location = new Point(190, 112);
            txtTenLoaiDichVu.Name = "txtTenLoaiDichVu";
            txtTenLoaiDichVu.Size = new Size(265, 30);
            txtTenLoaiDichVu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 112);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên Loại Dịch vụ:";
            // 
            // txtMaLoaiDichVu
            // 
            txtMaLoaiDichVu.Enabled = false;
            txtMaLoaiDichVu.Location = new Point(190, 51);
            txtMaLoaiDichVu.Name = "txtMaLoaiDichVu";
            txtMaLoaiDichVu.ReadOnly = true;
            txtMaLoaiDichVu.Size = new Size(76, 30);
            txtMaLoaiDichVu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 51);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại Dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 14);
            label1.Name = "label1";
            label1.Size = new Size(367, 38);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC LOẠI DỊCH VỤ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoaiDichVu);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 323);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH CÁC LOẠI DỊCH VỤ";
            // 
            // dgvLoaiDichVu
            // 
            dgvLoaiDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDichVu.Location = new Point(6, 45);
            dgvLoaiDichVu.Name = "dgvLoaiDichVu";
            dgvLoaiDichVu.RowHeadersWidth = 51;
            dgvLoaiDichVu.Size = new Size(949, 272);
            dgvLoaiDichVu.TabIndex = 8;
            dgvLoaiDichVu.CellClick += dgvLoaiDichVu_CellClick;
            dgvLoaiDichVu.CellContentClick += dgvLoaiDichVu_CellContentClick;
            // 
            // LoaiDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 746);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoaiDichVu";
            Text = "Danh Mục";
            Load += LoaiDichVu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenLoaiDichVu;
        private Label label3;
        private TextBox txtMaLoaiDichVu;
        private Label label2;
        private Label label1;
        private Button btnLamMoi;
        private Button btnCapnhat;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtghiChu;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dgvLoaiDichVu;
    }
}