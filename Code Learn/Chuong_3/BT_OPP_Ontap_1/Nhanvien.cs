using System;
using System.Collections.Generic;
using System.Text;

namespace BT_OPP_Ontap_1
{
    class Nhanvien
    {
        private string _Manhanvien, _Tennhanvien;
        private double _Luong1gio, _Sogiolam;
        public string Manhanvien 
        {
            get { return _Manhanvien; }
            set { _Manhanvien = value; }
        }
        public string Tennhanvien
        {
            get { return _Tennhanvien; }
            set { _Tennhanvien = value; }
        }
        public double Luong1gio
        {
            get { return _Luong1gio; }
            set { _Luong1gio = value; }
        }
        public double Sogiolam
        {
            get { return _Sogiolam; }
            set { _Sogiolam = value; }
        }
        public void Nhap ( string ma , string ten , int luong , int sogio)
        {
            this.Manhanvien = ma;
            this.Tennhanvien = ten;
            this.Luong1gio = luong;
            this.Sogiolam = sogio;
        }

        public virtual double Tinhluong()
        {
            return this.Sogiolam * this.Luong1gio;
        }
        public double Tinhluong( int Sogiolam , int Luong1gio)
        {
            return this.Sogiolam * this.Luong1gio;
        }
        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3}\t {4}", this.Manhanvien, this.Tennhanvien, this.Luong1gio, this.Sogiolam, this.Tinhluong());
        }

    }

}
