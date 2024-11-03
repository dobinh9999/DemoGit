using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
	internal class KhachHangVietNam: KhachHang
	{
		public string LoaiKhachHang { get; set; }
		public double DinhMuc { get; set; }

		// Hàm tạo không tham số
		public KhachHangVietNam() : base()
		{
			LoaiKhachHang = "";
			DinhMuc = 0;
		}

		// Hàm nhập thông tin khách hàng Việt Nam
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập loại khách hàng: ");
			LoaiKhachHang = Console.ReadLine();
			Console.Write("Nhập định mức: ");
			DinhMuc = double.Parse(Console.ReadLine());
		}

		// Hàm xuất thông tin khách hàng Việt Nam
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine($"Loại khách hàng: {LoaiKhachHang}, Định mức: {DinhMuc}");
		}
	}
}
