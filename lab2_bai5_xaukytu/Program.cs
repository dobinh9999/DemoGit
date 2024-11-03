namespace lab2_bai5_xaukytu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Nhập vào một xâu ký tự
			Console.Write("Nhập vào một xâu ký tự: ");
			string inputString = Console.ReadLine();

			// 1. Hiển thị xâu ký tự vừa nhập
			Console.WriteLine($"Xâu ký tự vừa nhập: {inputString}");

			// 2. Đếm số chữ thường và chữ hoa
			int lowerCaseCount = 0;
			int upperCaseCount = 0;
			foreach (char c in inputString)
			{
				if (char.IsLower(c))
				{
					lowerCaseCount++;
				}
				else if (char.IsUpper(c))
				{
					upperCaseCount++;
				}
			}
			Console.WriteLine($"Số chữ thường: {lowerCaseCount}");
			Console.WriteLine($"Số chữ hoa: {upperCaseCount}");

			// 3. Đếm số từ trong xâu vừa nhập
			string[] words = inputString.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			int wordCount = words.Length;
			Console.WriteLine($"Số từ trong xâu: {wordCount}");

			// 4. Đếm số phụ âm và nguyên âm trong xâu
			int vowelCount = 0;
			int consonantCount = 0;
			string vowels = "aeiouAEIOU";
			foreach (char c in inputString)
			{
				if (char.IsLetter(c))
				{
					if (vowels.Contains(c))
					{
						vowelCount++;
					}
					else
					{
						consonantCount++;
					}
				}
			}
			Console.WriteLine($"Số nguyên âm: {vowelCount}");
			Console.WriteLine($"Số phụ âm: {consonantCount}");

			// 5. Nhập vào một xâu con và đếm số lần xuất hiện của xâu con trong xâu đã nhập
			Console.Write("Nhập vào một xâu con: ");
			string subString = Console.ReadLine();
			int subStringCount = CountSubstringOccurrences(inputString, subString);
			Console.WriteLine($"Số lần xuất hiện của xâu con \"{subString}\" trong xâu: {subStringCount}");
		}

		// Hàm đếm số lần xuất hiện của xâu con trong xâu lớn
		static int CountSubstringOccurrences(string text, string subString)
		{
			int count = 0;
			int index = text.IndexOf(subString);
			while (index != -1)
			{
				count++;
				index = text.IndexOf(subString, index + subString.Length);
			}
			return count;
		}
	}
}
