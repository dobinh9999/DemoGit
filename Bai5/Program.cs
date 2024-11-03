namespace Bai5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<KhachHang> danhSachKhachHang = new List<KhachHang>();

			
			Console.Write("Nhập số lượng khách hàng: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"Nhập thông tin khách hàng thứ {i + 1}:");
				Console.Write("Nhập loại khách hàng (1: Việt Nam, 2: Nước ngoài): ");
				int loaiKhachHang = int.Parse(Console.ReadLine());

				KhachHang khachHang = null;
				if (loaiKhachHang == 1)
				{
					khachHang = new KhachHangVietNam();
				}
				else if (loaiKhachHang == 2)
				{
					khachHang = new KhachHangNuocNgoai();
				}
				khachHang.Nhap();
				danhSachKhachHang.Add(khachHang);
			}

			
			Console.WriteLine("\nDanh sách hóa đơn khách hàng:");
			foreach (var kh in danhSachKhachHang)
			{
				kh.Xuat();
			}

			int tongSoLuongVN = 0;
			int tongSoLuongNN = 0;
			foreach (var kh in danhSachKhachHang)
			{
				if (kh is KhachHangVietNam)
				{
					tongSoLuongVN += kh.SoLuong;
				}
				else if (kh is KhachHangNuocNgoai)
				{
					tongSoLuongNN += kh.SoLuong;
				}
			}

			Console.WriteLine($"\nTổng số lượng điện tiêu thụ của khách hàng Việt Nam: {tongSoLuongVN}");
			Console.WriteLine($"Tổng số lượng điện tiêu thụ của khách hàng nước ngoài: {tongSoLuongNN}");

			double tongTienNN = 0;
			int soLuongNN = 0;
			foreach (var kh in danhSachKhachHang)
			{
				if (kh is KhachHangNuocNgoai)
				{
					tongTienNN += kh.ThanhTien;
					soLuongNN++;
				}
			}
			double trungBinhNN = soLuongNN > 0 ? tongTienNN / soLuongNN : 0;
			Console.WriteLine($"Trung bình thành tiền của khách hàng nước ngoài: {trungBinhNN}");

			Console.WriteLine("\nHóa đơn trong tháng 09 năm 2020:");
			foreach (var kh in danhSachKhachHang)
			{
				if (kh.NgayHoaDon.Year == 2020 && kh.NgayHoaDon.Month == 9)
				{
					kh.Xuat();
				}
			}

			Console.ReadKey();
		}
	}
}
