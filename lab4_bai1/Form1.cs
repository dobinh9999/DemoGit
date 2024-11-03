using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_bai1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void lstWeb_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void btnoke_Click(object sender, EventArgs e)
		{
			if (lstWeb.SelectedIndex != -1)
			{
				txtkq.Text = "Bạn đã chọn Website \n" + lstWeb.SelectedItem.ToString();
			}
		}

		private void btnreset_Click(object sender, EventArgs e)
		{
			txtkq.Text = "";
		}
	}
}
