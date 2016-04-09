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
			Character thisCharacter = (Character) entity;
			thisCharacter.ProcessSkill(this, thisCharacter);
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
					Send.ZC_NORMAL_Skill(Map.GetCharacter(ownerHandle), 40001, this.Position, new Melia.Shared.World.Direction(0.707f, 0.707f), false, 1234);
					this.ToDestroy = true;
				}
			}
			
		}
	}
}
