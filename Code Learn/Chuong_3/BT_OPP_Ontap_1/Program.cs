using System;

namespace BT_OPP_Ontap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nhanvien NV = new Nhanvien();
            NV.Manhanvien = "NV1";
            NV.Tennhanvien = "Bach Quoc Dong ";
            NV.Sogiolam = 2;
            NV.Luong1gio = 20;
            Console.WriteLine(NV.ToString());
            Console.Read();
        }
    }
}
