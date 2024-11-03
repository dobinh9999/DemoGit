using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtN_TextChanged(object sender, EventArgs e)
		{
			gr_luachon.Enabled = true;
			if (txtN.Text == "")
			{
				gr_luachon.Enabled = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			gr_luachon.Enabled = false;
			lblkq.Enabled = false;
		}
		bool kt(string s)
		{
			if (string.IsNullOrWhiteSpace(s)) return true;
			else return false;
		}
		bool kt_dulieu()
		{
			int n;
			if (kt(txtN.Text)) return false;
			if (!int.TryParse(txtN.Text, out n) || n <= 0) return false;
			return true;
		}

		private void rdotinhtongN_CheckedChanged(object sender, EventArgs e)
		{
			if (kt_dulieu())
			{
				int S = 0, r; lblkq.Enabled = true;
				int n = int.Parse(txtN.Text);
				while (n != 0)
				{
					r = n % 10;
					S += r;
					n = n / 10;
				}
				lblkq.Text = "Tổng các chữ số của n là : " +S.ToString();
			}
			else
			{
				MessageBox.Show("Nhập sai n", "Thông báo");
				txtN.Focus();
			}
		}

		private void rdopheptinhtong_CheckedChanged(object sender, EventArgs e)
		{
			if (kt_dulieu())
			{
				float S = 0; lblkq.Enabled = true;
				int n = int.Parse(txtN.Text);
				for (int i = 1; i <= n; i++) S += 1.0f / i;
				lblkq.Text = "Tổng các chữ số của n là : " + S.ToString("F3");
			}
			else
			{
				MessageBox.Show("Nhập sai n", "Thông báo");
				txtN.Focus();
			}
		}
		}
}
