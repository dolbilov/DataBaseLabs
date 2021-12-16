using System;
using System.Collections.Generic;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Models
{
	class Doctor
	{
		// Табельный номер врача
		public int DoctorPersonalNum { get; set; }

		// Номер лечебного учреждения
		public int HospitalNumber { get; set; }

		// Фамилия
		public string LastName { get; set; }

		// Имя
		public string FirstName { get; set; }

		// Отчество
		public string Patronymic { get; set; }

		// Специализация
		public Specialization DoctorSpecialization { get; set; }

		public static List<Doctor> instances = new();

		public Doctor(List<string> data)
		{
			
			if (data == null) throw new ArgumentNullException(nameof(data));

			if (data.Count != 6) throw new ArgumentException("Length of array doesn't match the required");

			DoctorPersonalNum = Convert.ToInt32(data[0]);

			HospitalNumber = Convert.ToInt32(data[1]);

			LastName = data[2];

			FirstName = data[3];

			Patronymic = data[4];

			DoctorSpecialization = DoctorSpecializationParser.StringToEnum(data[5]);

			instances.Add(this);
		}
	}
}
