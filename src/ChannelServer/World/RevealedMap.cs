// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Channel.World
{
	public class RevealedMap
	{
		/// <summary>
		/// Class ID of the map.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// An array of 128 bytes where each bit represents an explored sector of a map.
		/// </summary>
		public byte[] Explored { get; set; }

		/// <summary>
		/// Percentage of the entire map that has been revealed.
		/// </summary>
		public float Percentage { get; set; }

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
