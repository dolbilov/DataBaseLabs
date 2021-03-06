using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Utils;
using WinFormsApp1.Utils.Enums;

namespace WinFormsApp1.Forms
{
	public partial class Form1 : Form
	{
		private const string provider =
			@"Provider=Microsoft.ACE.OLEDB.12.0;" +
			@"Data Source=""..\..\..\..\src\bd.accdb""";

		public static OleDbConnection connection = new(provider);

		private static bool _isChoose = false;

		private static Form1 _instance = null;

		public static TableOpenMode CurrentTableOpenMode = TableOpenMode.Add;

		public Form1()
		{
			_instance = this;
			InitializeComponent();
		}

		public static Form1 GetInstance()
		{
			return _instance;
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
			CurrentTableOpenMode = TableOpenMode.Add;
			AddOrEditTable();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_isChoose)
			{
				menuStrip1.Items.Find("actionsToolStripMenuItem", false)[0].Enabled = true;
				_isChoose = true;
			}

			var comboBox = sender as ComboBox;

			if (comboBox == null)
				throw new ArgumentNullException(nameof(comboBox));

			var index = comboBox.SelectedIndex;

			var dataSet = DBManager.GetDataSet(index);

			if (dataSet == null)
			{
				MessageBox.Show("Проблемы с чтением данных из файла БД :(", "Ошибка!", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			mainDataGrid.DataSource = dataSet.Tables[0];


			// Disable sorting for columns
			for (var i = 0; i < mainDataGrid.ColumnCount; i++)
			{
				mainDataGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}


			// if selected table is "_Приемы"
			if (comboBox1.SelectedIndex == 4)
			{
				mainDataGrid.Columns[1].DefaultCellStyle.Format = "h:mm tt";
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
				UpdateTable();

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

		public void UpdateTable()
		{
			var dataSet = DBManager.GetDataSet(comboBox1.SelectedIndex);

			mainDataGrid.DataSource = dataSet.Tables[0];
		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentTableOpenMode = TableOpenMode.Edit;
			AddOrEditTable();
		}

		private void AddOrEditTable()
		{
			var cells = mainDataGrid.SelectedRows[0].Cells;


			switch (comboBox1.SelectedIndex)
			{
				// Врачи
				case 0:
					var form = new DoctorsForm(cells);
					if (CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form.mainLabel.Text = "Изменить значения";
						form.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form.textBox1.Text = cells[0].Value.ToString();
						form.textBox2.Text = cells[1].Value.ToString();
						form.textBox3.Text = cells[2].Value.ToString();
						form.textBox4.Text = cells[3].Value.ToString();
						form.textBox5.Text = cells[4].Value.ToString();
						form.textBox6.Text = cells[5].Value.ToString();
					}
					
					form.ShowDialog(this);
					break;

				// Диагнозы
				case 1:
					var form1 = new DiagnosisForm(cells);
					if (CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form1.mainLabel.Text = "Изменить значения";
						form1.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form1.textBox1.Text = cells[0].Value.ToString();
						form1.textBox2.Text = cells[1].Value.ToString();
						form1.textBox3.Text = cells[2].Value.ToString();
					}

					form1.ShowDialog(this);
					break;

				// Лечебные учреждения
				case 2:
					var form2 = new HospitalsForm(cells);
					if (CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form2.mainLabel.Text = "Изменить значения";
						form2.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form2.textBox1.Text = cells[0].Value.ToString();
						form2.textBox2.Text = cells[1].Value.ToString();
						form2.textBox3.Text = cells[2].Value.ToString();
						form2.textBox4.Text = cells[3].Value.ToString();
					}

					form2.ShowDialog(this);
					break;

				// Пациенты
				case 3:
					var form3 = new PatientsForm(cells);
					if (CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form3.mainLabel.Text = "Изменить значения";
						form3.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form3.textBox1.Text = cells[0].Value.ToString();
						form3.textBox2.Text = cells[1].Value.ToString();
						form3.textBox3.Text = cells[2].Value.ToString();
						form3.textBox4.Text = cells[3].Value.ToString();
						form3.dateTimePicker1.Text = cells[4].Value.ToString();
						form3.textBox5.Text = cells[5].Value.ToString();
					}

					form3.ShowDialog(this);
					break;

				// Приемы
				case 4:
					var form4 = new AppointmentsForm(cells);
					if (Form1.CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form4.mainLabel.Text = "Изменить значения";
						form4.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form4.dateTimePicker1.Text = cells[0].Value.ToString();
						form4.dateTimePicker2.Text = cells[1].Value.ToString();
						form4.textBox1.Text = cells[2].Value.ToString();
						form4.textBox2.Text = cells[3].Value.ToString();
						form4.textBox3.Text = cells[4].Value.ToString();
						form4.textBox4.Text = cells[5].Value.ToString();
						form4.textBox5.Text = cells[6].Value.ToString();
					}

					form4.ShowDialog(this);
					break;

				// Процедуры
				case 5:
					var form5 = new ProceduresForm(cells);
					if (CurrentTableOpenMode == TableOpenMode.Edit)
					{
						form5.mainLabel.Text = "Изменить значения";
						form5.button1.Text = "Сохранить изменения";

						//insert values into textboxes
						form5.textBox1.Text = cells[0].Value.ToString();
						form5.textBox2.Text = cells[1].Value.ToString();
						form5.textBox3.Text = cells[2].Value.ToString();
						form5.textBox4.Text = cells[3].Value.ToString();
					}

					form5.ShowDialog(this);
					break;
			}

			UpdateTable();
		}

		private void queryStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new QuerySelectForm();
			form.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			const string query = "SELECT * FROM MSysObjects";
			try
			{
				DBManager.connection.Open();
				var adapter = new OleDbDataAdapter(query, connection);
				DataSet dataSet = new();
				adapter.Fill(dataSet);
				var form = new ShowResultForm(dataSet);
				form.ShowDialog();
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
