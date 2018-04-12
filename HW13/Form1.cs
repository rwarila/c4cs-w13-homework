using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Specify that the link was visited.
			this.linkLabel1.LinkVisited = true;

			// Navigate to a URL.
			System.Diagnostics.Process.Start("https://c4cs.github.io/static/w18/hw/c4cs-wk13-homework.pdf");
            //Test
		}
	}
}
