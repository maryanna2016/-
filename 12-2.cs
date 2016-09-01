using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
		{
			String[] s = Console.ReadLine().Split(' ');
			int[] w = new int[s.Length];
			for (int i = 1; i < s.Length; i++)
				w[i] = Convert.ToInt32(s[i]);
			Array.Sort(w, 1, s.Length - 1);
			for (int i = 1; i < s.Length; i++)
				s[i] = Convert.ToString(w[i]);
			Console.WriteLine(String.Join(" ", s, 1, s.Length - 1));
		}
	}
}