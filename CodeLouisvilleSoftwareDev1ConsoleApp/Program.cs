using System;
using System.Collections.Generic;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    class MainClass
    {
        static List<MenuItem> menuItems = new List<MenuItem>();

        public static void Main(string[] args)
        {
            menuItems.Add(new MenuItemAddTwoNumbers());
            menuItems.Add(new MenuItemSubtractTwoNumbers());
            menuItems.Add(new MenuItemRemoveWhitespace());
            menuItems.Add(new MenuItemReverseString());
            menuItems.Add(new MenuItemGetWeather());
            menuItems.Add(new MenuItemExit());

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
            
            for (int i = 0; i < menuItems.Count; i++)
            {
                MenuItem item = menuItems[i];
                Console.WriteLine($"{i}. {item.Choice}");
            }

            Console.Write("Enter your choice: ");
            // ask for their choice
            int userChoice = Library.GetNumber();

            Console.WriteLine("");

            if (userChoice < menuItems.Count)
            {
                return menuItems[userChoice].ExecuteChoice();
            }
            else
            {
                Console.WriteLine($"You have input the choice '{userChoice}'.");
                Console.WriteLine("That isn't valid, try again.");
                return true;
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
