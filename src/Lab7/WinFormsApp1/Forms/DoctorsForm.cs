using System;
using System.Data.OleDb;
using System.Windows.Forms;
using WinFormsApp1.Utils;
using WinFormsApp1.Utils.Enums;

namespace WinFormsApp1.Forms
{
	public partial class DoctorsForm : Form
	{
		private const string TableName = "_Врачи";
		private static DataGridViewCellCollection _selectedRowCells;
		

		public DoctorsForm(DataGridViewCellCollection cells)
		{
			_selectedRowCells = cells;
			InitializeComponent();
		}
		
		// Табельный номер врача
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		// Номер медицинского учреждения
		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// check if all fields are filled
			if (string.IsNullOrEmpty(textBox1.Text) ||
			    string.IsNullOrEmpty(textBox2.Text) ||
			    string.IsNullOrEmpty(textBox3.Text) ||
			    string.IsNullOrEmpty(textBox4.Text) ||
			    string.IsNullOrEmpty(textBox5.Text) ||
			    string.IsNullOrEmpty(textBox6.Text))
			{
				MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				string query;
				if (Form1.CurrentTableOpenMode == TableOpenMode.Add) //adding new row
				{
					query = $"INSERT INTO {TableName} VALUES (";
					query += $"{textBox1.Text}, ";
					query += $"{textBox2.Text}, ";
					query += $"'{textBox3.Text}', ";
					query += $"'{textBox4.Text}', ";
					query += $"'{textBox5.Text}', ";
					query += $"'{textBox6.Text}')";
				}
				else // change data of selected row
				{
					query = $"UPDATE {TableName} ";
					query += $"SET [Табельный номер врача] = {textBox1.Text}, ";
					query += $"[Номер лечебного учреждения] = {textBox2.Text}, ";
					query += $"[Фамилия] = '{textBox3.Text}', ";
					query += $"[Имя] = '{textBox4.Text}', ";
					query += $"[Отчество] = '{textBox5.Text}', ";
					query += $"[Специальность] = '{textBox6.Text}'\n";

					query += $"WHERE [Табельный номер врача] = {_selectedRowCells[0].Value} AND ";
					query += $"[Номер лечебного учреждения] = {_selectedRowCells[1].Value} AND ";
					query += $"[Фамилия] = '{_selectedRowCells[2].Value}' AND ";
					query += $"[Имя] = '{_selectedRowCells[3].Value}' AND ";
					query += $"[Отчество] = '{_selectedRowCells[4].Value}' AND ";
					query += $"[Специальность] = '{_selectedRowCells[5].Value}'";
				}

				DBManager.connection.Open();
				var cmd = new OleDbCommand(query, DBManager.connection);
				cmd.ExecuteNonQuery();
				var msg = "Данные успешно " + (Form1.CurrentTableOpenMode == TableOpenMode.Add ? "добавлены!" : "обновлены!");
				MessageBox.Show(msg, "Успех!", MessageBoxButtons.OK,
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