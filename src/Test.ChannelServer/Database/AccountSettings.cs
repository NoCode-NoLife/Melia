using Melia.Channel.Database;
using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Melia.Test.Channel.Database
{
	public class AccountSettingsTests
	{
		[Fact]
		public void Setting()
		{
			var settings = new AccountSettings();
			settings.Set(Option.ApplyBloom, 1);
			settings.Set(Option.JoypadVibration, 1);
			settings.Set(Option.UiMode, 2);

			Assert.Equal("23 1 46 1 43 2", settings.ToString());
		}

		[Fact]
		public void Parsing()
		{
			var settings = new AccountSettings("23 1 46 1 43 2");

			Assert.Equal("23 1 46 1 43 2", settings.ToString());
		}
	}
}
