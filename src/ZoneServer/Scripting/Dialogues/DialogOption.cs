using System.Collections;
using System.Collections.Generic;
using Yggdrasil.Util;

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

	/// <summary>
	/// A mutable list of dialog options.
	/// </summary>
	public class DialogOptionList : IEnumerable<DialogOption>
	{
		private readonly List<DialogOption> _options = new List<DialogOption>();

		/// <summary>
		/// Creates a new list of options.
		/// </summary>
		/// <param name="options"></param>
		public DialogOptionList(params DialogOption[] options)
		{
			_options.AddRange(options);
		}

		/// <summary>
		/// Adds the option at the end of the list.
		/// </summary>
		/// <param name="option"></param>
		public void Add(DialogOption option)
			=> _options.Add(option);

		/// <summary>
		/// Inserts the given option at the given index.
		/// </summary>
		/// <remarks>
		/// If the index is negative, it will be treated as an index from
		/// the end of the list. The final index is clammed to the range
		/// of options, ensuring that the option is inserted at a valid
		/// index.
		/// </remarks>
		/// <param name="index"></param>
		/// <param name="option"></param>
		public void Insert(int index, DialogOption option)
		{
			if (index < 0)
				index = _options.Count + index;

			index = Math2.Clamp(0, _options.Count, index);

			_options.Insert(index, option);
		}

		/// <summary>
		/// Removes the option with the given key.
		/// </summary>
		/// <param name="optionKey"></param>
		public void Remove(string optionKey)
			=> _options.RemoveAll(a => a.Key == optionKey);

		/// <summary>
		/// Returns an enumerator that iterates through the options.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<DialogOption> GetEnumerator()
			=> _options.GetEnumerator();

		/// <summary>
		/// Returns an enumerator that iterates through the options.
		/// </summary>
		/// <returns></returns>
		IEnumerator IEnumerable.GetEnumerator()
			=> _options.GetEnumerator();
	}
}
