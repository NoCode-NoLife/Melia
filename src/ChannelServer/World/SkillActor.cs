using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.Network;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public class SkillActor : Actor, IVisitor
	{
		public float range;
		public int SkillId;
		public bool fired;
		public int delayRemove = 200;
		public DateTime timeFired;
		public int ownerHandle;
		public Map Map { get; set; }

		public void Init()
		{
			this.range = 0.0f;
			this.Handle = ChannelServer.Instance.World.CreateHandle();
		}

		public bool OnVisit(Actor entity)
		{
			// check if attackable
			if (entity.GetType() != typeof(Character))
				return true;

			Character thisCharacter = Map.GetCharacter(ownerHandle);
			thisCharacter.ProcessSkill(this, entity);
			fired = true;
			timeFired = DateTime.Now;
			
			return true;
		}

		public void Process()
		{
			
			if (!fired)
			{
				Map.SectorManager.Visit(this.Position, this, 10);
			}
			else
			{
				if ((timeFired.AddMilliseconds((double)delayRemove) < DateTime.Now))
				{
					Send.ZC_NORMAL_Skill(Map.GetCharacter(ownerHandle), 40001, this.Position, new Melia.Shared.World.Direction(0.707f, 0.707f), false, this.Handle);
					this.ToDestroy = true;
				}
			}
			
		}
	}
}
