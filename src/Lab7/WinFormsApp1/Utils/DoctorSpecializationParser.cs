using System;
using WinFormsApp1.Models;

namespace WinFormsApp1.Utils
{
	public static class DoctorSpecializationParser
	{
		public static Specialization StringToEnum(string data)
		{
			if (data == null) throw new ArgumentNullException(nameof(data));
			return data switch
			{
				"Лаборант" => Specialization.Assistant,
				"Стоматолог" => Specialization.Dentist,
				"Врач общей практики" => Specialization.GeneralDoctor,
				"Невролог" => Specialization.Neurologist,
				"Мед. брат/сестра" => Specialization.Nurse,
				"Хирург" => Specialization.Surgeon,
				_ => throw new ArgumentException($"There is no {data} specialization")

			};
		}

		public static string EnumToString(Specialization specialization)
		{
			return specialization switch
			{
				Specialization.Assistant => "Лаборант",
				Specialization.Dentist => "Стоматолог",
				Specialization.GeneralDoctor => "Врач общей практики",
				Specialization.Neurologist => "Невролог",
				Specialization.Nurse => "Мед. брат/сестра",
				Specialization.Surgeon => "Хирург",
				_ => throw new ArgumentException($"{specialization} is not correct specialization")
			};
		}



	}
}