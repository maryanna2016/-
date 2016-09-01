using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		for(int T=Convert.ToInt32(Console.ReadLine()); T>0; T--)
		{
			String[] a = Console.ReadLine().Split(' ');
			int A = Convert.ToInt32(a[0]);
			int B = Convert.ToInt32(a[1]);
			Console.WriteLine(A + B);
		}
	}
}