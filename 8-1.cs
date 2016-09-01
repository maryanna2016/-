using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void o(char c, int m)
	{
		while (m-- > 0)
			Console.Write(c);
	}
	static void Main(string[] args)
	{
		bool flag = false;
		while (true)
		{
			String[] a = Console.ReadLine().Split(' ');
			char c = Convert.ToChar(a[0]);
			if (c == '@') break;
			if (flag) Console.WriteLine(); flag = true;
			int n = Convert.ToInt32(a[1]);
			for (int i = 1; i <= n; i++)
			{
				if (i == n)
				{
					o(c, 2 * n - 1); Console.WriteLine();
				}
				else
					if (i == 1)
					{
						o(' ', n - 1); Console.WriteLine(c);
					}
					else
					{
						o(' ', n - i); Console.Write(c); o(' ', 2 * i - 3); Console.WriteLine(c);
					}
			}
		}
	}
}