using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    internal class MenuItemAddTwoNumbers : MenuItem
    {
        public MenuItemAddTwoNumbers()
        {
            this.Choice = "Add two numbers";
        }

        public override bool ExecuteChoice()
        {
            Console.WriteLine("Your choice was to add two numbers");

            var firstNumber = Library.GetNumber();
            var secondNumber = Library.GetNumber();

            Console.WriteLine($"The total of {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            return true;
        }
    }
}
