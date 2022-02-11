using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    using MicrosoftSucks;
    internal class MenuItemReverseString : MenuItem
    {
        public MenuItemReverseString()
        {
            this.Choice = "Reverse a string";
        }

        public override bool ExecuteChoice()
        {
            
            Console.WriteLine("Your choice was to reverse a string");

            Console.Write("Insert string: ");
            var str = Console.ReadLine();

            Console.WriteLine($"You old string was {str}");
            Console.WriteLine($"You new string is  {str.Reverse()}");
            return true;
        }
    }
}
