using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		Console.WriteLine("{0:N2}", 5 * (Convert.ToDouble(Console.ReadLine()) - 32) / 9.0);
	}
}