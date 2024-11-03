namespace bai4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhập số lượng hành khách: ");
			int n = int.Parse(Console.ReadLine());

			List<HanhKhach> danhSachHanhKhach = new List<HanhKhach>();

			
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"Nhập thông tin hành khách thứ {i + 1}:");
				HanhKhach hanhKhach = new HanhKhach();
				hanhKhach.Nhap();
				danhSachHanhKhach.Add(hanhKhach);
			}

			
			Console.WriteLine("\nDanh sách hành khách và tổng tiền phải trả:");
			foreach (HanhKhach hk in danhSachHanhKhach)
			{
				hk.Xuat();
			}

			
			danhSachHanhKhach.Sort((hk1, hk2) => hk2.TongTien().CompareTo(hk1.TongTien()));

			
			Console.WriteLine("\nDanh sách hành khách sau khi sắp xếp theo tổng tiền giảm dần:");
			foreach (HanhKhach hk in danhSachHanhKhach)
			{
				hk.Xuat();
			}

			
			Console.ReadKey();
		}
	}
}
