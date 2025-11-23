using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Base Buff for sadhu's buffs
	/// </summary>
	public class Sadhu_BuffHandler_Base : BuffHandler, IBuffCombatAttackAfterCalcHandler
	{
		/// <summary>
		/// Remove the spirit clone character from the map.
		/// </summary>
		/// <param name="dummyCharacter"></param>
		protected void RemoveSpritCloneCharacter(DummyCharacter dummyCharacter)
		{
			Send.ZC_OWNER(dummyCharacter.Owner, dummyCharacter, 0);
			Send.ZC_LEAVE(dummyCharacter);

			dummyCharacter.Map.RemoveCharacter(dummyCharacter);
		}

		/// <summary>
		/// Makes the character returns to original position
		/// and also get ride of the dummy character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="dummyHandle"></param>
		protected void ReturnToBody(Character character, int dummyHandle)
		{
			var dummyCharacter = character.Map.GetCharacter(dummyHandle);

			if (dummyCharacter == null)
				return;

			character.Position = dummyCharacter.Position;
			character.Direction = dummyCharacter.Direction;

			dummyCharacter.Died -= this.OnDummyDied;

			Send.ZC_ROTATE(character);
			Send.ZC_SET_POS(character, dummyCharacter.Position);
			Send.ZC_OWNER(character, dummyCharacter, 0);
			Send.ZC_LEAVE(dummyCharacter);

			character.Map.RemoveCharacter(dummyCharacter);
		}

		/// <summary>
		/// Called when the clone dummy character dies.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="killer"></param>
		protected void OnDummyDied(ICombatEntity character, ICombatEntity killer)
		{
			if (character is DummyCharacter dummyCharacter)
				dummyCharacter.Owner.StopBuff(BuffId.OOBE_Anila_Buff);
			else if (character is Character ch)
				ch.StopBuff(BuffId.OOBE_Anila_Buff);
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// While in OOBE the character won't receive damage from any sources
			// besides Holy Damage (which will double) or if the attacker is Elite/Boss
			if (target is Character tagetCharacter && tagetCharacter.IsOutOfBody())
			{
				if (attacker.Rank != MonsterRank.Boss && (skill.Data.Attribute != AttributeType.Holy || !attacker.IsBuffActive(BuffId.EliteMonsterBuff)))
					skillHitResult.Damage = 0;
				else if (skill.Data.Attribute == AttributeType.Holy)
					skillHitResult.Damage = (int)(skillHitResult.Damage * 2);
			}
		}
	}
}
