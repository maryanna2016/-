using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	Dictionary<String, int> d = new Dictionary<String, int>();
	void oup(String x)
	{
		if (d.ContainsKey(x.ToLower()))
		{
			Console.Write(x[0]);
			for (int i = 1; i < x.Length; i++)
				Console.Write("*");
		}
		else
			Console.Write(x);
	}
	void run()
	{
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
		{
			String s = Console.ReadLine().ToLower();
			d[s] = 1;
		}
		while (true)
		{
			String s = Console.ReadLine();
			if (s == null) break;
			String now = "";
			foreach (char x in s)
			{
				if (char.IsLetter(x))
					now += x;
				else
				{
					oup(now);
					now = "";
					Console.Write(x);
				}
			}
			oup(now);
			Console.WriteLine();
		}
	}
	static void Main(string[] args)
	{
		new Test().run();
	}
}