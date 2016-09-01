using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] s = Console.ReadLine().Split(' ');
		int n = Convert.ToInt32(s[0]);
		int m = Convert.ToInt32(s[1]);
		int[][] a = new int[n][];
		for (int i = 0; i < n; i++)
		{
			a[i] = new int[m];
			String[] s2 = Console.ReadLine().Split(' ');
			for (int j = 0; j < m; j++)
				a[i][j] = Convert.ToInt32(s2[j]);
		}
		for(int i=0; i<n; i++)
			for (int j = 0; j < m; j++)
			{
				bool flag = true;
				for (int k = 0; k < m; k++)
					if (a[i][j] < a[i][k])
						flag = false;
				for (int k = 0; k < n; k++)
					if (a[i][j] > a[k][j])
						flag = false;
				if (flag)
				{
					Console.WriteLine("Array[{0}][{1}]={2}", i, j, a[i][j]);
					return;
				}
			}
		Console.WriteLine("None");
	}
}