// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

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
				Log.Error("Error on startup: {0}", ex.Message);
				CliUtil.Exit(1, true);
			}
		}
	}
}
