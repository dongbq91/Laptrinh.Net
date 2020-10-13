using System;
using System.Collections.Generic;
using System.Text;

namespace BT_OOP_2
{
    class nhanvien
    {
        private string _Manhanvien;
        public string Manhanvien
        {
            get { return _Manhanvien; }
            set { _Manhanvien=value; }
        }
        private string _Tennhanvien;
        public string Tennhanvien
        {
            get { return _Tennhanvien; }
            set { _Tennhanvien = value; }
        }
        private int _luong1gio;
        public int luong1gio
        {
            get { return _luong1gio; }
            set { _luong1gio = value; }
        }
        private int _sogiolamviec;
        public int sogiolamviec
        {
            get { return _sogiolamviec; }
            set { _sogiolamviec = value; }
        }
        public nhanvien (string ma , string ten , int luong , int gio)
        {
            this.Manhanvien = ma;
            this.Tennhanvien = ten;
            this.luong1gio = luong;
            this.sogiolamviec = gio;
        }
        public nhanvien() { }
        private int tinhluong()
        {
            return this.sogiolamviec * this.luong1gio;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}",
            this.Manhanvien, this.Tennhanvien,
            this.luong1gio, this.sogiolamviec, this.tinhluong());
        }
    }
}
