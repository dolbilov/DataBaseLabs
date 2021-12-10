using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace WinFormsApp1
{
	class DBManager
	{
		public const string provider = 
			@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=""D:\IT\Projects\DataBaseLabs\src\Lab7\WinFormsApp1\src\bd.accdb""";

		public static OleDbConnection connection = new OleDbConnection(provider);

		public static void Initialize()
		{
			connection.Open();
			var cmd = new OleDbCommand
			{
				Connection = connection,
				CommandText = "SELECT * FROM _Приемы"
			};

			OleDbDataReader rd = cmd.ExecuteReader();

			if (rd.HasRows)
			{
				while (rd.Read())
				{
					for (int i = 0; i < rd.FieldCount; i++)
					{
						Console.WriteLine(rd[i]);
					}
					Console.WriteLine("------------");
				}
			}

			connection.Close();

		}
	}
}
