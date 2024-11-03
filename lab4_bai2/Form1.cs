using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_bai2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnoke_Click(object sender, EventArgs e)
		{
			if (ccbweb.SelectedIndex != -1)
			{
				txtkq.Text = "Bạn đã chọn website : "+ccbweb.Text.ToString();
			}
		}

		private void btnreset_Click(object sender, EventArgs e)
		{
			txtkq.Text = "";
		}
	}
}
