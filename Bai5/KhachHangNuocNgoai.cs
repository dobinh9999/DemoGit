using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
	internal class KhachHangNuocNgoai:KhachHang
	{
		public string QuocTich { get; set; }

		// Hàm tạo không tham số
		public KhachHangNuocNgoai() : base()
		{
			QuocTich = "";
		}

		// Hàm nhập thông tin khách hàng nước ngoài
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập quốc tịch: ");
			QuocTich = Console.ReadLine();
		}

		// Hàm xuất thông tin khách hàng nước ngoài
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine($"Quốc tịch: {QuocTich}");
		}
	}
}
