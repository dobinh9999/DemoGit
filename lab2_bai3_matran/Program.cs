namespace lab2_bai3_matran
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Nhập ma trận số thực gồm n hàng, m cột
			Console.Write("Nhập số hàng n: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Nhập số cột m: ");
			int m = int.Parse(Console.ReadLine());

			double[,] matrix = new double[n, m];

			for (int i = 0; i < n; i++)
			{
				Console.Write($"Nhập hàng {i + 1} gồm {m} phần tử: ");
				string[] input = Console.ReadLine().Split();
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = double.Parse(input[j]);
				}
			}

			// 2. Hiển thị ma trận
			Console.WriteLine("Ma trận đã nhập:");
			HienThiMaTran(matrix);

			// 3. Tìm số âm nhỏ nhất của ma trận
			double soAmNhoNhat = TimSoAmNhoNhat(matrix);
			if (soAmNhoNhat != double.MaxValue)
				Console.WriteLine($"Số âm nhỏ nhất trong ma trận: {soAmNhoNhat}");
			else
				Console.WriteLine("Không có số âm trong ma trận.");

			// 4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần
			SapXepCot(matrix);
			Console.WriteLine("Ma trận sau khi sắp xếp từng cột theo thứ tự tăng dần:");
			HienThiMaTran(matrix);

			// 5. Nhập số nguyên dương k, xóa cột thứ k của ma trận nếu có
			Console.Write("Nhập số nguyên dương k (số cột cần xóa): ");
			int k = int.Parse(Console.ReadLine()) - 1;
			if (k >= 0 && k < m)
			{
				matrix = XoaCot(matrix, k);
				Console.WriteLine($"Ma trận sau khi xóa cột thứ {k + 1}:");
				HienThiMaTran(matrix);
			}
			else
			{
				Console.WriteLine("Cột cần xóa không hợp lệ.");
			}

			// 6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận
			double trungBinhCongChan = TinhTrungBinhCongChan(matrix);
			if (trungBinhCongChan != -1)
				Console.WriteLine($"Trung bình cộng các phần tử chẵn trong ma trận: {trungBinhCongChan}");
			else
				Console.WriteLine("Không có phần tử chẵn trong ma trận.");
		}

		// Hiển thị ma trận
		static void HienThiMaTran(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write($"{matrix[i, j]} ");
				}
				Console.WriteLine();
			}
		}

		// Tìm số âm nhỏ nhất
		static double TimSoAmNhoNhat(double[,] matrix)
		{
			double min = double.MaxValue;
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (matrix[i, j] < 0 && matrix[i, j] < min)
					{
						min = matrix[i, j];
					}
				}
			}
			return min;
		}

		// Sắp xếp từng cột của ma trận theo thứ tự tăng dần
		static void SapXepCot(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			for (int j = 0; j < m; j++)
			{
				double[] column = new double[n];
				for (int i = 0; i < n; i++)
				{
					column[i] = matrix[i, j];
				}
				Array.Sort(column);
				for (int i = 0; i < n; i++)
				{
					matrix[i, j] = column[i];
				}
			}
		}

		// Xóa cột thứ k của ma trận
		static double[,] XoaCot(double[,] matrix, int k)
		{
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			double[,] newMatrix = new double[n, m - 1];
			for (int i = 0; i < n; i++)
			{
				int newCol = 0;
				for (int j = 0; j < m; j++)
				{
					if (j != k)
					{
						newMatrix[i, newCol] = matrix[i, j];
						newCol++;
					}
				}
			}
			return newMatrix;
		}

		// Tính trung bình cộng các phần tử chẵn trong ma trận
		static double TinhTrungBinhCongChan(double[,] matrix)
		{
			int count = 0;
			double sum = 0;
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if ((int)matrix[i, j] % 2 == 0)
					{
						sum += matrix[i, j];
						count++;
					}
				}
			}
			return count > 0 ? sum / count : -1;
		}
	}
}
