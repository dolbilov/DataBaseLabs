using System;

namespace WinFormsApp1.Models
{
	class Appointment
	{
		public DateTime Datetime { get; set; }

		public int RoomNumber { get; set; }

		public int DoctorPersonalNum { get; set; }

		public int SSNNumber { get; set; }

		public int DiagnosisNumber { get; set; }

		public int ProcedureNumber { get; set; }
	}
}
