using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradsFirstConsoleApp
{
    class Program
    {
        /// <summary>
        /// My first console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string myName = "Jack";
            string lastName = "Stewart";
            int myAge = 5;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hi my name is {myName} {lastName} and i am {myAge} years old");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            int humanYears = 7 * myAge;
            Console.WriteLine($"In human years i am {humanYears} years old");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
