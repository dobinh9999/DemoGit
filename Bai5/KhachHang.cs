using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
	internal class KhachHang
	{
		public string MaKhachHang { get; set; }
		public int SoLuong { get; set; }
		public double DonGia { get; set; }
		public double ThanhTien { get; set; }
		public DateTime NgayHoaDon { get; set; }
		public string HoTen { get; set; }

		// Hàm tạo không tham số
		public KhachHang()
		{
			MaKhachHang = "";
			SoLuong = 0;
			DonGia = 0;
			ThanhTien = 0;
			NgayHoaDon = DateTime.Now;
			HoTen = "";
		}

		// Hàm tạo có tham số
		public KhachHang(string maKhachHang, int soLuong, double donGia, DateTime ngayHoaDon, string hoTen)
		{
			MaKhachHang = maKhachHang;
			SoLuong = soLuong;
			DonGia = donGia;
			NgayHoaDon = ngayHoaDon;
			HoTen = hoTen;
			ThanhTien = SoLuong * DonGia;
		}

		// Hàm nhập thông tin khách hàng
		public virtual void Nhap()
		{
			Console.Write("Nhập mã khách hàng: ");
			MaKhachHang = Console.ReadLine();
			Console.Write("Nhập họ tên: ");
			HoTen = Console.ReadLine();
			Console.Write("Nhập số lượng điện tiêu thụ: ");
			SoLuong = int.Parse(Console.ReadLine());
			Console.Write("Nhập đơn giá: ");
			DonGia = double.Parse(Console.ReadLine());
			Console.Write("Nhập ngày hóa đơn (dd/MM/yyyy): ");
			NgayHoaDon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
			ThanhTien = SoLuong * DonGia;
		}

		// Hàm xuất thông tin khách hàng
		public virtual void Xuat()
		{
			Console.WriteLine($"Mã khách hàng: {MaKhachHang}, Họ tên: {HoTen}, Số lượng: {SoLuong}, Đơn giá: {DonGia}, Thành tiền: {ThanhTien}, Ngày hóa đơn: {NgayHoaDon.ToShortDateString()}");
		}
	}
}
