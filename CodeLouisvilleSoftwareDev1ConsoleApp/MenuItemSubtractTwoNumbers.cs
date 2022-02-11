using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    internal class MenuItemSubtractTwoNumbers : MenuItem
    {
        public MenuItemSubtractTwoNumbers()
        {
            this.Choice = "Subtract two numbers";
        }

        public override bool ExecuteChoice()
        {
            Console.WriteLine("Your choice was to subtract two numbers");

            var firstNumber = Library.GetNumber("Enter first number");
            var secondNumber = Library.GetNumber();

            Console.WriteLine($"The total of {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            return true;
        }
    }
}
