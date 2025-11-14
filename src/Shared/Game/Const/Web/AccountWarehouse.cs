using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Game.Const.Web
{
	public class AccountWarehouse
	{
		public AccountWarehouse()
		{
			this.List = new List<List>
			{
				new List()
				{
					Index = "0",
					Title = "",
				},
				new List()
				{
					Index = "1",
					Title = "",
				},
				new List()
				{
					Index = "2",
					Title = "",
				},
				new List()
				{
					Index = "3",
					Title = "",
				}
			};
		}
		[JsonProperty("list")]
		public List<List> List { get; set; }
	}

	public class List
	{
		[JsonProperty("index")]
		public string Index { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}
}
