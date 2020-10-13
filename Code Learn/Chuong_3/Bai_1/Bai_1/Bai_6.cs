using System;

namespace Bai_1
{
    class Bai_6
    {
        /* Viết chương trình cho phép người dùng nhập n số nguyên vào từ bàn phím.
         * Hiển thị các số đã nhập, sau đó tính và hiển thị giá trị trung bình các số vừa nhập
         */
        static void Main(string[] args)
        {
            Console.WriteLine("\n Nhap vao so phan tu cua mang : ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = NhapMang(n);
           HienThiMang(mang);
            Console.WriteLine("\n\nGia tri trung binh cac phan tu: {0}",TinhGiaTriTrungBinh(mang));
            Console.ReadLine();
        }
        private static void HienThiMang(int [] mang)
        {
            Console.WriteLine("\n Mang da nhap : ");
            for (int i=0; i < mang.Length; i++)
            {
                Console.WriteLine("\t{0}", mang[i]);
            }
        }
        private static int[] NhapMang(int n)
        {
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNhap vao so phan tu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            return mang;
        }
        static double TinhGiaTriTrungBinh(int[] mang)
        {
            int tong = 0;
            foreach (int item in mang)
            {
                tong += item;
            }
            return (double)tong / (double)mang.Length;
        }

    }
}
