namespace QUANLYPHONGKHAM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtTaiKhoan = new TextBox();
            btnDangNhap = new Button();
            label2 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            ckbHienMatKhau = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(273, 21);
            label1.Name = "label1";
            label1.Size = new Size(177, 24);
            label1.TabIndex = 0;
            label1.Text = "TÊN ĐĂNG NHẬP";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Tahoma", 12F);
            txtTaiKhoan.Location = new Point(222, 62);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(335, 32);
            txtTaiKhoan.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.Location = new Point(295, 444);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(184, 53);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.TextAlign = ContentAlignment.MiddleRight;
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(293, 114);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 3;
            label2.Text = "MẬT KHẨU";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Tahoma", 12F);
            txtMatKhau.Location = new Point(222, 153);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(335, 32);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(286, 28);
            label3.TabIndex = 5;
            label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MediumTurquoise;
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 57);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(675, 444);
            button1.Name = "button1";
            button1.Size = new Size(184, 53);
            button1.TabIndex = 5;
            button1.Text = "THOÁT";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(ckbHienMatKhau);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(txtMatKhau);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtTaiKhoan);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(302, 122);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(591, 251);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // ckbHienMatKhau
            // 
            ckbHienMatKhau.AutoSize = true;
            ckbHienMatKhau.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbHienMatKhau.ForeColor = Color.Red;
            ckbHienMatKhau.Location = new Point(399, 213);
            ckbHienMatKhau.Name = "ckbHienMatKhau";
            ckbHienMatKhau.Size = new Size(184, 25);
            ckbHienMatKhau.TabIndex = 3;
            ckbHienMatKhau.Text = "Hiển thị mật khẩu";
            ckbHienMatKhau.UseVisualStyleBackColor = true;
            ckbHienMatKhau.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(125, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 190);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(18, 70);
            label4.Name = "label4";
            label4.Size = new Size(461, 24);
            label4.TabIndex = 6;
            label4.Text = "PHẦN MỀM QUẢN LÝ PHÒNG KHÁM TƯ NHÂN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(888, 509);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnDangNhap);
            DoubleBuffered = true;
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý phòng khám [HỆ THỐNG ĐĂNG NHẬP]";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTaiKhoan;
        private Button btnDangNhap;
        private Label label2;
        private TextBox txtMatKhau;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox3;
        private CheckBox ckbHienMatKhau;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
    }
}