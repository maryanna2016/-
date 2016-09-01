using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] s = Console.ReadLine().Split(' ');
		double A = Convert.ToDouble(s[0]);
		double B = Convert.ToDouble(s[1]);
		double C = Convert.ToDouble(s[2]);
		if(A<0){
			A=-A;
			B=-B;
			C=-C;
		}
		double delta = B * B - 4 * A * C;
		if (delta >= 0)
		{
			delta = Math.Sqrt(delta);
			Console.WriteLine("{0:N2} {1:N2}", (-B + delta) / (2 * A), (-B - delta) / (2 * A));
		}
		else
		{
			delta = Math.Sqrt(-delta);
			Console.WriteLine("{0:N2}+{1:N2}i {0:N2}-{1:N2}i", -B / (2 * A), delta / (2 * A));
		}
	}
}