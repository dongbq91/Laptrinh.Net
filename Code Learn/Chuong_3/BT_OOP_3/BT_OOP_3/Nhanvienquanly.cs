using System;
using System.Collections.Generic;
using System.Text;

namespace BT_OOP_3
{
    class Nhanvienquanly:nhanvien
    {
        private double _Hesophucap;
        public double Hesophucap
        {
            get { return _Hesophucap; }
            set { _Hesophucap = value; }
        }
        public Nhanvienquanly() { }
        public Nhanvienquanly(string ma, string ten, int luong1, double sogio , double heso)
                                        : base (ma , ten , luong1 , sogio)
        {
            this.Hesophucap = heso;
        }
        public override double tinhluong()
        {
            return this.Luong1gio * this.Sogiolamviec * (1 + this.Hesophucap);
        }
        public override string ToString()
        {
            return string.Format("\n{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", this.Manhanvien, this.Tennhanvien, this.Luong1gio, this.Sogiolamviec,this.Hesophucap, this.tinhluong());
        }
    }
}
