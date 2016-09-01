using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		double[] a = new double[n];
		int[] e = new int[n];
		for(int i=0; i<n; i++)
		{
			String[] s = Console.ReadLine().Split(' ');
			a[i] = Convert.ToDouble(s[0]);
			e[i] = Convert.ToInt32(s[1]);
			e[i] += 1;
			a[i] /= e[i];
		}
		String[] s2 = Console.ReadLine().Split(' ');
		double u = Convert.ToDouble(s2[0]);
		double d = Convert.ToDouble(s2[1]);
		double r = 0;
		for (int i = 0; i < n; i++)
		{
			r += a[i] * Math.Pow(u, e[i]);
			r -= a[i] * Math.Pow(d, e[i]);
		}
		Console.WriteLine("{0:N4}", r);
	}
}