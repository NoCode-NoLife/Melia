using System;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Barracks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				BarracksServer.Instance.Run(args);
			}
			catch (Exception ex)
			{
				Log.Error("While starting server: {0}", ex);
				ConsoleUtil.Exit(1);
			}
		}
	}
}
