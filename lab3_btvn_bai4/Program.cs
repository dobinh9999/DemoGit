using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_btvn_bai4
{
	internal class Program
	{
		static ArrayList students = new ArrayList();
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Chương trình quản lý sinh viên");
				Console.WriteLine("1. Thêm sinh viên");
				Console.WriteLine("2. Sửa sinh viên");
				Console.WriteLine("3. Xóa sinh viên");
				Console.WriteLine("4. Xuất số lượng sinh viên");
				Console.WriteLine("5. Xuất danh sách sinh viên theo lớp");
				Console.WriteLine("6. Thoát");
				Console.Write("Chọn chức năng (1-6): ");

				string choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						AddStudent();
						break;
					case "2":
						EditStudent();
						break;
					case "3":
						RemoveStudent();
						break;
					case "4":
						DisplayStudentCount();
						break;
					case "5":
						DisplayStudentsByClass();
						break;
					case "6":
						return;
					default:
						Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
						break;
				}
			}
		}

		static void AddStudent()
		{
			student student = new student();
			Console.Write("Nhập mã số sinh viên: ");
			student.StudentId = Console.ReadLine();
			Console.Write("Nhập họ tên: ");
			student.FullName = Console.ReadLine();
			Console.Write("Nhập năm sinh: ");
			student.BirthYear = int.Parse(Console.ReadLine());
			Console.Write("Nhập địa chỉ: ");
			student.Address = Console.ReadLine();
			Console.Write("Nhập lớp học: ");
			student.ClassName = Console.ReadLine();

			students.Add(student);
			Console.WriteLine("Đã thêm sinh viên thành công.");
		}

		static void EditStudent()
		{
			Console.Write("Nhập mã số sinh viên cần sửa: ");
			string studentId = Console.ReadLine();

			foreach (student student in students)
			{
				if (student.StudentId == studentId)
				{
					Console.Write("Nhập họ tên mới: ");
					student.FullName = Console.ReadLine();
					Console.Write("Nhập năm sinh mới: ");
					student.BirthYear = int.Parse(Console.ReadLine());
					Console.Write("Nhập địa chỉ mới: ");
					student.Address = Console.ReadLine();
					Console.Write("Nhập lớp học mới: ");
					student.ClassName = Console.ReadLine();

					Console.WriteLine("Đã sửa thông tin sinh viên thành công.");
					return;
				}
			}
			Console.WriteLine("Không tìm thấy sinh viên với mã số đã nhập.");
		}

		static void RemoveStudent()
		{
			Console.Write("Nhập mã số sinh viên cần xóa: ");
			string studentId = Console.ReadLine();

			for (int i = 0; i < students.Count; i++)
			{
				if (((student)students[i]).StudentId == studentId)
				{
					students.RemoveAt(i);
					Console.WriteLine("Đã xóa sinh viên thành công.");
					return;
				}
			}
			Console.WriteLine("Không tìm thấy sinh viên với mã số đã nhập.");
		}

		static void DisplayStudentCount()
		{
			Console.WriteLine($"Số lượng sinh viên hiện có: {students.Count}");
		}

		static void DisplayStudentsByClass()
		{
			Console.Write("Nhập lớp học cần xuất danh sách: ");
			string className = Console.ReadLine();

			Console.WriteLine($"Danh sách sinh viên lớp {className}:");
			foreach (student student in students)
			{
				if (student.ClassName.Equals(className, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine(student);
				}
			}
		}
	}
}
