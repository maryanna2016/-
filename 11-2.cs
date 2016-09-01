using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		for (int T = Convert.ToInt32(Console.ReadLine()); T > 0; T--)
		{
			String s = Console.ReadLine();
			bool chk = true;
			if (s.Length < 8 || s.Length > 16)
				chk = false;
			bool upper = false, lower = false, digit = false, other = false;
			foreach (char c in s)
			{
				if (Char.IsLower(c)) lower = true;
				else
					if (Char.IsUpper(c)) upper = true;
					else
						if (Char.IsDigit(c)) digit = true;
						else
							other = true;
			}
			if (Convert.ToInt32(upper) + Convert.ToInt32(lower) + Convert.ToInt32(digit) + Convert.ToInt32(other) < 3) chk = false;
			Console.WriteLine(chk ? "YES" : "NO");
		}
	}
}