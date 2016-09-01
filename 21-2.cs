using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static bool cmp(String A, String B)
	{
		char[] a = A.ToCharArray();
		char[] b = B.ToCharArray();
		Array.Sort(a);
		Array.Sort(b);
		return new String(a) == new String(b);
	}
	static void Main(string[] args)
	{
		String[] a = new String[111];
		int la = 0;
		while (true)
		{
			String s = Console.ReadLine();
			if (s == "XXXXXX") break;
			a[la++] = s;
		}
		Array.Sort(a,0,la);
		while (true)
		{
			String s = Console.ReadLine();
			if (s == "XXXXXX") break;
			bool flag = true;
			for (int i = 0; i < la; i++)
				if (cmp(a[i], s))
				{
					Console.WriteLine(a[i]);
					flag = false;
				}
			if(flag)
				Console.WriteLine("NOT A VALID WORD");
			Console.WriteLine("******");
		}
	}
}