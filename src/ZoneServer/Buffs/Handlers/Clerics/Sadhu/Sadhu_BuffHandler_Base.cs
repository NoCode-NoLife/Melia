using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Base Buff for sadhu's buffs
	/// </summary>
	public class Sadhu_BuffHandler_Base : BuffHandler
	{
		/// <summary>
		/// Remove the dummy character from the map
		/// </summary>
		/// <param name="character"></param>
		protected void RemoveDummyCharacter(DummyCharacter dummyCharacter)
		{
			Send.ZC_OWNER(dummyCharacter.Owner, dummyCharacter, 0);
			Send.ZC_LEAVE(dummyCharacter);

			dummyCharacter.Map.RemoveDummyCharacter(dummyCharacter);
		}

		/// <summary>
		/// Makes the chararacter returns to original position
		/// and also get ride of the dummy character
		/// </summary>
		/// <param name="character"></param>
		/// <param name="dummyHandle"></param>
		protected void ReturnToBody(Character character, int dummyHandle)
		{
			var dummyCharacter = character.Map.GetDummyCharacter(dummyHandle);

			if (dummyCharacter == null)
				return;

			character.Position = dummyCharacter.Position;
			character.Direction = dummyCharacter.Direction;

			dummyCharacter.Died -= this.OnDummyDied;

			Send.ZC_ROTATE(character);
			Send.ZC_SET_POS(character, dummyCharacter.Position);
			Send.ZC_OWNER(character, dummyCharacter, 0);
			Send.ZC_LEAVE(dummyCharacter);

			character.Map.RemoveDummyCharacter(dummyCharacter);
		}

		/// <summary>
		/// Called when the dummy character died
		/// disappeared.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="killer"></param>
		protected void OnDummyDied(Character character, ICombatEntity killer)
		{
			if (character is DummyCharacter dummyCharacter)
				dummyCharacter.Owner.StopBuff(BuffId.OOBE_Anila_Buff);
		}
	}
}
