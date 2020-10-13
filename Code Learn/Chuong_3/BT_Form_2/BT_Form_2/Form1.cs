using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            double kq;
            kq = double.Parse(txtso1.Text) + double.Parse(txtso2.Text);
            txtkq.Text = kq.ToString();
        }

        private void tru_Click(object sender, EventArgs e)
        {
            double kq;
            kq = double.Parse(txtso1.Text) - double.Parse(txtso2.Text);
            txtkq.Text = kq.ToString();
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtso1.Text);
            double y = double.Parse(txtso2.Text);
            double kq = x * y;
            txtkq.Text = kq.ToString();
        }

        private void chia_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtso1.Text);
            double y = double.Parse(txtso2.Text);
            if (y == 0) 
            {
                MessageBox.Show("\n Hình như bạn đã sai ");
                return;
            }
            double kq = x / y;
            txtkq.Text = kq.ToString();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            this.txtso1.ResetText();
            this.txtso2.ResetText();
            this.txtkq.ResetText();
            this.txtso1.Focus();
        }
    }
}
