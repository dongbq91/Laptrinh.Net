using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;

            Console.Write("\nNhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\nNhap he so b: ");
            b = double.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine("\n Phuong trinh {0}x + {1} = 0 co nghiem x = {2}", a, b, x);
            Console.ReadLine();

        }
    }
}
