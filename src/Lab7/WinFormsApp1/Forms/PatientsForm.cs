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
using WinFormsApp1.Utils.Enums;

namespace WinFormsApp1.Forms
{
	public partial class PatientsForm : Form
	{
		private const string TableName = "_Пациенты";
		private static DataGridViewCellCollection _selectedRowCells;

		public PatientsForm(DataGridViewCellCollection cells)
		{
			_selectedRowCells = cells;
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text) ||
			    string.IsNullOrEmpty(textBox2.Text) ||
			    string.IsNullOrEmpty(textBox3.Text) ||
			    string.IsNullOrEmpty(textBox4.Text) ||
			    string.IsNullOrEmpty(textBox5.Text))
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
					query += $"'{textBox3.Text}', ";
					query += $"'{textBox4.Text}', ";
					query += $"#{dateTimePicker1.Text}#, ";
					query += $"'{textBox5.Text}')";
				}
				else // change data of selected row
				{
					query = $"UPDATE {TableName} ";
					query += $"SET [Номер страхового полиса] = {textBox1.Text}, ";
					query += $"[Фамилия] = '{textBox2.Text}', ";
					query += $"[Имя] = '{textBox3.Text}', ";
					query += $"[Отчество] = '{textBox4.Text}', ";
					query += $"[Дата рождения] = #{dateTimePicker1.Text}#, ";
					query += $"[Адрес] = '{textBox5.Text}'\n";

					query += $"WHERE [Номер страхового полиса] = {_selectedRowCells[0].Value} AND ";
					query += $"[Фамилия] = '{_selectedRowCells[1].Value}' AND ";
					query += $"[Имя] = '{_selectedRowCells[2].Value}' AND ";
					query += $"[Отчество] = '{_selectedRowCells[3].Value}' AND ";
					query += $"[Адрес] = '{_selectedRowCells[5].Value}'";
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
