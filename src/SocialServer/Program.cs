// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Melia.Social
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				SocialServer.Instance.Run();
			}
			catch (Exception ex)
			{
				Log.Error("Error on startup: {0}, {1}", ex.GetType().Name, ex.Message);
				Cmd.Exit(1, true);
			}
		}
	}
}
