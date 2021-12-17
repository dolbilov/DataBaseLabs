using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Forms
{
	public partial class ParameterAskForm : Form
	{
		public static bool IsIntInput = false;
		
		public ParameterAskForm()
		{
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (IsIntInput && !InputValidator.ValidateInt(e))
			{
				e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			QueryManager.QueryParameter = textBox1.Text;
			Close();
		}
	}
}
