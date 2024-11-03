using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
	internal class Vemaybay
	{
		public string TenChuyen { get; set; }
		public string NgayBay { get; set; }
		public double GiaVe { get; set; }

		
		public Vemaybay()
		{
			TenChuyen = "";
			NgayBay = "";
			GiaVe = 0;
		}

		
		public Vemaybay(string tenChuyen, string ngayBay, double giaVe)
		{
			TenChuyen = tenChuyen;
			NgayBay = ngayBay;
			GiaVe = giaVe;
		}

		
		public void Nhap()
		{
			Console.Write("Nhập tên chuyến bay: ");
			TenChuyen = Console.ReadLine();
			Console.Write("Nhập ngày bay: ");
			NgayBay = Console.ReadLine();
			Console.Write("Nhập giá vé: ");
			GiaVe = double.Parse(Console.ReadLine());
		}

		
		public void Xuat()
		{
			Console.WriteLine($"Tên chuyến: {TenChuyen}, Ngày bay: {NgayBay}, Giá vé: {GiaVe}");
		}

		
		public double GetGiaVe()
		{
			return GiaVe;
		}
	}
}
