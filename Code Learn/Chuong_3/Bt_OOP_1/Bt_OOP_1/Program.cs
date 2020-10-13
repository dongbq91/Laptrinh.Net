using System;

namespace Bt_OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng nhanVien 1 của lớp NhanVien
            NhanVien nhanVien1 = new NhanVien();
            //gán giá trị cho các thuộc tính của đối tượng nhanVien1
            nhanVien1.MaNhanVien = "NV01";
            nhanVien1.TenNhanVien = "Nguyen Van A";
            nhanVien1.Luong1Gio = 2;
            nhanVien1.SoGioLamViec = 10;

            NhanVien nhanVien2 = new NhanVien();
            //gán giá trị cho các thuộc tính của đối tượng nhanVien1 
            //bằng cách gọi phương thức nhập
            nhanVien2.Nhap("NV02", "Nguyen Van B", 3, 20);

            //Hiển thị thông tin của đối tượng nhanVien1
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", nhanVien1.MaNhanVien, nhanVien1.TenNhanVien, nhanVien1.Luong1Gio, nhanVien1.SoGioLamViec);

            //Hiển thị thông tin của đối tượng nhanVien2 sử dụng 
            //phương thức Xuat
            Console.WriteLine(nhanVien1.Xuat());

            Console.Read();
        }
    }
}

