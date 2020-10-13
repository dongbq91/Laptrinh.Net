using System;
using System.Collections.Generic;
using System.Text;

namespace Bt_OOP_1
{
    class NhanVien
    {
        //biến thành viên lưu giá trị thuộc tính Mã nhân viên
        private string _MaNhanVien;
        //thuộc tính cho phép truy cập an toàn biến thành viên 
        // _MaNhanVien
        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }

        private string _TenNhanVien;

        public string TenNhanVien
        {
            get { return _TenNhanVien; }
            set { _TenNhanVien = value; }
        }

        private int _Luong1Gio;

        public int Luong1Gio
        {
            get { return _Luong1Gio; }
            set { _Luong1Gio = value; }
        }

        private int _SoGioLamViec;

        public int SoGioLamViec
        {
            get { return _SoGioLamViec; }
            set { _SoGioLamViec = value; }
        }
        public int soGioLamViec{
            get{ return _SoGioLamViec}
        }

        public void Nhap(string ma, string ten, int luongGio, int soGioLamViec)
        {//phương thức nhập thông tin của nhân viên
            this.MaNhanVien = ma;
            this.TenNhanVien = ten;
            this.Luong1Gio = luongGio;
            this.SoGioLamViec = soGioLamViec;
        }

        private int TinhLuong()
        {//phương thức tính lương của nhân viên
            return this.SoGioLamViec * this.Luong1Gio;
        }
        public string Xuat()
        {//phương thức xuất thông tin của nhân viên
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}",this.MaNhanVien, this.TenNhanVien,this.Luong1Gio, this.SoGioLamViec,this.TinhLuong());
        } 
        public string n
    }
}

