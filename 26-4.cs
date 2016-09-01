using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		SortedDictionary<String, int> d = new SortedDictionary<string, int>();
		char[] sep = "\'.,;: ".ToCharArray();
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
		{
			foreach (String x in Console.ReadLine().ToLower().Split(sep))
			{
				if (x == "") continue;
				if (!d.ContainsKey(x))
					d[x] = 1;
			}
		}
		Console.WriteLine(d.Count);
		foreach (KeyValuePair<String,int> x in d)
		{
			Console.WriteLine(x.Key);
		}
	}
}