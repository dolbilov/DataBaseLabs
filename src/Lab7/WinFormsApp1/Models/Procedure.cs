using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models
{
	class Procedure
	{
		// Номер процедуры
		public int ProcedureNumber { get; set; }

		// Название
		public string Name { get; set; }

		// Длительность
		public uint Duration { get; set; }

		// Цена
		public uint Price { get; set; }

		public static List<Procedure> instances = new();

		public Procedure(List<string> data)
		{
			if (data is null)
			{
				throw new ArgumentNullException(nameof(data));
			}

			if (data.Count != 4)
			{
				throw new ArgumentException("Length of array doesn't match the required");
			}

			ProcedureNumber = Convert.ToInt32(data[0]);
			Name = data[1];
			Duration = Convert.ToUInt32(data[2]);
			Price = Convert.ToUInt32(data[3]);

			instances.Add(this);

		}
	}
}
