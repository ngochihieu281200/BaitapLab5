using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NVSanXuat : NhanVien
    {
        public static readonly int TIEN_CONG_MOT_SAN_PHAM = 1000;
        private int _soLuongSanPham = 0;
        public int soLuongSanPham
        {
            get { return _soLuongSanPham; }
            set { _soLuongSanPham = value; }
        }
        public NVSanXuat(string MSNV,String Hoten, int soLuongSanPham) : base(MSNV, Hoten) 
        {
            this.soLuongSanPham = soLuongSanPham;
        }
        public override int TinhLuong()
        {
            //if(this.soLuongSanPham<=3000)
            //{
            //    return this.soLuongSanPham * NVSanXuat.TIEN_CONG_MOT_SAN_PHAM;
            //}
            //else
            //{
            //    return (int)((this.soLuongSanPham * NVSanXuat.TIEN_CONG_MOT_SAN_PHAM));
            //}
           int kq = this.soLuongSanPham * NVSanXuat.TIEN_CONG_MOT_SAN_PHAM;
            if (this.soLuongSanPham > 3000)
                kq = (int)(kq * 1.05);
            return kq;
        }
    }
}
