using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Tos.Const
{
	public enum StorageResult
	{
		Success,
		ItemNotFound,
		InvalidOperation,
		StorageFull,
	}

	public enum StorageType
	{
		PersonalStorage = 1,
		TeamStorage = 6,
	}
}
