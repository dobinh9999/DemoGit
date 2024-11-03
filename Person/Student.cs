using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Student : person
	{
		public void ThongBaoTuoi()
		{
			Console.WriteLine("Tuoi cua ban la: {0} tuoi", age);
		}
	}
}
