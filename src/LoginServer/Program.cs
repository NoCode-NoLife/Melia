using System;
using Melia.Shared.Util;

namespace Melia.Login
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				LoginServer.Instance.Run();
			}
			catch (Exception ex)
			{
				Log.Error("Error on startup: {0}, {1}", ex.GetType().Name, ex.Message);
				CliUtil.Exit(1, true);
			}
		}
	}
}
