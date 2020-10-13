using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class Class3
    {
        public static void main(string[] args)
        {
            int n;
            int x;
            Console.WriteLine("Nhap n :");
            n = int.Parse(Console.ReadLine());
            int s = 0;
            for(int i = 0; i < n; i++)
            {
                s += giaithua(i);
            }
            Console.Write("S= " + s);
        }
        private static int giaithua (double x)
        {
            int gt = 1;
            for (int i=0;i<=x;i++)
            {
                gt *= i;
                return gt;
            }
        }
    }
}
