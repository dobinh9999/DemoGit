using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
	internal class HanhKhach : Nguoi
	{
		public Vemaybay[] Ve { get; set; }
		public int SoLuong { get; set; }

		
		public HanhKhach() : base()
		{
			SoLuong = 0;
			Ve = null;
		}

		
		public override void Nhap()
		{
			base.Nhap();
			Console.Write("Nhập số lượng vé: ");
			SoLuong = int.Parse(Console.ReadLine());

			Ve = new Vemaybay[SoLuong];
			for (int i = 0; i < SoLuong; i++)
			{
				Console.WriteLine($"Nhập thông tin vé thứ {i + 1}:");
				Ve[i] = new Vemaybay();
				Ve[i].Nhap();
			}
		}

		
		public override void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Thông tin các vé:");
			for (int i = 0; i < SoLuong; i++)
			{
				Ve[i].Xuat();
			}
			Console.WriteLine($"Tổng tiền: {TongTien()}");
		}

		
		public double TongTien() 
		{
			double tongTien = 0;
			for (int i = 0; i < SoLuong; i++)
			{
				tongTien += Ve[i].GetGiaVe();
			}
			return tongTien;
		}
	}
}
