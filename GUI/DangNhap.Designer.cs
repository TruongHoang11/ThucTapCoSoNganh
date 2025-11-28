namespace Dayone
{
    partial class DangNhap
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
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(37, 69);
            this.txbTenDangNhap.MaxLength = 255;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(209, 30);
            this.txbTenDangNhap.TabIndex = 1;
            this.txbTenDangNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(37, 128);
            this.txbMatKhau.MaxLength = 255;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(209, 30);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.UseSystemPasswordChar = true;
            this.txbMatKhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(81, 183);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(112, 31);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(58, 232);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(158, 33);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.TabStop = false;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu ";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.ClientSize = new System.Drawing.Size(292, 301);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}

