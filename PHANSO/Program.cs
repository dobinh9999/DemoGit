using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			PhanSo ps1 = new PhanSo();
			Console.WriteLine("Nhập phân số thứ nhất:");
			ps1.Nhap();

			
			PhanSo ps2 = new PhanSo();
			Console.WriteLine("Nhập phân số thứ hai:");
			ps2.Nhap();

			
			PhanSo tong = ps1.Cong(ps2);
			Console.Write("Tổng hai phân số: ");
			tong.Xuat();

			
			PhanSo hieu = ps1.Tru(ps2);
			Console.Write("Hiệu hai phân số: ");
			hieu.Xuat();

			
			PhanSo tich = ps1.Nhan(ps2);
			Console.Write("Tích hai phân số: ");
			tich.Xuat();

			
			PhanSo thuong = ps1.Chia(ps2);
			Console.Write("Thương hai phân số: ");
			thuong.Xuat();

			
			Console.ReadKey();
		}
	}
}
