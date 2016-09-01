using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		bool flag = false;
		while(true)
		{
			String[] a = Console.ReadLine().Split(' ');
			int A = Convert.ToInt32(a[0]);
			int B = Convert.ToInt32(a[1]);
			if (A == 0 && B == 0) break;
			if (flag) Console.WriteLine();
			flag = true;
			Console.WriteLine(A + B);
		}
	}
}