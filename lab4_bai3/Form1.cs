using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4_bai3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btncphai_Click(object sender, EventArgs e)
		{
			if (lstA.SelectedItem != null)
			{
				lstB.Items.Add(lstA.SelectedItem.ToString());
				lstA.Items.Remove(lstA.SelectedItem.ToString());
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void lstA_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstA.SelectedItem != null)
			{
				
				txtten.Text = lstA.SelectedItem.ToString();
			}
			else
			{
				
				txtten.Text = string.Empty;
			}
		}

		private void btnketthuc_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnctrai_Click(object sender, EventArgs e)
		{
			if (lstB.SelectedItem != null)
			{
				lstA.Items.Add((lstB.SelectedItem.ToString()));
				lstB.Items.Remove((lstB.SelectedItem.ToString()));
			}
		}

		private void btnallphai_Click(object sender, EventArgs e)
		{
			while (lstA.SelectedItems.Count > 0 )
			{
				lstB.Items.Add(lstA.SelectedItems[0].ToString());
				lstA.Items.Remove(lstA.SelectedItems[0]);
			}
		}

		private void btnalltrai_Click(object sender, EventArgs e)
		{
			while(lstB.SelectedItems.Count > 0)
			{
				lstA.Items.Add(lstB.SelectedItems[0].ToString());
				lstB.Items.Remove(lstB.SelectedItems[0]);
			}
		}

		private void btncapnhat_Click(object sender, EventArgs e)
		{
			if (lstA.SelectedIndex != -1 && !string.IsNullOrEmpty(txtten.Text))
			{
				
				lstA.Items[lstA.SelectedIndex] = txtten.Text.ToString();
			}
			if (lstB.SelectedIndex != -1 && !string.IsNullOrEmpty(txtten.Text))
			{

				lstB.Items[lstB.SelectedIndex] = txtten.Text.ToString();
			}

		}

		private void lstB_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstB.SelectedItem != null)
			{
				
				txtten.Text = lstB.SelectedItem.ToString();
			}
			else
			{
				
				txtten.Text = string.Empty;
			}
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			if(lstA.SelectedIndex != -1)
			{
				lstA.Items.Remove(lstA.SelectedItem.ToString());
			}
		}
	}
}
