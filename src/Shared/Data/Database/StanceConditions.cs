using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class StanceConditionData
	{
		public JobId JobId { get; set; }
		public bool Riding { get; set; }
		public EquipType RightHand { get; set; }
		public EquipType LeftHand { get; set; }
		public int StanceId { get; set; }
	}

	/// <summary>
	/// Stance condition database.
	/// </summary>
	public class StanceConditionDb : DatabaseJson<StanceConditionData>
	{
		/// <summary>
		/// Returns first matching stance based on given parameters,
		/// defaults to 10000 if no stances were found.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="riding"></param>
		/// <param name="rightHand"></param>
		/// <param name="leftHand"></param>
		/// <returns></returns>
		public int FindStanceId(JobId jobId, bool riding, EquipType rightHand, EquipType leftHand)
		{
			var data = this.Entries.FirstOrDefault(a => a.JobId == jobId && a.Riding == riding && a.RightHand == rightHand && a.LeftHand == leftHand);
			if (data == null)
			{
				switch (jobId.ToClass())
				{
					default:
					case JobClass.Swordsman: return 10000;
					case JobClass.Wizard: return 10006;
					case JobClass.Archer: return 10008;
					case JobClass.Cleric:
					case JobClass.GM: return 10004;
				}
			}

			return data.StanceId;
		}

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "riding", "rightHand", "leftHand", "stanceId");

			var data = new StanceConditionData();

			data.JobId = (JobId)entry.ReadInt("jobId");
			data.Riding = entry.ReadBool("riding");
			data.StanceId = entry.ReadInt("stanceId");

			var rightHand = entry.ReadString("rightHand", null);
			if (!Enum.TryParse<EquipType>(rightHand, out var rightHandType))
				throw new DatabaseErrorException($"Invalid equip type '{rightHand}'.");

			var leftHand = entry.ReadString("leftHand", null);
			if (!Enum.TryParse<EquipType>(leftHand, out var leftHandType))
				throw new DatabaseErrorException($"Invalid equip type '{leftHand}'.");

			data.RightHand = rightHandType;
			data.LeftHand = leftHandType;

			// XXX: Maybe index on a hash of the values?

			this.Add(data);
		}
	}
}
