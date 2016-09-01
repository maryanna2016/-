using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	void run()
	{
		SortedDictionary<String, int> d = new SortedDictionary<String, int>();
		char[] sep = " ,.;\'`\"()/:-".ToCharArray();
		while (true)
		{
			String s = Console.ReadLine();
			if (s == null) break;
			foreach (String x in s.Split(sep))
			{
				if (x == "") continue;
				String y = x.ToLower();
				if (!d.ContainsKey(y)) d[y] = 1;
				else
					d[y]++;
			}
		}
		int z = 0;
		foreach (KeyValuePair<String, int> k in d)
		{
			z = Math.Max(z,k.Value);
		}
		Console.WriteLine("{0} occurrences", z);
		foreach (KeyValuePair<String, int> k in d)
		{
			if (k.Value == z)
				Console.WriteLine(k.Key);
		}
	}
	static void Main(string[] args)
	{
		new Test().run();
	}
}