using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Test
{
	static void Main(string[] args)
	{
		String[] ss = Console.ReadLine().Split(' ');
		int m = Convert.ToInt32(ss[0]);
		int q = Convert.ToInt32(ss[1]);
		Dictionary<String, int> dict = new Dictionary<string, int>();
		while (m-- > 0)
		{
			ss = Console.ReadLine().Split(' ');
			dict[ss[0]] = Convert.ToInt32(ss[1]);
		}
		while (q-- > 0)
		{
			int tot = 0;
			while (true)
			{
				String s2 = Console.ReadLine();
				if (s2 == ".") break;

				foreach (String x in s2.Split(' '))
					if (dict.ContainsKey(x))
						tot += dict[x];
			}
			Console.WriteLine(tot);
		}
	}
}