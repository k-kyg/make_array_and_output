using System;
using System.Collections.Generic;
class MainProgram
{
	public static void Main(string[] args)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < 100; ++i) list.Add(i);
		foreach (int i in list) Console.WriteLine(i);
	}
}