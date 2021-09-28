using System;
using Melia.Shared.Util;

namespace Melia.Channel
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ChannelServer.Instance.Run();
			}
			catch (Exception ex)
			{
				Log.Error("Error on startup: {0}", ex);
				CliUtil.Exit(1, true);
			}
		}
	}
}
