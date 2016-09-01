using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		while (true)
		{
			String s = Console.ReadLine();
			if (s == null) break;
			String[] ss = s.Split(' '), st = new String[ss.Length];
			int top = 0;
			foreach (String x in ss)
			{
				if (x == "+" || x == "-" || x == "*" || x == "/")
				{
					String o2 = st[--top];
					String o1 = st[--top];
					st[top++] = "("+o1 + x + o2+")";
				}
				else
					st[top++] = x;
			}
			Console.WriteLine(st[0]);
		}
	}
}