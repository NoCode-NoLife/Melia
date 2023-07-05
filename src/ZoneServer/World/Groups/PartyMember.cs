using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Groups
{
	public class PartyMember
	{
		public long DbId { get; set; }
		public long ObjectId => ObjectIdRanges.Characters + this.DbId;
		public long AccountId { get; set; }
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

		public static PartyMember ToMember(Character character)
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
				IsOnline = true,
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

			}
			return member;
		}
	}
}
