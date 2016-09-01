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
			String[] a = Console.ReadLine().Split(' ');
			double A = Convert.ToDouble(a[0]);
			int B = Convert.ToInt32(a[1]);
			double r1 = A;
			while (--B > 0)
			{
				r1 += A;
				A /= 2;
			}
			Console.WriteLine("{0:N2} {1:N2}", r1, A / 2);
		}
	}
}