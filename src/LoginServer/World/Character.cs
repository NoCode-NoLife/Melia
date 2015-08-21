// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Login.World
{
	public class Character : Shared.World.Character
	{
		public byte Index { get; set; }

		public int[] Equipment { get; private set; }

		public Character()
		{
			this.Level = 1;
			this.Equipment = new int[20] { 2, 2, 4, 8, 6, 7, 10000, 11000, 9999996, 9999996, 4, 9, 9, 4, 9, 9, 9, 9, 9, 10 };
		}
	}
}
