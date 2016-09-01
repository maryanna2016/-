using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	bool run()
	{
		String s = Console.ReadLine();
		if (s == "*") return false;
		bool flag = true;
		int L = s.Length;
		for (int i = 1; i < L; i++)
		{
			bool[][] f = new bool[26][];
			for (int j = 0; j < 26; j++)
			{
				f[j] = new bool[26];
			}
			for (int k = 0; k + i < L; k++)
			{
				int x = s[k] - 'A', y = s[k + i] - 'A';
				if (f[x][y])
					flag = false;
				f[x][y] = true;
			}
			if (!flag) break;
		}
		Console.WriteLine("{0} is {1}surprising.", s, flag ? "" : "NOT ");
		return true;
	}
	static void Main(string[] args)
	{
		while (new Test().run()) ;
	}
}