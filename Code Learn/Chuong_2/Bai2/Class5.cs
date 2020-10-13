using System;
using System.Text;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("\nNhập hệ số  A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\nNhập hệ số  B: ");
            b = int.Parse(Console.ReadLine());
            string luachon = "";
            while (luachon != "4")
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("\n 1.Cộng");
                Console.WriteLine("\n 2.Trừ");
                Console.WriteLine("\n 3.Nhân");
                Console.WriteLine("\n 4.Chia ");
                Console.WriteLine("\n Nhập lựa chọn của bạn : ");
                luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        Console.WriteLine("Kết quả của phép cộng là :{0}", a + b);
                        break;
                    case "2":
                        Console.WriteLine("Kết quả của phép trừ là : {0}", a - b);
                        break;
                    case "3":
                        Console.WriteLine("Kết quả của phép nhân là : {0}", a * b);
                        break;
                    case "4":
                        Console.WriteLine("Kết quả của phép chia là :{0}", (float)a / (float)b);
                        break;
                }    
            }
            }
    }
}
