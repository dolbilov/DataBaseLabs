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
	public partial class AppointmentsForm : Form
	{
		private const string TableName = "_Приемы";
		private static DataGridViewCellCollection _selectedRowCells;

		public AppointmentsForm(DataGridViewCellCollection cells)
		{
			_selectedRowCells = cells;
			InitializeComponent();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!InputValidator.ValidateInt(e))
				e.Handled = true;
		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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
					query += $"#{dateTimePicker1.Text}#, ";
					query += $"#{dateTimePicker2.Text}#, ";
					query += $"{textBox1.Text}, ";
					query += $"{textBox2.Text}, ";
					query += $"{textBox3.Text}, ";
					query += $"{textBox4.Text}, ";
					query += $"{textBox5.Text})";
				}
				else // change data of selected row
				{
					query = $"UPDATE {TableName} ";
					query += $"SET [Дата приема] = #{dateTimePicker1.Text}#, ";
					query += $"[Время приема] = #{dateTimePicker2.Text}#, ";
					query += $"[Номер кабинета] = {textBox1.Text}, ";
					query += $"[Табельный номер врача] = {textBox2.Text}, ";
					query += $"[Номер страхового полиса] = {textBox3.Text}, ";
					query += $"[Идентификатор диагноза] = {textBox4.Text}, ";
					query += $"[Номер процедуры] = {textBox5.Text}\n";

					query += $"WHERE [Дата приема] = #{_selectedRowCells[0].Value}# AND ";
					query += $"[Время приема] = #{_selectedRowCells[1].Value}# AND ";
					query += $"[Номер кабинета] = {_selectedRowCells[2].Value} AND ";
					query += $"[Табельный номер врача] = {_selectedRowCells[3].Value} AND ";
					query += $"[Номер страхового полиса] = {_selectedRowCells[4].Value} AND ";
					query += $"[Идентификатор диагноза] = {_selectedRowCells[5].Value} AND ";
					query += $"[Номер процедуры] = {_selectedRowCells[6].Value}";
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
