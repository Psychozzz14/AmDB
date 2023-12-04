using Microsoft.Data.Sqlite;

namespace AmDB
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new MainApp());
		}
	}
}