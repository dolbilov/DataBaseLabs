using System;

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



	}
}
