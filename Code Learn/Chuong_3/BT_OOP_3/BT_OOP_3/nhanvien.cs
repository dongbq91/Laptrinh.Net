using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace BT_OOP_3
{
    class nhanvien
    {
        private string _Manhanvien;
        public string Manhanvien
        {
            get { return _Manhanvien; }
            set { _Manhanvien = value; }
        }
        private string _Tennhanvien;
        public string Tennhanvien
        {
            get { return _Tennhanvien; }
            set { _Tennhanvien = value; }
        }
        private int _Luong1gio;
        public int Luong1gio
        {
            get { return _Luong1gio; }
            set { _Luong1gio = value; }
        }
        private double _Sogiolamviec;
        public double Sogiolamviec
        {
            get { return _Sogiolamviec; }
            set { _Sogiolamviec = value; }
        }
        public nhanvien (string ma , string ten , int luong1 , double sogio)
        {
            this.Manhanvien = ma;
            this.Tennhanvien = ten;
            this.Luong1gio = luong1;
            this.Sogiolamviec = sogio;
        }
        public nhanvien() { }
        public virtual double tinhluong()
        {
            return this.Luong1gio * this.Sogiolamviec;
        }
        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", this.Manhanvien , this.Tennhanvien , this.Luong1gio , this.Sogiolamviec,0, this.tinhluong() );
        }
    }
}
