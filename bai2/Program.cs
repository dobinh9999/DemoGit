namespace bai2
{
	internal class Program
	{
		
			static List<SinhVien> danhSachSinhVien = new List<SinhVien>();

			// Tạo danh sách sinh viên
			static void TaoDanhSachSinhVien()
			{
				Console.Write("Nhập số lượng sinh viên: ");
				int soLuong = int.Parse(Console.ReadLine());
				for (int i = 0; i < soLuong; i++)
				{
					Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
					SinhVien sv = new SinhVien();
					sv.Nhap();
					danhSachSinhVien.Add(sv);
				}
			}

			// Sửa thông tin sinh viên
			static void SuaThongTinSinhVien(string hoTen)
			{
				SinhVien sv = danhSachSinhVien.FirstOrDefault(s => s.HoTen == hoTen);
				if (sv != null)
				{
					Console.WriteLine("Nhập lại thông tin sinh viên:");
					sv.Nhap();
					Console.WriteLine("Thông tin sinh viên đã được cập nhật.");
				}
				else
				{
					Console.WriteLine("Không tìm thấy sinh viên này.");
				}
			}

			// Xóa thông tin sinh viên
			static void XoaThongTinSinhVien(string hoTen)
			{
				SinhVien sv = danhSachSinhVien.FirstOrDefault(s => s.HoTen == hoTen);
				if (sv != null)
				{
					danhSachSinhVien.Remove(sv);
					Console.WriteLine("Đã xóa thông tin sinh viên.");
				}
				else
				{
					Console.WriteLine("Không tìm thấy sinh viên này.");
				}
			}

			// Đưa ra những sinh viên có quê quán ở Nam Định
			static void TimSinhVienTheoQueQuan(string queQuan)
			{
				var sinhVienQueQuan = danhSachSinhVien.Where(sv => sv.QueQuan == queQuan).ToList();
				if (sinhVienQueQuan.Count > 0)
				{
					Console.WriteLine($"Sinh viên có quê quán ở {queQuan}:");
					foreach (var sv in sinhVienQueQuan)
					{
						sv.Xuat();
					}
				}
				else
				{
					Console.WriteLine($"Không có sinh viên nào có quê quán ở {queQuan}.");
				}
			}

			// Đưa ra sinh viên có điểm tổng kết lớn nhất
			static void TimSinhVienDiemTongKetLonNhat()
			{
				double maxDiem = danhSachSinhVien.Max(sv => sv.DiemTongKet);
				var sinhVienMaxDiem = danhSachSinhVien.Where(sv => sv.DiemTongKet == maxDiem).ToList();

				Console.WriteLine("Sinh viên có điểm tổng kết lớn nhất:");
				foreach (var sv in sinhVienMaxDiem)
				{
					sv.Xuat();
				}
			}

			static void Main(string[] args)
			{
				int luaChon;
				do
				{
					Console.WriteLine("\n------ MENU ------");
					Console.WriteLine("1. Tạo danh sách sinh viên");
					Console.WriteLine("2. Sửa thông tin sinh viên");
					Console.WriteLine("3. Xóa thông tin sinh viên");
					Console.WriteLine("4. Tìm sinh viên quê quán ở Nam Định");
					Console.WriteLine("5. Tìm sinh viên có điểm tổng kết lớn nhất");
					Console.WriteLine("0. Thoát");
					Console.Write("Nhập lựa chọn của bạn: ");
					luaChon = int.Parse(Console.ReadLine());

					switch (luaChon)
					{
						case 1:
							TaoDanhSachSinhVien();
							break;
						case 2:
							Console.Write("Nhập tên sinh viên cần sửa: ");
							string tenSua = Console.ReadLine();
							SuaThongTinSinhVien(tenSua);
							break;
						case 3:
							Console.Write("Nhập tên sinh viên cần xóa: ");
							string tenXoa = Console.ReadLine();
							XoaThongTinSinhVien(tenXoa);
							break;
						case 4:
							TimSinhVienTheoQueQuan("Nam Định");
							break;
						case 5:
							TimSinhVienDiemTongKetLonNhat();
							break;
						case 0:
							Console.WriteLine("Kết thúc chương trình.");
							break;
						default:
							Console.WriteLine("Lựa chọn không hợp lệ!");
							break;
					}
				} while (luaChon != 0);
			}
		}
	
}
