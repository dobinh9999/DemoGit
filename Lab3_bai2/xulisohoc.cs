using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_bai2
{
	internal class xulisohoc
	{
		private int a;
		private int b;

		public xulisohoc()
		{
			a = 0;
			b = 0;
		}
		public xulisohoc(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public int timucln(int a, int b)
		{
			int x = Math.Abs(a);
			int y = Math.Abs(b);
			while (x != y)
			{
				if (x > y)
				{
					x = x - y;
				}
				else
					y = y - x;

				return x;
			}
		}
	}
}
