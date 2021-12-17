using System.Collections.Generic;

namespace WinFormsApp1.Utils
{
	public static class QueryManager
	{
		public static string QueryParameter;

		public static readonly List<string> Queries = new()
		{
			"Добавить нового врача",
			"Обновление: применить скидку 10% ко всем процедурам",
			"Удаление приемов из 4 кабинета",
			"Врачи, у которых есть хотя бы 1 прием",
			"Параметр: все врачи с заданной фамилией",
			"Параметр: все пациенты с заданной фамилией",
			"Параметр: все процедуры, дороже введеной цены",
			"Прием с самым поздним временем начала",
			"Самый молодой пациент"
		};
	}
}