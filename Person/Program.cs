namespace Person
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool debug = false;
			Console.WriteLine("\nLap trinh huong doi tuong trong C#");
			Console.WriteLine("-------------------------------\n");
			//tao doi tuong Person va goi phuong thuc Greet() 
			person myPerson = new person(); //day la constructor   mac dinh

		  myPerson.LoiChao();
			/*tao mot doi tuong Student, thiet lap tuoi cho sinh    vien 
   nay la 21, gui loi chao toi anh ta va thong bao tuoi*/
			Student myStudent = new Student(); //day la constructor  mac dinh

		  myStudent.SetAge(21);
			myStudent.LoiChao();
			myStudent.ThongBaoTuoi();
			/*tao mot doi tuong Teacher, thiet lap tuoi cho giang   vien 
   nay la 30, de nghi anh ta chao va bat dau giang day*/
			Teacher myTeacher = new Teacher(); //day la constructor  mac dinh

		 myTeacher.SetAge(30);
			myTeacher.LoiChao();
			myTeacher.GiangDay();
			if (debug)
				Console.ReadLine();
			Console.ReadKey();
		}
	}
	
}
