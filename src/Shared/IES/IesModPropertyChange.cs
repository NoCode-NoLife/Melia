using System;

namespace Melia.Shared.IES
{
	/// <summary>
	/// Information about a change to a property.
	/// </summary>
	public class IesModPropertyChange
	{
		/// <summary>
		/// Returns the revision number of the change.
		/// </summary>
		public int Revision { get; }

		/// <summary>
		/// Returns the old value of the property. Not necessary for simple,
		/// singular changes.
		/// </summary>
		public string OldValue { get; }

		/// <summary>
		/// Returns the new value of the property.
		/// </summary>
		public string NewValue { get; }

		/// <summary>
		/// Returns the name of the author of the change (optional).
		/// </summary>
		public string AuthorName { get; }

		/// <summary>
		/// Returns the date of the change (optional).
		/// </summary>
		public DateTime Date { get; }

		/// <summary>
		/// Returns information about the change (optional).
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Creates new change.
		/// </summary>
		/// <param name="revision"></param>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		/// <param name="authorName"></param>
		/// <param name="date"></param>
		/// <param name="comment"></param>
		public IesModPropertyChange(int revision, string oldValue, string newValue, string authorName, DateTime date, string comment)
		{
			this.Revision = revision;
			this.OldValue = oldValue;
			this.NewValue = newValue;
			this.AuthorName = authorName;
			this.Date = date;
			this.Comment = comment;
		}
	}
}
