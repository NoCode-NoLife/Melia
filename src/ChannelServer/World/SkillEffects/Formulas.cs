using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Const;
using Melia.Shared.Util;

namespace Melia.Channel.World.SkillEffects
{
	class Formulas
	{
		public static int Heal40001(Skill skill, IEntity character, SkillEffect effect)
		{
			Random rnd = new Random();
			int randomNumber = rnd.Next(1, 3);
			float baseHeal = character.MaxHp * 0.05f;
			float extraHeal = ((50 + (((skill.level * effect.Data.Amount)  + 27) + character.statsManager.stats[(int)Stat.INT])) * 1.5f) * (1 + (randomNumber * 0.1f));

			return (int)(baseHeal + extraHeal);
			
		}

		public static int Cure40002(Skill skill, IEntity dealer, SkillEffect effect)
		{
			return (int) (skill.GetData().AttackAdd + dealer.statsManager.stats[(int)Stat.INT] * 1.2f);
		}

		public static int DeprotectedZone40004(Skill skill, IEntity dealer, SkillEffect effect)
		{
			return -(int)(effect.Data.Amount + dealer.statsManager.stats[(int)Stat.SPR]);
		}

		public static int INTAttack(int baseDamage, IEntity dealer)
		{
			return (int) (baseDamage + dealer.statsManager.stats[(int)Stat.INT]);
		}


		public static int PhisicalAttack(int baseDamage, IEntity dealer)
		{
			Random rnd = new Random();
			int patkDamage = rnd.Next((int) dealer.statsManager.stats[(int)Stat.MINPATK], (int) dealer.statsManager.stats[(int)Stat.MAXPATK]);
			return (int)(baseDamage + patkDamage);
		}
	}
}
