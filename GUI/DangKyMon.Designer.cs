namespace Dayone.GUI
{
    partial class DangKyMon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDangKyMon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();

            this.cmbTenMon = new System.Windows.Forms.ComboBox();

            this.TenLop = new System.Windows.Forms.ComboBox();

            this.label4 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dtpkDangKy = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cmbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaHocPhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();

            this.btnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLopCodinh = new System.Windows.Forms.ComboBox();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyMon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDangKyMon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 433);
            this.panel1.TabIndex = 0;
            // 
            // dgvDangKyMon
            // 
            this.dgvDangKyMon.AllowUserToAddRows = false;
            this.dgvDangKyMon.AllowUserToDeleteRows = false;
            this.dgvDangKyMon.ColumnHeadersHeight = 30;
            this.dgvDangKyMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column5});
            this.dgvDangKyMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangKyMon.Location = new System.Drawing.Point(0, 0);
            this.dgvDangKyMon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDangKyMon.Name = "dgvDangKyMon";
            this.dgvDangKyMon.ReadOnly = true;
            this.dgvDangKyMon.RowHeadersVisible = false;
            this.dgvDangKyMon.RowHeadersWidth = 51;
            this.dgvDangKyMon.RowTemplate.Height = 30;
            this.dgvDangKyMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKyMon.Size = new System.Drawing.Size(1102, 433);
            this.dgvDangKyMon.TabIndex = 0;
            this.dgvDangKyMon.TabStop = false;
            this.dgvDangKyMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKyMon_CellClick);
            this.dgvDangKyMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKyMon_CellClick);
            this.dgvDangKyMon.SelectionChanged += new System.EventHandler(this.dgvDangKyMon_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSV";
            this.Column2.HeaderText = "MÃ SV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenSV";
            this.Column4.HeaderText = "TÊN SV";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 165;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaLopHocPhan";
            this.Column3.HeaderText = "MÃ H.PHẦN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenLopHocPhan";
            this.Column6.HeaderText = "TÊN H.PHẦN";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenMH";
            this.Column7.HeaderText = "TÊN MH";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayDangKy";
            this.Column5.HeaderText = "NGÀY ĐK";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbLopCodinh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BtnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.cmbTenMon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnTaiLai);
            this.panel2.Controls.Add(this.dtpkDangKy);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDangKy);
            this.panel2.Controls.Add(this.cmbMaSinhVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbMaHocPhan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 274);
            this.panel2.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnTimKiem.Location = new System.Drawing.Point(646, 204);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 32);
            this.btnTimKiem.TabIndex = 10;

            this.btnTimKiem.Location = new System.Drawing.Point(756, 174);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(200, 54);
            this.btnTimKiem.TabIndex = 12;

            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 

            // cmbTenMon
            // 
            this.cmbTenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMon.FormattingEnabled = true;
            this.cmbTenMon.Location = new System.Drawing.Point(177, 89);
            this.cmbTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenMon.Name = "cmbTenMon";
            this.cmbTenMon.Size = new System.Drawing.Size(184, 30);
            this.cmbTenMon.TabIndex = 2;
            this.cmbTenMon.SelectedIndexChanged += new System.EventHandler(this.TenLop_SelectedIndexChanged);
     // 
            this.TenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLop.FormattingEnabled = true;
            this.TenLop.Location = new System.Drawing.Point(869, 46);
            this.TenLop.Margin = new System.Windows.Forms.Padding(4);
            this.TenLop.Name = "TenLop";
            this.TenLop.Size = new System.Drawing.Size(184, 30);
            this.TenLop.TabIndex = 11;
            this.TenLop.SelectedIndexChanged += new System.EventHandler(this.TenLop_SelectedIndexChanged);

            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label4.Location = new System.Drawing.Point(60, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Môn học:";

            this.label4.Location = new System.Drawing.Point(752, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Môn :";

            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(487, 204);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(127, 32);
            this.btnTaiLai.TabIndex = 9;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dtpkDangKy
            // 
            this.dtpkDangKy.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDangKy.Location = new System.Drawing.Point(185, 154);
            this.dtpkDangKy.Margin = new System.Windows.Forms.Padding(6);
            this.dtpkDangKy.Name = "dtpkDangKy";
            this.dtpkDangKy.Size = new System.Drawing.Size(176, 30);
            this.dtpkDangKy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Đăng Ký:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(68, 204);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(123, 32);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cmbMaSinhVien
            // 
            this.cmbMaSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSinhVien.FormattingEnabled = true;
            this.cmbMaSinhVien.Location = new System.Drawing.Point(456, 37);
            this.cmbMaSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaSinhVien.Name = "cmbMaSinhVien";
            this.cmbMaSinhVien.Size = new System.Drawing.Size(291, 30);
            this.cmbMaSinhVien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // cmbMaHocPhan
            // 
            this.cmbMaHocPhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaHocPhan.FormattingEnabled = true;
            this.cmbMaHocPhan.Location = new System.Drawing.Point(611, 81);
            this.cmbMaHocPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaHocPhan.MaxLength = 255;
            this.cmbMaHocPhan.Name = "cmbMaHocPhan";
            this.cmbMaHocPhan.Size = new System.Drawing.Size(287, 30);
            this.cmbMaHocPhan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp Học Phần:";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(88, 37);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.MaxLength = 255;
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(124, 30);
            this.txbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 

            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(215, 204);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 32);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(351, 204);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(107, 32);
            this.BtnXoa.TabIndex = 8;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lớp Cố Định :";
            // 
            // cmbLopCodinh
            // 
            this.cmbLopCodinh.FormattingEnabled = true;
            this.cmbLopCodinh.Location = new System.Drawing.Point(611, 133);
            this.cmbLopCodinh.Name = "cmbLopCodinh";
            this.cmbLopCodinh.Size = new System.Drawing.Size(287, 30);
            this.cmbLopCodinh.TabIndex = 5;
            this.cmbLopCodinh.SelectedIndexChanged += new System.EventHandler(this.cmbLopCodinh_SelectedIndexChanged);
            // 


            // DangKyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangKyMon";
            this.Text = "DangKyMon";
            this.Load += new System.EventHandler(this.DangKyMon_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDangKyMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaHocPhan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkDangKy;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cmbTenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cmbLopCodinh;
        private System.Windows.Forms.Label label6;
    }
}