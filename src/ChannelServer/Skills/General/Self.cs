using System.Collections.Generic;
using Melia.Channel.Skills.Base;
using Melia.Channel.Skills.Cleric;
using Melia.Channel.Skills.Swordsman;
using Melia.Channel.Skills.Wizard;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.World;
using GungHo = Melia.Channel.Skills.Swordsman.GungHo;

namespace Melia.Channel.Skills.General
{
	public class SelfSkillHanler : ISelfSkillHandler
	{
		//TODO :: WIZARD Class
		private MagicShield MagicShield = new MagicShield();
		private QuickCast QuickCast = new QuickCast();
		private Sleep Sleep = new Sleep();
		private Surespell Surespell = new Surespell();
		//TODO :: SWORDSMAN Class
		private GungHo GungHo = new GungHo();
		private PainBarrier PainBarrier = new PainBarrier();
		private Restrain Restrain = new Restrain();
		private Concentrate Concentrate = new Concentrate();
		//TODO :: ClERIC Class
		private Fade Fade = new Fade();
		private GuardianSaint GuardianSaint = new GuardianSaint();
		private Heal Heal = new Heal();
		
		
		public void Handle(Skill skill, Character caster, Position castPosition)
		{
			//TODO :: this. for simple test maybe need move to read from orther file
			switch (skill.Id)
			{
				// TODO :: WIZARD Class
				case SkillId.Wizard_ReflectShield:
					this.MagicShield.Handle(skill,caster,castPosition);
					break;
				case SkillId.Wizard_Lethargy: // TODO :: THIS DEBUFF Maybe change to orther class
					MagicShield.Handle(skill,caster,castPosition);
					break;
				case SkillId.Wizard_Sleep: // TODO :: THIS DEBUFF Maybe change to orther class
					this.Sleep.Handle(skill,caster,castPosition);
					break;
				case SkillId.Wizard_Teleportation:
					this.QuickCast.Handle(skill,caster,castPosition);
					break;
				case SkillId.Wizard_Surespell:
					this.Surespell.Handle(skill,caster,castPosition);
					break;
				// TODO :: SWORDSMAN Class
				case SkillId.Swordman_Concentrate:
					this.Concentrate.Handle(skill,caster,castPosition);
					break;
				case SkillId.Swordman_GungHo:
					this.GungHo.Handle(skill,caster,castPosition);
					break;
				case SkillId.Swordman_PainBarrier:
					this.PainBarrier.Handle(skill,caster,castPosition);
					break;
				case SkillId.Swordman_Restrain:
					this.Restrain.Handle(skill,caster,castPosition);
					break;
				// TODO :: Cleric class
				case SkillId.Cleric_Fade:
					this.Fade.Handle(skill,caster,castPosition);
					break;
				case SkillId.Cleric_PatronSaint:
					this.GuardianSaint.Handle(skill,caster,castPosition);
					break;
				case SkillId.Cleric_Heal:
					this.Heal.Handle(skill,caster,castPosition);
					break;
				default:
					break;
			}
		}
	}
	
}
