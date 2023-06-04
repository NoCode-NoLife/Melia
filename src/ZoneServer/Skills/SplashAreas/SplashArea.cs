using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.World;

namespace Melia.Zone.Skills.SplashAreas
{
	public interface ISplashArea
	{
		SplashType SplashType { get; }
		Position OriginPos { get; }
		Direction Direction { get; }
		float Height { get; }
		float Width { get; }
	}
}
