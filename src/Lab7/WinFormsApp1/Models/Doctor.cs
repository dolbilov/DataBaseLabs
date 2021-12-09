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
	}
}
