using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] a = Console.ReadLine().Split(' ');
		double A = Convert.ToDouble(a[0]);
		int B = Convert.ToInt32(a[1]);
		double r = 1, z = 1;
		for (int i = 1; i <= B; i++)
		{
			z = -z * A * A / (i * 2 - 1) / (i * 2);
			r += z;
		}
		Console.WriteLine("{0:N4}", r);
	}
}