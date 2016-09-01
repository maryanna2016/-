using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	bool run()
	{
		String[] ss = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(ss[0]);
		if (n == 0) return false;
		int[] a = new int[26];
		int cnt = 0, res = 0;
		foreach (char x in ss[1])
		{
			int y = Convert.ToInt32(x) - 'A';
			if (a[y] == 0)
			{
				if (cnt == n)
				{
					res++;
					a[y] = -1;
				}
				else
				{
					cnt++;
					a[y] = 1;
				}
			}
			else
			{
				if (a[y] == 1)
				{
					a[y] = 0;
					cnt--;
				}
				else
				{
					a[y] = 0;
				}
			}
		}
		if (res == 0)
			Console.WriteLine("All customers tanned successfully.");
		else
			Console.WriteLine("{0} customer(s) walked away.", res);
		return true;
	}
	static void Main(string[] args)
	{
		while (new Test().run()) ;
	}
}