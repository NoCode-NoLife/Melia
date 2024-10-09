namespace Melia.Zone.World.Maps
{
	/// <summary>
	/// Information about a player's exploration progress on a map.
	/// </summary>
	public class RevealedMap
	{
		/// <summary>
		/// Gets or sets the class id of the map.
		/// </summary>
		public int MapId { get; }

		/// <summary>
		/// Gets or sets an array of 128 bytes where each bit represents an
		/// explored sector of a map.
		/// </summary>
		public byte[] Explored { get; private set; }

		/// <summary>
		/// Gets or sets the percentage of the entire map that has been revealed.
		/// </summary>
		public float Percentage { get; private set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="mapId"></param>
		/// <param name="explored"></param>
		/// <param name="percentage"></param>
		public RevealedMap(int mapId, byte[] explored, float percentage)
		{
			this.MapId = mapId;
			this.Explored = explored;
			this.Percentage = percentage;
		}

		/// <summary>
		/// Updates a revealed map.
		/// </summary>
		/// <param name="explored"></param>
		/// <param name="percentage"></param>
		public void Update(byte[] explored, float percentage)
		{
			if (this.Percentage < percentage)
				this.Percentage = percentage;

			if (explored != null)
				this.Explored = explored;
		}
	}
}
