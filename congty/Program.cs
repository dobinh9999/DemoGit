namespace congty
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// để chế độ output là UTF-8 
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			// chỉnh màu nền 
			Console.BackgroundColor = ConsoleColor.White;
			//Xóa màu nên cũ 
			Console.Clear();
			// chỉnh màu chữ  
			Console.ForegroundColor = ConsoleColor.Black;
			GiamDoc objGiamDoc = new GiamDoc();
			objGiamDoc.HoTen = "Nguyễn Thị A";
			objGiamDoc.Tuoi = 30;
			objGiamDoc.GioiTinh = "Nữ";
			System.Console.WriteLine("Lop Dan xuat 'GiamDoc': {0},{1},{2},{3}",objGiamDoc.HoTen,objGiamDoc.Tuoi, objGiamDoc.GioiTinh, objGiamDoc.ChucVu());
			ketoan objKeToan = new ketoan();
			objKeToan.HoTen = "Nguyễn Thị B";
			objKeToan.Tuoi = 26;
			objKeToan.GioiTinh = "Nữ";
			System.Console.WriteLine("Lop Dan xuat 'Ke Toan': {0}, {1}, {2}, {3}",objKeToan.HoTen, objKeToan.Tuoi, objKeToan.GioiTinh,objKeToan.ChucVu());
			Console.ReadKey();
			ketoan objKeToan1 = new ketoan();
			objKeToan1.HoTen = "Nguyễn Thị A";
			objKeToan1.Tuoi = 25;
			objKeToan1.GioiTinh = "Nữ";
		}
	}
}
