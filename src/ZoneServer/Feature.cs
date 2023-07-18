using System;

namespace Melia.Zone
{
	/// <summary>
	/// Easy access method for feature options checks and modification.
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

		/// <summary>
		/// Enables the given feature.
		/// </summary>
		/// <param name="featureName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the given feature doesn't exist.
		/// </exception>
		public static void Enable(string featureName)
		{
			if (!ZoneServer.Instance.Data.FeatureDb.TryFind(featureName, out var feature))
				throw new ArgumentException($"Feature '{featureName}' not found.");

			feature.Enable(true);
		}

		/// <summary>
		/// Enables the given feature.
		/// </summary>
		/// <param name="featureName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the given feature doesn't exist.
		/// </exception>
		public static void Disable(string featureName)
		{
			if (!ZoneServer.Instance.Data.FeatureDb.TryFind(featureName, out var feature))
				throw new ArgumentException($"Feature '{featureName}' not found.");

			feature.Enable(false);
		}
	}
}
