using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yggdrasil.Scripting;

public class TestScript1 : IScript
{
	public bool Init()
	{
		Console.WriteLine("Test script loaded.");
		return true;
	}
}
