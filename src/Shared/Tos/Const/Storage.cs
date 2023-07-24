using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Tos.Const
{
	public enum StorageResult
	{
		Success = 0,
		ItemNotFound = 1,
		InvalidOperation = 2,
		StorageFull = 3,
	}

	public enum StorageType
	{
		PersonalStorage = 1,
		TeamStorage = 6,
	}
}
