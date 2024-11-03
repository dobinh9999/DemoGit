using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtnhap1.Enabled = false;
			txtnhap2.Enabled = false;
			txtkqLN.Enabled = false;
			txtkqNN.Enabled = false;
			btnTimucln.Enabled = false;
			btnTimbcnn.Enabled = false;	
		}
		bool kt(string s)
		{
			if(string.IsNullOrEmpty(s))
				{
					return true;
				}
			else return false;
		}
		bool kt_dulieu()
		{
			int n;
			if(kt(txtnhap1.Text) || kt(txtnhap2.Text))
				{ return false; }
			if(!int.TryParse(txtnhap1.Text,out n) || n < 0) return false;
			if(!int.TryParse(txtnhap2.Text,out n) || n < 0) return false;
			
			return true;
		}

		private void btnnhap_Click(object sender, EventArgs e)
		{
			txtnhap1.Enabled=true;
			txtnhap2.Enabled=true;
			txtnhap1.Focus();
			btnTimucln.Enabled=true;
			btnTimbcnn.Enabled=true;
		}
		int ucln(int a , int b)
		{
			while(a != b)
			{
				if (a > b)
				{
					a = a - b;
				}
				else b = b - a;
			}
			return a;
		}

		private void btnTimucln_Click(object sender, EventArgs e)
		{
			btnnhap.Enabled=false;
			if (kt_dulieu())
			{
				txtkqLN.Text = ucln(int.Parse(txtnhap1.Text), int.Parse(txtnhap2.Text)).ToString();
			}
			else MessageBox.Show(" nhập sai dữ liệu "," thông báo !", MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}

		private void btnTimbcnn_Click(object sender, EventArgs e)
		{
			btnnhap.Enabled = false;
			if (kt_dulieu())
			{
				int s1, s2;
				s1 = int.Parse(txtnhap1.Text);
				s2 = int.Parse(txtnhap2.Text);
				int n = ucln(s1, s2);
				txtkqNN.Text = ((s1 * s2) / n).ToString();
			}
			else MessageBox.Show(" nhập sai dữ liệu ", " thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
