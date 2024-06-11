using System.Threading.Tasks;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Scripting.Extensions.LivelyDialog
{
	public static class DialogExtensions
	{
		/// <summary>
		/// Shows an introductory message to the player that describes
		/// an NPC they're meeting for the first time.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static async Task Intro(this Dialog dialog, string text)
		{
			var varName = $"Ashen.Npcs.{dialog.Npc.UniqueName}.IntroSeen";
			var seenIntro = dialog.Player.Variables.Perm.GetBool(varName, false);

			if (seenIntro)
				return;

			var title = dialog.Title;
			var portrait = dialog.Portrait;

			dialog.SetTitle("Intro");
			dialog.SetPortrait(null);

			await dialog.Msg(text);

			dialog.SetTitle(title);
			dialog.SetPortrait(portrait);

			dialog.Player.Variables.Perm.SetBool(varName, true);
		}
	}
}
