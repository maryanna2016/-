using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String s = Console.ReadLine();
		String t = Console.ReadLine();
		String o = "";
		foreach (char c in s)
		{
			if (t.IndexOf(c) == -1)
				o += c;
		}
		Console.WriteLine(o);
	}
}