using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("x+y= {0}", x + y);
            Console.WriteLine("x-y= {0}", x - y);
            Console.WriteLine("x*y= {0}", x * y);
            Console.WriteLine("x/y= {0}", (float)x / (float)y);
            Console.WriteLine("x%y= {0}", x % y);
            Console.ReadLine();
        }
    }
}
