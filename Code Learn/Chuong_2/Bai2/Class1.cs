using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Viết chương trình nhập vào số nguyên dương n. In ra màn hình kết quả của cáctổng sau:
            a) S= 1+2+3+ …+n
            b) S= 1+1/2+1/3+…+1/n */
            int n, s = 0;
            Console.Write("Nhap vao so nguyen : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            Console.WriteLine("Tong S {0}", s);
            double h = 0;
            for (int i = 1; i <= n; i++)
            {
                h = h + (double)1 / i;
            }
            Console.WriteLine("Tong S2 {0}", h);

            Console.ReadLine();
        }
    }
}