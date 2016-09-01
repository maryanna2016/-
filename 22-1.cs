using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	void run()
	{
		String[] s = Console.ReadLine().Split(' ');
		double ax = Convert.ToDouble(s[0]);
		double ay = Convert.ToDouble(s[1]);
		double bx = Convert.ToDouble(s[2]);
		double by = Convert.ToDouble(s[3]);
		double cx = Convert.ToDouble(s[4]);
		double cy = Convert.ToDouble(s[5]);
		double dx = Convert.ToDouble(s[6]);
		double dy = Convert.ToDouble(s[7]);
		double ang1 = Math.Atan2(by - ay, bx - ax);
		double ang2 = Math.Atan2(dy - cy, dx - cx);
		double ang = ang1 - ang2;
		while (ang < 0) ang += 2 * Math.PI;
		while (ang >= 2 * Math.PI) ang -= 2 * Math.PI;
		if (ang > Math.PI) ang = 2 * Math.PI - ang;
		if (ang > Math.PI / 2) ang = Math.PI - ang;
		Console.WriteLine("{0:N1}", ang / Math.PI * 180);
	}
	static void Main(string[] args)
	{
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
			new Test().run();
	}
}