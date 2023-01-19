using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
			string diceRollsString;
			int[] resultsAsNumbers = new int[11];
			for(int i = 0; i < resultsAsNumbers.Length; i ++) // initialize the array as 0's
            {
				resultsAsNumbers[i] = 0;
            }
			string[] resultsAsString = new string[11];
			int roll1;
			int roll2;
			int result;

			Console.WriteLine("Welcome to the dice throwing simulator!\n");
			Console.WriteLine("How many dice rolls would you like to simulate?");
			diceRollsString = Console.ReadLine();
			int diceRolls = Convert.ToInt32(diceRollsString);
			Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
			Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + diceRollsString + ".\n");

			Random rnd = new Random();

			for (int j = 0; j < diceRolls; j++) // roll the dice
			{
				roll1 = rnd.Next(1, 7); // returns random integers >= 1 and < 7
				roll2 = rnd.Next(1, 7);
				result = roll1 + roll2;
				resultsAsNumbers[result-2]++;
			}

			for (int i = 0; i < resultsAsNumbers.Length;i++) // go through our results and convert to stars
            {
				string stars = "";
				double doubleNumber = resultsAsNumbers[i] / Convert.ToDouble(diceRolls) * 100;
				int numberResults = Convert.ToInt32(doubleNumber);
				for (int j = 0; j < numberResults;j++) // convert to stars
                {
					stars = stars + "*";
                }
				resultsAsString[i] = stars;
            }

			for (int i = 0; i < resultsAsString.Length;i++) // print out the results
            {
				int diceResult = i + 2;
				Console.WriteLine(diceResult.ToString() + ": " + resultsAsString[i]);
            }
			Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
			Console.ReadLine();
		}
	}
}
