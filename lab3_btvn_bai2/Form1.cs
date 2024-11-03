using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_btvn_bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnchuyenhauto.Enabled = false;
			richTextBox2.Enabled = false;
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			btnchuyenhauto.Enabled = true;
			if (richTextBox1.Text == "")
			{
				btnchuyenhauto.Enabled = false;
			}
		}

		private void btnchuyenhauto_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem người dùng đã nhập biểu thức trung tố chưa
			if (string.IsNullOrWhiteSpace(richTextBox1.Text))
			{
				MessageBox.Show("Vui lòng nhập biểu thức trung tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			
			//richTextBox1.Enabled = false;

			// Chuyển biểu thức trung tố sang hậu tố
			string bieuThucTrungTo = richTextBox1.Text;
			string bieuThucHauTo = ChuyenTrungToSangHauTo(bieuThucTrungTo);

			
			richTextBox2.Visible = true;
			richTextBox2.Text = bieuThucHauTo;
		}
		private string ChuyenTrungToSangHauTo(string bieuThucTrungTo)
		{
			Stack<char> stack = new Stack<char>();
			StringBuilder hauTo = new StringBuilder();

			foreach (char c in bieuThucTrungTo)
			{
				if (Char.IsLetterOrDigit(c))
				{
					
					hauTo.Append(c);
				}
				else if (c == '(')
				{
					
					stack.Push(c);
				}
				else if (c == ')')
				{
				
					while (stack.Count > 0 && stack.Peek() != '(')
					{
						hauTo.Append(stack.Pop());
					}
					if (stack.Count > 0 && stack.Peek() == '(')
					{
						stack.Pop(); // Bỏ dấu ngoặc mở
					}
					else
					{
						
						MessageBox.Show("Biểu thức không hợp lệ: Thiếu dấu ngoặc mở.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return "";
					}
				}
				else
				{
					
					while (stack.Count > 0 && DoUuTien(c) <= DoUuTien(stack.Peek()))
					{
						hauTo.Append(stack.Pop());
					}
					stack.Push(c);
				}
			}

			
			while (stack.Count > 0)
			{
				if (stack.Peek() == '(')
				{
					MessageBox.Show("Biểu thức không hợp lệ: Thiếu dấu ngoặc đóng.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return "";
				}
				hauTo.Append(stack.Pop());
			}

			return hauTo.ToString();
		}

		private int DoUuTien(char c)
		{
			switch (c)
			{
				case '+':
				case '-':
					return 1;
				case '*':
				case '/':
					return 2;
				case '^':
					return 3;
				default:
					return 0;
			}
		}

		
		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
