namespace Dayone.GUI
{
    partial class ThongTinChiTiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLoaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Enabled = false;
            this.txbTenDangNhap.Location = new System.Drawing.Point(16, 44);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(218, 30);
            this.txbTenDangNhap.TabIndex = 1;
            this.txbTenDangNhap.TextChanged += new System.EventHandler(this.txbTenDangNhap_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu :";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Enabled = false;
            this.txbMatKhau.Location = new System.Drawing.Point(16, 119);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(218, 30);
            this.txbMatKhau.TabIndex = 1;
            this.txbMatKhau.Text = "*******";
            this.txbMatKhau.TextChanged += new System.EventHandler(this.txbMatKhau_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại Tài Khoản :";
            // 
            // txbLoaiTaiKhoan
            // 
            this.txbLoaiTaiKhoan.Enabled = false;
            this.txbLoaiTaiKhoan.Location = new System.Drawing.Point(16, 190);
            this.txbLoaiTaiKhoan.Name = "txbLoaiTaiKhoan";
            this.txbLoaiTaiKhoan.Size = new System.Drawing.Size(218, 30);
            this.txbLoaiTaiKhoan.TabIndex = 1;
            this.txbLoaiTaiKhoan.TextChanged += new System.EventHandler(this.txbLoaiTaiKhoan_TextChanged);
            // 
            // ThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 243);
            this.Controls.Add(this.txbLoaiTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinChiTiet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Chi Tiết";
            this.Load += new System.EventHandler(this.ThongTinChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLoaiTaiKhoan;
    }
}