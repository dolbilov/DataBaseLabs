using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WinFormsApp1.Utils
{
	public static class DBManager
	{
		private const string Provider =
			@"Provider=Microsoft.ACE.OLEDB.12.0;" +
			@"Data Source=""..\..\..\..\src\bd.accdb"";" +
			@"Persist Security Info = False;" +
			@"Jet OLEDB:Create System Database=true;" +
			@"Jet OLEDB:System database=C:\Users\dolbi\AppData\Roaming\Microsoft\Access\System.mdw";

		public static OleDbConnection connection = new(Provider);

		public static string IndexToTableName(int index)
		{
			return index switch
			{
				0 => "_Врачи",
				1 => "_Диагнозы",
				2 => "[_Лечебные учреждения]",
				3 => "_Пациенты",
				4 => "_Приемы",
				5 => "_Процедуры",
				_ => throw new ArgumentException("There in no that table")
			};
		}

		public static DataSet GetDataSet(int index)
		{
			var tableName = IndexToTableName(index);

			var query = "SELECT * FROM " + tableName;

			DataSet dataSet = new();
			try
			{
				connection.Open();
				var adapter = new OleDbDataAdapter(query, connection);
				adapter.Fill(dataSet);
				connection.Close();
				return dataSet;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally
			{
				connection.Close();
				
			}
		}
	}
}
