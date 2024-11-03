using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_btvn_bai4
{
	internal class student
	{
		public string StudentId { get; set; }
		public string FullName { get; set; }
		public int BirthYear { get; set; }
		public string Address { get; set; }
		public string ClassName { get; set; }

		public override string ToString()
		{
			return $"Mã số sinh viên: {StudentId}, Họ tên: {FullName}, Năm sinh: {BirthYear}, Địa chỉ: {Address}, Lớp học: {ClassName}";
		}
	}
}
