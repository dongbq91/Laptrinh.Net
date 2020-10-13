namespace BT_Form_1
{
    partial class VD3p1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Thongtin = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Thongtin
            // 
            this.Thongtin.AutoSize = true;
            this.Thongtin.Location = new System.Drawing.Point(74, 56);
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Size = new System.Drawing.Size(115, 17);
            this.Thongtin.TabIndex = 0;
            this.Thongtin.Text = "Thông Tin Đăng Nhập";
            this.Thongtin.UseCompatibleTextRendering = true;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Location = new System.Drawing.Point(103, 115);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(86, 13);
            this.ten.TabIndex = 1;
            this.ten.Text = "Tên Người Dùng";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(133, 153);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(56, 13);
            this.pass.TabIndex = 2;
            this.pass.Text = "Mật Khẩu ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(216, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(203, 20);
            this.txtname.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(216, 153);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(203, 20);
            this.txtpass.TabIndex = 4;
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(136, 211);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(75, 23);
            this.dangnhap.TabIndex = 5;
            this.dangnhap.Text = "Đăng Nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(307, 211);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoát ";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // VD3p1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.Thongtin);
            this.Name = "VD3p1";
            this.Text = "VD3";
            this.Load += new System.EventHandler(this.VD3p1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Thongtin;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button Thoat;
    }
}