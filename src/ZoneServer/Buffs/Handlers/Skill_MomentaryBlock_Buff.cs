using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Contains code related to the Momentary Block Buff
	/// </summary>
	/// <remarks>
	/// This buff is granted by certain skills and causes you to always
	/// block for a duration.  It also provides a method to determine
	/// if an attack was successfully blocked, as some skills have
	/// an extra effect if it was
	/// </remarks>
	[BuffHandler(BuffId.Skill_MomentaryBlock_Buff)]
	public class Skill_MomentaryBlock_Buff : BuffHandler
	{
		private const string VarName = "Melia.BlockedAttack";

		public override void OnStart(Buff buff)
		{
			buff.Vars.SetBool(VarName, false);
		}

		/// <summary>
		/// This is called when an attack is blocked, to set
		/// a variable we can check later
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public static void BlockedAnAttack(Buff buff)
		{
			buff.Vars.SetBool(VarName, true);
		}


		/// <summary>
		/// This is called to see if an attack was blocked
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public static bool WasAttackBlocked(Buff buff)
		{
			if (buff.Vars.TryGetBool(VarName, out var value)) 
			{
				return value;
			}

			return false;
		}
	}
}
