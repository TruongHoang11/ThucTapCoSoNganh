namespace Dayone.GUI
{
    partial class DoiMatKhau
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
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ :";
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(48, 125);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(221, 30);
            this.txbMatKhauCu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu Mới :";
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(48, 200);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(221, 30);
            this.txbMatKhauMoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác Nhận Mật Khẩu Mới :";
            // 
            // txbXacNhanMatKhauMoi
            // 
            this.txbXacNhanMatKhauMoi.Location = new System.Drawing.Point(48, 283);
            this.txbXacNhanMatKhauMoi.Name = "txbXacNhanMatKhauMoi";
            this.txbXacNhanMatKhauMoi.Size = new System.Drawing.Size(221, 30);
            this.txbXacNhanMatKhauMoi.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(184, 333);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 36);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.TabStop = false;
            this.btnXacNhan.Text = "Xác Nhận ";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(18, 333);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 36);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.TabStop = false;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Đăng Nhập :";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(48, 41);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(221, 30);
            this.txbTenDangNhap.TabIndex = 1;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 389);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txbXacNhanMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbMatKhauCu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu ";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbXacNhanMatKhauMoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTenDangNhap;
    }
}