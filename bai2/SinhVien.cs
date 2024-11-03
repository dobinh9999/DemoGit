using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
	internal class SinhVien
	{
		public string HoTen { get; set; }
		public string QueQuan { get; set; }
		public int NamSinh { get; set; }
		public double DiemTongKet { get; set; }

		
		public SinhVien()
		{
			HoTen = "";
			QueQuan = "";
			NamSinh = 0;
			DiemTongKet = 0.0;
		}

		
		public SinhVien(string hoTen, string queQuan, int namSinh, double diemTongKet)
		{
			HoTen = hoTen;
			QueQuan = queQuan;
			NamSinh = namSinh;
			DiemTongKet = diemTongKet;
		}

		
		public void Nhap()
		{
			Console.Write("Nhập họ và tên: ");
			HoTen = Console.ReadLine();
			Console.Write("Nhập quê quán: ");
			QueQuan = Console.ReadLine();
			Console.Write("Nhập năm sinh: ");
			NamSinh = int.Parse(Console.ReadLine());
			Console.Write("Nhập điểm tổng kết: ");
			DiemTongKet = double.Parse(Console.ReadLine());
		}

		
		public void Xuat()
		{
			Console.WriteLine($"Họ và tên: {HoTen}, Quê quán: {QueQuan}, Năm sinh: {NamSinh}, Điểm tổng kết: {DiemTongKet}");
		}

	}
}
