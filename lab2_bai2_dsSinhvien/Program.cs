namespace lab2_bai2_dsSinhvien
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();

			Console.Write("Nhập số lượng sinh viên: ");
			int numberOfStudents = int.Parse(Console.ReadLine());

			// Nhập danh sách sinh viên
			for (int i = 0; i < numberOfStudents; i++)
			{
				Console.WriteLine("Nhập thông tin sinh viên thứ " + (i + 1) + ":");
				Student student = new Student();
				student.input();
				students.Add(student);
			}

			// Hiển thị danh sách sinh viên
			Console.WriteLine("\nDanh sách sinh viên vừa nhập:");
			foreach (var student in students)
			{
				student.display();
			}

			// Tìm kiếm sinh viên có tên là "Nam"
			Console.WriteLine("Tìm kiếm sinh viên có tên là 'Nam':");
			bool found = false;
			foreach (var student in students)
			{
				if (student.Name.ToLower() == "nam".ToLower())
				{
					student.display();
					found = true;
				}
			}

			if (!found)
			{
				Console.WriteLine("Không tìm thấy sinh viên có tên là 'Nam'.");
			}
		}
	}
}
