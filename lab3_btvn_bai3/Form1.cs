using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_btvn_bai3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			rtb_kq.Visible = false;

		}

		private void btntinhtong_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(txtN.Text))
			{
				int S = 0, r;
				rtb_kq.Visible = true;
				int n = int.Parse(txtN.Text);
				while (n != 0)
				{
					r = n % 10;
					S += r;
					n = n / 10;
				}
				rtb_kq.Text = "Tổng các chữ số của n là : " + S.ToString();
			}
			else
			{
				MessageBox.Show("Nhập sai n", "Thông báo");
				txtN.Focus();
			}
		}
		bool IsPrime(int n)
		{
			if (n <= 1) return false; // 0 và 1 không phải số nguyên tố
			if (n == 2) return true;  // 2 là số nguyên tố

			// Kiểm tra các số từ 2 đến căn bậc hai của n
			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
					return false; // Nếu n chia hết cho i thì n không phải số nguyên tố
			}
			return true; // Nếu không chia hết cho số nào, n là số nguyên tố
		}

		private void btnsnt_Click(object sender, EventArgs e)
		{
			int n = int.Parse((txtN.Text).Trim());
			if(IsPrime(n))
			{
				MessageBox.Show(n+ " là số nguyên tố"," kết quả", MessageBoxButtons.OK);
			}
			else MessageBox.Show(n + " không là số nguyên tố"," kết quả",MessageBoxButtons.OK);
		}
	}
}
