using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NVKinhDoanh : NhanVien
    {
        public static readonly int TIEN_CUA_MOT_HOP_DONG = 500000;
        private int _soLuongHopDong = 0;
        public int soLuongHopDong
        {
            get { return _soLuongHopDong; }
            set { _soLuongHopDong = value; }
        }
        private int _luongCoBan = 0;
        public int luongCoBan
        {
            get { return _luongCoBan; }
            set { _luongCoBan = value; }
        }
        public NVKinhDoanh(string MSNV,string Hoten, int luongCoBan, int soLuongHopDong) : base(MSNV, Hoten)
        {
            this.luongCoBan = luongCoBan;
            this.soLuongHopDong = soLuongHopDong;
        }
        public override int TinhLuong()
        {
            return this.luongCoBan + this.soLuongHopDong * NVKinhDoanh.TIEN_CUA_MOT_HOP_DONG;
        }
    }
}
