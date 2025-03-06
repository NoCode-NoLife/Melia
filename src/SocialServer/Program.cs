﻿using System;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Social
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				SocialServer.Instance.Run(args);
			}
			catch (Exception ex)
			{
				Log.Error("While starting server: {0}", ex);
				ConsoleUtil.Exit(1);
			}
		}
	}
}
