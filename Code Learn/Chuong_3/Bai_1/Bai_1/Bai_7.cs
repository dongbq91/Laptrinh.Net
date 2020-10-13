using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    class Bai_7
	{
		static void Main(string[] args)
		{
			ArrayList dsSoNguyen = new ArrayList();
			//Gọi phương thức đã viết để nhập các phần tử
			NhapDanhSachSoNguyen(dsSoNguyen);
			//Gọi phương thức đã viết để hiển thị danh sách
			HienThiDanhSach(dsSoNguyen);
			//Gọi phương thức đã viết để hiển thị phần tử lớn nhất trong danh sách
			Console.WriteLine("\n\nPhan tu lon nhat la: {0}",
							TimPhanTuLonNhat(dsSoNguyen));
			//Gọi phương thức đã viết để hiển thị phần tử nhỏ nhất trong danh sách
			Console.WriteLine("\nPhan tu nho nhat la: {0}",
	 TimPhanTuNhoNhat(dsSoNguyen));
			Console.ReadLine();
		}

		private static void HienThiDanhSach(ArrayList dsSoNguyen)
		{
			//Phương thức hiển thị nội dung của danh sách
			Console.WriteLine("\nCac so da nhap: \n");
			foreach (var item in dsSoNguyen)
			{
				Console.Write("\t{0}", item);
			}
		}

		private static void NhapDanhSachSoNguyen(ArrayList dsSoNguyen)
		{
			//Phương thức nhập dãy các số lưu vào danh sách. Kết thúc việc nhập 
			//khi user nhấn phím n
			string tiepTuc = "";
			while (tiepTuc != "n")
			{
				Console.Write("\nNhap vao 1 so: ");
				dsSoNguyen.Add(Console.ReadLine());
				Console.Write("\nNhan n de ket thuc nhap: ");
				tiepTuc = Console.ReadLine().ToLower();
			}
		}
		static double TimPhanTuLonNhat(ArrayList ds)
		{
			//Phương thức trả lại số nhỏ nhất trong danh sách 
			double max = Convert.ToDouble(ds[0]);
			for (int i = 1; i < ds.Count; i++)
			{
				if (max < Convert.ToDouble(ds[i]))
				{
					max = Convert.ToDouble(ds[i]);
				}
			}
			return max;
		}

		static double TimPhanTuNhoNhat(ArrayList ds)
		{
			//Phương thức trả lại số nhỏ nhất trong danh sách 
			double min = Convert.ToDouble(ds[0]);
			for (int i = 1; i < ds.Count; i++)
			{
				if (min > Convert.ToDouble(ds[i]))
				{
					min = Convert.ToDouble(ds[i]);
				}
			}
			return min;
		}


	}
