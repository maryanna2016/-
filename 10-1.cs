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
			String[] s = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(s[0]);
			int m = Convert.ToInt32(s[1]);
			char[][] a = new char[n][];
			int x = -1,y = -1;
			for (int i = 0; i < n; i++)
			{
				a[i] = Console.ReadLine().ToCharArray();
				for(int j = 0; j<m; j++)
					if(a[i][j] == 's'){
						x = i; y = j;
					}
			}
			int r = 1234567,ox = -1,oy = -1;
			for(int i=0; i<n; i++)
				for(int j=0; j<m; j++)
					if (a[i][j] == 'd')
					{
						int d = Math.Abs(x - i) + Math.Abs(y - j);
						if (d < r)
						{
							r = d;
							ox = i;
							oy = j;
						}
					}
			Console.WriteLine("({0},{1})", ox, oy);
		}
	}
}