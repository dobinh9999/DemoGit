namespace bai3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			VanDongVien p = new VanDongVien("Nguyen Van A", 25, "Điền kinh", 65.5, 1.75);

			
			Console.WriteLine("Thông tin vận động viên p:");
			p.Xuat();
			Console.WriteLine();

			// Nhập vào mảng n vận động viên
			Console.Write("Nhập số lượng vận động viên: ");
			int n = int.Parse(Console.ReadLine());
			VanDongVien[] danhSach = new VanDongVien[n];

			
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"\nNhập thông tin vận động viên thứ {i + 1}:");
				danhSach[i] = new VanDongVien();
				danhSach[i].Nhap();
			}

			
			Console.WriteLine("\nDanh sách vận động viên đã nhập:");
			for (int i = 0; i < n; i++)
			{
				danhSach[i].Xuat();
			}

			
			Array.Sort(danhSach, (vdv1, vdv2) => vdv1.Tuoi.CompareTo(vdv2.Tuoi));

			
			Console.WriteLine("\nDanh sách vận động viên sau khi sắp xếp theo tuổi tăng dần:");
			for (int i = 0; i < n; i++)
			{
				danhSach[i].Xuat();
			}

			Console.ReadKey();
		}
	}
}
