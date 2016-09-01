using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	int L;
	String[] s, o = new String[6];
	void dfs(int i, int c)
	{
		if (c == 6)
		{
			Console.WriteLine(String.Join(" ",o));
			return;
		}
		if (i == L + 1)
			return;
		o[c] = s[i];
		dfs(i + 1, c + 1);
		dfs(i + 1, c);
	}
	void run()
	{
		bool ff = false;
		while (true)
		{
			s = Console.ReadLine().Split(' ');
			L = s.Length - 1;
			if (L == 0) break;
			if (ff) Console.WriteLine();
			ff = true;
			dfs(1, 0);
		}
	}
	static void Main(string[] args)
	{
		new Test().run();
	}
}