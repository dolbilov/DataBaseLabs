using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
	public partial class ShowResultForm : Form
	{
		public ShowResultForm(DataSet dataSet)
		{
			InitializeComponent();
			dataGridView1.DataSource = dataSet.Tables[0];
		}
	}
}
