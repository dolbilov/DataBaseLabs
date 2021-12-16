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

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public const string provider =
			@"Provider=Microsoft.ACE.OLEDB.12.0;" +
			@"Data Source=""..\..\..\..\src\bd.accdb""";

		public static OleDbConnection connection = new(provider);

		private static bool isChoose = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new();
			sb.Append($"Author: {Config.ProgramAuthor}\n");
			sb.Append($"Version: {Config.ProgramVersion}\n");
			sb.Append($"{Config.AdditionalInfo}\n");
			
			
			MessageBox.Show(sb.ToString(), "DataBaseBrowser");
		}


		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//TODO: create new form
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isChoose)
			{
				menuStrip1.Items.Find("actionsToolStripMenuItem", false)[0].Enabled = true;
				isChoose = true;
			}
			
			var comboBox = sender as ComboBox;

			if (comboBox == null)
				throw new ArgumentNullException(nameof(comboBox));

			var index = comboBox.SelectedIndex;

			var dataSet = DBManager.GetDataSet(index);
			
			mainDataGrid.DataSource = dataSet.Tables[0];

			
			// Disable sorting for columns
			for (var i = 0; i < mainDataGrid.ColumnCount; i++)
			{
				mainDataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var query = "DELETE FROM ";

				var cells = mainDataGrid.SelectedRows[0].Cells;

				switch (comboBox1.SelectedIndex)
				{
					// врачи
					case 0:
						query += "_Врачи WHERE";
						query += $"[Табельный номер врача] = {cells[0].Value} AND ";
						query += $"[Номер лечебного учреждения] = {cells[1].Value} AND ";
						query += $"[Фамилия] = '{cells[2].Value}' AND ";
						query += $"[Имя] = '{cells[3].Value}' AND ";
						query += $"[Отчество] = '{cells[4].Value}' AND ";
						query += $"[Специальность] = '{cells[5].Value}'";
						break;

					// диагнозы
					case 1:
						query += "_Диагнозы WHERE";
						query += $"[Идентификатор] = {cells[0].Value} AND ";
						query += $"[Описание диагноза] = '{cells[1].Value}' AND ";
						query += $"[Лечение] = {cells[2].Value}";
						break;

					// лечебные учреждения
					case 2:
						query += "[_Лечебные учреждения] WHERE ";
						query += $"[Тип лечебного учреждения] = '{cells[0].Value}' AND ";
						query += $"[Номер лечебного учреждения] = {cells[1].Value} AND ";
						query += $"[Специализация лечебного учреждения] = '{cells[2].Value}' AND ";
						query += $"[Адрес] = '{cells[3].Value}'";
						break;

					// пациенты
					case 3:
						query += "_Пациенты WHERE ";
						query += $"[Номер страхового полиса] = {cells[0].Value} AND ";
						query += $"[Фамилия] = '{cells[1].Value}' AND ";
						query += $"[Имя] = '{cells[2].Value}' AND ";
						query += $"[Отчество] = '{cells[3].Value}' AND ";
						query += $"[Дата рождения] = #{cells[4].Value}# AND ";
						query += $"[Адрес] = '{cells[5].Value}'";
						break;

					// приемы
					case 4:
						query += "_Приемы WHERE ";

						var tempDate = DateTime.Parse(cells[0].Value.ToString());
						var tempTime = DateTime.Parse(cells[1].Value.ToString());

						var stringTempDate = tempDate.ToString("M/d/yyyy");
						var stringTempTime = tempTime.ToString("h:mm tt");


						query += $"[Дата приема] = #{stringTempDate}# AND ";
						query += $"[Время приема] = #{stringTempTime}# AND ";
						query += $"[Номер кабинета] = {cells[2].Value} AND ";
						query += $"[Табельный номер врача] = {cells[3].Value} AND ";
						query += $"[Номер страхового полиса] = {cells[4].Value} AND ";
						query += $"[Идентификатор диагноза] = {cells[5].Value} AND ";
						query += $"[Номер процедуры] = {cells[6].Value}";
						break;

					// процедуры
					case 5:
						query += "_Процедуры WHERE ";
						query += $"[Номер процедуры] = {cells[0].Value} AND ";
						query += $"[Название] = '{cells[1].Value}' AND ";
						query += $"[Длительность] = {cells[2].Value} AND ";
						query += $"[Цена] = {cells[3].Value}";
						break;
				}

				DBManager.connection.Open();
				var cmd = new OleDbCommand(query, DBManager.connection);
				cmd.ExecuteNonQuery();
				DBManager.connection.Close();
				mainDataGrid.DataSource = DBManager.GetDataSet(comboBox1.SelectedIndex).Tables[0];

			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				DBManager.connection.Close();
			}
		}
	}
}
