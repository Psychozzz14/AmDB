using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmDB
{
	public partial class Contents : Form
	{
		public Contents()
		{
			InitializeComponent();
		}
		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
