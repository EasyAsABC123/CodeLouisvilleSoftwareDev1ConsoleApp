using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    internal class MenuItemRemoveWhitespace : MenuItem
    {
        public MenuItemRemoveWhitespace()
        {
            this.Choice = "Remove whitespace from a string";
        }

        public override bool ExecuteChoice()
        {
            Console.WriteLine("Your choice was to remove whitespace from a string");
            Console.Write("Insert string: ");
            var str = Console.ReadLine();
            Console.WriteLine($"You old string was {str}");
            Console.WriteLine($"You new string is  {str.Replace(" ", "")}");
            return true;
        }
    }
}
