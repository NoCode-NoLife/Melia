namespace Melia.Zone.Scripting.Dialogues
{
	/// <summary>
	/// Represents an option in a dialog's menu.
	/// </summary>
	public class DialogOption
	{
		/// <summary>
		/// Gets or sets the text displayed in the menu.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Gets or sets the key that is returned when this option
		/// is selected by the player.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="text"></param>
		/// <param name="key"></param>
		public DialogOption(string text, string key)
		{
			this.Text = text;
			this.Key = key;
		}
	}
}
