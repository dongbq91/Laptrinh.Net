namespace BT_Form_2
{
    partial class Form1
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
            this.so1 = new System.Windows.Forms.Label();
            this.so2 = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.Label();
            this.cong = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Location = new System.Drawing.Point(78, 68);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(86, 13);
            this.so1.TabIndex = 0;
            this.so1.Text = "Nhập Số Thứ 1 :";
            // 
            // so2
            // 
            this.so2.AutoSize = true;
            this.so2.Location = new System.Drawing.Point(78, 131);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(89, 13);
            this.so2.TabIndex = 1;
            this.so2.Text = "Nhập Số Thứ 2 : ";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(78, 232);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(70, 13);
            this.ketqua.TabIndex = 2;
            this.ketqua.Text = "Kết Quả Là : ";
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(74, 182);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(40, 23);
            this.cong.TabIndex = 3;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(148, 182);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(40, 23);
            this.tru.TabIndex = 4;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(234, 182);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(40, 23);
            this.nhan.TabIndex = 5;
            this.nhan.Text = "*";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(313, 182);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(43, 23);
            this.chia.TabIndex = 6;
            this.chia.Text = "/";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.chia_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(313, 229);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(56, 23);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(174, 68);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 8;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(174, 131);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 9;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(174, 232);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(456, 321);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label so2;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtkq;
    }
}

