using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
	class Diagnosis
	{
		// Идентификатор
		public int DiagnosisNumber { get; set; }

		// Описание
		public string Description { get; set; }

		// Лечение
		public int Treatment { get; set; }
	}
}
