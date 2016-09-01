using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		int z = 100001;
		int[] a = new int[z];
		int[] p = new int[z];
		int lp = 0;
		for (int i = 2; i < z; i++)
			a[i] = -1;
		for (int i = 2; i < z; i++)
		{
			if (a[i] == -1)
			{
				a[i] = i;
				p[lp++] = i;
			}
			for (int j = 0; j < lp; j++)
			{
				int x = p[j] * i;
				if (x >= z) break;
				a[x] = 0;
				if (i % p[j] == 0) break;
			}
		}
		for (int i = 2; i < z; i++)
			a[i] += a[i - 1];
		while (true)
		{
			String s = Console.ReadLine();
			if (s == null) break;
			Console.WriteLine(a[Convert.ToInt32(s)]);
		}
	}
}