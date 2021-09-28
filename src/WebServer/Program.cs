using System;
using Melia.Shared.Util;

namespace Melia.Web
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				WebServer.Instance.Run();
			}
			catch (Exception ex)
			{
				Log.Error("Error on startup: {0}", ex);
				CliUtil.Exit(1, true);
			}
		}
	}
}
