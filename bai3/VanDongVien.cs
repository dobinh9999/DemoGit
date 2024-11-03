using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
	internal class VanDongVien
	{
		
		public string HoTen { get; set; }
		public int Tuoi { get; set; }
		public string MonThiDau { get; set; }
		public double CanNang { get; set; }
		public double ChieuCao { get; set; }

		
		public VanDongVien()
		{
			HoTen = "";
			Tuoi = 0;
			MonThiDau = "";
			CanNang = 0.0;
			ChieuCao = 0.0;
		}

		
		public VanDongVien(string hoTen, int tuoi, string monThiDau, double canNang, double chieuCao)
		{
			HoTen = hoTen;
			Tuoi = tuoi;
			MonThiDau = monThiDau;
			CanNang = canNang;
			ChieuCao = chieuCao;
		}

		
		~VanDongVien()
		{
			// Do nothing
		}

		
		public void Nhap()
		{
			Console.Write("Nhập họ và tên: ");
			HoTen = Console.ReadLine();
			Console.Write("Nhập tuổi: ");
			Tuoi = int.Parse(Console.ReadLine());
			Console.Write("Nhập môn thi đấu: ");
			MonThiDau = Console.ReadLine();
			Console.Write("Nhập cân nặng (kg): ");
			CanNang = double.Parse(Console.ReadLine());
			Console.Write("Nhập chiều cao (m): ");
			ChieuCao = double.Parse(Console.ReadLine());
		}

		
		public void Xuat()
		{
			Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Môn thi đấu: {MonThiDau}, Cân nặng: {CanNang} kg, Chiều cao: {ChieuCao} m");
		}
	}
}
