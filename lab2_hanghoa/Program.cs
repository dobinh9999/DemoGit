﻿namespace lab2_hanghoa
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Interface trong C#");
			Console.WriteLine("Vi du minh hoa interface");
			Console.WriteLine("--------------------------");
			//tao cac doi tuong GiaoDichHangHoa 
			GiaoDichHangHoa t1 = new GiaoDichHangHoa("001","8/10/2012", 78900.00);
			GiaoDichHangHoa t2 = new GiaoDichHangHoa("002","9/10/2012", 451900.00);
			t1.hienThiThongTinGiaoDich();
			t2.hienThiThongTinGiaoDich();
			Console.ReadKey();
		}
	}
}
