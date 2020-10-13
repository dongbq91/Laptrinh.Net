using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_3
{
    class Class2
    {
        public static void main (string[] args)
        {
            /* Viết chương trình nhập vào họ tên, điểm thi cuối kỳ của một học sinh. In ra họ tên học sinh bằng chữ IN HOA, và kết quả xếp loại của học sinh theo tiêu chuẩn sau:
                - Giỏi: Nếu Điểm kết quả >= 8
                - Khá: Nếu 8 > Điểm >= 6.5
                - Trung bình: Nếu 6.5 > Điểm >= 5
                - Yếu: Nếu Điểm < 5 
            */
            string ten;
            float diem;
            Console.Write("Nhap ten ");
            ten = Console.ReadLine();
            diem = float.Parse(Console.ReadLine());
            Console.Write("Ten la :" + ten);
            if (diem > 8)
            {
                Console.Write("gioi");
            }else if(diem>=6.5 && diem < 8)
            {
                Console.Write("Kha");
            }
            else if (diem >= 5 && diem < 6.5)
            {
                Console.Write("Trung binh");
            }
            else 
            {
                Console.Write("Yeu");
            }
        }
    }
}
