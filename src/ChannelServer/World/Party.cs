using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;

namespace Melia.Channel.World
{
	public class Party
	{
		/// <summary>
		/// The party's unique id.
		/// </summary>
		public long ObjectId { get; } = ChannelServer.Instance.World.CreatePartyObjectId();

		/// <summary>
		/// The party's owner.
		/// </summary>
		public Character Owner { get; }

		/// <summary>
		/// The party's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The party's creation date
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// List of party members
		/// </summary>
		public List<Character> Members { get; set; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="character"></param>
		public Party(Character character)
		{
			this.Owner = character;
			this.Name = "Party#" + ObjectId.ToString().Substring(ObjectId.ToString().Length - 4);
			this.DateCreated = DateTime.Now;
		}

		public void AddMember(Character character)
		{
			this.Members.Add(character);
			character.Party = this;
			Send.ZC_NORMAL_ShowParty(character);
			Send.ZC_PARTY_LIST(character, this);
			Send.ZC_PARTY_ENTER(character);
		}
	}
}
