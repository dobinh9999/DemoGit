using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_bai1
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

		private void button1_Click_1(object sender, EventArgs e)
		{
			int a = int.Parse(txtN.Text);
			long s = 0;
			for (int i = 1; i <= a; i++)
			{
				s = s + i;
			}
			txtkq.Text = s.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
