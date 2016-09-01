using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] a = Console.ReadLine().Split(' ');
		int x = Convert.ToInt32(a[0]);
		int y = Convert.ToInt32(a[1]);
		int z = Convert.ToInt32(a[2]);
		Console.WriteLine("{0} {1} {2:N2}",x+y+z,x*y*z,(x+y+z)/3.0);
	}
}