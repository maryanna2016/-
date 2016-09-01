using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static bool isV(char c)
	{
		return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
	}
	static void Main(string[] args)
	{
		while (true)
		{
			String s = Console.ReadLine();
			if (s == "end") break;
			bool flag = true;
			int L = s.Length;
			flag = false;
			for (int i = 0; i < L; i++)
				if (isV(s[i]))
					flag = true;
			for (int i = 0; i < L - 2; i++)
				if (isV(s[i]) && isV(s[i + 1]) && isV(s[i + 2]) ||
					!isV(s[i]) && !isV(s[i + 1]) && !isV(s[i + 2]))
					flag = false;
			for (int i = 0; i < L - 1; i++)
				if (s[i] == s[i + 1] && s[i] != 'e' && s[i] != 'o')
					flag = false;
			Console.WriteLine("<{0}> is {1}acceptable.", s, flag ? "" : "not ");
		}
	}
}