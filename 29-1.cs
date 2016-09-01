using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		SortedDictionary<String, int> d = new SortedDictionary<string,int>();
		for(int T = Convert.ToInt32(Console.ReadLine()); T>0; T--)
		{
			String s = Console.ReadLine();
			if (!d.ContainsKey(s)) d[s] = 1;else
				d[s]++;
		}
		foreach (KeyValuePair<String, int> x in d)
		{
			Console.WriteLine("{0} {1}", x.Key, x.Value);
		}
	}
}