using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Prakriti Buff
	/// which makes the character go back to original position after a while
	/// </summary>
	[BuffHandler(BuffId.OOBE_Prakriti_Buff)]
	public class OOBE_Prakriti_Buff : BuffHandler
	{
		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			if (caster.TryGetSkill((SkillId)buff.NumArg1, out var skill)) {
				var pad = new Pad(PadName.Sadhu_Prakriti_Pad, caster, skill, new Square(caster.Position, caster.Direction, 1, 1));
				pad.Position = caster.Position;
				pad.Trigger.LifeTime = TimeSpan.FromSeconds(1);

				caster.Map.AddPad(pad);
			}
			
			if (caster is Character casterCharacter)
			{
				Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Prakriti_Buff);
				var dummyCharacter = casterCharacter.Map.GetCharacter((int)buff.NumArg2);
				Send.ZC_LEAVE(dummyCharacter);
				casterCharacter.Map.RemoveCharacter(dummyCharacter);
			}
		}
	}
}
