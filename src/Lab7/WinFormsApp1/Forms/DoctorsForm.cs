using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Forms
{
	public partial class DoctorsForm : Form
	{
		public DoctorsForm()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		// Табельный номер врача
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			var sym = e.KeyChar;
			if (!char.IsDigit(sym) && sym!=8)
			{
				e.Handled = true;
			}
		}

		// Номер медицинского учреждения
		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			var sym = e.KeyChar;
			if (!char.IsDigit(sym) && sym != 8)
			{
				e.Handled = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// check if all fields are filled
			if (string.IsNullOrEmpty(label1.Text) ||
			    string.IsNullOrEmpty(label2.Text) ||
			    string.IsNullOrEmpty(label3.Text) ||
			    string.IsNullOrEmpty(label4.Text) ||
			    string.IsNullOrEmpty(label5.Text) ||
			    string.IsNullOrEmpty(label6.Text))
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				var query = "INSERT INTO _Врачи VALUES (";
				query += $"{textBox1.Text}, ";
				query += $"{textBox2.Text}, ";
				query += $"'{textBox3.Text}', ";
				query += $"'{textBox4.Text}', ";
				query += $"'{textBox5.Text}', ";
				query += $"'{textBox6.Text}')";

				Console.WriteLine(query);
				DBManager.connection.Open();
				var cmd = new OleDbCommand(query, DBManager.connection);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Данные успешно добавлены!", "Успех!", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				DBManager.connection.Close();
			}
		}
	}
}
