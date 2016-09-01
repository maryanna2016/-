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
			int LA = Convert.ToInt32(s[0]);
			String A = s[1];
			s = Console.ReadLine().Split(' ');
			int LB = Convert.ToInt32(s[0]);
			String B = s[1];
			double r = 0;
			if (LA == LB)
			{
				int cnt = 0;
				for (int i = 0; i < LA; i++)
					if (A[i] == B[i])
						cnt++;
				r = cnt / (LA + 0.0);
			}
			Console.WriteLine(r >= 0.7 ? "Yes" : "No");
		}
	}
}