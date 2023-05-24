namespace Melia.Zone
{
	/// <summary>
	/// Easy access method for feature checks.
	/// </summary>
	public static class Feature
	{
		/// <summary>
		/// Returns true if the given feature is enabled.
		/// </summary>
		/// <param name="feature"></param>
		/// <returns></returns>
		public static bool IsEnabled(string feature)
			=> ZoneServer.Instance.Data.FeatureDb.IsEnabled(feature);
	}
}
