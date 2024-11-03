namespace lab2_sinhvien1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SinhVien sv = new SinhVien();
			sv.Ma = "sv001";
			sv.hT = "Do Xuan Binh";
			sv.QQ = " Nam Dinh";
			sv.Tuoi = 20;

			sv.hienthi();

			Console.WriteLine(" ===================== Sử dụng interface để in ra kết quả =================");

			Nguoi ng = sv;
			ng.hienthi();

			Console.ReadKey();

		}
	}
}
