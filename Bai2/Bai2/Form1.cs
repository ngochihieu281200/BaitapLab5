using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnCongPhanSo_Click(object sender, EventArgs e)
        {
            int tusoa = int.Parse(this.txtBoxtusoa.Text);
            int mausoa = int.Parse(this.txtBoxmausoa.Text);
            int tusob = int.Parse(this.txtBoxtusob.Text);
            int mausob = int.Parse(this.txtBoxmausob.Text);

            PhanSo kq = new PhanSo(tusoa, mausoa) + new PhanSo(tusob, mausob);
            kq = PhanSo.Reduce(kq);
           
            this.label5.Text = "ket qua cong 2 phan so la: " + kq.tuso + "/" + kq.mauso;
            this.label5.Location = new System.Drawing.Point(this.Width/2 - this.label5.Width/2, this.label5.Location.Y);
        }

    }
}
