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

		[Fact]
		public void InvalidOptionSet()
		{
			var settings = new AccountSettings();

			Assert.Throws<ArgumentException>(() => { settings.Set((Option)123456, 1); });
		}

		[Fact]
		public void InvalidOptionParse()
		{
			Assert.Throws<ArgumentException>(() => { var settings = new AccountSettings("12345 1 3 1 23 1"); });
		}

		[Fact]
		public void InvalidSettings()
		{
			Assert.Throws<ArgumentException>(() => { var settings = new AccountSettings("3 1 23"); });
		}
	}
}
