using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.Network;

namespace Melia.Channel.World
{
	public class SkillActor : Actor, IVisitor
	{
		public float range;
		public int SkillId;
		public int Handle;
		public bool fired;
		public int delayRemove = 200;
		public DateTime timeFired;

		public void Init()
		{
			this.range = 0.0f;
			this.Handle = ChannelServer.Instance.World.CreateHandle();
		}

		public new bool OnVisit(Actor entity)
		{
			this.character.ProcessSkill(this, entity);
			fired = true;
			timeFired = DateTime.Now;
			
			return true;
		}

		public void Process()
		{
			if (!fired)
			{
				map.SectorManager.Visit(this.Position, this, 10);
			}
			else
			{
				if ((timeFired.AddMilliseconds((double)delayRemove) < DateTime.Now))
				{
					Send.ZC_NORMAL_Skill(this.character, 40001, this.Position, new Melia.Shared.World.Direction(0.707f, 0.707f), false, 1234);
					this.ToDelete = true;
				}
			}
			
		}
	}
}
