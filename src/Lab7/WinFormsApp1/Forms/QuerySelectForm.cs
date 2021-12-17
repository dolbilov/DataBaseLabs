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
	public partial class QuerySelectForm : Form
	{
		public QuerySelectForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var needParameter = false;
			var needShowingResult = false;

			var selected = 0;
			
			if (radioButton1.Checked) // Добавить нового врача
			{
				selected = 1;
			}
			else if (radioButton2.Checked) // Применить скидку 10% к процедурам
			{
				selected = 2;
			}
			else if (radioButton3.Checked) // Удалить приемы из 4 кабинета
			{
				selected = 3;
			}
			else if (radioButton4.Checked) // Врачи, у которых есть приемы
			{
				needShowingResult = true;
				selected = 4;
			}
			else if (radioButton5.Checked) // Все врачи с введенной фамилией
			{
				needParameter = true;
				needShowingResult = true;
				selected = 5;
			}
			else if (radioButton6.Checked) // Все пациенты с введенной фамилией
			{
				needParameter = true;
				needShowingResult = true;
				selected = 6;
			}
			else if (radioButton7.Checked) // Все процедуры, дороже заданной цены
			{
				needParameter = true;
				needShowingResult = true;
				selected = 7;
			}
			else if (radioButton8.Checked) // Прием с самым поздним временем начала
			{
				needShowingResult = true;
				selected = 8;
			}
			else if (radioButton9.Checked) // Самый молодой пациент
			{
				needShowingResult = true;
				selected = 9;
			}

			try
			{
				var query = $"EXEC [{QueryManager.Queries[selected - 1]}] ";
				//var query = $"SELECT * FROM [{QueryManager.Queries[selected - 1]}]";

				if (needParameter)
				{
					var form = new ParameterAskForm();
					ParameterAskForm.IsIntInput = selected == 7;
					form.ShowDialog();

					if (selected == 7)
						query += $"{QueryManager.QueryParameter}";
					else
						query += $"'{QueryManager.QueryParameter}'";
				}

				DBManager.connection.Open();

				//TODO: delete this
				Console.WriteLine(query);
				if (needShowingResult)
				{
					var adapter = new OleDbDataAdapter(query, DBManager.connection);
					DataSet dataSet = new();
					adapter.Fill(dataSet);

					var form = new ShowResultForm(dataSet);
					form.ShowDialog();
				}
				else
				{
					var cmd = new OleDbCommand(query, DBManager.connection);
					cmd.ExecuteNonQuery();
					DBManager.connection.Close();
					Form1.GetInstance().UpdateTable();
					MessageBox.Show("Запрос выполнен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				DBManager.connection.Close();
			}
			
		}
	}
}
