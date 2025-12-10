namespace Dayone.GUI
{
    partial class SinhVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCốVấnHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongtinchitietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoimatkhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.cbbMaCoVan = new System.Windows.Forms.ComboBox();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpkNhapHoc = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbQueQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLy,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.quảnLýCốVấnHọcTậpToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem});
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(65, 19);
            this.btnQuanLy.Text = "Quản Lý ";
            this.btnQuanLy.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa ";
            this.quảnLýKhoaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKhoaToolStripMenuItem_Click);
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            this.quảnLýLớpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpToolStripMenuItem_Click);
            // 
            // quảnLýCốVấnHọcTậpToolStripMenuItem
            // 
            this.quảnLýCốVấnHọcTậpToolStripMenuItem.Name = "quảnLýCốVấnHọcTậpToolStripMenuItem";
            this.quảnLýCốVấnHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýCốVấnHọcTậpToolStripMenuItem.Text = "Quản lý cố vấn học tập ";
            this.quảnLýCốVấnHọcTậpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCốVấnHọcTậpToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản lý môn học ";
            this.quảnLýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMônHọcToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản ";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            this.quảnLýĐiểmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongtinchitietToolStripMenuItem,
            this.DoimatkhauToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản ";
            // 
            // ThongtinchitietToolStripMenuItem
            // 
            this.ThongtinchitietToolStripMenuItem.Name = "ThongtinchitietToolStripMenuItem";
            this.ThongtinchitietToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ThongtinchitietToolStripMenuItem.Text = "Thông tin chi tiêt ";
            this.ThongtinchitietToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // DoimatkhauToolStripMenuItem
            // 
            this.DoimatkhauToolStripMenuItem.Name = "DoimatkhauToolStripMenuItem";
            this.DoimatkhauToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.DoimatkhauToolStripMenuItem.Text = "Đổi mật khẩu ";
            this.DoimatkhauToolStripMenuItem.Click += new System.EventHandler(this.DoimatkhauToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất ";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cbbMaLop);
            this.panel1.Controls.Add(this.cbbMaCoVan);
            this.panel1.Controls.Add(this.cbbMaKhoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.rbNu);
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.dtpkNhapHoc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbQueQuan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbTenSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 175);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(544, 80);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(121, 27);
            this.cbbMaLop.TabIndex = 1;
            this.cbbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbbMaLop_SelectedIndexChanged);
            // 
            // cbbMaCoVan
            // 
            this.cbbMaCoVan.FormattingEnabled = true;
            this.cbbMaCoVan.Location = new System.Drawing.Point(1028, 78);
            this.cbbMaCoVan.Name = "cbbMaCoVan";
            this.cbbMaCoVan.Size = new System.Drawing.Size(121, 27);
            this.cbbMaCoVan.TabIndex = 12;
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(782, 80);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(121, 27);
            this.cbbMaKhoa.TabIndex = 11;
            this.cbbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbMaKhoa_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(386, 126);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 32);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.TabStop = false;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(264, 126);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(142, 126);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 32);
            this.btnSua.TabIndex = 10;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 126);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(996, 21);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(48, 23);
            this.rbNu.TabIndex = 4;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(931, 21);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 23);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(674, 18);
            this.dtpkNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(157, 26);
            this.dtpkNgaySinh.TabIndex = 3;
            // 
            // dtpkNhapHoc
            // 
            this.dtpkNhapHoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNhapHoc.Location = new System.Drawing.Point(325, 80);
            this.dtpkNhapHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNhapHoc.Name = "dtpkNhapHoc";
            this.dtpkNhapHoc.Size = new System.Drawing.Size(129, 26);
            this.dtpkNhapHoc.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(927, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên cố vấn :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Khoa :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày nhập học :";
            // 
            // txbQueQuan
            // 
            this.txbQueQuan.Location = new System.Drawing.Point(99, 80);
            this.txbQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txbQueQuan.MaxLength = 255;
            this.txbQueQuan.Name = "txbQueQuan";
            this.txbQueQuan.Size = new System.Drawing.Size(90, 26);
            this.txbQueQuan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê quán: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Sinh :";
            // 
            // txbTenSV
            // 
            this.txbTenSV.Location = new System.Drawing.Point(371, 18);
            this.txbTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenSV.MaxLength = 255;
            this.txbTenSV.Name = "txbTenSV";
            this.txbTenSV.Size = new System.Drawing.Size(195, 26);
            this.txbTenSV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên SV :";
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(186, 18);
            this.txbMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaSV.MaxLength = 255;
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(108, 26);
            this.txbMaSV.TabIndex = 1;
            this.txbMaSV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(54, 18);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(52, 26);
            this.txbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSinhVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 301);
            this.panel2.TabIndex = 2;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 30;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1200, 301);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.TabStop = false;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MaxInputLength = 255;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "MÃ SINH VIÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenSV";
            this.Column3.HeaderText = "TÊN SINH VIÊN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "NGÀY SINH ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GioiTinh";
            this.Column5.HeaderText = "GIỚI TÍNH ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "QueQuan";
            this.Column6.HeaderText = "QUÊ QUÁN";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayNhapHoc";
            this.Column7.HeaderText = "NGÀY NHẬP HỌC";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaLop";
            this.Column8.HeaderText = "MÃ LỚP";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaKhoa";
            this.Column9.HeaderText = "MÃ KHOA";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaCVHT";
            this.Column10.HeaderText = "MÃ CỐ VẤN";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(508, 126);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 32);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCốVấnHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txbQueQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpkNhapHoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolStripMenuItem ThongtinchitietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoimatkhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.ComboBox cbbMaCoVan;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btnTimKiem;
    }
}