using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    internal class MenuItemGetWeather : MenuItem
    {
        public MenuItemGetWeather()
        {
            this.Choice = "Check the weather";
        }

        public override bool ExecuteChoice()
        {
            Console.WriteLine("You want to check the weather");

            return true;
        }
    }
}
