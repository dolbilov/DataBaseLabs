using System;
using System.Data.OleDb;
using System.Windows.Forms;
using WinFormsApp1.Utils;
using WinFormsApp1.Utils.Enums;

namespace WinFormsApp1.Forms
{
	public partial class DiagnosisForm : Form
	{
		private const string TableName = "_Диагнозы";
		private static DataGridViewCellCollection _selectedRowCells;

		public DiagnosisForm(DataGridViewCellCollection cells)
		{
			_selectedRowCells = cells;
			InitializeComponent();
		}

		// идентификатор
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		// лечение
		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// check if all fields are filled
			if (string.IsNullOrEmpty(textBox1.Text) ||
			    string.IsNullOrEmpty(textBox2.Text) ||
			    string.IsNullOrEmpty(textBox3.Text))
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
					query += $"'{textBox2.Text}', ";
					query += $"{textBox3.Text})";
				}
				else // change data of selected row
				{
					query = $"UPDATE {TableName} ";
					query += $"SET [Идентификатор] = {textBox1.Text}, ";
					query += $"[Описание диагноза] = '{textBox2.Text}', ";
					query += $"[Лечение] = {textBox3.Text}\n";

					query += $"WHERE [Идентификатор] = {_selectedRowCells[0].Value} AND ";
					query += $"[Описание диагноза] = '{_selectedRowCells[1].Value}' AND ";
					query += $"[Лечение] = {_selectedRowCells[2].Value}";
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
