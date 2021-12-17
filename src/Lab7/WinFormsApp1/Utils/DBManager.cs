using System;
using System.Data;
using System.Data.OleDb;

namespace WinFormsApp1.Utils
{
	class DBManager
	{
		private const string Provider =
			@"Provider=Microsoft.ACE.OLEDB.12.0;" +
			@"Data Source=""..\..\..\..\src\bd.accdb""";

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

			connection.Open();

			var adapter = new OleDbDataAdapter(query, connection);
			DataSet dataSet = new();
			adapter.Fill(dataSet);
			
			connection.Close();

			return dataSet;
		}
	}
}
