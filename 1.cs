using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] a = Console.ReadLine().Split(' ');
		Console.WriteLine(Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]));
	}
}