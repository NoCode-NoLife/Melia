using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Util;
using Melia.Channel.World.SkillEffects;
using Melia.Channel.Network;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	public class BuffManager
	{
		public Actor owner;
		public Dictionary<int, Buff> buffList;
		
		public BuffManager(Actor ownerActor)
		{
			this.owner = ownerActor;

			this.buffList = new Dictionary<int, Buff>();
		}

		public void AddToBuffs(Skill skill)
		{
			Buff currentBuff = null;
			double buffSeconds = skill.Data.buffLifeInSeconds == 0 ? 1.1 : skill.Data.buffLifeInSeconds;

			if (buffList.TryGetValue(skill.Id, out currentBuff))
			{
				if (skill.Data.buffCanStack)
				{
					currentBuff.stackLevel = currentBuff.stackLevel + 1;
					BuffSkill buffSkillHandler = (BuffSkill)skill.EffectHandler;
					if (buffSkillHandler != null)
						buffSkillHandler.OnStack(currentBuff, currentBuff.stackLevel);
				}

				// Refresh
				currentBuff.expireTime = DateTime.Now.AddSeconds(buffSeconds);



				bool update = true;
				if (currentBuff != null && skill.Data.buffLifeInSeconds == 0 && !skill.Data.buffCanStack)
					update = false;

				if (update)
					// Update buff
					Send.ZC_BUFF_ADD_2((Character)owner, currentBuff, true);
			}
			else
			{
				Buff newBuff = new Buff();
				newBuff.owner = this.owner;
				newBuff.expireTime = DateTime.Now.AddSeconds(buffSeconds);
				newBuff.ownerSkill = skill;
				newBuff.StatModifiers = skill.Data.statModifiers;
				newBuff.Id = skill.Data.buffId;

				buffList[newBuff.ownerSkill.Id] = newBuff;

				// Add buff
				BuffSkill buffSkillHandler = (BuffSkill)skill.EffectHandler;
				if (buffSkillHandler != null)
					buffSkillHandler.OnAdd(newBuff);

				Send.ZC_BUFF_ADD_2((Character)owner, newBuff, false);
			}
		}

		public void RemoveExpiredBuffs()
		{

			List<int> buffSkillIdToRemove = new List<int>();

			if (buffList.Count > 0)
			{
				lock (buffList)
				{
					foreach (var buff in buffList.Values)
					{
						if (buff.expireTime < DateTime.Now)
						{
							buffSkillIdToRemove.Add(buff.ownerSkill.Id);

						}
					}
				}
				foreach (var skillId in buffSkillIdToRemove)
					this.RemoveBuffBySkillId(skillId);
			}
		}

		public void RemoveBuffBySkillId(int skillId)
		{
			lock (buffList)
			{
				Buff buff;
				if (buffList.TryGetValue(skillId, out buff))
				{
					BuffSkill buffSkillHandler = (BuffSkill)buff.ownerSkill.EffectHandler;
					if (buffSkillHandler != null)
						buffSkillHandler.OnRemove(buff);

					buffList.Remove(skillId);

					Send.ZC_BUFF_REMOVE((Character)owner, buff);
				}
			}

		}

	}

	public class Buff
	{

		public int Id;
		public DateTime expireTime;
		public Skill ownerSkill;
		public Dictionary<Stat, StatModifier> StatModifiers;
		public int stackLevel;
		public int Handle;
		public Actor owner;

		public Buff()
		{
			this.Handle = ChannelServer.Instance.World.CreateHandle();
			this.StatModifiers = new Dictionary<Stat, StatModifier>();
			this.stackLevel = 1;
		}

		public bool GetStatModifierByStat(Stat stat, out StatModifier modifier)
		{
			return StatModifiers.TryGetValue(stat, out modifier);
		}

		public void AddModifier(StatModifier statModidifer)
		{
			this.StatModifiers.Add(statModidifer.stat, statModidifer);
		}

		public void AddModifier(Stat stat, StatModifierType modifierType, float value)
		{
			StatModifier statMod = new StatModifier();
			statMod.modifierType = modifierType;
			statMod.modifierValue = value;
			statMod.stat = stat;
			this.StatModifiers.Add(stat, statMod);
		}
	}
}
