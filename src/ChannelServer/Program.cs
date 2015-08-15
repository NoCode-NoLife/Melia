using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
				Log.Error("Error on startup: {0}, {1}", ex.GetType().Name, ex.Message);
				Cmd.Exit(1, true);
			}
		}
	}
}
