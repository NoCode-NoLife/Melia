// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Login.Database
{
	public class EquipItem
	{
		/// <summary>
		/// The item's id.
		/// </summary>
		public int Id { get; }

		/// <summary>
		/// The item's equip type.
		/// </summary>
		public EquipType Type { get; }

		/// <summary>
		/// The item's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties();

		/// <summary>
		/// Creates new instance.
		/// </summary>
		public EquipItem(int itemId)
		{
			var data = LoginServer.Instance.Data.ItemDb.Find(itemId) ?? throw new ArgumentException($"Unknown item '{itemId}'.");

			this.Id = itemId;
			this.Type = data.EquipType1;
		}
	}
}
