using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	String proc(String a)
	{
		String r = "";
		String[] A = a.Split(' ');
		a = "";
		foreach (String x in A)
		{
			if (x == "") continue;
			if (a != "") a += " ";
			a += x;
		}
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] == '(' || a[i] == '[' || a[i] == '{')
				r += "(";
			else
				if (a[i] == ')' || a[i] == ']' || a[i] == '}')
					r += ")";
				else
					if (a[i] == ',' || a[i] == ';')
						r += ",";
					else
						if (a[i] == ' ')
						{
							if (char.IsLetterOrDigit(a[i - 1]) && char.IsLetterOrDigit(a[i + 1]))
								r += " ";
						}
						else
							r += a[i];
		}
		return r;
	}
	void run()
	{
		String a = Console.ReadLine().Trim().ToLower();
		String b = Console.ReadLine().Trim().ToLower();
		Console.WriteLine(proc(a) == proc(b) ? "equal" : "not equal");
	}
	static void Main(string[] args)
	{
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
			new Test().run();
	}
}