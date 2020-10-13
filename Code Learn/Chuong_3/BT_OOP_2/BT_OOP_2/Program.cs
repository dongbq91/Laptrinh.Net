using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BT_OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            nhanvien nhanVien1 = new nhanvien();
            nhanVien1.Manhanvien = "NV01";
            nhanVien1.Tennhanvien = "Bach Quoc Dong";
            nhanVien1.luong1gio = 10000;
            nhanVien1.sogiolamviec = 24;
            nhanvien nhanVien2 = new nhanvien("NV02", "Bach Quoc Tay", 5000, 12);
            Console.WriteLine(nhanVien1.ToString());
            Console.WriteLine(nhanVien2.ToString());
            Console.Read();

        }
    }
}
