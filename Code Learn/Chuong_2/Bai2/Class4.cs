using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            string chuoiA, chuoiB, chuoiC;
            Console.WriteLine("Nhap he so a:");
            chuoiA = Console.ReadLine();
            if (chuoiA != "")
            {
                try
                {
                    a = float.Parse(chuoiA);
                    Console.WriteLine("nhap he so b:");
                    chuoiB = Console.ReadLine();
                    if (chuoiB != "")
                    {
                        try
                        {
                            b = float.Parse(chuoiB);
                            Console.WriteLine("nhap he so c:");
                            chuoiC = Console.ReadLine();
                            if (chuoiC != "")
                            {
                                try
                                {
                                    c = float.Parse(chuoiC);
                                    Ptbac2(a, b, c);
                                }
                                catch
                                {
                                    Console.WriteLine("he so c phai la so");
                                }
                            }
                            else
                            {
                                Console.WriteLine("he so c khong duoc de trong");
                            }

                        }
                        catch
                        {
                            Console.WriteLine("he so b phai la so");
                        }
                    }
                    else
                    {
                        Console.WriteLine("he so b khong duoc de trong");
                    }
                }
                catch
                {
                    Console.WriteLine("he so a phai la so");
                }
            }
            else
            {
                Console.WriteLine("he so a khong duoc de trong");
            }

            Console.ReadLine();
        }
        public static void Ptbac2(float a, float b, float c)
        {
            if (a == 0)
            {
                // a== 0 phuong trinh tro thanh phuong trinh bac mot bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem duy nhat: " + -c / b);
                }
            }
            else
            {
                float delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    float x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                    float x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Nghiem thu nhat x1 = " + x1);
                    Console.WriteLine("Nghiem thu nhat x2= " + x2);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = " + -b / 2 * a);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
    }
}