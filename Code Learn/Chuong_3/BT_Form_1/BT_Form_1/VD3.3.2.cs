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
    public partial class VD3p1 : Form
    {
        public VD3p1()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if ((this.txtname.Text == "Dong") && (this.txtpass.Text == "dongcute")) this.Close();
            else
            {
                MessageBox.Show("Không Phải Thằng Đông Đẹp Trai", "Thoát đê em ơi :)");
                this.txtname.Focus();
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show(" Chắc Không ", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void VD3p1_Load(object sender, EventArgs e)
        {

        }
    }
}
