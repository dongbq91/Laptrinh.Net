namespace BT_Form_1
{
    partial class Formdangnhap
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
            this.Tendangnhap = new System.Windows.Forms.Label();
            this.Matkhau = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Luumatkhau = new System.Windows.Forms.CheckBox();
            this.Dangnhap = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Dừng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.AutoSize = true;
            this.Tendangnhap.BackColor = System.Drawing.Color.Pink;
            this.Tendangnhap.Location = new System.Drawing.Point(76, 101);
            this.Tendangnhap.Name = "Tendangnhap";
            this.Tendangnhap.Size = new System.Drawing.Size(81, 13);
            this.Tendangnhap.TabIndex = 0;
            this.Tendangnhap.Text = "Tên đăng nhập";
            // 
            // Matkhau
            // 
            this.Matkhau.AutoSize = true;
            this.Matkhau.BackColor = System.Drawing.Color.Pink;
            this.Matkhau.Location = new System.Drawing.Point(104, 177);
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Size = new System.Drawing.Size(53, 13);
            this.Matkhau.TabIndex = 1;
            this.Matkhau.Text = "Mật Khẩu";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(197, 101);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(361, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(197, 174);
            this.pass.Name = "pass";
            this.pass.PasswordChar = 'Đ';
            this.pass.Size = new System.Drawing.Size(361, 20);
            this.pass.TabIndex = 3;
            // 
            // Luumatkhau
            // 
            this.Luumatkhau.AutoSize = true;
            this.Luumatkhau.Location = new System.Drawing.Point(106, 254);
            this.Luumatkhau.Name = "Luumatkhau";
            this.Luumatkhau.Size = new System.Drawing.Size(93, 17);
            this.Luumatkhau.TabIndex = 4;
            this.Luumatkhau.Text = "Lưu Mật Khẩu";
            this.Luumatkhau.UseVisualStyleBackColor = true;
            // 
            // Dangnhap
            // 
            this.Dangnhap.Location = new System.Drawing.Point(106, 340);
            this.Dangnhap.Name = "Dangnhap";
            this.Dangnhap.Size = new System.Drawing.Size(75, 23);
            this.Dangnhap.TabIndex = 5;
            this.Dangnhap.Text = "Đăng Nhập";
            this.Dangnhap.UseVisualStyleBackColor = true;
            this.Dangnhap.Click += new System.EventHandler(this.Dangnhap_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(269, 339);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 6;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Dừng
            // 
            this.Dừng.Location = new System.Drawing.Point(504, 339);
            this.Dừng.Name = "Dừng";
            this.Dừng.Size = new System.Drawing.Size(75, 23);
            this.Dừng.TabIndex = 7;
            this.Dừng.Text = "Dừng";
            this.Dừng.UseVisualStyleBackColor = true;
            this.Dừng.Click += new System.EventHandler(this.Dừng_Click);
            // 
            // Formdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dừng);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Dangnhap);
            this.Controls.Add(this.Luumatkhau);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Matkhau);
            this.Controls.Add(this.Tendangnhap);
            this.Name = "Formdangnhap";
            this.Text = "Form Đăng Nhập";
            this.Load += new System.EventHandler(this.Formdangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tendangnhap;
        private System.Windows.Forms.Label Matkhau;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox Luumatkhau;
        private System.Windows.Forms.Button Dangnhap;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Dừng;
    }
}

