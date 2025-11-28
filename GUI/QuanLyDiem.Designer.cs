namespace Dayone.GUI
{
    partial class QuanLyDiem
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
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.cmbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.numPhanTramThi = new System.Windows.Forms.NumericUpDown();
            this.numPhanTramLop = new System.Windows.Forms.NumericUpDown();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDiemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDiemThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDiemLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLoai);
            this.panel1.Controls.Add(this.cmbMaMonHoc);
            this.panel1.Controls.Add(this.cmbMaSinhVien);
            this.panel1.Controls.Add(this.numPhanTramThi);
            this.panel1.Controls.Add(this.numPhanTramLop);
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbDiemTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbDiemThi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbDiemLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 157);
            this.panel1.TabIndex = 6;
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cmbLoai.Location = new System.Drawing.Point(839, 16);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(148, 30);
            this.cmbLoai.TabIndex = 3;
            // 
            // cmbMaMonHoc
            // 
            this.cmbMaMonHoc.FormattingEnabled = true;
            this.cmbMaMonHoc.Location = new System.Drawing.Point(561, 16);
            this.cmbMaMonHoc.Name = "cmbMaMonHoc";
            this.cmbMaMonHoc.Size = new System.Drawing.Size(209, 30);
            this.cmbMaMonHoc.TabIndex = 2;
            // 
            // cmbMaSinhVien
            // 
            this.cmbMaSinhVien.FormattingEnabled = true;
            this.cmbMaSinhVien.Location = new System.Drawing.Point(240, 16);
            this.cmbMaSinhVien.Name = "cmbMaSinhVien";
            this.cmbMaSinhVien.Size = new System.Drawing.Size(192, 30);
            this.cmbMaSinhVien.TabIndex = 1;
            this.cmbMaSinhVien.SelectedIndexChanged += new System.EventHandler(this.cmbMaSinhVien_SelectedIndexChanged);
            // 
            // numPhanTramThi
            // 
            this.numPhanTramThi.Location = new System.Drawing.Point(338, 63);
            this.numPhanTramThi.Name = "numPhanTramThi";
            this.numPhanTramThi.Size = new System.Drawing.Size(70, 30);
            this.numPhanTramThi.TabIndex = 5;
            this.numPhanTramThi.ValueChanged += new System.EventHandler(this.numPhanTramThi_ValueChanged);
            // 
            // numPhanTramLop
            // 
            this.numPhanTramLop.Location = new System.Drawing.Point(127, 63);
            this.numPhanTramLop.Name = "numPhanTramLop";
            this.numPhanTramLop.Size = new System.Drawing.Size(74, 30);
            this.numPhanTramLop.TabIndex = 4;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(307, 112);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(101, 30);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(207, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(110, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 112);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "P. Trăm Thi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(807, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm TB :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm Thi :";
            // 
            // txbDiemTB
            // 
            this.txbDiemTB.Location = new System.Drawing.Point(899, 63);
            this.txbDiemTB.Name = "txbDiemTB";
            this.txbDiemTB.Size = new System.Drawing.Size(88, 30);
            this.txbDiemTB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm Lớp :";
            // 
            // txbDiemThi
            // 
            this.txbDiemThi.Location = new System.Drawing.Point(702, 63);
            this.txbDiemThi.Name = "txbDiemThi";
            this.txbDiemThi.Size = new System.Drawing.Size(88, 30);
            this.txbDiemThi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "P. Trăm Lớp :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(776, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại :";
            // 
            // txbDiemLop
            // 
            this.txbDiemLop.Location = new System.Drawing.Point(521, 63);
            this.txbDiemLop.Name = "txbDiemLop";
            this.txbDiemLop.Size = new System.Drawing.Size(83, 30);
            this.txbDiemLop.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Môn Học :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên :";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(50, 16);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(43, 30);
            this.txbID.TabIndex = 0;
            this.txbID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dgvQuanLyDiem
            // 
            this.dgvQuanLyDiem.AllowUserToAddRows = false;
            this.dgvQuanLyDiem.AllowUserToDeleteRows = false;
            this.dgvQuanLyDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvQuanLyDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyDiem.Location = new System.Drawing.Point(0, 157);
            this.dgvQuanLyDiem.MultiSelect = false;
            this.dgvQuanLyDiem.Name = "dgvQuanLyDiem";
            this.dgvQuanLyDiem.ReadOnly = true;
            this.dgvQuanLyDiem.RowHeadersVisible = false;
            this.dgvQuanLyDiem.RowHeadersWidth = 51;
            this.dgvQuanLyDiem.RowTemplate.Height = 30;
            this.dgvQuanLyDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyDiem.Size = new System.Drawing.Size(1103, 383);
            this.dgvQuanLyDiem.TabIndex = 7;
            this.dgvQuanLyDiem.TabStop = false;
            this.dgvQuanLyDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyDiem_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MaxInputLength = 255;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MÃ SINH VIÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MÃ MÔN HỌC";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "P.TRĂM LỚP";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "P. TRĂM THI";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ĐIỂM LỚP";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ĐIỂM THI";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ĐIỂM TB";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "LOẠI";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // QuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 540);
            this.Controls.Add(this.dgvQuanLyDiem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhanTramLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numPhanTramThi;
        private System.Windows.Forms.NumericUpDown numPhanTramLop;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLyDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox cmbMaSinhVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDiemTB;
        private System.Windows.Forms.TextBox txbDiemThi;
        private System.Windows.Forms.TextBox txbDiemLop;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.ComboBox cmbMaMonHoc;
        private System.Windows.Forms.Label label9;
    }
}