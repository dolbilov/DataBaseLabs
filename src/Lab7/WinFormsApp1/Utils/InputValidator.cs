using System.Windows.Forms;

namespace WinFormsApp1.Utils
{
	public static class InputValidator
	{
		public static bool ValidateInt(KeyPressEventArgs e)
		{
			var sym = e.KeyChar;
			return (char.IsDigit(sym) || sym == 8);
		}
	}
}