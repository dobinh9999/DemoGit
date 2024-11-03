using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
	internal class Nguoi
	{
		public string HoTen { get; set; }
		public string GioiTinh { get; set; }
		public int Tuoi { get; set; }

		
		public Nguoi()
		{
			HoTen = "";
			GioiTinh = "";
			Tuoi = 0;
		}

		
		public Nguoi(string hoTen, string gioiTinh, int tuoi)
		{
			HoTen = hoTen;
			GioiTinh = gioiTinh;
			Tuoi = tuoi;
		}

		
		public virtual void Nhap()
		{
			Console.Write("Nhập họ tên: ");
			HoTen = Console.ReadLine();
			Console.Write("Nhập giới tính: ");
			GioiTinh = Console.ReadLine();
			Console.Write("Nhập tuổi: ");
			Tuoi = int.Parse(Console.ReadLine());
		}

		
		public virtual void Xuat()
		{
			Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {GioiTinh}, Tuổi: {Tuoi}");
		}
	}
}
