using System.Text;

namespace BiLabTask1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "ааbсссссааа";
			Console.WriteLine(CompressString(s));
			Console.ReadLine();
		}

		static string CompressString(string s)
		{
			if (string.IsNullOrEmpty(s))
				return s;

			StringBuilder compressed = new StringBuilder();
			int count = 1;

			for (int i = 1; i < s.Length; i++)
			{
				if (s[i] == s[i - 1])
				{
					count++;
				}
				else
				{
					compressed.Append(s[i - 1]);
					compressed.Append(count);
					count = 1;
				}
			}

			compressed.Append(s[s.Length - 1]);
			compressed.Append(count);

			return compressed.Length < s.Length ? compressed.ToString() : s;
		}
	}
}
