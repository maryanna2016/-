using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	void run()
	{
		String[] s = Console.ReadLine().Split(' ');
		int F = Convert.ToInt32(s[0]);
		int I = Convert.ToInt32(s[1]);
		int T = Convert.ToInt32(s[2]);
		int[] r = new int[I];
		for (int i = 0; i < F; i++)
		{
			String s2 = Console.ReadLine();
			for (int j = 0; j < I; j++)
				if (s2[j] == 'Y')
					r[j]++;
		}
		int res = 0;
		for (int j = 0; j < I; j++)
			if (r[j] >= T)
				res++;
		Console.WriteLine(res);
	}
	static void Main(string[] args)
	{
		new Test().run();
	}
}