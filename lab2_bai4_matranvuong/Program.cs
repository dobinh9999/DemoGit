namespace lab2_bai4_matranvuong
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Nhập ma trận số thực vuông cấp n
			Console.Write("Nhập số nguyên dương n (cấp của ma trận vuông): ");
			int n = int.Parse(Console.ReadLine());

			double[,] matrix = new double[n, n];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"Nhập hàng {i + 1} gồm {n} phần tử: ");
				string[] input = Console.ReadLine().Split();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = double.Parse(input[j]);
				}
			}

			// 2. Hiển thị ma trận
			Console.WriteLine("Ma trận đã nhập:");
			HienThiMaTran(matrix);

			// 3. Tính tổng các phần tử nằm trên đường chéo phụ của ma trận
			double tongCheoPhu = TinhTongCheoPhu(matrix);
			Console.WriteLine($"Tổng các phần tử trên đường chéo phụ: {tongCheoPhu}");

			// 4. Tìm số âm lớn nhất trên đường chéo chính của ma trận
			double soAmLonNhatCheoChinh = TimSoAmLonNhatCheoChinh(matrix);
			if (soAmLonNhatCheoChinh != double.MinValue)
				Console.WriteLine($"Số âm lớn nhất trên đường chéo chính: {soAmLonNhatCheoChinh}");
			else
				Console.WriteLine("Không có số âm trên đường chéo chính.");

			// 5. Đếm các phần tử của ma trận có giá trị chia hết cho 3 và 5
			int demChiaHet3Va5 = DemPhanTuChiaHetCho3Va5(matrix);
			Console.WriteLine($"Số phần tử chia hết cho 3 và 5 trong ma trận: {demChiaHet3Va5}");
		}

		// Hiển thị ma trận
		static void HienThiMaTran(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
		}

		// Tính tổng các phần tử nằm trên đường chéo phụ
		static double TinhTongCheoPhu(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			double tong = 0;
			for (int i = 0; i < n; i++)
			{
				tong += matrix[i, n - i - 1];
			}
			return tong;
		}

		// Tìm số âm lớn nhất trên đường chéo chính của ma trận
		static double TimSoAmLonNhatCheoChinh(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			double max = double.MinValue;
			for (int i = 0; i < n; i++)
			{
				if (matrix[i, i] < 0 && matrix[i, i] > max)
				{
					max = matrix[i, i];
				}
			}
			return max;
		}

		// Đếm các phần tử có giá trị chia hết cho 3 và 5
		static int DemPhanTuChiaHetCho3Va5(double[,] matrix)
		{
			int count = 0;
			int n = matrix.GetLength(0);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (matrix[i, j] % 15 == 0)
					{
						count++;
					}
				}
			}
			return count;
		}
	}
	
}
