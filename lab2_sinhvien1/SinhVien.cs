using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_sinhvien1
{
	internal class SinhVien : Nguoi
	{
		private String ma;
		private String HT;
		private String qq;
		private int tuoi;
		public SinhVien() { }
		public SinhVien(string ma, string hT, string qq, int tuoi)
		{
			this.ma = ma;
			this.HT = hT;
			this.qq = qq;
			this.tuoi = tuoi;
		}

		~SinhVien() { }

		

		public String Ma {  get { return ma; }  set { this.ma = value; } }
		public String hT { get { return HT; } set { this.HT = value; } }
		public String QQ { get { return qq; } set { this.qq = value; } }
		public int Tuoi { get { return this.tuoi; } set { this.tuoi = value; } }


		public void hienthi()
		{
			Console.WriteLine(" Mã Sinh Viên :"+ma +"\n Ho Ten Sinh Vien :"+HT+"\n que quan sinh vien :"+qq+"\n tuoi sinh vien : "+tuoi);
		}

	}
}
