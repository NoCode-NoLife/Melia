using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Scripting;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Zhendu Buff, which increases the other wugushi skills final damage.
	/// </summary>
	[BuffHandler(BuffId.Zhendu_Buff)]
	public class Zhendu_Buff : BuffHandler
	{
		private const string varName = "Melia.dmgIncreasePercentage";

		// TODO: Find a way to increase only Wugushi skills
		public override void OnStart(Buff buff)
		{
			var dmgIncreasePercentage = 100 + this.GetDamagePercentageIncrease(buff);

			var caster = buff.Caster as Character;

			buff.Vars.SetFloat(varName, dmgIncreasePercentage);

			if (buff.Target.Properties.Has(PropertyName.SkillFactor))
			{
				buff.Target.Properties.Modify(PropertyName.SkillFactor, dmgIncreasePercentage);
			}
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(varName, out var bonus))
			{
				if (buff.Target.Properties.Has(PropertyName.SkillFactor))
				{
					buff.Target.Properties.Modify(PropertyName.SkillFactor, -bonus);
				}
			}				
		}

		// Unknow Purposes

		/*private float GetRatio(Buff buff)
		{
			return Convert.ToSingle((15 * buff.Target.Level) + (buff.Skill.Level * buff.Target.Level * 3.3));
		}

		private float GetRatio(Buff buff)
		{
			var minPAtk = buff.Target.Properties.GetFloat(PropertyName.MINPATK);
			var maxPAtk = buff.Target.Properties.GetFloat(PropertyName.MAXPATK);
			var value = Math.Floor(((minPAtk + maxPAtk) / 2) * 0.5);
			return Convert.ToSingle(value);
		}*/

		private float GetDamagePercentageIncrease(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return 5 + skillLevel * 2;
		}
	}
}
