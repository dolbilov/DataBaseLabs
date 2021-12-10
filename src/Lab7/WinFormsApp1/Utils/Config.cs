using System.Collections.Generic;

namespace WinFormsApp1.Utils
{
	public static class Config
	{
		public static readonly Dictionary<TableNames, string> StringTableNames = new()
		{
			[TableNames.Appointments] = "_Приемы",
			[TableNames.Diagnoses] = "_Диагнозы",
			[TableNames.Doctors] = "_Врачи",
			[TableNames.Hospitals] = "_Лечебные учреждения",
			[TableNames.Patients] = "_Пациенты",
			[TableNames.Procedures] = "_Процедуры"
		};
	}
}