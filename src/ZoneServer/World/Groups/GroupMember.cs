using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Groups
{
	public abstract class GroupMember : IMember
	{
		public long DbId { get; set; }
		public long ObjectId => this.DbId | ObjectIdRanges.Characters;
		public long AccountId { get; set; }
		public long AccountObjectId => this.AccountId | ObjectIdRanges.Account;
		public string TeamName { get; set; }
		public string Name { get; set; }
		public bool IsOnline { get; set; } = false;
		public int Handle { get; set; }
		public int MapId { get; set; }
		public int Stance { get; set; }
		public Gender Gender { get; set; }
		public int Level { get; set; } = 1;
		public int Hair { get; set; }
		public Position Position { get; set; }
		public int Hp { get; set; }
		public int MaxHp { get; set; }
		public int Sp { get; set; }
		public int MaxSp { get; set; }
		public JobId FirstJobId { get; set; }
		public JobId SecondJobId { get; set; }
		public JobId ThirdJobId { get; set; }
		public JobId FourthJobId { get; set; }
		public JobId VisualJobId { get; set; }
		public int JobLevel { get; set; }
		public int ServerGroup { get; set; } = 1001;

		public Properties Properties { get; }
		public short Channel { get; set; }

		public static PartyMember ToPartyMember(Character character)
		{
			var member = new PartyMember()
			{
				DbId = character.DbId,
				AccountId = character.AccountId,
				Gender = character.Gender,
				Hair = character.Hair,
				Handle = character.Handle,
				Hp = character.Hp,
				JobLevel = character.Job?.Level ?? 1001,
				Sp = character.Sp,
				Level = character.Level,
				MapId = character.MapId,
				TeamName = character.TeamName,
				MaxHp = character.MaxHp,
				MaxSp = character.MaxSp,
				Name = character.Name,
				Position = character.Position,
				Stance = character.Stance,
				IsOnline = character.Connection?.LoggedIn ?? false,
			};
			var i = 0;
			foreach (var job in character.Jobs.GetList())
			{
				member.VisualJobId = job.Id;
				switch (i)
				{
					case 0:
						member.FirstJobId = job.Id;
						break;
					case 1:
						member.SecondJobId = job.Id;
						break;
					case 2:
						member.ThirdJobId = job.Id;
						break;
					case 3:
						member.FourthJobId = job.Id;
						break;
				}
				i++;
			}
			return member;
		}
	}

	public class PartyMember : GroupMember
	{
		public new Properties Properties { get; set; } = new Properties("PartyMember");
	}

	public interface IMember : IPropertyHolder
	{
		public long DbId { get; set; }
		public long ObjectId { get; }
		public long AccountId { get; set; }
		public long AccountObjectId { get; }
		public string TeamName { get; set; }
		public string Name { get; set; }
		public bool IsOnline { get; set; }
		public int Handle { get; set; }
		public int MapId { get; set; }
		public int Stance { get; set; }
		public Gender Gender { get; set; }
		public int Level { get; set; }
		public int Hair { get; set; }
		public Position Position { get; set; }
		public int Hp { get; set; }
		public int MaxHp { get; set; }
		public int Sp { get; set; }
		public int MaxSp { get; set; }
		public JobId FirstJobId { get; set; }
		public JobId SecondJobId { get; set; }
		public JobId ThirdJobId { get; set; }
		public JobId FourthJobId { get; set; }
		public JobId VisualJobId { get; set; }
		public int JobLevel { get; set; }
		public int ServerGroup { get; set; }
		public short Channel { get; set; }
	}
}
