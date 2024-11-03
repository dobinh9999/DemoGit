using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_bai4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnketthuc_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtnhap_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void btncapnhat_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtnhap.Text))
			{
				lstso.Items.Add(txtnhap.Text);
				txtnhap.Clear();
				txtnhap.Focus(); // Focus lại vào TextBox
			}
		}

		private void txtnhap_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btncapnhat_Click(sender, e);
				e.SuppressKeyPress = true; // Ngăn Enter làm hành động khác
			}
		}
		private void tang2()
		{
			for (int i = 0; i < lstso.Items.Count; i++)
			{
				int value = int.Parse(lstso.Items[i].ToString());
				lstso.Items[i] = (value + 2).ToString();
			}
		}
		private void chandautien()
		{
			foreach (var item in lstso.Items)
			{
				int value = int.Parse(item.ToString());
				if (value % 2 == 0)
				{
					lstso.SelectedItem = item;
					break;
				}
			}
		}
		private void lecuoicung()
		{
			for (int i = lstso.Items.Count - 1; i >= 0; i--)
			{
				int value = int.Parse(lstso.Items[i].ToString());
				if (value % 2 != 0)
				{
					lstso.SelectedItem = lstso.Items[i];
					break;
				}
			}
		}
		private void xoadangchon()
		{
			if (lstso.SelectedItem != null)
			{
				lstso.Items.Remove(lstso.SelectedItem);
			}
		}
		private void xoaphantudau()
		{
			if (lstso.Items.Count > 0)
			{
				lstso.Items.RemoveAt(0);
			}
		}
		private void xoaphantucuoi()
		{
			if (lstso.Items.Count > 0)
			{
				lstso.Items.RemoveAt(lstso.Items.Count - 1);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tang2();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			chandautien();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			lecuoicung();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			xoadangchon();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			xoaphantudau();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			xoaphantucuoi();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
