using System;


namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    using MicrosoftSucks;

    class MainClass
    {
        public static void Main(string[] args)
        {
            var keepGoing = true;
            while (keepGoing)
            {
                keepGoing = MainMenu();
            }

            // go back to menu
            //   go back to beginning
            // unless choice is exit
            //   exit application

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            Console.WriteLine("Program exited");
        }

        public static bool MainMenu()
        {
            // show user a menu
            Console.WriteLine("Main Menu:");

            //  offer options to user
            //   - ADD TWO NUMBERS
            Console.WriteLine("1. Add two numbers");
            //   - SUBTRACT TWO NUMBERS
            Console.WriteLine("2. Subtract two numbers");
            //   - remove whitespace from a string
            Console.WriteLine("3. Remove whitespace from a string");
            //   - reverse a string
            Console.WriteLine("4. Reverse a string");
            //  ATTEMPT ERROR HANDLING (user does something i am not expecting)
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            // ask for their choice
            char userChoice = Console.ReadKey().KeyChar;

            Console.WriteLine("");
            // do their choice
            switch (userChoice)
            {
                case '1':
                    Console.WriteLine("Your choice was to add two numbers");

                    var firstNumber = GetNumber();
                    var secondNumber = GetNumber();

                    Console.WriteLine($"The total of {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

                    break;
                case '2':
                    Console.WriteLine("Your choice was to subtract two numbers");

                    firstNumber = GetNumber();
                    secondNumber = GetNumber();

                    Console.WriteLine($"The total of {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");

                    break;
                case '3':
                    Console.WriteLine("Your choice was to remove whitespace from a string");
                    Console.Write("Insert string: ");
                    var str = Console.ReadLine();
                    Console.WriteLine($"You old string was {str}");
                    Console.WriteLine($"You new string is  {str.Replace(" ", "")}");

                    break;
                case '4':
                    Console.WriteLine("Your choice was to reverse a string");

                    Console.Write("Insert string: ");
                    str = Console.ReadLine();

                    Console.WriteLine($"You old string was {str}");
                    Console.WriteLine($"You new string is  {str.Reverse()}");

                    break;
                case '5':
                    return false;
                default:
                    Console.WriteLine($"You have input the choice '{userChoice}'.");
                    Console.WriteLine("That isn't valid, try again.");
                    break;
            }

            return true;
        }

        private static int GetNumber()
        {
            Console.Write("Insert number: ");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("I don't understand, can you please try again.");
                return GetNumber();
            }
        }
    }
}

namespace MicrosoftSucks
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
