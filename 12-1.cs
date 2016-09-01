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
			String[] a = s.Split('5');
			int[] w = new int[a.Length];
			int lw = 0;
			for (int i = 0; i < a.Length; i++)
				if(a[i] != "")
					w[lw++] = Convert.ToInt32(a[i]);
			Array.Sort(w,0,lw);
			for (int i = 0; i < lw; i++)
				a[i] = Convert.ToString(w[i]);
			Console.WriteLine(String.Join(" ", a, 0, lw));
		}
	}
}