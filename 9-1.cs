using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static int pal(int x)
	{
		char[] c = Convert.ToString(x).ToCharArray();
		Array.Reverse(c);
		return Convert.ToInt32(new String(c));
	}
	static void Main(string[] args)
	{
		while (true)
		{
			String s = Console.ReadLine();
			if (s == "" || s==null) break;
			int A = Convert.ToInt32(s);
			List<int> lis = new List<int>();
			int cnt = 0, A1 = A;
			while (true)
			{
				int B = pal(A);
				if (A == B) break;
				A += B;
				lis.Add(A);
				cnt ++;
			}
			Console.WriteLine(cnt);
			Console.Write(A1);
			foreach (int x in lis)
				Console.Write("--->{0}", x);
			Console.WriteLine();
		}
	}
}