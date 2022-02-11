using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    public static class Library
    {
        public static int GetNumber(string message = "Insert Number")
        {
            Console.Write($"{message}: ");
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
