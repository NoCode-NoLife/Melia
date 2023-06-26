using System.Threading;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Force id generator.
	/// </summary>
	public static class ForceId
	{
		private static int Id;

		/// <summary>
		/// Returns a new force id.
		/// </summary>
		/// <returns></returns>
		public static int GetNew()
			=> Interlocked.Increment(ref Id);
	}
}
