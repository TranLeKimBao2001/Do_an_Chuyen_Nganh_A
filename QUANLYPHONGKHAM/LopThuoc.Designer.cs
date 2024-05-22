namespace QUANLYPHONGKHAM
{
    partial class LopThuoc
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
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            button6 = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            rtbGhiChu = new RichTextBox();
            label3 = new Label();
            txtTenLopThuoc = new TextBox();
            label2 = new Label();
            txtMaLopThuoc = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvDSLopTHuoc = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSLopTHuoc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(rtbGhiChu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenLopThuoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaLopThuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1102, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN LỚP THUỐC";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(696, 271);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(138, 58);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // button6
            // 
            button6.Location = new Point(696, 191);
            button6.Name = "button6";
            button6.Size = new Size(138, 58);
            button6.TabIndex = 6;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(696, 110);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 58);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(696, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 58);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // rtbGhiChu
            // 
            rtbGhiChu.Location = new Point(183, 174);
            rtbGhiChu.Name = "rtbGhiChu";
            rtbGhiChu.Size = new Size(262, 120);
            rtbGhiChu.TabIndex = 3;
            rtbGhiChu.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 174);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Ghi chú:";
            // 
            // txtTenLopThuoc
            // 
            txtTenLopThuoc.Location = new Point(183, 110);
            txtTenLopThuoc.Name = "txtTenLopThuoc";
            txtTenLopThuoc.Size = new Size(262, 31);
            txtTenLopThuoc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 110);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên Loại Thuốc:";
            // 
            // txtMaLopThuoc
            // 
            txtMaLopThuoc.Enabled = false;
            txtMaLopThuoc.Location = new Point(183, 47);
            txtMaLopThuoc.Name = "txtMaLopThuoc";
            txtMaLopThuoc.ReadOnly = true;
            txtMaLopThuoc.Size = new Size(125, 31);
            txtMaLopThuoc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Loại Thuốc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDSLopTHuoc);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1102, 307);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "DANH SÁCH LỚP THUỐC";
            // 
            // dgvDSLopTHuoc
            // 
            dgvDSLopTHuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSLopTHuoc.Location = new Point(19, 49);
            dgvDSLopTHuoc.Name = "dgvDSLopTHuoc";
            dgvDSLopTHuoc.RowHeadersWidth = 51;
            dgvDSLopTHuoc.Size = new Size(1047, 219);
            dgvDSLopTHuoc.TabIndex = 8;
            dgvDSLopTHuoc.CellClick += dgvDSLopTHuoc_CellClick;
            // 
            // LopThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 715);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LopThuoc";
            Text = "Danh mục";
            Load += LopThuoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDSLopTHuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtTenLopThuoc;
        private Label label2;
        private TextBox txtMaLopThuoc;
        private Label label1;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private DataGridView dgvDSLopTHuoc;
        private RichTextBox rtbGhiChu;
        private Button btnLamMoi;
        private Button button6;
        private Button btnXoa;
        private Button btnThem;
    }
}