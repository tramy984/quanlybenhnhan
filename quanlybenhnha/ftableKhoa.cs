using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybenhnha
{
    public partial class ftableKhoa : Form
    {
        public ftableKhoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void thôngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoatieuhoa_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKhoacapcuu_Click(object sender, EventArgs e)
        {
            ftableKhoacapcuu f = new ftableKhoacapcuu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnKhoaptgmhs_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftableAccount f = new ftableAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
