using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	bool run(bool flag)
	{
		String[] s = Console.ReadLine().Split(' ');
		char[] c = new char[4];
		for (int i = 0; i < 4; i++)
			c[i] = Convert.ToChar(s[i]);
		Array.Sort(c);
		String C = new String(c);
		if (c[3] == '0') return false;
		if (flag) Console.WriteLine();
		for(int j = 1; j < 10; j++){
			bool ff = false;
			for (int i = j * 1000; i < j * 1000 + 1000; i++)
			{
				char[] c2 = Convert.ToString(i).ToCharArray();
				Array.Sort(c2);
				if (new String(c2) == C)
				{
					if (ff) Console.Write(' ');
					Console.Write(i);
					ff = true;
				}
			}
			if (ff) Console.WriteLine();
		}
		return true;
	}
	static void Main(string[] args)
	{
		bool flag = false;
		while (new Test().run(flag))
			flag = true;
	}
}