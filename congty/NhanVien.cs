using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congty
{
	abstract class NhanVien
	{
		public string HoTen;
		public int Tuoi;
		public string GioiTinh;
		public string className;
		public abstract string ChucVu();
		public abstract void CongViec();
		public void HienThi()
		{
			System.Console.WriteLine("Lop Dan xuat '{4}': {0}, {1}, {2}, {3}",this.HoTen, this.Tuoi, this.GioiTinh, this.ChucVu(), className);
		}
	}
}
