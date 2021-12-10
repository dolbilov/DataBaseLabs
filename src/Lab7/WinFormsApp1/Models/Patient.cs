using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models
{
	class Patient
	{
		// Номер страхового полиса
		public int SSNNumber { get; set; }

		// Фамилия
		public string LastName { get; set; }

		// Имя
		public string FirstName { get; set; }

		// Отчество
		public string Patronymic { get; set; }

		// Дата рождения
		public DateTime Birthday { get; set; }

		// Адрес
		public string Address { get; set; }

		public static List<Patient> Instances = new();

		public Patient(List<string> data)
		{
			if (data is null)
			{
				throw new ArgumentNullException(nameof(data));
			}

			if (data.Count != 6)
			{
				throw new ArgumentException("Length of array doesn't match the required");
			}

			SSNNumber = Convert.ToInt32(data[0]);

			LastName = data[1];

			FirstName = data[2];

			Patronymic = data[3];

			Birthday = DateTime.Parse(data[4]);

			Address = data[5];



		}



	}
}
