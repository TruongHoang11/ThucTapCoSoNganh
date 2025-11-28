namespace Dayone.GUI
{
    partial class QuanLyKhoa
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
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txbTenKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 117);
            this.panel1.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(317, 71);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(101, 30);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(217, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(120, 71);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txbTenKhoa
            // 
            this.txbTenKhoa.Location = new System.Drawing.Point(388, 23);
            this.txbTenKhoa.Name = "txbTenKhoa";
            this.txbTenKhoa.Size = new System.Drawing.Size(75, 30);
            this.txbTenKhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Khoa :";
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(190, 23);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(95, 30);
            this.txbMaKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khoa :";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(45, 23);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(43, 30);
            this.txbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AllowUserToAddRows = false;
            this.dgvKhoa.AllowUserToDeleteRows = false;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoa.Location = new System.Drawing.Point(0, 117);
            this.dgvKhoa.MultiSelect = false;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.RowHeadersVisible = false;
            this.dgvKhoa.RowHeadersWidth = 51;
            this.dgvKhoa.RowTemplate.Height = 30;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(474, 318);
            this.dgvKhoa.TabIndex = 2;
            this.dgvKhoa.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MaxInputLength = 255;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MÃ KHOA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TÊN KHOA";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 435);
            this.Controls.Add(this.dgvKhoa);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}