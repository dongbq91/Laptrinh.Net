using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Form_1
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
        private void Dangnhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = " Tên đăng nhập :";
            thongbao += this.name.Text;
            thongbao += " \n \r Mật Khẩu :";
            thongbao += this.pass.Text;
            if (this.Luumatkhau.Checked == true)
            {
                thongbao += " \n \r Bạn đã ghi nhớ !!";
            }
            MessageBox.Show(thongbao, "Thông Báo");
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            this.name.ResetText();
            this.pass.ResetText();
            this.name.Focus();
        }

        private void Dừng_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Mày Muốn Out Chắc không ?", "Như Lào Phải Lói ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
