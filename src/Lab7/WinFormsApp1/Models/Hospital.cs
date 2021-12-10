using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models
{
	class Hospital
	{
		// Тип лечебного учреждения
		public string Type { get; set; }

		// Номер лечебного учреждения
		public int Number { get; set; }

		// Специализация лечебного учреждения
		public string Specialization { get; set; }

		// Адрес
		public string Address { get; set; }

		public static List<Hospital> instances = new();

		public Hospital(List<string> data)
		{
			if (data == null) throw new ArgumentNullException(nameof(data));

			if (data.Count != 4) throw new ArgumentException("Length of array doesn't match the required");

			Type = data[0];
			Number = Convert.ToInt32(data[1]);
			Specialization = data[2];
			Address = data[3];

			instances.Add(this);
		}
	}
}
