using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_bai2_dsSinhvien
{
	class Student : Person
	{
		private string name;
		private int age;
		private string nativePlace;
		private string id;

		public Student() { }

		public Student(string name, int age, string nativePlace, string id)
		{
			this.name = name;
			this.age = age;
			this.nativePlace = nativePlace;
			this.id = id;
		}

		public string Name
		{ 
			get { return this.name; } 
			set { name = value; } 
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string NativePlace
		{
			get { return nativePlace; }
			set { nativePlace = value; }
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}
		public void input()
		{
			Console.Write("Nhập tên: ");
			name = Console.ReadLine();

			Console.Write("Nhập tuổi: ");
			age = int.Parse(Console.ReadLine());

			Console.Write("Nhập quê quán: ");
			nativePlace = Console.ReadLine();

			Console.Write("Nhập mã sinh viên: ");
			id = Console.ReadLine();
		}

		public void display()
		{
			Console.WriteLine("Tên: " + name);
			Console.WriteLine("Tuổi: " + age);
			Console.WriteLine("Quê quán: " + nativePlace);
			Console.WriteLine("Mã sinh viên: " + id);
			Console.WriteLine("---------------------------");
		}
	}
}
