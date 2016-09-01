using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	double sqr(double x) { return x * x; }
	bool run()
	{
		String ss = Console.ReadLine();
		if (ss == null) return false;
		String[] s = ss.Split(' ');
		double ax = Convert.ToDouble(s[0]);
		double ay = Convert.ToDouble(s[1]);
		double az = Convert.ToDouble(s[2]);
		double bx = Convert.ToDouble(s[3]);
		double by = Convert.ToDouble(s[4]);
		double bz = Convert.ToDouble(s[5]);
		double cx = Convert.ToDouble(s[6]);
		double cy = Convert.ToDouble(s[7]);
		double cz = Convert.ToDouble(s[8]);
		double c = Math.Sqrt(sqr(ax - bx) + sqr(ay - by) + sqr(az - bz));
		double b = Math.Sqrt(sqr(ax - cx) + sqr(ay - cy) + sqr(az - cz));
		double a = Math.Sqrt(sqr(cx - bx) + sqr(cy - by) + sqr(cz - bz));
		double p = (a + b + c) / 2;
		double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		Console.WriteLine("{0:N3}", sqr(S/p / (a*b*c/(4*S))));
		return true;
	}
	static void Main(string[] args)
	{
		while (new Test().run()) ;
	}
}