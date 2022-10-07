using System.Drawing;
using System;

namespace CountingTotalLetterInText
{
	public class Program
	{
		public static void Main(string[]args)
		{
			Console.Write("Enter string: ");
			var myString = Console.ReadLine();
			var count = 0;
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < myString.Length; i++)
			{
				if(!char.IsWhiteSpace(myString[i]))
					count++;
			}
			
			Console.WriteLine("Total letters: "+ count);
			Console.ReadLine();

		}
	}
}