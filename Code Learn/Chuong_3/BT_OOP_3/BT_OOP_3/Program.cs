using System;
using System.Collections.Generic;
using System.Text;

namespace BT_OOP_3
{
    class Program
    {
        static private List<nhanvien> DSnhanvien = new List<nhanvien>();
        static void Main(string[] args)
        {
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Clear();
                Console.WriteLine("\n MAIN MENU");
                Console.WriteLine("\n 1: Nhập nhân viên mới ");
                Console.WriteLine("\n 2: Hiển thị danh sách ");
                Console.WriteLine("\n 3: Tính lương trung bình ");
                Console.WriteLine("\n 4: Thoát chương tình ");
                Console.WriteLine("\n Nhập lựa chọn của bạn : ");
                string luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        Program.Nhapkhachhangmoi();
                        break;
                    case "2":
                        Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "Manhanvien", "Tennhanvien", "Luong1gio", "Sogiolamviec","1","tinhluong");
                        xuatdanhsachnhanvien();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\n Lương trung bình = {0}", tinhluongtrungbinh());
                        Console.ReadLine();
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Bạn đã nhập sai . Nhấn Enter Để tiếp tục !");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;

                }
            } while (true);
        } 
            static private void Nhapkhachhangmoi()
        {
            string ma, ten;
            int luong1;
            double sogio, heso;
            Console.WriteLine("\n 1: Nhân Viên ");
            Console.WriteLine("\n 2: Quản Lý ");
            Console.Write("\n Nhập vào lựa chọn của bạn : ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    Console.Write("\n Nhập mã nhân viên : ");
                    ma = Console.ReadLine();
                    Console.Write("\n Nhập tên nhân viên :");
                    ten = Console.ReadLine();
                    Console.Write("\n Nhâp lương một giờ :");
                    luong1 = int.Parse(Console.ReadLine());
                    Console.Write("\n Nhập số giờ làm việc: ");
                    sogio = int.Parse(Console.ReadLine());
                    nhanvien nvmoi = new nhanvien(ma, ten, luong1, sogio);
                    DSnhanvien.Add(nvmoi);
                    break;
                case "2":
                    Console.Write("\n Nhập mã quản lý : ");
                    ma = Console.ReadLine();
                    Console.Write("\n Nhập tên nhân viên :");
                    ten = Console.ReadLine();
                    Console.Write("\n Nhâp lương một giờ :");
                    luong1 = int.Parse(Console.ReadLine());
                    Console.Write("\n Nhập số giờ làm việc: ");
                    sogio = double.Parse(Console.ReadLine());
                    Console.Write("\n Nhập hệ số phụ cấp : ");
                    heso = double.Parse(Console.ReadLine());
                    Nhanvienquanly quanlymoi = new Nhanvienquanly(ma, ten, luong1, sogio, heso);
                    DSnhanvien.Add(quanlymoi);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Bạn đã nhập sai . Nhấn Enter Để tiếp tục !");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;
            }
            Console.ReadLine();
        }
        static private void xuatdanhsachnhanvien()
        {
            foreach (nhanvien item in DSnhanvien)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static private double tinhluongtrungbinh()
        {
            double tong = 0;
            foreach (nhanvien item in DSnhanvien)
            {
                tong += item.tinhluong();
            }
            return tong / DSnhanvien.Count;
        }
    }
    
}
