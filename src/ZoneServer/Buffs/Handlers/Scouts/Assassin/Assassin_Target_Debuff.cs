using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for Assassin Target debuff, which can only
	/// be applied to a single target and needs to clean
	/// itself up when it ends
	/// </summary>
	[BuffHandler(BuffId.Assassin_Target_Debuff)]
	internal class Assassin_Target_Debuff : BuffHandler
	{
		/// <summary>
		/// Remove the variable from the caster when the buff ends,
		/// assuming this entity is still the target
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var targetHandle = buff.Target.Handle;
			var caster = buff.Caster;
			if (caster is Character character && character != null && character.Variables.Temp.TryGetInt("Melia.AssassinationTarget", out var assassinationTarget) && assassinationTarget == targetHandle)
				character.Variables.Temp.Remove("Melia.AssassinationTarget");
		}
	}
}
