using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANSO
{
	internal class PhanSo
	{
		private int tuSo;
		private int mauSo;

		
		public PhanSo()
		{
			tuSo = 0;
			mauSo = 1; 
		}

		
		public PhanSo(int tuSo, int mauSo)
		{
			this.tuSo = tuSo;
			if (mauSo == 0)
			{
				throw new ArgumentException("Mẫu số không thể là 0.");
			}
			this.mauSo = mauSo;
		}

		
		public void Nhap()
		{
			Console.Write("Nhập tử số: ");
			tuSo = int.Parse(Console.ReadLine());

			do
			{
				Console.Write("Nhập mẫu số (khác 0): ");
				mauSo = int.Parse(Console.ReadLine());
			} while (mauSo == 0);
		}

		
		public void Xuat()
		{
			Console.WriteLine($"{tuSo}/{mauSo}");
		}

		
		public PhanSo Cong(PhanSo ps)
		{
			int tu = tuSo * ps.mauSo + mauSo * ps.tuSo;
			int mau = mauSo * ps.mauSo;
			return ToiGian(new PhanSo(tu, mau));
		}

		
		public PhanSo Tru(PhanSo ps)
		{
			int tu = tuSo * ps.mauSo - mauSo * ps.tuSo;
			int mau = mauSo * ps.mauSo;
			return ToiGian(new PhanSo(tu, mau));
		}

		
		public PhanSo Nhan(PhanSo ps)
		{
			int tu = tuSo * ps.tuSo;
			int mau = mauSo * ps.mauSo;
			return ToiGian(new PhanSo(tu, mau));
		}

		
		public PhanSo Chia(PhanSo ps)
		{
			int tu = tuSo * ps.mauSo;
			int mau = mauSo * ps.tuSo;
			if (mau == 0)
			{
				throw new DivideByZeroException("Mẫu số không thể là 0.");
			}
			return ToiGian(new PhanSo(tu, mau));
		}

		
		private PhanSo ToiGian(PhanSo ps)
		{
			int ucln = UCLN(ps.tuSo, ps.mauSo);
			ps.tuSo /= ucln;
			ps.mauSo /= ucln;
			return ps;
		}

		
		private int UCLN(int a, int b)
		{
			while (b != 0)
			{
				int tmp = b;
				b = a % b;
				a = tmp;
			}
			return Math.Abs(a);
		}
	}
}
