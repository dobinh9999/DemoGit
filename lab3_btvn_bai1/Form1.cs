using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_btvn_bai1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btngpt.Enabled = false;
			lblKq.Visible = false;
		}

		private void btnkt_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtA.Text) && string.IsNullOrWhiteSpace(txtB.Text))
			{
				
				MessageBox.Show("Vui lòng nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}

			// Kiểm tra xem dữ liệu nhập vào có phải là số thực hay không
			if (!double.TryParse(txtA.Text, out double A) || !double.TryParse(txtB.Text, out double B))
			{
				
				MessageBox.Show("Dữ liệu nhập vào phải là số thực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; 
			}

			// Dữ liệu hợp lệ, hiển thị thông báo
			MessageBox.Show("Dữ liệu đã hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Bật nút "Giải phương trình" và vô hiệu hóa nút "Kiểm tra"
			btngpt.Enabled = true;
			btnkt.Enabled = false;
		}

		private void btngpt_Click(object sender, EventArgs e)
		{
			double a,b;
			a = int .Parse(txtA.Text);
			b = int .Parse(txtB.Text);
			if (a == 0)
			{
				if (b == 0)
				{
					MessageBox.Show("Phương trình có vô số nghiệm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Phương trình vô nghiệm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				// Giải phương trình
				double x = -b / a;
				lblKq.Visible = true;
				lblKq.Text = "Phương trình có nghiệm x = "+ x.ToString();
			}
		}
	}
}
