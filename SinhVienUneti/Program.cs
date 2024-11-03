namespace SinhVienUneti
{
	abstract class SinhVienUneti
	{
		public string HoTen { get; set; }
		public string Nganh { get; set; }

		// Phương thức trừu tượng getDiem()
		public abstract double getDiem();

		// Phương thức xếp loại học lực
		public string getXepLoaiHL()
		{
			double diem = getDiem();
			if (diem >= 8) return "Giỏi";
			else if (diem >= 6.5) return "Khá";
			else if (diem >= 5) return "Trung Bình";
			else return "Yếu";
		}

		// Phương thức xuất thông tin
		public void Xuat()
		{
			Console.WriteLine("Họ Tên: " + HoTen);
			Console.WriteLine("Ngành: " + Nganh);
			Console.WriteLine("Điểm: " + getDiem());
			Console.WriteLine("Xếp loại: " + getXepLoaiHL());
		}
	}

	// Lớp cụ thể kế thừa từ SinhVienUneti
	class SinhVienCNTT : SinhVienUneti
	{
		private double diemJava;
		private double diemCSharp;

		public SinhVienCNTT(string hoTen, string nganh, double diemJava, double diemCSharp)
		{
			this.HoTen = hoTen;
			this.Nganh = nganh;
			this.diemJava = diemJava;
			this.diemCSharp = diemCSharp;
		}

		// Triển khai phương thức getDiem()
		public override double getDiem()
		{
			return (diemJava + diemCSharp) / 2;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			SinhVienCNTT sv1 = new SinhVienCNTT("Nguyen Van A", "Công nghệ thông tin", 8.0, 7.5);
			sv1.Xuat();
		}
	}
}
