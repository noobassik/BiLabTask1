using System.Text;

namespace BiLabTask1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string s1 = "ааbсссссааа";
			string s2 = "abcdefghhh";
			string s3 = "aabbcccc";
			Console.WriteLine($"Result: {CompressString(s1)}, \nExpected result: а2b1с5а3\n");
			Console.WriteLine($"Result: {CompressString(s2)}, \nExpected result: abcdefghhh\n");
			Console.WriteLine($"Result: {CompressString(s3)}, \nExpected result: a2b2c4\n");
			Console.ReadLine();
		}

		static string CompressString(string input)
		{
			input = input.ToLower();
			if (string.IsNullOrEmpty(input) || input.Length == 1)
				return input;

			StringBuilder compressed = new StringBuilder();
			int count = 1;

			for (int i = 1; i < input.Length; i++)
			{
				if (input[i] == input[i - 1])
				{
					count++;
				}
				else
				{
					compressed.Append(input[i - 1]);
					compressed.Append(count);
					count = 1;
				}
			}

			compressed.Append(input[input.Length - 1]);
			compressed.Append(count);

			return compressed.Length < input.Length ? compressed.ToString() : input;
		}
	}
}