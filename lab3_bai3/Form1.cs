using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txt1.Enabled = false;
			txt2.Enabled = false;
			txt3.Enabled = false;
			gr_tinh.Enabled = false;
			lblKq.Visible = false;
		}

		private void btnnhap_Click(object sender, EventArgs e)
		{
			txt1.Enabled = true;
			txt2.Enabled = true;
			txt3.Enabled = true;
			gr_tinh.Enabled = true;
			txt1.Focus();
		}
		bool kt(string s)
		{
			if (string.IsNullOrEmpty(s)) return true;
			else return false;
		}
		bool kt_dulieu()
		{
			double n;
			if (kt(txt1.Text) ||
			kt(txt2.Text) || kt(txt3.Text)) return false;
			if (!double.TryParse(txt1.Text, out n) || n < 0)
				return false;
			if (!double.TryParse(txt2.Text, out n) || n < 0)
				return false;
			if (!double.TryParse(txt3.Text, out n) || n < 0)
				return false;
			return true;
		}
		bool kt_tamgiac(double a, double b, double c)
		{
			if (a + b > c && a + c > b && b + c > a)
				return true;
			else return false;
		}

		private void rdo_tinhdientich_CheckedChanged(object sender, EventArgs e)
		{
			txt1.Enabled = false;
			txt2.Enabled = false;
			txt3.Enabled = false;
			btnnhap.Enabled = false;
			lblKq.Visible = true;
			if (kt_dulieu())
			{
				double a, b, c;
				a = double.Parse(txt1.Text);
				b = double.Parse(txt2.Text);
				c = double.Parse(txt3.Text);

				if (kt_tamgiac(a, b, c))
				{
					double p = (a + b + c) / 2;
					lblKq.Text = " Diện Tích tam giác : " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString("F3");
				}
				else lblKq.Text = " ba cạnh không lập thành tam giác ";
			}
			else MessageBox.Show(" Dữ liệu nhập chưa chính xác", "thông báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
		}

		private void rdo_tinhchuci_CheckedChanged(object sender, EventArgs e)
		{
			txt1.Enabled = false;
			txt2.Enabled = false;
			txt3.Enabled = false;
			btnnhap.Enabled = false;
			lblKq.Visible = true;
			if (kt_dulieu())
			{
				double a, b, c;
				a = double.Parse(txt1.Text);
				b = double.Parse(txt2.Text);
				c = double.Parse(txt3.Text);
				if (kt_tamgiac(a, b, c))
				{
					lblKq.Text = " Chu vi của tam giác :" + (a + b + c).ToString("F3");
				}
				else lblKq.Text = " ba cạnh không lập thành tam giác ";

			}
			else MessageBox.Show("Dữ liệu chưa hợp lệ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}
