using System;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Groups
{
	public class PartyMember
	{
		public Character Character { get; set; }
		public long CharacterDbId { get; set; }
		public long CharacterObjectId => ObjectIdRanges.Characters + this.CharacterDbId;
		public long AccountId { get; set; }
		public string TeamName { get; set; }
		public string Name { get; set; }
		public bool IsOnline { get; private set; } = false;
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

		/// <summary>
		/// Transform a Character to a PartyMember
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public static PartyMember ToMember(Character character)
		{
			var member = new PartyMember()
			{
				Character = character,
				CharacterDbId = character.DbId,
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
				IsOnline = character.Connection != null,
			};

			var i = 0;
			var jobs = character.Jobs.GetList();
			var lastJob = jobs[jobs.Length - 1].Id;
			member.VisualJobId = lastJob;
			member.FirstJobId = lastJob;

			foreach (var job in jobs)
			{				
				switch (i)
				{
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

		/// <summary>
		/// Updates the member information
		/// </summary>
		/// <param name="character"></param>
		public void UpdateValues(Character character)
		{
			this.CharacterDbId = character.DbId;
			this.AccountId = character.AccountId;
			this.Gender = character.Gender;
			this.Hair = character.Hair;
			this.Handle = character.Handle;
			this.Hp = character.Hp;
			this.JobLevel = character.Job?.Level ?? 1001;
			this.Sp = character.Sp;
			this.Level = character.Level;
			this.MapId = character.MapId;
			this.TeamName = character.TeamName;
			this.MaxHp = character.MaxHp;
			this.MaxSp = character.MaxSp;
			this.Name = character.Name;
			this.Position = character.Position;
			this.Stance = character.Stance;
			this.UpdateOnlineStatus(character.Connection != null);
		}

		/// <summary>
		/// Updates the IsOnline
		/// </summary>
		/// <param name="value"></param>
		public void UpdateOnlineStatus(bool value)
		{
			this.IsOnline = value;
		}
	}
}
