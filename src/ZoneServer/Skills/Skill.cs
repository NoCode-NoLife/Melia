using System;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills
{
	public class Skill : IPropertyObject
	{
		/// <summary>
		/// The skill's unique id.
		/// </summary>
		/// <remarks>
		/// We're basically assigning a new object id to every skill here,
		/// every time it's loaded. That *might* work, but we have to be
		/// careful. If there's a single case where the skill id needs to
		/// persist, we have to seriously rethink our approach to object
		/// ids, and potentially create a global pool on the database or
		/// something.
		/// </remarks>
		public long ObjectId { get; } = ZoneServer.Instance.World.CreateSkillObjectId();

		/// <summary>
		/// Returns reference to the skill's properties.
		/// </summary>
		public SkillProperties Properties { get; }

		/// <summary>
		/// Returns reference to the skill's properties.
		/// </summary>
		Properties IPropertyHolder.Properties => this.Properties;

		/// <summary>
		/// Returns reference to the skill's owner.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns the skill's class id.
		/// </summary>
		public SkillId Id { get; }

		/// <summary>
		/// Gets or sets skill's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Returns the amount of SP necessary to use the skill.
		/// </summary>
		public int SpendSp
			=> (int)this.Properties.GetFloat(PropertyName.SpendSP);

		/// <summary>
		/// Returns the skill's overheat count. If this value reaches the
		/// skill's maximum overheat, the skill goes on a cooldown.
		/// </summary>
		public int OverheatCounter { get; private set; }

		/// <summary>
		/// Returns reference to the skill's data from the file database.
		/// </summary>
		public SkillData Data { get; }

		/// <summary>
		/// Returns reference to the skill's cooldow ndata from the file
		/// database.
		/// </summary>
		public CooldownData CooldownData { get; }

		/// <summary>
		/// Returns reference to the skill's overheat data from the file
		/// database.
		/// </summary>
		public CooldownData OverheatData { get; }

		/// <summary>
		/// Returns whether this skill can overheat.
		/// </summary>
		public bool CanOverheat => this.Data.Overheat > 0;

		/// <summary>
		/// Returns whether the skill is currently overheated.
		/// </summary>
		public bool IsOverheated => this.CanOverheat && this.OverheatCounter >= this.Data.Overheat;

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		/// <param name="level"></param>
		public Skill(Character character, SkillId skillId, int level)
		{
			this.Character = character;
			this.Id = skillId;
			this.Level = level;

			this.Data = ZoneServer.Instance.Data.SkillDb.Find(skillId) ?? throw new ArgumentException($"Unknown skill '{skillId}'.");
			this.CooldownData = ZoneServer.Instance.Data.CooldownDb.Find(this.Data.CooldownGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' cooldown group '{this.Data.CooldownGroup}'.");
			this.OverheatData = ZoneServer.Instance.Data.CooldownDb.Find(this.Data.OverheatGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' overheat group '{this.Data.OverheatGroup}'.");

			this.Properties = new SkillProperties(this);
		}

		/// <summary>
		/// Increases skill's overheat counter by 1 if the skill can
		/// overheat and updates the client.
		/// </summary>
		public void IncreaseOverheat()
		{
			if (this.CanOverheat)
				this.OverheatCounter++;

			// TODO: Are these packets necessary even if the skill
			//   can't overheat?

			Send.ZC_OVERHEAT_CHANGED(this.Character, this);

			// TODO: Apply overheat cooldown
			if (this.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(this.Character, this);
				this.OverheatCounter = 0;
			}
		}

		/// <summary>
		/// Generates a splash area based on the given arguments and the
		/// skill's data.
		/// </summary>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		/// <returns></returns>
		public ISplashArea GetSplashArea(Position originPos, Direction dir)
		{
			var skill = this;
			ISplashArea splashArea;

			switch (this.Data.SplashType)
			{
				default:
				case SplashType.Square:
				{
					// These sizes are currently guessed and should
					// probably also use calculation functions
					var height = skill.Data.SplashHeight;
					var width = skill.Data.SplashRange;

					splashArea = new Square(originPos, dir, height, width);
					break;
				}
				case SplashType.Circle:
				{
					var radius = skill.Data.SplashHeight;

					splashArea = new Circle(originPos, radius);
					break;
				}
				case SplashType.Fan:
				{
					var height = skill.Data.SplashHeight;
					var angle = skill.Data.SplashAngle;

					splashArea = new Fan(originPos, dir, height, angle);
					break;
				}
			}

			return splashArea;
		}
	}
}
