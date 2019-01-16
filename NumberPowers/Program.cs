using System;

namespace NumberPowers
{
	class Program
	{
		static void Main()
		{
			Console.Write("Hello, please give me a number to cube and square." +
							"\nPlease use whole numbers only: ");
			double input;
			double.TryParse(Console.ReadLine(), out input);

			Console.WriteLine("Number" + "\t\t" + "Squared" + "\t\t" + "Cubed");
			Console.WriteLine("=======\t\t=======\t\t=====");

			for (int i = 1; i <= input; i++ )
			{
				double getSquared = i * i;
				double getCubed = i * i * i;
				Console.WriteLine(i + "\t\t" + getSquared + "\t\t"  + getCubed);
			}



			Console.WriteLine("Would you like to run this program again?? type 'y' for yes, or 'n' for no");
			string choice = Console.ReadLine();
			choice = choice.ToLower();
			while (choice != "y" && choice != "n")
			{
				Console.WriteLine("Sorry, I didn't quite catch that, try again please.");
				choice = Console.ReadLine();
				choice = choice.ToLower();

			}
			
	
			 if (choice == "y")
			{
				Main();
			}

			else if (choice == "n")
			{
				Environment.Exit(1);
			}



		}
	}
}
